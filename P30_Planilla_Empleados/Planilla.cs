using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P30_Planilla_Empleados
{
    public class Planilla
    {
        public string empleado {  get; set; }
        public string cargo { get; set; }
        public DateTime fechaIngreso { get; set; }
        public int anios {  get; set; }

        // Metodos

        public int aniosServicio()
        {
            return DateTime.Now.Year - fechaIngreso.Year;

        }

        public string mesConsultado()
        {
            int mes = DateTime.Now.Month;
            switch(mes)
            {
                case 1: return "Enero";
                case 2: return "Febrero";
                case 3: return "Marzo";
                case 4: return "Abril";
                case 5: return "Mayo";
                case 6: return "Junio";
                case 7: return "Julio";
                case 8: return "Agosto";
                case 9: return "Septiembre";
                case 10: return "Octubre";
                case 11: return "Noviembre";
                case 12: return "Diciembre";
            }

            return "";
        }

        public double DeteriminaBasico()
        {
            switch(cargo)
            {
                case "Coordinador": return 2000;
                case "Jefe": return 4000;
                case "Capacitador": return 2500;
                case "Asistente": return 1200;
            }

            return 0;
        }

        public double determinaGratificacion()
        {
            if (mesConsultado() == "Abril") return 400;
            else if (mesConsultado() == "Julio") return 450;
            else if (mesConsultado() == "Diciembre") return DeteriminaBasico()*2;

            return 0;
        }

        public double determinaComision()
        {
            if (cargo == "Asistente") return 100;
            else if (cargo == "Coordinador") return 200;
            return 0;
        }

        public double determinaDescuentoAFP()
        {
            return 0.12 * DeteriminaBasico();
        }

        public double determinaDescuentoCooperativa()
        {
            if(cargo == "Jefe") return 5.0 / 100 * DeteriminaBasico();
            else if(cargo == "Capacitador") return 2.0 * 100  * DeteriminaBasico();
            return 0;
        }

        public double determinaAportacionSeguro()
        {
            return 0.5 * DeteriminaBasico();
        }

        public double calculaTotalIngresos()
        {
            return DeteriminaBasico() + determinaGratificacion() + determinaComision();
        }

        public double calculaTotalDescuento()
        {
            return determinaDescuentoAFP() + determinaDescuentoCooperativa();
        }

        public double calculaTotalAportaciones()
        {
            return determinaAportacionSeguro();
        }

        public double determinaNeto()
        {
            return calculaTotalIngresos() - calculaTotalDescuento() - calculaTotalAportaciones();
        }
    }
}
