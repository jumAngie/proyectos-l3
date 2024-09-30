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

namespace P6_Pago_De_Empleados
{
    public partial class frmPagoEmpleado : Form
    {
        public frmPagoEmpleado()
        {
            InitializeComponent();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            // Recuperando los datos registrados
            string empleado = txtEmpleado.Text;
            int horas = int.Parse(txtHoras.Text);
            double costo = double.Parse(txtCosto.Text);

            // Realizando los calculos
            double sueldoBasico = horas * costo;
            double bonificacion = 20.0 / 100 * sueldoBasico;
            double sueldoBruto = sueldoBasico + bonificacion;
            double descuento = sueldoBruto * 12.0 / 100;
            double sueldoNeto = sueldoBruto - descuento;

            //Imprimiendo sueldos
            lblMontoBruto.Text = sueldoBruto.ToString("C");
            lblMontoDescuento.Text = descuento.ToString("C");
            lblMontoNeto.Text = sueldoNeto.ToString("C");

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            txtHoras.Clear();
            txtCosto.Clear();
            lblMontoBruto.Text = "";
            lblMontoDescuento.Text = "";
            lblMontoNeto.Text = "";
            txtEmpleado.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de seguro?",
                                                "Control de Pago",
                                                MessageBoxButtons.YesNo,
                                                MessageBoxIcon.Information);
            if (r == DialogResult.Yes)
                this.Close();
        }
    }
}
