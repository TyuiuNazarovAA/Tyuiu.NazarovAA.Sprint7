using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.NazarovAA.Sprint7.Project.V14.Lib;

namespace Tyuiu.NazarovAA.Sprint7.Project.V14
{
    public partial class FormGeneral : Form
    {

        public FormGeneral()
        {
            InitializeComponent();
            comboBoxSort_NAA.SelectedIndex = 0;

            openFileDialogRoutes.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogRoutes.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }

        string databaseRoutesPath;
        private List<CityRoute> cityRoutesFiltered;
        private List<CityRoute> cityRoutesAll;
        private DataService ds = new DataService();

        private void SetupSearchAutoComplete()
        {
            textBoxFromStation_NAA.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxFromStation_NAA.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxToStation_NAA.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxToStation_NAA.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autoCompleteCollectionFrom = new AutoCompleteStringCollection();
            AutoCompleteStringCollection autoCompleteCollectionTo = new AutoCompleteStringCollection();

            string[] fromStations = cityRoutesAll.Select(r => r.FromStation).Distinct().ToArray();
            autoCompleteCollectionFrom.AddRange(fromStations);

            string[] toStations = cityRoutesAll.Select(r => r.ToStation).Distinct().ToArray();
            autoCompleteCollectionTo.AddRange(toStations);

            textBoxFromStation_NAA.AutoCompleteCustomSource = autoCompleteCollectionFrom;
            textBoxToStation_NAA.AutoCompleteCustomSource = autoCompleteCollectionTo;
        }
        private void SetupRemoveAutoComplete()
        {
            textBoxRemoveNumber_NAA.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxRemoveNumber_NAA.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxRemoveFrom_NAA.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxRemoveFrom_NAA.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxRemoveTo_NAA.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxRemoveTo_NAA.AutoCompleteSource = AutoCompleteSource.CustomSource;


            AutoCompleteStringCollection autoCompleteCollectionNumber = new AutoCompleteStringCollection();
            AutoCompleteStringCollection autoCompleteCollectionFrom = new AutoCompleteStringCollection();
            AutoCompleteStringCollection autoCompleteCollectionTo = new AutoCompleteStringCollection();

            string[] numberStations = cityRoutesAll.Select(r => r.BusNumber).Distinct().ToArray();
            autoCompleteCollectionNumber.AddRange(numberStations);

            string[] fromStations = cityRoutesAll.Select(r => r.FromStation).Distinct().ToArray();
            autoCompleteCollectionFrom.AddRange(fromStations);

            string[] toStations = cityRoutesAll.Select(r => r.ToStation).Distinct().ToArray();
            autoCompleteCollectionTo.AddRange(toStations);

            textBoxRemoveNumber_NAA.AutoCompleteCustomSource = autoCompleteCollectionNumber;
            textBoxRemoveFrom_NAA.AutoCompleteCustomSource = autoCompleteCollectionFrom;
            textBoxRemoveTo_NAA.AutoCompleteCustomSource = autoCompleteCollectionTo;
        }

        private void buttonDatabaseFile_NAA_Click(object sender, EventArgs e)
        {
            openFileDialogRoutes.ShowDialog();

            databaseRoutesPath = openFileDialogRoutes.FileName;

            if (databaseRoutesPath == null)
                return;

            try
            {
                ReadDatabaseFile();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка чтения данных", "Ошибка базы данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                databaseRoutesPath = null;
                return;
            }
            FillDataGridViewAllRoutes();
            FillChartFromStation();
            FillChartToStation();

            SetupSearchAutoComplete();
            SetupRemoveAutoComplete();
        }
        private void ReadDatabaseFile()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (StreamReader reader = new StreamReader(databaseRoutesPath, Encoding.GetEncoding(1251)))
            {
                reader.ReadLine();
                cityRoutesAll = ConvertToCityRoutes(reader.ReadToEnd());
            }

