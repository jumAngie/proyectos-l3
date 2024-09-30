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

namespace P11_Promedio_de_Notas
{
    public partial class frmEvaluacion : Form
    {
        public frmEvaluacion()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Capturando valores
            string alumno = txtAlumno.Text;
            int e1 = int.Parse(txtE1.Text);
            int e2 = int.Parse(txtE2.Text);
            int e3 = int.Parse(txtE3.Text);
            int e4 = int.Parse(txtE4.Text);

            
            // Determinar la mejor nota
            int menor;
            if (e1 < e2) menor = e1; else menor = e2;
            if (e3 < menor) menor = e3;
            if (e4 < menor) menor = e4;

            // Calcular el promedio
            double promedio = (e1 + e2 + e3 + e4 - menor) / 3;

            // Determinando la condicion
            string condicion;
            if (promedio <= 12.49)
                condicion = "DESAPROBADO";
            else
                condicion = "APROBADO";

            // Imprimir
            ListViewItem fila = new ListViewItem(alumno);
            fila.SubItems.Add(e1.ToString());
            fila.SubItems.Add(e2.ToString());
            fila.SubItems.Add(e3.ToString());
            fila.SubItems.Add(e4.ToString());
            fila.SubItems.Add(menor.ToString());
            fila.SubItems.Add(promedio.ToString());
            fila.SubItems.Add(condicion);
            lvRegistro.Items.Add(fila);

            btnCancelar_Click(sender, e);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtAlumno.Clear();
            txtE1.Clear();
            txtE2.Clear();
            txtE3.Clear();
            txtE4.Clear();
            txtAlumno.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Promedio",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Information);
            
            if (r == DialogResult.Yes) this.Close();
        }

        private void txtAlumno_Validated(object sender, EventArgs e)
        {
            if (txtAlumno.Text.Trim() == "")
            {
                epError.SetError(txtAlumno, "Ingrese nombre del Alumno....!!");
                txtAlumno.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtE1_Validated(object sender, EventArgs e)
        {
            if (txtE1.Text.Trim() == "")
            {
                epError.SetError(txtE1, "Ingrese evaluacion 1....!");
                txtE1.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtE2_Validated(object sender, EventArgs e)
        {
            if (txtE2.Text.Trim() == "")
            {
                epError.SetError(txtE2, "Ingrese evaluacion 2....!");
                txtE2.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtE3_Validated(object sender, EventArgs e)
        {
            if (txtE3.Text.Trim() == "")
            {
                epError.SetError(txtE3, "Ingrese evaluacion 3....!");
                txtE3.Focus();
            }
            else
            {
                epError.Clear();
            }
        }

        private void txtE4_Validated(object sender, EventArgs e)
        {
            if (txtE4.Text.Trim() == "")
            {
                epError.SetError(txtE4, "Ingrese evaluacion 4....!");
                txtE4.Focus();
            }
            else
            {
                epError.Clear();
            }
        }
    }
}
