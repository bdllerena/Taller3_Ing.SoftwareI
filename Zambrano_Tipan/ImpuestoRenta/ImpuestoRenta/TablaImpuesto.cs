using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestoRenta
{
    public class TablaImpuesto
    {
        Dictionary<int, Impuesto> tabla = new Dictionary<int, Impuesto>()
        {
            {1,new Impuesto(0, 11290, 0, 0) },
            {2, new Impuesto(11290, 14390, 0, 0.05f) },
            {3, new Impuesto(14390, 17990, 155, 0.10f) },
            {4, new Impuesto(17990, 21600, 515, 0.12f) },
            {5, new Impuesto(21600, 43190, 948, 0.15f) },
            {6, new Impuesto(43190, 64770, 4187, 0.20f) },
            {7, new Impuesto(64770, 86370, 8513, 0.25f) },
            {8, new Impuesto(86370, 115140, 13903, 0.30f) },
            {9, new Impuesto(115140, 1000000000000000000,22534, 0.35f) }
        };

        public int calculoSueldo(float sueldo)
        {
            if (sueldo > 0)
            {
                double sueldoCalculado = sueldo * 12 * 0.9055;
                int aux = (Int32)(Math.Truncate(sueldoCalculado));
                return aux;
            }
            else
                return 0;

        }

        public int calcularImpuesto(float sueldo)
        {
            if (sueldo >= 0)
            {
                int sueldoAnual = calculoSueldo(sueldo);
                int valorExcedente = 0;
                float impuestoFraccionExcedenteCalculado = 0f;
                float valorFinal = 0f;
                foreach (KeyValuePair<int, Impuesto> result in tabla)
                {
                    if ((sueldoAnual >= result.Value.getFraccionBasica()) && (sueldoAnual < result.Value.getExcesoHasta()))
                    {
                        valorExcedente = sueldoAnual - result.Value.getFraccionBasica();
                        impuestoFraccionExcedenteCalculado = valorExcedente * result.Value.getImpuestoFraccionExcedente();
                        valorFinal = impuestoFraccionExcedenteCalculado + result.Value.getImpuestoFraccionBasica();
                        break;
                    }
                }
                int valorFinalEntero = (Int32)(Math.Truncate(valorFinal));
                return valorFinalEntero;

            }
            else
            {
                Console.Write("Valor de sueldo inválido");
                return 0;
            }
        }

        
    }
}
