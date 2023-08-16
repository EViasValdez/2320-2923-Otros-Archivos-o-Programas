using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace ConsumoServicio.Clases
{
    internal class Informacion
    {
        public void MostrarInformacion(DataGridView TablaInformacion)
        {
            try
            {
                Conexion ObjetoInformacion = new Conexion();

                String query = "select * from datosws";
                TablaInformacion.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, ObjetoInformacion.EmpezarConexion());
                DataTable DT = new DataTable();
                adapter.Fill(DT);
                TablaInformacion.DataSource = DT;
                ObjetoInformacion.TerminarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos de la tabla no han sido mostrados");
            }
        }
        public void GuardarInformacion(TextBox TB_Id, TextBox TB_Nombre, TextBox TB_AP, TextBox TB_AM, TextBox TB_FechaNacimiento, TextBox TB_Matricula, TextBox TB_NumeroS, TextBox TB_Genero, TextBox TB_Carrera, TextBox TB_Salon)
        {
            try
            {
                Conexion ObjetoInformacion = new Conexion();

                String query = "insert into datosws (id, nombre, a_paterno, a_materno, fecha_nacimiento, matricula, n_social, genero, carrera, salon)" + "values ("+ TB_Id.Text + ", " + TB_Nombre.Text + ", " + TB_AP.Text + ", " + TB_AM.Text + ", " + TB_FechaNacimiento.Text + ", " + TB_Matricula.Text + ", " + TB_NumeroS.Text + ", " + TB_Genero.Text + ", " + TB_Carrera.Text + ", " + TB_Salon.Text+");";
                MySqlCommand myComand = new MySqlCommand(query, ObjetoInformacion.EmpezarConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se han guardado los datos");
                while (reader.Read()) {

                }
                ObjetoInformacion.TerminarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no han sido guardados");
            }
        }
        public void SeleccionarInformacion(DataGridView DGV_TablaInformacion, TextBox TB_Id, TextBox TB_Nombre, TextBox TB_AP, TextBox TB_AM, TextBox TB_FechaNacimiento, TextBox TB_Matricula, TextBox TB_NumeroS, TextBox TB_Genero, TextBox TB_Carrera, TextBox TB_Salon)
        {
            TB_Id.Text = DGV_TablaInformacion.CurrentRow.Cells[0].Value.ToString();
            TB_Nombre.Text = DGV_TablaInformacion.CurrentRow.Cells[1].Value.ToString();
            TB_AP.Text = DGV_TablaInformacion.CurrentRow.Cells[2].Value.ToString();
            TB_AM.Text = DGV_TablaInformacion.CurrentRow.Cells[3].Value.ToString();
            TB_FechaNacimiento.Text = DGV_TablaInformacion.CurrentRow.Cells[4].Value.ToString();
            TB_Matricula.Text = DGV_TablaInformacion.CurrentRow.Cells[5].Value.ToString();
            TB_NumeroS.Text = DGV_TablaInformacion.CurrentRow.Cells[6].Value.ToString();
            TB_Genero.Text = DGV_TablaInformacion.CurrentRow.Cells[7].Value.ToString();
            TB_Carrera.Text = DGV_TablaInformacion.CurrentRow.Cells[8].Value.ToString();
            TB_Salon.Text = DGV_TablaInformacion.CurrentRow.Cells[9].Value.ToString();
        }
        public void ModificarInformacion(TextBox TB_Id, TextBox TB_Nombre, TextBox TB_AP, TextBox TB_AM, TextBox TB_FechaNacimiento, TextBox TB_Matricula, TextBox TB_NumeroS, TextBox TB_Genero, TextBox TB_Carrera, TextBox TB_Salon)
        {
            try
            {
                Conexion ObjetoInformacion = new Conexion();

                String query = "update datosws set nombres=" + TB_Id.Text + ", " + TB_Nombre.Text + ", " + TB_AP.Text + ", " + TB_AM.Text + ", " + TB_FechaNacimiento.Text + ", " + TB_Matricula.Text + ", " + TB_NumeroS.Text + ", " + TB_Genero.Text + ", " + TB_Carrera.Text + ", " + TB_Salon.Text +"where id =" + TB_Id.Text + ";";
                MySqlCommand myComand = new MySqlCommand(query, ObjetoInformacion.EmpezarConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se han actualizado los datos");
                while (reader.Read())
                {

                }
                ObjetoInformacion.TerminarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no han sido actualizados");
            }
        }
        public void EliminarInformacion(TextBox TB_Id, TextBox TB_Nombre, TextBox TB_AP, TextBox TB_AM, TextBox TB_FechaNacimiento, TextBox TB_Matricula, TextBox TB_NumeroS, TextBox TB_Genero, TextBox TB_Carrera, TextBox TB_Salon)
        {
            try
            {
                Conexion ObjetoInformacion = new Conexion();

                String query = "delete from datosws where id" + TB_Id.Text;
                MySqlCommand myComand = new MySqlCommand(query, ObjetoInformacion.EmpezarConexion());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se han eliminado los datos");
                while (reader.Read())
                {

                }
                ObjetoInformacion.TerminarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Los datos no han sido borrados");
            }
        }
    }
}
