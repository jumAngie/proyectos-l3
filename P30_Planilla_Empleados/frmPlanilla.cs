using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P30_Planilla_Empleados
{
    public partial class frmPlanilla : Form
    {
        public frmPlanilla()
        {
            InitializeComponent();
        }

        private void frmPlanilla_Load(object sender, EventArgs e)
        {
            mostrarFecha();
            mostrarMesActual();
        }

        void mostrarFecha() 
        { 
            lblConsulta.Text = DateTime.Now.ToShortDateString();
        }

        void mostrarMesActual()
        {
            Planilla planilla = new Planilla();
            lblMesConsultado.Text = planilla.mesConsultado();
        }

        private void dtFechaIng_ValueChanged(object sender, EventArgs e)
        {
            lblAniosServicio.Text = (DateTime.Now.Year - dtFechaIng.Value.Year).ToString();
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            string empleado = txtEmpleado.Text;
            string cargo = cboCargo.Text;
            DateTime fechaIngreso = dtFechaIng.Value;
            int anios = int.Parse(lblAniosServicio.Text);

            // Planilla
            Planilla objP = new Planilla();
            objP.empleado = empleado;
            objP.cargo = cargo;
            objP.fechaIngreso = fechaIngreso;
            objP.anios = anios;

            // impresion de valores

            lblMesConsultado.Text = objP.mesConsultado();
            lblSueldoBasico.Text = objP.DeteriminaBasico().ToString("C");
            lblGratificacion.Text = objP.determinaGratificacion().ToString("C");
            lblComision.Text = objP.determinaComision().ToString("C");
            lblAFP.Text = objP.determinaDescuentoAFP().ToString("C");
            lblCoop.Text = objP.determinaDescuentoCooperativa().ToString("C");
            lblSeguroSocial.Text = objP.determinaAportacionSeguro().ToString("C");


            lblTotalIngresos.Text = objP.calculaTotalIngresos().ToString("C");
            lblTotalDescuentos.Text = objP.calculaTotalDescuento().ToString("C");
            lblTotalAportaciones.Text = objP.calculaTotalAportaciones().ToString("C");

            lblTotalNeto.Text = objP.determinaNeto().ToString("C");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtEmpleado.Clear();
            dtFechaIng.Value = DateTime.Now;
            cboCargo.Text = "(Seleccione un cargo)";
            lblMesConsultado.Text = "";
            lblAniosServicio.Text = "";

            lblSueldoBasico.Text = (0).ToString("C");
            lblGratificacion.Text = (0).ToString("C");
            lblComision.Text = (0).ToString("C");
            lblAFP.Text = (0).ToString("C");
            lblCoop.Text = (0).ToString("C");
            lblSeguroSocial.Text = (0).ToString("C");

            txtEmpleado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Planilla",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) this.Close();
             
        }
    }
}
