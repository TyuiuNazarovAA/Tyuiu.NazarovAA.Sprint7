using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.NazarovAA.Sprint7.Project.V14
{
    public partial class FormAppInfo : Form
    {
        public FormAppInfo()
        {
            InitializeComponent();
        }

        private void buttonNextPage_NAA_Click(object sender, EventArgs e)
        {
            Close();
            FormAppInfo2 formAppInfo2 = new FormAppInfo2();
            formAppInfo2.ShowDialog();
        }

        private void buttonClose_NAA_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
