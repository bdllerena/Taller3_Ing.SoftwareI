using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpuestoRenta
{
    public class CalculoRenta
    {
           
        public double SueldoAnual(int sueldo)
        {
            double sueldoAnual;
            if (sueldo <= 0)
                return 0;
            else {
                sueldoAnual = (sueldo * 0.9055) * 12;
                return sueldoAnual;
            }
            
        }
        public int ImpuestoRenta(string sueldoA)
        {
            double sueldoAnual;
            sueldoAnual = Validacion(sueldoA);
            if (sueldoAnual>=0) { 
            int impRenta;
                if (sueldoAnual >= 0 && sueldoAnual < 11290) {
                    impRenta=Convert.ToInt32(sueldoAnual * 0.10);
                    return impRenta;
                }
                    else if (sueldoAnual >= 11290 && sueldoAnual < 14390) {
                        impRenta = Convert.ToInt32((sueldoAnual - 11290) * 0.05);
                        return impRenta;
                     }
                        else if (sueldoAnual >= 14390 && sueldoAnual < 17990) {
                            impRenta = Convert.ToInt32((sueldoAnual - 14390) * 0.10);
                            return impRenta+155;
                        }
                            else if (sueldoAnual >= 17990 && sueldoAnual < 21600) {
                                impRenta = Convert.ToInt32((sueldoAnual - 17990) * 0.12);
                                return impRenta + 515;
                            }
                                else if (sueldoAnual >= 21600 && sueldoAnual < 43190) {
                                    impRenta = Convert.ToInt32((sueldoAnual - 21600) * 0.15);
                                    return impRenta + 948;
                                }
                                    else if (sueldoAnual >= 43190 && sueldoAnual < 64770) {
                                        impRenta = Convert.ToInt32((sueldoAnual - 43190) * 0.2);
                                        return impRenta + 4187;
                                    }
                                        else if (sueldoAnual >= 64770 && sueldoAnual < 86370) {
                                            impRenta = Convert.ToInt32((sueldoAnual - 64770) * 0.25);
                                            return impRenta + 8503;
                                        }
                                            else if (sueldoAnual >= 86370 && sueldoAnual < 115140) {
                                                impRenta = Convert.ToInt32((sueldoAnual - 86370) * 0.25);
                                                return impRenta + 13903;
                                            }
                                                else {
                                                    impRenta = Convert.ToInt32((sueldoAnual - 115140) * 0.35);
                                                    return impRenta + 22534;
                                                }
                }else
                return 0;                            
            }

        public double Validacion(string sueldoA) {
            double num;
            try {
                num = Double.Parse(sueldoA);
                return num;
            }
            catch (Exception ex) {
                return -1;
            }
        }

    }
}
