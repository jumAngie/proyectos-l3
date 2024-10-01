using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P14_Registro_de_Postulantes
{
    public partial class frmPostulantes : Form
    {
        public frmPostulantes()
        {
            InitializeComponent();
            tHora.Enabled = true;
        }

        private void tsRegistrar_Click(object sender, EventArgs e)
        {
            string postulante = txtPostulante.Text;
            string carrera = cboCarrera.Text;
            double puntaje = double.Parse(txtPuntaje.Text);

            string condicion = "INGRESA";
            double puntos = 0;
            if(carrera == "Ingeniería de Sistemas")
            {
                if(puntaje < 900)
                {
                    condicion = "NO INGRESA";
                    puntos = 900 - puntaje;
                }
            }
            else if(carrera == "Ingeniería de Software")
            {
                if (puntaje < 1200)
                {
                    condicion = "NO INGRESA";
                    puntos = 1200 - puntaje;
                }
            }
            else if (carrera == "Ingeniería Mécanica")
            {
                if (puntaje < 900)
                {
                    condicion = "NO INGRESA";
                    puntos = 900 - puntaje;
                }
            }
            else if (carrera == "Ingeniería Industrial")
            {
                if (puntaje < 1000)
                {
                    condicion = "NO INGRESA";
                    puntos = 1000 - puntaje;
                }
            }
            else if (carrera == "Informática Administrativa")
            {
                if (puntaje < 700)
                {
                    condicion = "NO INGRESA";
                    puntos = 700 - puntaje;
                }
            }
            else if (carrera == "Medicina")
            {
                if (puntaje < 1500)
                {
                    condicion = "NO INGRESA";
                    puntos = 1500 - puntaje;
                }
            }

            ListViewItem fila = new ListViewItem(postulante);
            fila.SubItems.Add(carrera);
            fila.SubItems.Add(puntaje.ToString("0.00"));
            fila.SubItems.Add(condicion);
            fila.SubItems.Add("Falta "+puntos.ToString("0.00"));
            lvPostulantes.Items.Add(fila);

            tsCancelar_Click(sender, e);
        }

        private void tsCancelar_Click(object sender, EventArgs e)
        {
            txtPostulante.Clear();
            cboCarrera.SelectedIndex = -1;
            txtPuntaje.Clear();
            txtPostulante.Focus();
        }

        private void tsSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?",
                                            "Postulantes",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Information);
            
            if (r == DialogResult.Yes) this.Close();
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            this.Text = "Control de Registro de postulantes - ";
            this.Text += DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
