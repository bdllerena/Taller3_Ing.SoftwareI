using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Taller
{
    public class CalculoImpuesto
    {
        public CalculoImpuesto()
        {

        }
        public double Sueldo(double sueldo)
        {
            if (sueldo < 0 || sueldo > 10000000)
            {

                return 0;
            }
            else
            {
                    double sueldoTotal = sueldo * 0.9055 * 12;
                    return sueldoTotal;
             }

            //return sueldoFinal;
        }
        public double calcularImpueto(int sueldo)
        {
            double sueldoExcedente = 0;
            if (sueldo < 0)
            {
                return 0;
            }
            else
            {
                
                if (sueldo >= 0 && sueldo < 11290)
                {
                    sueldoExcedente = 0;
                }
                if (sueldo >= 11290 && sueldo < 14390)
                {
                    sueldoExcedente = (sueldo - 11290) * 0.05;
                }
                if (sueldo >= 14390 && sueldo < 17990)
                {
                    sueldoExcedente = (sueldo - 14390) * 0.10 + 155;
                }
                if (sueldo >= 17990 && sueldo < 21600)
                {
                    sueldoExcedente = (sueldo - 17990) * 0.12 + 515;
                }
                if (sueldo >= 21600 && sueldo < 43190)
                {
                    sueldoExcedente = (sueldo - 21600) * 0.15 + 948;
                }
                if (sueldo >= 43190 && sueldo < 64770)
                {
                    sueldoExcedente = (sueldo - 43190) * 0.20 + 4187;
                }
                if (sueldo >= 64770 && sueldo < 86370)
                {
                    sueldoExcedente = (sueldo - 64770) * 0.25 + 8503;
                }
                if (sueldo >= 86370 && sueldo < 115140)
                {
                    sueldoExcedente = (sueldo - 86370) * 0.30 + 13903;
                }
                if (sueldo >= 115140)
                {
                    sueldoExcedente = (sueldo - 115140) * 0.35 + 22534;
                }
            }
            return sueldoExcedente;
        }
    }
}
