using System;

namespace Lab2_z5
{
    class Program
    {
        static string SortirajRijec(string s)
        {
            if (s.Length < 2)
                return s;

            char[] slova = new char[s.Length];
            for (int i = 0; i < slova.Length; i++)
                slova[i] = s[i];

            for(int i = 0;i < slova.Length - 1; i++)
            {
                for(int j = i + 1; j < slova.Length; j++)
                {
                    if (slova[j] < slova[i])
                    {
                        char pomocna = slova[j];
                        slova[j] = slova[i];
                        slova[i] = pomocna;
                    }
                }
            }

            return string.Concat(slova);
        }

        static void Main(string[] args)
        {
            Console.Write("Unesite broj rijeci: ");
            string ulaz = Console.ReadLine();
            int n = Int32.Parse(ulaz);

            Console.WriteLine("Unesite rijeci: ");
            string[] rijeci = new string[n];
            for(int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i + 1);
                rijeci[i] = Console.ReadLine();
            }

        }
    }
}
