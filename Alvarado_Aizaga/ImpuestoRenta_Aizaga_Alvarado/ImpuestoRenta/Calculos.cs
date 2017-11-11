using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestoRenta
{


   public class Calculos
    {
        float valor = 0.9055f;
        public int CalcularSueldoAnual(float sueldo) {
            if (sueldo > 0)
            {
                float resultado = sueldo * valor * 12;
                return Convert.ToInt32(Math.Truncate(resultado));
            }
            else {
                Console.WriteLine("Error sueldo incorrecto");
                return 0;
            }
        }
        public int CalcularImpuesto(float sueldoAnual)
        {

           int iFraccionBasica = 0;
           float impuesto= 0;

           if(sueldoAnual>0 && sueldoAnual<=11.290){
               return 0;

           }
           if (sueldoAnual >11290 && sueldoAnual <=14390)
           {
               iFraccionBasica = 0;
               impuesto = 0.05f;
               return Convert.ToInt32(Math.Truncate((((sueldoAnual - 11290 )*impuesto)+iFraccionBasica)));
           }

           if (sueldoAnual >14390 && sueldoAnual <= 17990)
           {
               iFraccionBasica = 155;
               impuesto = 0.1f;
               return Convert.ToInt32(Math.Truncate((((sueldoAnual - 14390) * impuesto) + iFraccionBasica)));
           }

           if (sueldoAnual > 17990 && sueldoAnual <= 21600)
           {
               iFraccionBasica = 515;
               impuesto = 0.12f;
               return Convert.ToInt32(Math.Truncate((((sueldoAnual - 17990) * impuesto) + iFraccionBasica)));
           }
           if (sueldoAnual > 21600 && sueldoAnual <= 43190)
           {
               iFraccionBasica = 948;
               impuesto = 0.15f;
               return Convert.ToInt32(Math.Truncate((((sueldoAnual - 21600) * impuesto) + iFraccionBasica)));
           }
           if (sueldoAnual > 43190 && sueldoAnual <= 64770)
           {
               iFraccionBasica = 4187;
               impuesto = 0.2f;
               return Convert.ToInt32(Math.Truncate((((sueldoAnual - 43190) * impuesto) + iFraccionBasica)));
           }
           if (sueldoAnual > 64770 && sueldoAnual <= 86370)
           {
               iFraccionBasica = 8503;
               impuesto = 0.25f;
               return Convert.ToInt32(Math.Truncate((((sueldoAnual - 64770) * impuesto) + iFraccionBasica)));
           }
           if (sueldoAnual > 86370 && sueldoAnual <= 115140)
           {
               iFraccionBasica = 13903;
               impuesto = 0.3f;
               return Convert.ToInt32(Math.Truncate((((sueldoAnual - 86370) * impuesto) + iFraccionBasica)));
           }
           if (sueldoAnual > 115140)
           {
               iFraccionBasica = 22534;
               impuesto = 0.35f;
               return Convert.ToInt32(Math.Truncate((((sueldoAnual - 115140) * impuesto) + iFraccionBasica)));
           }
         

            return 0;
        }

    


    }
}
