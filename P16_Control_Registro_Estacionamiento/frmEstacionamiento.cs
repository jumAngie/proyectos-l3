using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Angie Yahaira Campos Arias
// 20222000215

namespace P16_Control_Registro_Estacionamiento
{
    public partial class frmEstacionamiento : Form
    {
        string dia;
        public frmEstacionamiento()
        {
            InitializeComponent();
        }

        private void frmEstacionamiento_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            dia = fecha.ToString("dddd");

            double costo = 0;
            switch (dia)
            {
                case "domingo": costo = 2; break;
                case "lunes": 
                case "martes":
                case "miercoles": 
                case "jueves": costo = 4; break;
                case "viernes":
                case "sábado": costo = 7; break;
            }

            lblCosto.Text = costo.ToString("0.00");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string placa = txtPlaca.Text;
            double costo = double.Parse(lblCosto.Text);
            DateTime fecha = DateTime.Parse(lblFecha.Text);
            DateTime horaInicio = DateTime.Parse(txtHoraInicio.Text);
            DateTime horaFin = DateTime.Parse(txtHoraSalida.Text);

            TimeSpan hora = horaFin - horaInicio;

            double importe = costo * (hora.TotalHours);

            ListViewItem fila = new ListViewItem(placa);
            fila.SubItems.Add(fecha.ToString("d"));
            fila.SubItems.Add(horaInicio.ToString("t"));
            fila.SubItems.Add(horaFin.ToString("t"));
            fila.SubItems.Add(hora.TotalHours.ToString("0"));
            fila.SubItems.Add(costo.ToString("C"));
            fila.SubItems.Add(importe.ToString("C"));
            lvRegistro.Items.Add(fila);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtPlaca.Clear();
            txtHoraInicio.Clear();
            txtHoraSalida.Clear();
            txtPlaca.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Estacionamiento",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);  
            
            if (r == DialogResult.Yes) this.Close();
        }
    }
}
