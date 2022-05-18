using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatosValida;
using maq;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;

namespace CapaNegociacionValida
{
    public class N
        
    {
        public int v = 1;
        public Boolean Negocia(string r, string c)
        {
            Boolean ret = false;
            Rut rt = new Rut();
            if (rt.ValidaRut(r) == true) //Valida el rut
            {
                try
                {
                    SqlConnection connection = new SqlConnection("server = DESKTOP-OCSVSQ7\\SQLEXPRESS ; database = maq ; INTEGRATED SECURITY = true");
                    connection.Open();
                    SqlCommand command = new SqlCommand("SELECT RutU, KeyU FROM Usuario WHERE RutU = @rut AND KeyU = @cla", connection);
                    command.Parameters.AddWithValue("@rut",r);
                    command.Parameters.AddWithValue("@cla", c);
                    SqlDataReader lector = command.ExecuteReader();
                    if (lector.Read())
                    {
                        MessageBox.Show("Usuario Encontrado");
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Usuario NO Encontrado");
                        return false;
                    }
                }
                catch
                {
                    MessageBox.Show("Error en la base");
                    ret = false;
                }
            }
            else
            {
                MessageBox.Show("Rut Incorrecto");
                ret=false;
                v++;
            }
        return ret;
        }
    }
          
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
