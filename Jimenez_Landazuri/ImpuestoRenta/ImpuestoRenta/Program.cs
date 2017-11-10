using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestoRenta
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculoRenta calc = new CalculoRenta();
            double slA;

            slA=calc.SueldoAnual(2000);
            calc.ImpuestoRenta(slA.ToString());
            //impuesto=968
            System.Console.Out.Write(calc.ImpuestoRenta(slA.ToString()));
                        
            
        }
    }
}
