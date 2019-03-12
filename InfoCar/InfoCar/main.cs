using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoCar
{
    public partial class controlStartUp : Form
    {

        public bool isNewCar = true;
        private string pathent;
        public controlStartUp()
        {
            InitializeComponent();
        }

        private void loadCar_Click(object sender, EventArgs e)
        {
            textM.Visible = true;
            loadCar.Visible = false;
            startInfocar.Visible = false;
            searchBtn.Visible = true;
            cancelBtn.Visible = true;
            patentBox.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            textM.Visible = false;
            loadCar.Visible = true;
            startInfocar.Visible = true;
            searchBtn.Visible = false;
            cancelBtn.Visible = false;
            patentBox.Visible = false;
        }

        private void newCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            databox openMain = new databox(isNewCar);
            openMain.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            pathent = patentBox.Text;
            databox openMain = new databox(!isNewCar, pathent);
            openMain.Show();
        }

        private void controlStartUp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

    }
}