            textBoxDatabaseSource_NAA.Text = databaseRoutesPath;
        }
        private void FillDataGridViewAllRoutes()
        {
            int columns = cityRoutesAll[0].GetType().GetProperties().Length;
            int rows = cityRoutesAll.Count + 1;

            dataGridViewAllRoutes_NAA.ColumnCount = columns;
            dataGridViewAllRoutes_NAA.RowCount = rows;

            dataGridViewAllRoutes_NAA.Columns[0].Width = 50;
            dataGridViewAllRoutes_NAA.Columns[1].Width = 200;
            dataGridViewAllRoutes_NAA.Columns[2].Width = 200;
            dataGridViewAllRoutes_NAA.Columns[3].Width = 50;

            dataGridViewAllRoutes_NAA.Rows[0].Cells[0].Value = "№";
            dataGridViewAllRoutes_NAA.Rows[0].Cells[1].Value = "Откуда";
            dataGridViewAllRoutes_NAA.Rows[0].Cells[2].Value = "Куда";
            dataGridViewAllRoutes_NAA.Rows[0].Cells[3].Value = "Время (мин.)";

            for (int r = 1; r < rows; r++)
            {
                dataGridViewAllRoutes_NAA.Rows[r].Cells[0].Value = cityRoutesAll[r - 1].BusNumber;
                dataGridViewAllRoutes_NAA.Rows[r].Cells[1].Value = cityRoutesAll[r - 1].FromStation;
                dataGridViewAllRoutes_NAA.Rows[r].Cells[2].Value = cityRoutesAll[r - 1].ToStation;
                dataGridViewAllRoutes_NAA.Rows[r].Cells[3].Value = cityRoutesAll[r - 1].Minutes;
            }
        }
        private void FillChartFromStation()
        {
            chartFromStation_NAA.Series[0].Points.Clear();

            List<(string, int)> stationNamesAndFromCount = ds.GetStationNamesAndFromCount(cityRoutesAll);

            for (int i = 0; i < stationNamesAndFromCount.Count; i++)
            {
                chartFromStation_NAA.Series[0].Points.AddXY(i, stationNamesAndFromCount[i].Item2);
                chartFromStation_NAA.Series[0].Points[i].AxisLabel = stationNamesAndFromCount[i].Item1;
            }
        }
        private void FillChartToStation()
        {
            chartToStation_NAA.Series[0].Points.Clear();

            List<(string, int)> stationNamesAndToCount = ds.GetStationNamesAndToCount(cityRoutesAll);

            for (int i = 0; i < stationNamesAndToCount.Count; i++)
            {
                chartToStation_NAA.Series[0].Points.AddXY(i, stationNamesAndToCount[i].Item2);
                chartToStation_NAA.Series[0].Points[i].AxisLabel = stationNamesAndToCount[i].Item1;
            }
        }
        private List<CityRoute> ConvertToCityRoutes(string text)
        {
            string[] lines = text.Split("\n", StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(";").Length;

            List<CityRoute> cityRoutes = new List<CityRoute>();

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");

                string busNumber = line[0];
                string from = line[1];
                string to = line[2];
                int minutes = int.Parse(line[3]);

                cityRoutes.Add(new CityRoute(busNumber, from, to, minutes));
            }

            return cityRoutes;
        }

        private void buttonSearch_NAA_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            List<CityRoute> filteredCityRoutes = GetSortedCityRoutes();

            cityRoutesFiltered = filteredCityRoutes;

