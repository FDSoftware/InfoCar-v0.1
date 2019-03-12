using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SQLite;

namespace InfoCar
{
    class ConnectDB
    {
        private string StringConnect = @"Data Source = C:\Users\Dalmiro\Documents\Visual Studio 2012\Projects\InfoCar\InfoCar\DataCars.s3db";
        private SQLiteConnection OleCn;
        private SQLiteCommand OleCmd;
        private SQLiteDataReader read;
        public ConnectDB() {
            try
            {
                OleCn = new SQLiteConnection(StringConnect);
                
            }
            catch (SQLiteException e) {
                MessageBox.Show(e.Message, e.Source, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OleCn.Close();
        }
        public string[] getInfoCar(string idP){
            string pID = idP;
            OleCn.Open();
            int rows = 0;
            string[] seed;
            using (OleCmd = new SQLiteCommand("SELECT * FROM DataCars WHERE Patente = @Patente", OleCn))
            {
                    OleCmd.Parameters.AddWithValue("@Patente", pID);
                    read = OleCmd.ExecuteReader();
                    rows = read.FieldCount;
                    seed = new string[rows];
                    if (rows > 0)
                    {
                        List<string> result = new List<string>();
                        while (read.Read()) {
                            result.Add(read["ID"].ToString());
                            result.Add(read["Patente"].ToString());
                            result.Add(read["PropietaryName"].ToString());
                            result.Add(read["MarcaAuto"].ToString());
                            result.Add(read["ModeloAuto"].ToString());
                            result.Add(read["MotorAuto"].ToString());
                            result.Add(read["YearAuto"].ToString());
                            result.Add(read["DTC_Error"].ToString());
                            result.Add(read["Solucion_Error"].ToString());
                            result.Add(read["Error"].ToString());
                        }
                        seed = result.ToArray();
                    }
            }
            OleCn.Close();
            return seed;
            }
        public bool SaveData(string[] data) {
            int isQuery = 0;
            bool finish = false;
            OleCn.Open();
            using (OleCmd = new SQLiteCommand("INSERT INTO DataCars (Patente, PropietaryName, MarcaAuto, ModeloAuto, MotorAuto, YearAuto, DTC_Error, Solucion_Error, Error) VALUES (@Patente, @propietario, @marca, @modelo, @year, @motor, @dtc, @solucion, @error);", OleCn))
            {
                OleCmd.Parameters.AddWithValue("@Patente", data[0].ToString());
                OleCmd.Parameters.AddWithValue("@propietario", data[1].ToString());
                OleCmd.Parameters.AddWithValue("@marca", data[2].ToString());
                OleCmd.Parameters.AddWithValue("@modelo", data[3].ToString());
                OleCmd.Parameters.AddWithValue("@year", data[4]);
                OleCmd.Parameters.AddWithValue("@motor", data[5].ToString());
                OleCmd.Parameters.AddWithValue("@dtc", data[6].ToString());
                OleCmd.Parameters.AddWithValue("@solucion", data[7].ToString());
                OleCmd.Parameters.AddWithValue("@error", data[8].ToString());
                isQuery = OleCmd.ExecuteNonQuery();
                if (isQuery > 0)
                {
                    finish = true;
                }
                else {
                    finish = false;
                }
            }
            return finish;
        }
    }
}
