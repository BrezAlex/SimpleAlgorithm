﻿using System;

namespace SimpleAlgorithm
{
    class Program
    {
        private static void Main()
        {
            int[] m = { 450, 177, 237, -27, -73, 466, -457 };

            var min = m[0];
            for (var i = 1; i < m.Length; i++)
            {
                if (m[i] >= min) continue;
                min = m[i];
            }
            Console.WriteLine("Min={0}", min);
            var max = m[0];
            for (var i = 1; i < m.Length; i++)
            {
                if (m[i] <= max) continue;
                max = m[i];
            }
            Console.WriteLine("Max={0}", max);
            for (var i = 0; i < m.Length - 1; i++)
            {
                for (var j = i + 1; j < m.Length; j++)
                {
                    if (m[i] <= m[j]) continue;
                    var option = m[i];
                    m[i] = m[j];
                    m[j] = option;
                }
            }
            Console.WriteLine("Сортировка по возрастанию:");
            foreach (var t in m)
            {
                Console.WriteLine(t);
            }

            for (var i = m.Length - 1 - 1; i >= 0; i--)
            {
                for (var j = m.Length - 1; j > i; j--)
                {
                    if (m[i] >= m[j]) continue;
                    var option1 = m[i];
                    m[i] = m[j];
                    m[j] = option1;
                }
            }
            Console.WriteLine("Сортировка по убыванию:");

            foreach (var t in m)
            {
                Console.WriteLine(t);
            }
            Console.ReadKey();

        }
    }
}

