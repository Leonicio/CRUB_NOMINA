using System;
using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace CRUB
{
    public class operacion
    {
        public string conectar()
        {
            SQLiteConnection cnx = new SQLiteConnection(@"Data Source=C:\Users\leoni\Desktop\Programacion III\Tarea 3\Nomina.s3db;version=3;");
            try
            {
                cnx.Open();
                return "conexión existosa";

            }

            catch (Exception ex)
            {
                return ex.Message;
            }

            finally
            {
                cnx.Close();
            }
        }

        public DataTable ConsultaConResultado(string sql)
        {
            SQLiteDataAdapter ad;
            DataTable dt = new DataTable();
            SQLiteConnection cnx = new SQLiteConnection(@"Data Source=C:\Users\leoni\Desktop\Programacion III\Tarea 3\Nomina.s3db;version=3;");
            try
            {
                cnx.Open();
                SQLiteCommand cmd;
                cmd = cnx.CreateCommand();
                cmd.CommandText = sql;
                ad = new SQLiteDataAdapter(cmd);
                ad.Fill(dt);
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
            cnx.Close();
            return dt;
        }

        public string ConsultaSinResultado(string sql)
        {
            SQLiteConnection cnx = new SQLiteConnection(@"Data Source=C:\Users\leoni\Desktop\Programacion III\Tarea 3\Nomina.s3db;version=3;");

            try
            {
                cnx.Open();
                SQLiteCommand command = new SQLiteCommand(sql, cnx);
                command.ExecuteNonQuery();
                return " ";
            }
            catch (Exception ex)
            {
                
                return ex.Message;
            }
            finally
            {
                cnx.Close();
            }
        }
    }
    
}

