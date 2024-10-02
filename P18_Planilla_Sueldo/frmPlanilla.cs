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

namespace P18_Planilla_Sueldo
{
    public partial class frmPlanilla : Form
    {
        double saldo;
        int cJefe, cSupervisor, cVendedor, cAdministrador;
        double aJefe, aSupervisor, aVendedor, aAdministrador;

        

        public frmPlanilla()
        {
            InitializeComponent();
        }
        private void frmPlanilla_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString("d");
            lblSueldo.Text = (0).ToString("C");
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string categoria = cboCategoria.Text;

            switch (categoria)
            {
                case "Jefe": saldo = 5000; break;
                case "Supervisor": saldo = 3500; break;
                case "Vendedor": saldo = 1500; break;
                case "Administrador": saldo = 7000; break;
            }

            lblSueldo.Text = saldo.ToString("C");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string DNI = txtDNI.Text;
            string empleado = txtEmpleado.Text;
            string categoria = cboCategoria.Text;

            switch (categoria)
            {
                case "Jefe":
                    cJefe++;
                    aJefe += saldo;
                    break;
                case "Supervisor":
                    cSupervisor++;
                    aSupervisor += saldo;
                    break;
                case "Vendedor":
                    cVendedor++;
                    aVendedor += saldo;
                    break;
                case "Administrador":
                    cAdministrador++;
                    aAdministrador += saldo;
                    break;
            }

            ListViewItem fila = new ListViewItem(DNI);
            fila.SubItems.Add(empleado);
            fila.SubItems.Add(categoria);
            fila.SubItems.Add(saldo.ToString("C"));
            lvEmpleados.Items.Add(fila);

            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[3];
            ListViewItem row;

            elementosFila[0] = "Jefe";
            elementosFila[1] = cJefe.ToString();
            elementosFila[2] = aJefe.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Supervisor";
            elementosFila[1] = cSupervisor.ToString();
            elementosFila[2] = aSupervisor.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Vendedor";
            elementosFila[1] = cVendedor.ToString();
            elementosFila[2] = aVendedor.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Administrador";
            elementosFila[1] = cAdministrador.ToString();
            elementosFila[2] = aAdministrador.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            txtDNI.Clear();
            txtEmpleado.Clear();
            cboCategoria.SelectedIndex = -1;
            lblSueldo.Text = (0).ToString("C");
            txtEmpleado.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Planilla",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtDNI.Clear();
            txtEmpleado.Clear();
            cboCategoria.SelectedIndex = -1;
            lblSueldo.Text = (0).ToString("C");
            txtEmpleado.Focus();
        }
    }
}
