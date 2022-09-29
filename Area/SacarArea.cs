using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Area
{
    public class SacarArea
    {
        public decimal numero1 { get; set; }
        public decimal numero2 { get; set; }
        public double numero3 { get; set; }
        public decimal cuadrado(decimal n1)
        {
            var resultado = n1 * n1;
            return resultado;
        }
        public decimal triangulo(decimal n1, decimal n2)
        {
            var resultado = (n1 * n2)/2;
            return resultado;
        }
        public double circulo(double n1)
        {
            const double pi = 3.1416;
            double resultado = pi * (n1 * n1);
            return resultado; 
        }
    }
}