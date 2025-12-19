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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonGeneralForm_NAA_Click(object sender, EventArgs e)
        {
            FormGeneral formGeneral = new FormGeneral();
            formGeneral.ShowDialog();
        }

        private void buttonHelp_NAA_Click(object sender, EventArgs e)
        {
            FormAppInfo formAppInfo = new FormAppInfo();
            formAppInfo.ShowDialog();
        }

        private void buttonAuthorInfo_NAA_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
    }
}
