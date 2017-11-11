using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppParaPruebaIngSoftware
{
    public class Operation
    {
        public int Add(int a, int b) {
            return a + b;
        }

        public double ImpuestoIessAnual(double salario) {
            if (salario < 0)
            {
                return 0;
            }
            else {
                return Math.Truncate((((salario * (1 - 0.0945)) * 12)));
            }
        }

        public double CalcularImpuestoRentaAnual(double salarioAnual) {
            double baseFraccion = 0;

            double salarioNeto = ImpuestoIessAnual(salarioAnual); //salarioAnual;//
            
            if (salarioNeto >= 0 && salarioNeto< 11290) {
                return 0;
            }
            else {
                if (salarioNeto >= 11290 && salarioNeto < 14390)
                {
                    return Math.Truncate(((salarioNeto - 11290)*0.05)+baseFraccion);
                }
                else
                {
                    if (salarioNeto >= 14390 && salarioNeto < 17990)
                    {
                        baseFraccion = 155;
                        return Math.Truncate(((salarioNeto - 14390) * 0.10) + baseFraccion);
                    }
                    else
                    {
                        if (salarioNeto >= 17990 && salarioNeto < 21600)
                        {
                            baseFraccion = 515;
                            return Math.Truncate(((salarioNeto - 17990) * 0.12) + baseFraccion);
                        }
                        else
                        {
                            if (salarioNeto >= 21600 && salarioNeto < 43190)
                            {
                                baseFraccion = 948;
                                return Math.Truncate(((salarioNeto - 21600) * 0.15) + baseFraccion);
                            }
                            else
                            {
                                if (salarioNeto >= 43190 && salarioNeto < 64770)
                                {
                                    baseFraccion = 4187;
                                    return Math.Truncate(((salarioNeto - 43190) * 0.20) + baseFraccion);
                                }
                                else
                                {
                                    if (salarioNeto >= 64770 && salarioNeto < 86370)
                                    {
                                        baseFraccion = 8503;
                                        return Math.Truncate(((salarioNeto - 64770) * 0.25) + baseFraccion);
                                    }
                                    else
                                    {
                                        if (salarioNeto >= 86370 && salarioNeto < 115140)
                                        {
                                            baseFraccion = 13903;
                                            return Math.Truncate(((salarioNeto - 86370) * 0.30) + baseFraccion);
                                        }
                                        else
                                        {
                                            if (salarioNeto >= 115140)
                                            {
                                                baseFraccion = 22534;
                                                return Math.Truncate(((salarioNeto - 115140) * 0.35) + baseFraccion);
                                            }
                                            else
                                            {
                                                return 0;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
         }
    }
}
