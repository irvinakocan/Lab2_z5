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

        static bool DaLiSuIsteRijeci(string s1, string s2)
        {
            if (s1.Length != s2.Length)
                return false;

            bool iste = true;

            for (int i = 0; i < s1.Length; i++)
            {
                if (char.ToLower(s1[i]) != char.ToLower(s2[i]))
                    iste = false;
            }

            return iste;
        }

        static string[] ProcistiNiz(string[] s)
        {
            for (int i = 0; i < s.Length - 1; i++)
                for (int j = i + 1; j < s.Length; j++)
                    if (DaLiSuIsteRijeci(s[i], s[j]))
                        s[j] = "";

            return s;
        }

        static void Main(string[] args)
        {
            Console.Write("Unesite broj rijeci: ");
            string ulaz = Console.ReadLine();
            int n = Int32.Parse(ulaz);

            Console.WriteLine("\nUnesite rijeci: ");
            string[] rijeci = new string[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}: ", i + 1);
                rijeci[i] = Console.ReadLine();
            }


            Console.WriteLine("\nPrva i posljednja rijec iz spiska po abecednom poretku: " +
                "\n {0} \n {1}",
                SortirajRijec(rijeci[0]), SortirajRijec(rijeci[n - 1]));


            Console.WriteLine("\nPopis svih unesenih riječi, bez duplikata:");
            var procisceneRijeci = ProcistiNiz(rijeci);
            for (int i = 0; i < procisceneRijeci.Length; i++)
                if (procisceneRijeci[i] != "")
                    Console.Write("{0} ", procisceneRijeci[i]);
        } 
    }
}
