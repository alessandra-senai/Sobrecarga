using System;

namespace SobrecargaClasses
{
    public static class Calculadora
    {
        public static int Somar(int valorA, int valorB)
        {
            return valorA + valorB;
        }

        public static double Somar(double valorA, double valorB)
        {
            return valorA + valorB;
        }

        public static int Subtrair(int valorA, int valorB)
        {
            return valorA - valorB;
        }

        public static decimal Subtrair(decimal valorA, decimal valorB)
        {
            return valorA - valorB;
        }

        public static int Multiplicar(int valorA, int valorB)
        {
            return valorA * valorB;
        }

        public static decimal Multiplicar(decimal valorA, decimal valorB)
        {
            return valorA * valorB;
        }

        public static int MenorValor(int numeroA, int numeroB)
        {
            return Math.Min(numeroA, numeroB);
        }

        public static int MaiorValor(int numeroA, int numeroB)
        {
            return Math.Max(numeroA, numeroB);
        }
    }
}
