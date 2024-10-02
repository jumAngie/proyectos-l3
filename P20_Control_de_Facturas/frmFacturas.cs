﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P20_Control_de_Facturas
{
    public partial class frmFacturas : Form
    {
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToShortDateString();
        }

        private void btnRegistrarItem_Click(object sender, EventArgs e)
        {
            int i;

            int numFact = int.Parse(txtNumFact.Text);
            string licencia = cboTipo.Text;
            int unidades = int.Parse(txtUnidades.Text);

            double precio = 0;
            switch (licencia) 
            {
                case "Cobre":   precio = 700;   break;
                case "Bronce":  precio = 900;   break;
                case "Silver":  precio = 1400;  break;
                case "Gold":    precio = 2500;  break;
            }

            double subtotal = unidades * precio;

            ListViewItem fila =  new ListViewItem(numFact.ToString());
            fila.SubItems.Add(licencia);
            fila.SubItems.Add(unidades.ToString());
            fila.SubItems.Add(subtotal.ToString("0.00"));
            lvRegistro.Items.Add(fila);

            double mAcumulado = 0;
            i = 0;
            while (i < lvRegistro.Items.Count)
            {
                mAcumulado += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                i++;
            }
            lblMonto.Text = mAcumulado.ToString("C");

            int cCobre = 0, cBronce = 0, cSilver=0, cGold=0;
            double tCobre = 0, tBronce=0, tSilver=0, tGold=0;

            i = 0;
            while(i < lvRegistro.Items.Count)
            {
                if (lvRegistro.Items[i].SubItems[1].Text == "Cobre")
                {
                    cCobre += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tCobre += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                }
                else if(lvRegistro.Items[i].SubItems[1].Text == "Bronce")
                {
                    cBronce += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tBronce += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                }
                else if (lvRegistro.Items[i].SubItems[1].Text == "Silver")
                {
                    cSilver += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tSilver += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                }
                else if (lvRegistro.Items[i].SubItems[1].Text == "Gold")
                {
                    cGold += int.Parse(lvRegistro.Items[i].SubItems[2].Text);
                    tGold += double.Parse(lvRegistro.Items[i].SubItems[3].Text);
                }
                i++;
            }

            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[3];
            ListViewItem row;

            elementosFila[0] = "Total Cobre";
            elementosFila[1] = cCobre.ToString();
            elementosFila[2] = tCobre.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Total Bronce";
            elementosFila[1] = cBronce.ToString();
            elementosFila[2] = tBronce.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Total Silver";
            elementosFila[1] = cSilver.ToString();
            elementosFila[2] = tSilver.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Total Gold";
            elementosFila[1] = cGold.ToString();
            elementosFila[2] = tGold.ToString();
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
        }

        private void btnNuevaFact_Click(object sender, EventArgs e)
        {
            txtNumFact.Clear();
            txtUnidades.Clear();
            cboTipo.Text = "(Seleccione tipo)";
            txtNumFact.Focus();
        }
    }
}
