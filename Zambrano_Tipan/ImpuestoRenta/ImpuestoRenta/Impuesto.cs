using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestoRenta
{
    class Impuesto
    {
        int fraccionBasica;
        Int64 excesoHasta;
        int impuestoFraccionBasica;
        float impuestoFraccionExcedente;

        public Impuesto()
        {
            this.fraccionBasica=0;
            this.excesoHasta =0;
            this.impuestoFraccionBasica =0;
            this.impuestoFraccionExcedente =0f;
        }

        public Impuesto(int fraccionBasica, Int64 excesoHasta, int impuestoFraccion, float impuestoFraccionExcedente)
        {
            this.fraccionBasica = fraccionBasica;
            this.excesoHasta = excesoHasta;
            this.impuestoFraccionBasica = impuestoFraccion;
            this.impuestoFraccionExcedente = impuestoFraccionExcedente;
        }

        public int getFraccionBasica()
        {
            return fraccionBasica;
        }

        public int getImpuestoFraccionBasica()
        {
            return impuestoFraccionBasica;
        }

        public float getImpuestoFraccionExcedente()
        {
            return impuestoFraccionExcedente;
        }

        public Int64 getExcesoHasta()
        {
            return excesoHasta;
        }

    }
}
