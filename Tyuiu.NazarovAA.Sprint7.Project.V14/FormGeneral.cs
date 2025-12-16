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
        }

        string databaseRoutesPath;
        private CityRoute[] cityRoutes;

        private void buttonDatabaseFile_NAA_Click(object sender, EventArgs e)
        {
            openFileDialogRoutes.ShowDialog();

            databaseRoutesPath = openFileDialogRoutes.FileName;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            using (StreamReader reader = new StreamReader(databaseRoutesPath, Encoding.GetEncoding(1251)))
            {
                reader.ReadLine();
                cityRoutes = ConvertToCityRoutes(reader.ReadToEnd());
            }

            textBoxDatabaseSource_NAA.Text = databaseRoutesPath;

            int columns = cityRoutes[0].GetType().GetProperties().Length;
            int rows = cityRoutes.Length;

            dataGridViewAllRoutes_NAA.ColumnCount = columns;
            dataGridViewAllRoutes_NAA.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewAllRoutes_NAA.Columns[i].Width = 50;
            }

            for (int r = 0; r < rows; r++)
            {
                dataGridViewAllRoutes_NAA.Rows[r].Cells[0].Value = cityRoutes[r].BusNumber;
                dataGridViewAllRoutes_NAA.Rows[r].Cells[1].Value = cityRoutes[r].FromStation;
                dataGridViewAllRoutes_NAA.Rows[r].Cells[2].Value = cityRoutes[r].ToStation;
                dataGridViewAllRoutes_NAA.Rows[r].Cells[3].Value = cityRoutes[r].Minutes;
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
    }
}
