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

namespace P28_Control_Registro_Libros
{
    public partial class frmLibros : Form
    {
        static int contador;
        public frmLibros()
        {
            InitializeComponent();
        }

        private void frmLibros_Load(object sender, EventArgs e)
        {
            lblNumeo.Text = generarNumero();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if(valida() == "")
            {
                double costo = getCosto();
                string categoria = getCategoria();
                double descuento = asignaDescuento(categoria, costo);
                double precioVenta = calculaPrecioVenta(costo, descuento);

                ImprimirRegistro(descuento,precioVenta);

                lblNumeo.Text = generarNumero();
            }
            else
            {
                MessageBox.Show("El error se encuentra en" + valida());
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            double totalDescuentos = calculaTotalDescuentos();
            string libroAlto = libroMasAlto();

            imprimirEstadisticas(totalDescuentos, libroAlto);
        }


        Func<string> generarNumero = () =>
        {
            contador++;
            return contador.ToString("0000");
        };

        int getNumero()
        {
            return int.Parse(lblNumeo.Text);
        }
        string getTitulo()
        {
            return txtTitulo.Text;
        }
        double getCosto()
        {
            return double.Parse(txtCosto.Text);
        }
        string getCategoria()
        {
            return cboCategoria.Text;
        }

        Func<string, double, double> asignaDescuento = (categoria, costo) =>
        {
            double descuento = 0;
            switch(categoria)
            {
                case "Gestion":         descuento = 10.0 / 100 * costo; break;
                case "Ingenieria":      descuento = 12.0 / 100 * costo; break;
                case "Programacion":    descuento = 20.0 / 100 * costo; break;
                case "Base de datos":   descuento = 15.0 / 100 * costo; break;
            }
            return descuento;
        };

        Func<double, double, double> calculaPrecioVenta = (costo, descuento) => costo - descuento;

        double calculaTotalDescuentos()
        {
            double total = 0;
            for(int i = 0; i < lvLibros.Items.Count; i++)
            {
                total += double.Parse(lvLibros.Items[i].SubItems[4].Text);
            }
            return total;
        }

        string libroMasAlto()
        {
            double mayor = double.Parse(lvLibros.Items[0].SubItems[5].Text);
            int posicion = 0;
            for(int i = 0; i < lvLibros.Items.Count;i++)
            {
                if (double.Parse(lvLibros.Items[i].SubItems[5].Text) > mayor)
                {
                    posicion = i;
                }
            }

            return lvLibros.Items[posicion].SubItems[1].Text;
        }

        void ImprimirRegistro(double descuento, double precioVenta)
        {
            ListViewItem fila = new ListViewItem(getNumero().ToString());
            fila.SubItems.Add(getTitulo());
            fila.SubItems.Add(getCategoria());
            fila.SubItems.Add(getCosto().ToString("0.00"));
            fila.SubItems.Add(descuento.ToString("0.00"));
            fila.SubItems.Add(precioVenta.ToString("0.00"));
            lvLibros.Items.Add(fila);
        }

        void imprimirEstadisticas(double totalDescuentos, string LibroAlto)
        {
            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Monto total acumulado de descuentos";
            elementosFila[1] = totalDescuentos.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "El libro con el precio de venta mas caro";
            elementosFila[1] = LibroAlto;
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
        }

        string valida()
        {
            if(txtTitulo.Text.Trim().Length == 0)
            {
                txtTitulo.Focus();
                return "titulo del libro";
            }
            else if(cboCategoria.SelectedIndex == -1)
            {
                cboCategoria.Focus();
                return "categoria del libro";
            }
            else if(txtCosto.Text.Trim().Length == 0)
            {
                txtCosto.Focus();
                return "costo del libro";
            }

            return "";
        }
    }
}
