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

namespace P27_Control_Pago_Empleados
{
    public partial class frmPlanilla : Form
    {
        double tVentas, tMarketing, tLogistica, tPrestamo;
        double aVentas, aMarketing, aLogistica, aPrestamo;
        double aPersonal, aComision;

        public frmPlanilla()
        {
            InitializeComponent();
        }

        string getEmpleado()
        {
            return txtEmpleado.Text;
        }

        int getHijos()
        {
            return int.Parse(txtHijos.Text);
        }

        string getArea()
        {
            return cboArea.Text;
        }

        string getCondicion()
        {
            return cboCondicion.Text;
        }

        DateTime getFecha()
        {
            return dtFechaIng.Value;
        }

        double asignaSueldoBase(string area, string condicion)
        {
            switch (area)
            {
                case "Ventas":
                    if (condicion == "Personal") return 2500;
                    else return 500;
                case "Marketing":
                    if (condicion == "Personal") return 1800;
                    else return 1100;
                case "Logistica":
                    if (condicion == "Personal") return 3500;
                    else return 2500;
                case "Prestamo":
                    if (condicion == "Personal") return 1500;
                    else return 900;
            }
            return 0;
        }

        int calculaTiempoServicio()
        {
            return DateTime.Now.Year - getFecha().Year;
        }

        double calculaMovilidad(double sueldoBase)
        {
            switch (getArea()) 
            {
                case "Ventas": 
                    if(getCondicion() == "Personal")
                        return 10.0 / 100 * 100 * sueldoBase;
                    else
                        return 5.0 / 100 * sueldoBase;
                case "Marketing":
                    if (getCondicion() == "Personal")
                        return 20.0 / 100 * 100 * sueldoBase;
                    else
                        return 10.0 / 100 * sueldoBase;
                case "Logistica":
                    if (getCondicion() == "Personal")
                        return 30.0 / 100 * 100 * sueldoBase;
                    else
                        return 15.0 / 100 * sueldoBase;
                case "Prestamo":
                    if (getCondicion() == "Personal")
                        return 25.0 / 100 * 100 * sueldoBase;
                    else
                        return 12.5 / 100 * sueldoBase;

            }
            return 0;
        }

        double calculaDescuento(double sueldoBase)
        {
            return 17.0 / 100 * sueldoBase;
        }
        double calculaAsignacion(int hijos)
        {
            return hijos * 20;
        }

        double calculaNeto(double sueldoBase, double movilidad, double asignacion, double descuento)
        {
            return sueldoBase + movilidad + asignacion - descuento;
        }

        void imprimir(int tiempo, double sueldoBase, double movilidad, double asignacion,
                        double descuento, double neto)
        {
            ListViewItem fila = new ListViewItem(getEmpleado());
            fila.SubItems.Add(getHijos().ToString());
            fila.SubItems.Add(getArea());
            fila.SubItems.Add(getCondicion());
            fila.SubItems.Add(tiempo.ToString());
            fila.SubItems.Add(sueldoBase.ToString("0.00"));
            fila.SubItems.Add(movilidad.ToString("0.00"));
            fila.SubItems.Add(asignacion.ToString("0.00"));
            fila.SubItems.Add(descuento.ToString());
            fila.SubItems.Add(neto.ToString("0.00"));
            lvEmpleados.Items.Add(fila);

        }

        // C1
        public void totalEmpleadosxArea()
        {
            tVentas = 0;
            tMarketing = 0;
            tLogistica = 0;
            tPrestamo = 0;

            for (int i = 0; i < lvEmpleados.Items.Count; i++) 
            { 
                string area = lvEmpleados.Items[i].SubItems[2].Text;
                switch(area)
                {
                    case "Ventas": tVentas++; break;
                    case "Marketing": tMarketing++; break;
                    case "Logistica": tLogistica++; break;
                    case "Prestamo": tPrestamo++; break;
                }
            }
        }

        //C2
        public void montoAcumuladorxCondicion()
        {
            aPersonal = 0;
            aComision = 0;

            for(int i =0; i < lvEmpleados.Items.Count; i++)
            {
                string condicion = lvEmpleados.Items[i].SubItems[3].Text;
                switch(condicion)
                {
                    case "Personal": 
                        aPersonal += double.Parse(lvEmpleados.Items[i].SubItems[9].Text);
                        break;
                    case "Comisión":
                        aComision += double.Parse(lvEmpleados.Items[i].SubItems[9].Text);
                        break;
                }
            }
        }
      
