using System;

namespace SimpleAlgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] m = { 450, 177, 237, -27, -73, 466, -457 };

            var min = m[0];
            for (var i = 1; i < m.Length; i++)
            {
                if (m[i] < min)
                {
                    min = m[i];
                }
            }
            Console.WriteLine("Min={0}", min);
            var max = m[0];
            for (var i = 1; i < m.Length; i++)
            {
                if (m[i] > max)
                {
                    max = m[i];
                }
            }
            Console.WriteLine("Max={0}", max);
            int option;
            for (var i = 0; i < m.Length - 1; i++)
            {
                for (var j = i + 1; j < m.Length; j++)
                {
                    if (m[i] > m[j])
                    {
                        option = m[i];
                        m[i] = m[j];
                        m[j] = option;
                    }
                }
            }
            Console.WriteLine("Сортировка по возрастанию:");
            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }
            int option_1;
            for (int i = 0; i < m.Length - 1; i++)
            {
                for (int j = i + 1; j < m.Length; j++)
                {
                    if (m[i] < m[j])
                    {
                        option_1 = m[i];
                        m[i] = m[j];
                        m[j] = option_1;
                    }
                }
            }
            Console.WriteLine("Сортировка по убыванию:");

            for (int i = 0; i < m.Length; i++)
            {
                Console.WriteLine(m[i]);
            }
            Console.ReadKey();

        }
    }
}

