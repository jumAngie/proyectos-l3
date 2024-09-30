using Microsoft.VisualBasic;
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

namespace P12_Venta_De_Productos
{
    public partial class frmVenta : Form
    {
        double precio = 0;
        public frmVenta()
        {
            InitializeComponent();
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Today.Date.ToString("d");
            lblPrecio.Text = (0).ToString("C");
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string producto = cboProducto.Text;

            if (producto.Equals("Colección Escolar")) precio = 250.00;
            if (producto.Equals("Colección Universitaria")) precio = 150.00;
            if (producto.Equals("Colección Profesional")) precio = 350.00;

            lblPrecio.Text = precio.ToString("C");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Validar
            if (cboProducto.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un producto..!");
            else
                if (!Information.IsNumeric(txtCantidad.Text))
                MessageBox.Show("Debe ingresar una cantidad..!!");
            else
                if (cboTipo.SelectedIndex == -1)
                MessageBox.Show("Debe seleccionar un tipo de pago..!");
            else
            {
                string producto = cboProducto.Text;
                int cantidad = int.Parse(txtCantidad.Text);
                string tipo = cboTipo.Text;

                double subtotal = cantidad * precio;

                double descuento = 0, recargo = 0;
                if (tipo.Equals("Contado"))
                    descuento = 0.05 * subtotal;
                else
                    recargo = 0.1 * subtotal;

                double precioFinal = subtotal - descuento + recargo;

                // Imprimir resltados
                ListViewItem fila = new ListViewItem(producto);
                fila.SubItems.Add(cantidad.ToString());
                fila.SubItems.Add(precio.ToString("C"));
                fila.SubItems.Add(tipo);
                fila.SubItems.Add(descuento.ToString("C"));
                fila.SubItems.Add(recargo.ToString("C"));
                fila.SubItems.Add(precioFinal.ToString("C"));
                lvVenta.Items.Add(fila);

                btnCancelar_Click(sender, e);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cboProducto.Text = "(Seleccione producto)";
            cboTipo.Text = "(Seleccione tipo)";
            txtCantidad.Clear();
            lblPrecio.Text = (0).ToString("C");
            cboProducto.Focus();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Venta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (r == DialogResult.Yes) this.Close();
        }
    }
}