        //C3
        public void montoAcumuladoxArea()
        {
            aVentas = 0;
            aMarketing = 0;
            aLogistica = 0;
            aPrestamo = 0;

            for (int i =0; i < lvEmpleados.Items.Count; i++)
            {
                string area = lvEmpleados.Items[i].SubItems[2].Text;
                switch (area)
                {
                    case "Ventas":
                        aVentas += double.Parse(lvEmpleados.Items[i].SubItems[9].Text);
                        break;
                    case "Marketing":
                        aMarketing += double.Parse(lvEmpleados.Items[i].SubItems[9].Text);
                        break;
                    case "Logistica":
                        aLogistica += double.Parse(lvEmpleados.Items[i].SubItems[9].Text);
                        break;
                    case "Prestamo":
                        aPrestamo += double.Parse(lvEmpleados.Items[i].SubItems[9].Text);
                        break;
                }
            }
        }

        bool validaEmpleado()
        {
            bool estado = false;
            for (int i=0; i < lvEmpleados.Items.Count; i++)
            {
                string empleado = lvEmpleados.Items[i].SubItems[0].Text;

                if (getEmpleado() == empleado) estado = true;
            }

            return estado;
        }

        string valida()
        {
            if(txtEmpleado.Text.Trim().Length == 0)
            {
                txtEmpleado.Focus();
                return "nombre del empleado";
            }
            else if(!Information.IsNumeric(txtHijos.Text))
            {
                txtHijos.Text = "";
                txtHijos.Focus();
                return "nombre de hijos; es un valor numero...!!!";
            }
            else if(cboArea.SelectedIndex == -1)
            {
                cboArea.Focus();
                return "area del empleado";
            }
            else if(cboCondicion.SelectedIndex == -1)
            {
                cboCondicion.Focus();
                return "condicion del empleado";
            }
            return "";
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (valida() == "")
            {
                string empleado = getEmpleado();
                if (validaEmpleado() == false)
                {
                    int hijos = getHijos();
                    string area = getArea();
                    string condicion = getCondicion();

                    int anios = calculaTiempoServicio();
                    double sueldoBase = asignaSueldoBase(area, condicion);
                    double movilidad = calculaMovilidad(sueldoBase);
                    double asignacion = calculaAsignacion(hijos);
                    double descuento = calculaDescuento(sueldoBase);
                    double neto = calculaNeto(sueldoBase, movilidad, asignacion, descuento);

                    imprimir(anios, sueldoBase, movilidad, asignacion, descuento, neto);
                }
                else
                {
                    MessageBox.Show("El empleado ya se encuentra registrado.", "Planilla");
                    return;
                }
            }
            else
            {
                MessageBox.Show("El error se encuentra en " + valida(), "Planilla",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConsulta1_Click(object sender, EventArgs e)
        {
            totalEmpleadosxArea();

            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Total de Personal area de Ventas";
            elementosFila[1] = tVentas.ToString("0.00");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Total de Personal area de Marketing";
            elementosFila[1] = tMarketing.ToString("0.00");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Total de Personal area de Logistica";
            elementosFila[1] = tLogistica.ToString("0.00");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Total de Personal area de Prestamo";
            elementosFila[1] = tPrestamo.ToString("0.00");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
        }

        private void btnConsulta2_Click(object sender, EventArgs e)
        {
            montoAcumuladorxCondicion();
            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Monto neto acumulado por empleados tipo Personal";
            elementosFila[1] = aPersonal.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto neto acumulado por empleados tipo Comision";
            elementosFila[1] = aComision.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);
        }

        private void btnConsulta3_Click(object sender, EventArgs e)
        {
            montoAcumuladoxArea();

            lvEstadisticas.Items.Clear();
            string[] elementosFila = new string[2];
            ListViewItem row;

            elementosFila[0] = "Monto neto acumulado del area de Ventas";
            elementosFila[1] = aVentas.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto neto acumulado del area de Marketing";
            elementosFila[1] = aMarketing.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto neto acumulado del area de Logistica";
            elementosFila[1] = aLogistica.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

            elementosFila[0] = "Monto neto acumulado del area de Prestamo";
            elementosFila[1] = aPrestamo.ToString("C");
            row = new ListViewItem(elementosFila);
            lvEstadisticas.Items.Add(row);

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Esta seguro de salir?", "Prestamo",
                                            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes) this.Close();    
        }


    }
}
