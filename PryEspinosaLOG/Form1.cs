using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;

namespace PryEspinosaLOG
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
            objAccesoBD = new clsAccesoBD();
        }
        clsAccesoBD objAccesoBD= new clsAccesoBD();

        private void mainform_Load(object sender, EventArgs e)
        {
            objAccesoBD.ConectarBaseDatos();
            lblEstadoConexion.Text = objAccesoBD.EstadoConexion;
            objAccesoBD.TraerDatos(DataGridViewLOG);
            objAccesoBD.RegistrarDatosDataSet();
        }

        private void btnConectarBase_Click(object sender, EventArgs e)
        {
            objAccesoBD.ConectarBaseDatos();
        }

        private void btnTraerDatos_Click(object sender, EventArgs e)
        {
            objAccesoBD.TraerDatos(DataGridViewLOG);
        }
    }
}
