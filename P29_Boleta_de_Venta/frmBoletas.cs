using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Angie Yahaira Arias 
// 20222000215

namespace P29_Boleta_de_Venta
{
    public partial class frmBoletas : Form
    {
        static int n;
        ListViewItem item;

        Boleta obB = new Boleta();

        public frmBoletas()
        {
            InitializeComponent();
        }

        private void frmBoletas_Load(object sender, EventArgs e)
        {
            lblNumero.Text = generaNumero();
            txtFecha.Text = DateTime.Now.ToShortDateString(); 
        }

        private void cboProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            obB.producto = cboProducto.Text;
            txtPrecio.Text = obB.determinaPrecio().ToString("C");
        }

        private void btnAnadir_Click(object sender, EventArgs e)
        {
            if(valida() == "")
            {
                capturarDatos();

                double precio = obB.determinaPrecio();
                double importe = obB.calculaImporte();

                imprimirDetalle(precio, importe);

                lblTotal.Text = determinaTotal().ToString("C");
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + valida());
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ListViewItem fila = new ListViewItem("2015-"+(int.Parse(lblNumero.Text).ToString("0000")));
            fila.SubItems.Add(txtFecha.Text);
            fila.SubItems.Add(totalCantidad().ToString("0"));
            fila.SubItems.Add(acumuladoImportes().ToString("C"));
            lvEstadisticas.Items.Add(fila);
            limpiarControles();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Boleta",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) this.Close();
        }

        Func<string> generaNumero = () =>
        {
            n++;
            return n.ToString("0000");
        };

        void capturarDatos()
        {
            obB.numero = int.Parse(lblNumero.Text);
            obB.cliente = txtCliente.Text;
            obB.direccion = txtDireccion.Text;
            obB.fecha = DateTime.Parse(txtFecha.Text);
            obB.dni = txtDNI.Text;
            obB.producto = cboProducto.Text;
            obB.cantidad = int.Parse(txtCantidad.Text);

        }

        void imprimirDetalle(double precio, double importe)
        {
            ListViewItem fila  = new ListViewItem(obB.cantidad.ToString());
            fila.SubItems.Add(obB.producto);
            fila.SubItems.Add(precio.ToString("0.00"));
            fila.SubItems.Add(importe.ToString("0.00"));
            lvDetalle.Items.Add(fila);
        }

        double determinaTotal()
        {
            double total = 0;
            for(int i = 0; i < lvDetalle.Items.Count; i++)
            {
                total += double.Parse(lvDetalle.Items[i].SubItems[3].Text);
            }
            return total;
        }

        int totalCantidad()
        {
            int total = 0;
            for (int i = 0; i < lvDetalle.Items.Count; i++)
            {
                total += int.Parse(lvDetalle.Items[i].SubItems[0].Text);
            }
            return total;
        }

        double acumuladoImportes()
        {
            double acumulado = 0;
            for(int i = 0; i < lvDetalle.Items.Count; i++)
            {
                acumulado += double.Parse(lvDetalle.Items[i].SubItems[3].Text);
            }
            return acumulado;
        }

        string valida()
        {
            if(txtCliente.Text.Trim().Length == 0)
            {
                txtCliente.Focus();
                return "nombre del cliente";
            }
            else if (txtDireccion.Text.Trim().Length == 0)
            {
                txtDireccion.Focus();
                return "dirección del cliente";
            }
            else if (txtDNI.Text.Trim().Length == 0)
            {
                txtDNI.Focus();
                return "DNI del cliente";
            }
            else if(cboProducto.SelectedIndex == -1)
            {
                cboProducto.Focus();
                return "descripción del producto";
            }
            else if (txtCantidad.Text.Trim().Length == 0)
            {
                txtCantidad.Focus();
                return "cantidad comprada";
            }
            return "";
        }

        void limpiarControles()
        {
            lblNumero.Text = generaNumero();
            txtCliente.Clear();
            txtDireccion.Clear();
            txtDNI.Clear();
            cboProducto.Text = "(Seleccione)";
            txtPrecio.Clear();
            txtCantidad.Clear();
            lvDetalle.Items.Clear();
            lblTotal.Text = (0).ToString("C");
        }

        private void lvDetalle_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            item = lvDetalle.GetItemAt(e.X, e.Y);
            string producto = lvDetalle.Items[item.Index].SubItems[1].Text;
            DialogResult r = MessageBox.Show("Esta seguro de eliminar el producto " 
                                + producto, "Boleta", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Information);

            if (r == DialogResult.Yes)
            {
                lvDetalle.Items.Remove(item);
                lblTotal.Text = acumuladoImportes().ToString("C");
                MessageBox.Show("Detalle elimindo correctamente...!!!");
            }
        }
    }
}
