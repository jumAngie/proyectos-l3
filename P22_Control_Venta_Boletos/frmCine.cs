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
// 2022200215

namespace P22_Control_Venta_Boletos
{
    public partial class frmCine : Form
    {
        double precio = 0;
        string categoria = "";

        public frmCine()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            categoria = lblCategoria.Text;
            int cantidad = int.Parse(txtCantidad.Text);

            double subtotal = precio * cantidad;
            double descuento = 0;

            switch (categoria)
            {
                case "Niño": descuento = 20.0 / 100 * subtotal; break;
                case "Joven I": descuento = 10.0 / 100 * subtotal; break;
                case "Joven II": descuento = 5.0 / 100 * subtotal; break;
                case "Adulto I": descuento = 10.0 / 100 * subtotal; break;
                case "Adulto II": descuento = 20.0 / 100 * subtotal; break;

            }
            double importe = subtotal - descuento;

            ListViewItem fila = new ListViewItem(categoria);
            fila.SubItems.Add(precio.ToString("0.00"));
            fila.SubItems.Add(cantidad.ToString("0.00"));
            fila.SubItems.Add(subtotal.ToString("0.00"));
            fila.SubItems.Add(descuento.ToString("0.00"));
            fila.SubItems.Add(importe.ToString("0.00"));
            lvRegistro.Items.Add(fila);

            //lvEstadisticas.Clear();
        }

        private void cboEdad_SelectedIndexChanged(object sender, EventArgs e)
        {
            int edad = cboEdad.SelectedIndex;

            switch (edad)
            {
                case 0: precio = 10; categoria = "Niño"; break;
                case 1: precio = 15; categoria = "Joven I"; break;
                case 2: precio = 25; categoria = "Joven II"; break;
                case 3: precio = 15; categoria = "Adulto I"; break;
                case 4: precio = 10; categoria = "Adulto II"; break;
            }

            lblPrecio.Text = precio.ToString("C");
            lblCategoria.Text = categoria;
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            lvEstadisticas.Items.Clear();

            double tSubtotal = 0;
            int i;

            for(i = 0; i < lvRegistro.Items.Count; i++) 
            {
                tSubtotal += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
            }

            double tDescuento = 0;
            i = 0;
            while (i < lvRegistro.Items.Count)
            {
                tDescuento += double.Parse(lvRegistro.Items[i].SubItems[4].Text);
                i++;
            }

            double aNino = 0, aJovenI = 0, aJovenII = 0, aAdultoI = 0, aAdultoII = 0;
            i = 0;
            do
            {
                string categoria = lvRegistro.Items[i].SubItems[0].Text;
                switch(categoria)
                {
                    case "Niño": aNino += double.Parse(lvRegistro.Items[i].SubItems[5].Text);
                        break;

                    case "Joven I":
                        aJovenI += double.Parse(lvRegistro.Items[i].SubItems[5].Text);
                        break;

                    case "Joven II":
                        aJovenII += double.Parse(lvRegistro.Items[i].SubItems[5].Text);
                        break;

                    case "Adulto I":
                        aAdultoI += double.Parse(lvRegistro.Items[i].SubItems[5].Text);
                        break;

                    case "Adulto II":
                        aAdultoII += double.Parse(lvRegistro.Items[i].SubItems[5].Text);
                        break;
                }
                i++;
            }while(i < lvRegistro.Items.Count );

            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Mostrando total sin descuento";
            elementosFila[1]= tSubtotal.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto total que la empresa no percibe";
            elementosFila[1] = tDescuento.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto acumulado por categ. Niño";
            elementosFila[1] = aNino.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto acumulado por categ. Joven I";
            elementosFila[1] = aJovenI.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto acumulado por categ. Joven II";
            elementosFila[1] = aJovenII.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto acumulado por categ. Adulto I";
            elementosFila[1] = aAdultoI.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto acumulado por categ. Adulto II";
            elementosFila[1] = aAdultoII.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Cine",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes) this.Close();
        }
    }
}
