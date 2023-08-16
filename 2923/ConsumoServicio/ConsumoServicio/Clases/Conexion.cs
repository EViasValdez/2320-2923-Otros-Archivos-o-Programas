using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsumoServicio.Clases
{
    internal class Conexion
    {
        MySqlConnection Conect = new MySqlConnection();

        static string servidor = "localhost";
        static string bd = "datosws";
        static string usuario = "root";
        static string password = "";
        static string puerto = "3306";

        string CadenaConexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "password=" + password + ";" + "database" + bd + ";";

        public MySqlConnection EmpezarConexion()
        {
            try
            {
                Conect.Open();
                Conect.ConnectionString = CadenaConexion;
                MessageBox.Show("Se ha conectado a la base de datos");
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo conectar a la base de datos");
            }
            return Conect;
        }
        public void TerminarConexion()
        {
            Conect.Close();
        }
    }
}