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

namespace P10_Control_De_Registro_de_Documentos
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //Captuar valores
            int numero = int.Parse(txtNumero.Text);
            DateTime fecha = dtFecha.Value;
            string empresa = txtEmpresa.Text;

            //Determinar la condicion
            int anios = DateTime.Today.Date.Year - fecha.Year;

            //Calcular años
            string condicion = "";
            if (anios <= 5) condicion = "HABILITADO";
            if (anios > 5) condicion = "INHABILITADO";

            //Imprmir
            ListViewItem fila = new ListViewItem(numero.ToString());
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(empresa);
            fila.SubItems.Add(anios.ToString());
            fila.SubItems.Add(condicion);
            lvRegistro.Items.Add(fila);

            // Limpiar
            btnCancelar_Click(sender, e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNumero.Clear();
            dtFecha.Value = DateTime.Today.Date;
            txtEmpresa.Clear();
            txtNumero.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Documentos",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information);
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
