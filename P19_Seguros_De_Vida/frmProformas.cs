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
// 20222200215

namespace P19_Seguros_De_Vida
{
    public partial class frmProformas : Form
    {
        public frmProformas()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string razon = txtRazon.Text;
            string tipo = cboTipo.Text;
            int cantidad = int.Parse(txtCantidad.Text);

            double pagoMensual = 0;
            switch (tipo)
            {
                case "Inversión Clásica":
                    if (cantidad <= 10)
                        pagoMensual = 50 * cantidad;
                    else
                        pagoMensual = (50 * cantidad) +(10*(cantidad-10));
                break;

                case "Inversión Platino":
                    if (cantidad <= 8)
                        pagoMensual = 80 * cantidad;
                    else
                        pagoMensual = (80 * cantidad) + (8 * (cantidad - 8));
                    break;

                case "Inversión Oro":
                    if (cantidad <= 5)
                        pagoMensual = 150 * cantidad;
                    else
                        pagoMensual = (150 * cantidad) + (15 * (cantidad - 5));
                    break;
            }    
            
            ListViewItem fila = new ListViewItem(tipo);
            fila.SubItems.Add(cantidad.ToString());
            fila.SubItems.Add(pagoMensual.ToString("0.00"));
            lvProforma.Items.Add(fila);
        }

        private void tsGeneral_Click(object sender, EventArgs e)
        {
            int totalAsegurados = 0;
            for (int i = 0; i < lvProforma.Items.Count; i++)
            {
                if (lvProforma.Items[i].SubItems[0].Text != "")
                totalAsegurados += int.Parse(lvProforma.Items[i].SubItems[1].Text);
            }

            double total = 0;
            for (int i = 0;i < lvProforma.Items.Count; i++)
            {
                if (lvProforma.Items[i].SubItems[0].Text != "")
                    total += double.Parse(lvProforma.Items[i].SubItems[2].Text);
            }

            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Total de personas aseguradas";
            elementosFila[1] = totalAsegurados.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto Total a Cancelar";
            elementosFila[1] = total.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
        }

        private void tsAnular_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de anular la proforma?", "Seguros",
                                            MessageBoxButtons.YesNo, 
                                            MessageBoxIcon.Question);

            if (r == DialogResult.Yes) 
            {
                txtRazon.Clear();
                cboTipo.Text = "(Seleccione tipo)";
                txtCantidad.Clear();
                txtRazon.Focus();
                lvProforma.Items.Clear();
                lvEstadisticas.Items.Clear();
            
            }
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Seguros",
                                           MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Exclamation);

            if (r == DialogResult.Yes) this.Close();
        }
    }
}
