using System;
using System.Collections.Generic;
using System.Linq;

namespace Numeros_Pseudoaleatorios
{
    public static class PruebasEstadisticas
    {
        // ============================================
        // PRUEBA DE MEDIOS
        // ============================================
        public static string Medios(List<double> numeros)
        {
            int n = numeros.Count;
            double media = numeros.Average();

            double z = (media - 0.5) / Math.Sqrt(1.0 / (12 * n));

            return $"Prueba de Medios\n" +
                   $"Media = {media:F4}\n" +
                   $"Estadístico Z = {z:F4}";
        }

        // ============================================
        // PRUEBA DE VARIANZA
        // ============================================
        public static string Varianza(List<double> numeros)
        {
            int n = numeros.Count;
            double media = numeros.Average();

            double suma = numeros.Sum(x => Math.Pow(x - media, 2));
            double varianza = suma / (n - 1);

            double chiCuadrada = (n - 1) * varianza / (1.0 / 12.0);

            return $"Prueba de Varianza\n" +
                   $"Varianza muestral = {varianza:F4}\n" +
                   $"Estadístico Chi-cuadrada (χ²) = {chiCuadrada:F4}";
        }

        // ============================================
        // PRUEBA DE FRECUENCIA
        // ============================================
        public static string Frecuencia(List<double> numeros, int intervalos = 10)
        {
            int n = numeros.Count;
            int[] freq = new int[intervalos];

            foreach (double num in numeros)
            {
                int index = (int)(num * intervalos);
                if (index == intervalos) index--;
                freq[index]++;
            }

            double esperado = (double)n / intervalos;
            double chiCuadrada = 0;

            for (int i = 0; i < intervalos; i++)
                chiCuadrada += Math.Pow(freq[i] - esperado, 2) / esperado;

            return $"Prueba de Frecuencia\n" +
                   $"Intervalos = {intervalos}\n" +
                   $"Estadístico Chi-cuadrada (χ²) = {chiCuadrada:F4}";
        }

        // ============================================
        // PRUEBA DE SERIES
        // ============================================
        public static string Series(List<double> numeros)
        {
            int n = numeros.Count - 1;
            int[,] matriz = new int[2, 2];

            for (int i = 0; i < n; i++)
            {
                int fila = numeros[i] < 0.5 ? 0 : 1;
                int col = numeros[i + 1] < 0.5 ? 0 : 1;
                matriz[fila, col]++;
            }

            double esperado = n / 4.0;
            double chiCuadrada = 0;

            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    chiCuadrada += Math.Pow(matriz[i, j] - esperado, 2) / esperado;

            return $"Prueba de Series\n" +
                   $"Estadístico Chi-cuadrada (χ²) = {chiCuadrada:F4}";
        }

        // ============================================
        // PRUEBA DE CORRIDAS
        // ============================================
        public static string Corridas(List<double> numeros)
        {
            int n = numeros.Count;
            int corridas = 1;

            for (int i = 1; i < n; i++)
            {
                if ((numeros[i] >= 0.5) != (numeros[i - 1] >= 0.5))
                    corridas++;
            }

            int n1 = numeros.Count(x => x >= 0.5);
            int n2 = numeros.Count(x => x < 0.5);

            double media =
                ((2.0 * n1 * n2) / (n1 + n2)) + 1;

            double varianza =
                (2.0 * n1 * n2 * (2 * n1 * n2 - n1 - n2)) /
                (Math.Pow(n1 + n2, 2) * (n1 + n2 - 1));

            double z = (corridas - media) / Math.Sqrt(varianza);

            return $"Prueba de Corridas\n" +
                   $"Número de corridas = {corridas}\n" +
                   $"Estadístico Z = {z:F4}";
        }

        // ============================================
        // PRUEBA DE POKER (solo conteo por ahora)
        // ============================================
        public static string Poker(List<double> numeros)
        {
            int todosDif = 0, unPar = 0, dosPares = 0, tercia = 0, poker = 0;

            foreach (double num in numeros)
            {
                string s = ((int)(num * 10000)).ToString("D4");

                var grupos = s.GroupBy(c => c)
                              .Select(g => g.Count())
                              .OrderByDescending(x => x)
                              .ToList();

                if (grupos[0] == 4) poker++;
                else if (grupos[0] == 3) tercia++;
                else if (grupos[0] == 2 && grupos.Count == 2) dosPares++;
                else if (grupos[0] == 2) unPar++;
                else todosDif++;
            }

            return $"Prueba de Poker\n" +
                   $"Todos diferentes = {todosDif}\n" +
                   $"Un par = {unPar}\n" +
                   $"Dos pares = {dosPares}\n" +
                   $"Tercia = {tercia}\n" +
                   $"Poker = {poker}";
        }
    }
}