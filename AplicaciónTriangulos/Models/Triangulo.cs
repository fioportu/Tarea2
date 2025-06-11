using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrianguloApp.Models
{
    public class Triangulo
    {
        public double LadoA { get; set; }
        public double LadoB { get; set; }
        public double LadoC { get; set; }

        public bool EsTriangulo()
        {
            return LadoA + LadoB > LadoC &&
                   LadoA + LadoC > LadoB &&
                   LadoB + LadoC > LadoA;
        }

        public string Tipo()
        {
            if (LadoA == LadoB && LadoB == LadoC)
                return "Equilátero";
            else if (LadoA == LadoB || LadoA == LadoC || LadoB == LadoC)
                return "Isósceles";
            else
                return "Escaleno";
        }

        public double Perimetro()
        {
            return LadoA + LadoB + LadoC;
        }

        public double Semiperimetro()
        {
            return (LadoA + LadoB + LadoC) / 2;
        }


        public double Area()
        {
            double s = Perimetro() / 2;
            return System.Math.Sqrt(s * (s - LadoA) * (s - LadoB) * (s - LadoC));
        }

        public (double, double, double) CalcularAngulos()
        {
            double alfa = Math.Acos((Math.Pow(LadoB, 2) + Math.Pow(LadoC, 2) - Math.Pow(LadoA, 2)) / (2 * LadoB * LadoC)) * (180 / Math.PI);
            double beta = Math.Acos((Math.Pow(LadoA, 2) + Math.Pow(LadoC, 2) - Math.Pow(LadoB, 2)) / (2 * LadoA * LadoC)) * (180 / Math.PI);
            double gamma = 180 - alfa - beta;

            return (Math.Round(alfa, 2), Math.Round(beta, 2), Math.Round(gamma, 2));
        }
    }
}