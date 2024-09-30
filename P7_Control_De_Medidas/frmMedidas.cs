using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Angie Yahaira Campos Arias
// 20222000215

namespace P7_Control_De_Medidas
{
    public partial class frmMedidas : Form
    {
        public frmMedidas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Capturando el valor en metros
            double metros = double.Parse(txtMetros.Text);

            // Realizando conversiones
            double centimetros = metros * 100;
            double pulgadas = centimetros / 2.54;
            double pies = pulgadas / 12;
            double yardas = pies / 3;

            // Mostrar los resultados
            lstR.Items.Add("** RESUMEN DE CONVERSIOES ** ");
            lstR.Items.Add("MEDIDA EN METROS: " + metros.ToString("0.00"));
            lstR.Items.Add("------------------------------------------");
            lstR.Items.Add("MEDIDA EN CENTIMETROS:  " + centimetros.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN PULGADAS:     " + pulgadas.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN PIES:         " + pies.ToString("0.00"));
            lstR.Items.Add("MEDIDA EN YARDAS:       " + yardas.ToString("0.00"));
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtMetros.Clear();
            lstR.Items.Clear();
            txtMetros.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Esta seguro de salir?", 
                                                    "Medidas",
                                                    MessageBoxButtons.YesNo,
                                                    MessageBoxIcon.Information);

            if (respuesta == DialogResult.Yes) this.Close();
        }
    }
}
