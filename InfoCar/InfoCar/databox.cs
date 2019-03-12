using System;
using System.Drawing.Imaging;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace InfoCar
{

    public partial class databox : Form
    {
        string picsPath = @"C:\Users\Dalmiro\Documents\InfoCar\images.path\{0}\{1}\{2}.jpg";
        string[] fileTmp;
        private string idCar = null;
        public databox(bool newcar)
        {
            InitializeComponent();
           
        }
        public databox(bool newcar, string pathent)
        {
            idCar = pathent;
            InitializeComponent();
            if (!newcar) {
                foreach (Control ctrl in this.Controls)
                {
                    ctrl.Enabled = false;
                }
                GenerarDatos();
            }
        }
        protected void GenerarDatos() {
            ConnectDB condb = new ConnectDB();
            string[] seed = new string[10];
            seed = condb.getInfoCar(idCar);
            patentBox.Text = seed[1];
            namePcar.Text = seed[2];
            brandCarTxt.Text = seed[3];
            modelCarTxt.Text = seed[4];
            motorCarTxt.Text = seed[6];
            yearCarTxt.Text = seed[5];
            dtcErrorTxt.Text = seed[7];
            solutionTxt.Text = seed[8];
            errorTxt.Text = seed[9];


        }

        protected void showMainForm() {
            controlStartUp newForm = new controlStartUp();
            newForm.Show();
        }
        private void clearData_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in this.groupBox1.Controls)
            {
                if (ctrl is TextBox || ctrl is GroupBox)
                {
                    ctrl.Text = null;
                }
            }
            foreach (Control ctrl in this.groupBox2.Controls)
            {
                if (ctrl is TextBox || ctrl is GroupBox)
                {
                    ctrl.Text = null;
                }
            }
        }
        private bool isEmpity(string x) {
            return (x != null) ? true : false;
        }
        private void SaveData_Click(object sender, EventArgs e)
        {
            bool isGood = false;
            try
            {
                ConnectDB inDat = new ConnectDB();
                string[] data = new string[9];
                data[0] = (!isEmpity(patentBox.Text)) ? patentBox.Text: null;
                data[1] = (!isEmpity(patentBox.Text)) ? namePcar.Text : null;
                data[2] = (!isEmpity(brandCarTxt.Text)) ? brandCarTxt.Text : null;
                data[3] = (!isEmpity(modelCarTxt.Text)) ?  modelCarTxt.Text: null;
                data[4] = (!isEmpity(modelCarTxt.Text)) ?  motorCarTxt.Text: null;
                data[5] = (!isEmpity(yearCarTxt.Text)) ?  yearCarTxt.Text: null;
                data[6] = (!isEmpity(dtcErrorTxt.Text)) ?  dtcErrorTxt.Text: null;
                data[7] = (!isEmpity(solutionTxt.Text)) ?  solutionTxt.Text: null;
                data[8] = (!isEmpity(errorTxt.Text)) ?  errorTxt.Text: null;
                for(int i = 0; i < data.Length; i++){
                    if (data[i] == null)
                    {
                        isGood = false;
                        MessageBox.Show("No puede haber espacios vacios.", "Ningun informe realizado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else {
                        isGood = true;
                    }
                    
                    
                }
                

            }
            catch (SQLiteException ee)
            {
                MessageBox.Show(ee.ToString(), ee.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                try
                {
                    string pathent = patentBox.Text;
                    string newPath;
                    string pathTmp = @"C:\Users\Dalmiro\Documents\InfoCar\images.path\";
                    if (!Directory.Exists(pathTmp + pathent))
                    {
                        Directory.CreateDirectory(pathTmp + pathent);
                    }
                    if (fileTmp != null)
                    {
                        for (int i = 0; i < fileTmp.Length; i++)
                        {
                            if (!Directory.Exists(pathTmp + pathent + @"\" + i))
                            {
                                Directory.CreateDirectory(pathTmp + pathent + @"\" + i);
                            }
                            using (Bitmap newDataBit = new Bitmap(fileTmp[i]))
                            {
                                newPath = String.Format(picsPath, pathent, i, pathent);
                                newDataBit.Save(newPath, ImageFormat.Jpeg);
                            }
                        }
                    }

                }
                catch (FileLoadException msg)
                {
                    MessageBox.Show(msg.ToString(), msg.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (isGood)
                {
                    MessageBox.Show(String.Format("El auto con patente: {0}, ha sido agregado exitosamente", patentBox.Text), "Exito al guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void yearCarTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Char.IsDigit(e.KeyChar)) e.Handled = false;
            if(Char.IsLetter(e.KeyChar)) e.Handled = true;
            if (Char.IsSeparator(e.KeyChar)) e.Handled = true;
        }

        private void addPhotos_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog newDialog = new OpenFileDialog()) {
                newDialog.Title = "Seleccionar fotografías";
                newDialog.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.BMP;*.JPG;*.PNG";
                newDialog.FilterIndex = 2;
                newDialog.Multiselect = true;
                newDialog.RestoreDirectory = true;
                if (newDialog.ShowDialog() == DialogResult.OK) {
                    int count = 0;
                    fileTmp = new string[newDialog.FileNames.Length];
                    foreach (String filePath in newDialog.FileNames) {
                        fileTmp[count] = filePath;
                        count++;
                    }
                    countPic.Text = String.Format("Imagenes agregadas:{0}", count);
                    countPic.Visible = true;
                }
            }
        }

        private void databox_FormClosing(object sender, FormClosingEventArgs e)
        {
            controlStartUp ctrl = new controlStartUp();
            ctrl.Show();
        }
    }
}
