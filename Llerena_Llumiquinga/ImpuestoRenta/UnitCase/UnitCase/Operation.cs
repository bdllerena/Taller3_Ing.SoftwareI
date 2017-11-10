
using System;

namespace UnitCase
{
   public  class Operation
    {
        public double SueldoAnual (double sueldo)
        {
            double sueldoAnual = sueldo * 0.9055 * 12;
            if(sueldoAnual < 0 || sueldoAnual == 0)
            {
                return 0;
            }
            else
            {
                return Math.Truncate(sueldoAnual);
            }
            
        }
        public double ImpuestoAnual(double  sueldoAnual)
        {
            double impuestoAnual=0;
            if(sueldoAnual>=0 && sueldoAnual<11290)
            {
                impuestoAnual = sueldoAnual;
            }
            else if(sueldoAnual >= 11290 && sueldoAnual <14390)
            {
                impuestoAnual = (sueldoAnual - 11290) * 0.05;
            }
            else if(sueldoAnual>=0 && sueldoAnual<11290)
             {
                 impuestoAnual = sueldoAnual;
             }
            else if(sueldoAnual >= 11290 && sueldoAnual < 14390)
             {
                 impuestoAnual = Convert.ToDouble(((sueldoAnual - 11290) * 0.05));
             }
            else if (sueldoAnual >= 14390 && sueldoAnual < 17990)
            {
                  impuestoAnual = (((sueldoAnual - 14390) * 0.10)+155);
            }
            else if (sueldoAnual >= 17990 && sueldoAnual < 21600)
            {
                  impuestoAnual = (((sueldoAnual - 17990) * 0.12) + 515);
            }
           else  if (sueldoAnual >= 21600 && sueldoAnual < 43190)
            {
                  impuestoAnual = (((sueldoAnual - 21600) * 0.15) + 948);
            }
           else  if (sueldoAnual >= 43190 && sueldoAnual < 64770)
            {
                 impuestoAnual = (((sueldoAnual - 43190) * 0.2) + 4187);
            }
           else if (sueldoAnual >= 64770 && sueldoAnual < 86370)
            {
                  impuestoAnual = (((sueldoAnual - 64770) * 0.25) + 8503);
            }
           else if (sueldoAnual >= 86370 && sueldoAnual < 115140)
            {
                  impuestoAnual = (((sueldoAnual - 86370) * 0.3) + 13903);
            }
           else  if (sueldoAnual >= 115140)
            {
                  impuestoAnual = (((sueldoAnual - 115140) * 0.35) + 22534);
            }
            else if(sueldoAnual < 0)
            {
                impuestoAnual = 0;
            }
            return Math.Truncate(impuestoAnual);
        }
    }
}
