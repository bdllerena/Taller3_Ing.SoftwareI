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
            //Console.Read()
            TablaImpuesto tabla = new TablaImpuesto();
            tabla.calcularImpuesto(350);

        }
    }
}
