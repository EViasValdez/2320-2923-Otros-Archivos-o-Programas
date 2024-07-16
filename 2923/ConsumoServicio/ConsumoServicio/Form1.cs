using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace ConsumoServicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Clases.Informacion ObjetoInformacion = new Clases.Informacion();
            ObjetoInformacion.MostrarInformacion(DGV_TablaInformacion);
        }

        private void BT_Conexion_Click(object sender, EventArgs e)
        {
            Clases.Conexion Conectar = new Clases.Conexion();
            Conectar.EmpezarConexion();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BT_Guardar_Click(object sender, EventArgs e)
        {
            Clases.Informacion ObjetoInformacion = new Clases.Informacion();
            ObjetoInformacion.GuardarInformacion(TB_Id, TB_Nombre, TB_AP, TB_AM, TB_FechaNacimiento, TB_Matricula, TB_NumeroS, TB_Genero, TB_Carrera, TB_Salon);
        }

        private void BT_Editar_Click(object sender, EventArgs e)
        {
            Clases.Informacion ObjetoInformacion = new Clases.Informacion();
            ObjetoInformacion.ModificarInformacion(TB_Id, TB_Nombre, TB_AP, TB_AM, TB_FechaNacimiento, TB_Matricula, TB_NumeroS, TB_Genero, TB_Carrera, TB_Salon);
            ObjetoInformacion.MostrarInformacion(DGV_TablaInformacion);
        }

        private void BT_Eliminar_Click(object sender, EventArgs e)
        {
            Clases.Informacion ObjetoInformacion = new Clases.Informacion();
            ObjetoInformacion.EliminarInformacion(TB_Id, TB_Nombre, TB_AP, TB_AM, TB_FechaNacimiento, TB_Matricula, TB_NumeroS, TB_Genero, TB_Carrera, TB_Salon);
            ObjetoInformacion.MostrarInformacion(DGV_TablaInformacion);
        }

        private void DGV_TablaInformacion_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Clases.Informacion ObjetoInformacion = new Clases.Informacion();
            ObjetoInformacion.SeleccionarInformacion(DGV_TablaInformacion, TB_Id, TB_Nombre, TB_AP, TB_AM, TB_FechaNacimiento, TB_Matricula, TB_NumeroS, TB_Genero, TB_Carrera, TB_Salon);
        }
    }
}
