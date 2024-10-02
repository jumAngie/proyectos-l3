using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P25_Control_Registro_Llamadas_MCVR_SP
{
    public partial class frmLlamadasCRSP : Form
    {
        public frmLlamadasCRSP()
        {
            InitializeComponent();
            tHora.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ListViewItem fila = new ListViewItem(getTipo());
            fila.SubItems.Add(getHorario());
            fila.SubItems.Add(getMinutos().ToString());
            fila.SubItems.Add(asignaCostoxMinuto().ToString("0.00"));
            fila.SubItems.Add(asignaCostoxLlamada().ToString("0.00"));
            lvRegistro.Items.Add(fila);

            lvEstadisticas.Items.Clear();
        }

        private void cboTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

            lblCosto.Text = asignaCostoxMinuto().ToString("C");
        }

        private void tHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        string getTipo() 
        { 
            return cboTipo.Text;
        }

        string getHorario()
        {
            return cboHorario.Text;
        }

        int getMinutos()
        {
            return int.Parse(txtMinutos.Text);
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {

            double aLocNac = 0, aLocInt = 0, aMovNac = 0, aMovInt = 0;
            for (int i = 0; i < lvRegistro.Items.Count; i++)
            {
                string t = lvRegistro.Items[i].SubItems[0].Text;
                if (t == "Local Nacional")
                    aLocNac += double.Parse(lvRegistro.Items[i].SubItems[4].Text);
                else if (t == "Local Internacional")
                    aLocInt += double.Parse(lvRegistro.Items[i].SubItems[4].Text);
                else if (t == "Movil Nacional")
                    aMovNac += double.Parse(lvRegistro.Items[i].SubItems[4].Text);
                else if (t == "Movil Internacional")
                    aMovInt += double.Parse(lvRegistro.Items[i].SubItems[4].Text);
            }

            lvEstadisticas.Items.Clear();
            string[] elementoFila = new string[2];
            ListViewItem row;

            elementoFila[0] = "Numero de llamadas entre 10 y 30 minutos";
            elementoFila[1] = numeroLlamadas().ToString();
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);

            elementoFila[0] = "Costo acumulado por Local Nacional";
            elementoFila[1] = aLocNac.ToString("C");
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);

            elementoFila[0] = "Costo acumulado por Local Internacional";
            elementoFila[1] = aLocInt.ToString("C");
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);

            elementoFila[0] = "Costo acumulado por Movil Nacional";
            elementoFila[1] = aMovNac.ToString("C");
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);

            elementoFila[0] = "Costo acumulado por Movil Internacional";
            elementoFila[1] = aMovInt.ToString("C");
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);

            double mayorMonto = double.Parse(lvRegistro.Items[0].SubItems[4].Text);
            int posicion = 0;
            for (int i = 0; i < lvRegistro.Items.Count; i++)
            {
                if (double.Parse(lvRegistro.Items[i].SubItems[4].Text) > mayorMonto)
                {
                    mayorMonto = double.Parse(lvRegistro.Items[i].SubItems[4].Text);
                    posicion = i;
                }
            }

            elementoFila[0] = "Mayor monto de llamada";
            elementoFila[1] = mayorMonto.ToString("C");
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);

            elementoFila[0] = "Tipo de Llamada con mayor monto";
            elementoFila[1] = lvRegistro.Items[posicion].SubItems[0].Text;
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);

            elementoFila[0] = "Horario con mayor monto";
            elementoFila[1] = lvRegistro.Items[posicion].SubItems[1].Text;
            row = new ListViewItem(elementoFila);
            lvEstadisticas.Items.Add(row);
        }

        double asignaCostoxMinuto()
        {
            double costoMinuto = 0;
            switch (cboTipo.Text)
            {
                case "Local Nacional": costoMinuto = 0.20; break;
                case "Local Internacional": costoMinuto = 0.50; break;
                case "Movil Nacional": costoMinuto = 1.20; break;
                case "Movil Internacional": costoMinuto = 2.20; break;

            }

            return costoMinuto;
        }

        double asignaCostoxLlamada()
        {
            double importe = asignaCostoxMinuto() * getMinutos();
            
            double descuento = 0;
            switch (getHorario())
            {
                case "Diurno\t    (07:00-13:00)": descuento = importe * 0.3; break;
                case "Tarde \t    (13:00-19:00)": descuento = importe * 0.2; break;
                case "Noche \t    (19:00-23:00)": descuento = importe * 0.1; break;
                case "Madrugada  (23:00-07:00)": descuento = importe * 0.3; break;
            }

            return importe - descuento;
        }

        int numeroLlamadas()
        {
            int cLlamadas = 0;
            for (int i = 0; i < lvRegistro.Items.Count; i++)
            {
                int minutos = int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                if (minutos >= 10 && minutos <= 30) cLlamadas++;
            }

            return cLlamadas;
        }

        private void frmLlamadasCRSP_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }
    }
}
