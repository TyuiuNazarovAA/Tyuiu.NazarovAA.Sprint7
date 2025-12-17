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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tyuiu.NazarovAA.Sprint7.Project.V14
{
    public partial class FormGeneral : Form
    {

        public FormGeneral()
        {
            InitializeComponent();
            comboBoxSort_NAA.SelectedIndex = 0;
        }

        string databaseRoutesPath;
        private CityRoute[] cityRoutes;

        private void SetupAutoComplete()
        {
            textBoxFromStation_NAA.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxFromStation_NAA.AutoCompleteSource = AutoCompleteSource.CustomSource;

            textBoxToStation_NAA.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBoxToStation_NAA.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection autoCompleteCollectionFrom = new AutoCompleteStringCollection();
            AutoCompleteStringCollection autoCompleteCollectionTo = new AutoCompleteStringCollection();

            string[] fromStations = cityRoutes.Select(r => r.FromStation).Distinct().ToArray();
            autoCompleteCollectionFrom.AddRange(fromStations);

            string[] toStations = cityRoutes.Select(r => r.ToStation).Distinct().ToArray();
            autoCompleteCollectionTo.AddRange(toStations);

            textBoxFromStation_NAA.AutoCompleteCustomSource = autoCompleteCollectionFrom;
            textBoxToStation_NAA.AutoCompleteCustomSource = autoCompleteCollectionTo;
        }

        private void buttonDatabaseFile_NAA_Click(object sender, EventArgs e)
        {
            openFileDialogRoutes.ShowDialog();

            databaseRoutesPath = openFileDialogRoutes.FileName;

            if (databaseRoutesPath == "None")
                return;

            FillDataGridViewAllRoutes();
            FillChartFromStation();
            FillChartToStation();

            SetupAutoComplete();
        }
        private void FillDataGridViewAllRoutes()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (StreamReader reader = new StreamReader(databaseRoutesPath, Encoding.GetEncoding(1251)))
            {
                reader.ReadLine();
                cityRoutes = ConvertToCityRoutes(reader.ReadToEnd());
            }

            textBoxDatabaseSource_NAA.Text = databaseRoutesPath;

            int columns = cityRoutes[0].GetType().GetProperties().Length;
            int rows = cityRoutes.Length + 1;

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
                dataGridViewAllRoutes_NAA.Rows[r].Cells[0].Value = cityRoutes[r-1].BusNumber;
                dataGridViewAllRoutes_NAA.Rows[r].Cells[1].Value = cityRoutes[r-1].FromStation;
                dataGridViewAllRoutes_NAA.Rows[r].Cells[2].Value = cityRoutes[r-1].ToStation;
                dataGridViewAllRoutes_NAA.Rows[r].Cells[3].Value = cityRoutes[r-1].Minutes;
            }
        }
        private void FillChartFromStation()
        {
            chartFromStation_NAA.Series[0].Points.Clear();

            List<(string, int)> stationNamesAndFromCount = cityRoutes
                .Select(r => r.FromStation)
                .Distinct()
                .Select(i => (i, cityRoutes
                    .Count(r => r.FromStation == i)))
                .OrderByDescending(r => r.Item2)
                .ToList();

            for (int i = 0; i < stationNamesAndFromCount.Count; i++)
            {
                chartFromStation_NAA.Series[0].Points.AddXY(i, stationNamesAndFromCount[i].Item2);
                chartFromStation_NAA.Series[0].Points[i].AxisLabel = stationNamesAndFromCount[i].Item1;
            }
        }
        private void FillChartToStation()
        {
            chartToStation_NAA.Series[0].Points.Clear();

            List<(string, int)> stationNamesAndToCount = cityRoutes
                .Select(r => r.ToStation)
                .Distinct()
                .Select(i => (i, cityRoutes
                    .Count(r => r.ToStation == i)))
                .OrderByDescending(r => r.Item2)
                .ToList();

            for (int i = 0; i < stationNamesAndToCount.Count; i++)
            {
                chartToStation_NAA.Series[0].Points.AddXY(i, stationNamesAndToCount[i].Item2);
                chartToStation_NAA.Series[0].Points[i].AxisLabel = stationNamesAndToCount[i].Item1;
            }
        }
        private CityRoute[] ConvertToCityRoutes(string text)
        {
            string[] lines = text.Split("\n", StringSplitOptions.RemoveEmptyEntries);
            int rows = lines.Length;
            int columns = lines[0].Split(";").Length;

            CityRoute[] cityRoutes = new CityRoute[rows];

            for (int i = 0; i < rows; i++)
            {
                string[] line = lines[i].Split(";");

                string busNumber = line[0];
                string from = line[1];
                string to = line[2];
                int minutes = int.Parse(line[3]);

                cityRoutes[i] = new CityRoute(busNumber, from, to, minutes);
            }

            return cityRoutes;
        }

        private void buttonSearch_NAA_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;

            CityRoute[] filteredCityRoutes = GetFilteredCityRoutes();

            if (filteredCityRoutes is null)
            {
                MessageBox.Show("Недопустимый метод фильтрации", "Ошибка фильтрации", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (filteredCityRoutes.Length == 0)
                return;

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

        private CityRoute[] GetFilteredCityRoutes()
        {
            string filterCondition = comboBoxSort_NAA.Text;

            CityRoute[] filteredCityRoutes;

            switch (filterCondition)
            {
                case "Нет":
                    filteredCityRoutes = cityRoutes
                        .Where(r => r.FromStation == textBoxFromStation_NAA.Text &&
                            r.ToStation == textBoxToStation_NAA.Text)
                        .ToArray();
                    break;
                case "Быстрее":
                    filteredCityRoutes = cityRoutes
                        .Where(r => r.FromStation == textBoxFromStation_NAA.Text &&
                            r.ToStation == textBoxToStation_NAA.Text)
                        .OrderBy(r => r.Minutes)
                        .ToArray();
                    break;
                case "Медленнее":
                    filteredCityRoutes = cityRoutes
                        .Where(r => r.FromStation == textBoxFromStation_NAA.Text &&
                            r.ToStation == textBoxToStation_NAA.Text)
                        .OrderByDescending(r => r.Minutes)
                        .ToArray();
                    break;
                default:
                    return null;
            }

            return filteredCityRoutes;
        }

        private void FillFilteredDataGridView(CityRoute[] filteredCityRoutes)
        {
            int columns = filteredCityRoutes[0].GetType().GetProperties().Length;
            int rows = filteredCityRoutes.Length + 1;

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
    }
}