            if (filteredCityRoutes is null)
            {
                MessageBox.Show("Недопустимый метод фильтрации", "Ошибка фильтрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (filteredCityRoutes.Count == 0)
            {
                dataGridViewFilteredRoutes_NAA.Rows.Clear();
                dataGridViewFilteredRoutes_NAA.Columns.Clear();
                return;
            }

            FillFilteredDataGridView(filteredCityRoutes);
        }

        private bool ValidateInput()
        {
            if (databaseRoutesPath is null)
            {
                MessageBox.Show("Не выбрана база данных", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxFromStation_NAA.Text))
            {
                MessageBox.Show("Не указана начальная станция", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrEmpty(textBoxToStation_NAA.Text))
            {
                MessageBox.Show("Не указана конечная станция", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private List<CityRoute> GetSortedCityRoutes()
        {
            string sortCondition = comboBoxSort_NAA.Text;

            string from = textBoxFromStation_NAA.Text;
            string to = textBoxToStation_NAA.Text;

            List<CityRoute> sortedCityRoutes = ds.GetSortedCityRoutes(cityRoutesAll, from, to, sortCondition);

            return sortedCityRoutes;
        }

        private void FillFilteredDataGridView(List<CityRoute> filteredCityRoutes)
        {
            int columns = filteredCityRoutes[0].GetType().GetProperties().Length;
            int rows = filteredCityRoutes.Count + 1;

            dataGridViewFilteredRoutes_NAA.Columns.Clear();
            dataGridViewFilteredRoutes_NAA.Rows.Clear();

            dataGridViewFilteredRoutes_NAA.ColumnCount = columns;
            dataGridViewFilteredRoutes_NAA.RowCount = rows;

            dataGridViewFilteredRoutes_NAA.Columns[0].Width = 50;
            dataGridViewFilteredRoutes_NAA.Columns[1].Width = 200;
            dataGridViewFilteredRoutes_NAA.Columns[2].Width = 200;
            dataGridViewFilteredRoutes_NAA.Columns[3].Width = 50;

            dataGridViewFilteredRoutes_NAA.Rows[0].Cells[0].Value = "№";
            dataGridViewFilteredRoutes_NAA.Rows[0].Cells[1].Value = "Откуда";
            dataGridViewFilteredRoutes_NAA.Rows[0].Cells[2].Value = "Куда";
            dataGridViewFilteredRoutes_NAA.Rows[0].Cells[3].Value = "Время (мин.)";


            for (int r = 1; r < rows; r++)
            {
                dataGridViewFilteredRoutes_NAA.Rows[r].Cells[0].Value = filteredCityRoutes[r - 1].BusNumber;
                dataGridViewFilteredRoutes_NAA.Rows[r].Cells[1].Value = filteredCityRoutes[r - 1].FromStation;
                dataGridViewFilteredRoutes_NAA.Rows[r].Cells[2].Value = filteredCityRoutes[r - 1].ToStation;
                dataGridViewFilteredRoutes_NAA.Rows[r].Cells[3].Value = filteredCityRoutes[r - 1].Minutes;
            }
        }
        private void buttonAddRoute_NAA_Click(object sender, EventArgs e)
        {
            if (databaseRoutesPath is null)
            {
                MessageBox.Show("Сначала необходимо подключить базу данных", "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddNumber_NAA.Text = "";
                textBoxAddFrom_NAA.Text = "";
                textBoxAddTo_NAA.Text = "";
                textBoxAddTime_NAA.Text = "";
                return;
            }

            string number = textBoxAddNumber_NAA.Text;
            string from = textBoxAddFrom_NAA.Text;
            string to = textBoxAddTo_NAA.Text;
            string time = textBoxAddTime_NAA.Text;

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(from) ||
                string.IsNullOrEmpty(to) || string.IsNullOrEmpty(time))
            {
                MessageBox.Show("Некорректные данные добавляемого маршрута", "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxAddNumber_NAA.Text = "";
                textBoxAddFrom_NAA.Text = "";
                textBoxAddTo_NAA.Text = "";
                textBoxAddTime_NAA.Text = "";

                return;
            }

            if (!int.TryParse(time, out int result))
            {
                MessageBox.Show("Минуты должны быть в формате целого числа", "Ошибка добавления данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            cityRoutesAll.Add(new CityRoute(number, from, to, result));

            FillDataGridViewAllRoutes();

            FillChartFromStation();
            FillChartToStation();

            textBoxAddNumber_NAA.Text = "";
            textBoxAddFrom_NAA.Text = "";
            textBoxAddTo_NAA.Text = "";
            textBoxAddTime_NAA.Text = "";
        }

        private void buttonRemoveRoute_NAA_Click(object sender, EventArgs e)
        {
            if (databaseRoutesPath is null)
            {
                MessageBox.Show("Сначала необходимо подключить базу данных", "Ошибка удаления данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRemoveNumber_NAA.Text = "";
                textBoxRemoveFrom_NAA.Text = "";
                textBoxRemoveTo_NAA.Text = "";
                return;
            }

            string number = textBoxRemoveNumber_NAA.Text;
            string from = textBoxRemoveFrom_NAA.Text;
            string to = textBoxRemoveTo_NAA.Text;

            if (string.IsNullOrEmpty(number) || string.IsNullOrEmpty(from) ||
                string.IsNullOrEmpty(to))
            {
                MessageBox.Show("Некорректные данные удаляемого маршрута", "Ошибка удаления данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRemoveNumber_NAA.Text = "";
                textBoxRemoveFrom_NAA.Text = "";
                textBoxRemoveTo_NAA.Text = "";
                return;
            }

            CityRoute? removedRoute = cityRoutesAll.Find(r =>
                    r.BusNumber == number && r.FromStation == from && r.ToStation == to);

            if (removedRoute == null)
            {
                MessageBox.Show("Данного маршрута не существует", "Ошибка удаления данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxRemoveNumber_NAA.Text = "";
                textBoxRemoveFrom_NAA.Text = "";
                textBoxRemoveTo_NAA.Text = "";
                return;
            }

            cityRoutesAll.Remove(removedRoute);

            FillDataGridViewAllRoutes();

            FillChartFromStation();
            FillChartToStation();

            textBoxRemoveNumber_NAA.Text = "";
            textBoxRemoveFrom_NAA.Text = "";
            textBoxRemoveTo_NAA.Text = "";
        }

        private void buttonSaveDatabaseFile_NAA_Click(object sender, EventArgs e)
        {
            if (cityRoutesFiltered == null)
            {
                MessageBox.Show("Сначала необходимо выполнить поиск маршрутов", "Ошибка сохранения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cityRoutesFiltered.Count == 0)
            {
                MessageBox.Show("Нельзя сохранять пустую таблицу", "Ошибка сохранения данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int columns = cityRoutesFiltered[0].GetType().GetProperties().Length;
            int rows = cityRoutesFiltered.Count + 1;

            string result = "";

            string number, from, to, time;

            for (int r = 1; r < rows; r++)
            {
                number = dataGridViewFilteredRoutes_NAA.Rows[r].Cells[0].Value.ToString();
                from = dataGridViewFilteredRoutes_NAA.Rows[r].Cells[1].Value.ToString();
                to = dataGridViewFilteredRoutes_NAA.Rows[r].Cells[2].Value.ToString();
                time = dataGridViewFilteredRoutes_NAA.Rows[r].Cells[3].Value.ToString();

                result += $"{number};{from};{to};{time}\n";
            }

            saveFileDialogRoutes.ShowDialog();

            string fileName = saveFileDialogRoutes.FileName;

            if (string.IsNullOrEmpty(fileName))
                return;

            File.AppendAllText(fileName, result, Encoding.UTF8);
        }
    }
}
