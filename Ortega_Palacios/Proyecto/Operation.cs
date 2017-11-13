using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto
{
    public class Operation
    
    {
        public Operation() 
        { 
        
        }
         public int add (int num1,int num2)
        {
            return num1 + num2;
        }

         public double calculoAnual(double sueldo)
         {

             if (sueldo < 0)
             {
                 return 0;
             }
             else
             {

                 double cantidadAnual = (sueldo * 0.9055 * 12);
                 return cantidadAnual;
             }
         
            }
         public double impuesto(double anual)
         {
             double renta = 0;
             if ((anual >= 0) && (anual <= 11290))
             {
                 renta = 0;
             }
             if ((anual > 11290) && (anual <= 14390))
             {
                 renta = ((anual - 11290) * (0.05));
             }
             if ((anual > 14390) && (anual <= 17990))
             {
                 renta = ((anual - 14390) * (0.1));
                 renta += 155;
             }
             if ((anual > 17990) && (anual <= 21600))
             {
                 renta = ((anual - 17990) * (0.12));
                 renta += 515;
             }
             if ((anual > 21600) && (anual <= 43190))
             {
                 renta = ((anual - 21600) * (0.15));
                 renta += 948;
             }
             if ((anual > 43190) && (anual <= 64770))
             {
                 renta = ((anual - 43190) * (0.20));
                 renta += 4187;
             }
             if ((anual > 64770) && (anual <= 86370))
             {
                 renta = ((anual - 64770) * (0.25));
                 renta += 8503;
             }
             if ((anual > 86370) && (anual <= 115140))
             {
                 renta = ((anual - 86370) * (0.30));
                 renta += 13903;
             }
             if ((anual > 115140) )
             {
                 renta = ((anual - 115140) * (0.35));
                 renta += 22534;
             }


             return renta;

         }
        
    }
}
