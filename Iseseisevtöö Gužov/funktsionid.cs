using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace Iseseisevtöö_Gužov
{
    class funktsionid
    {
        public static void ulesane1()
        {
            Console.WriteLine("kirjuta midagi");
            string line = Console.ReadLine();
            string vowels = "aeouiy";
            int result = 0;
            foreach (char symbol in line)
            {
                if (vowels.Contains(symbol.ToString()))
                    result++;
            }
            Console.WriteLine(result);
            double pikkusDouble = Convert.ToDouble(line.Length);
            double resultDouble = Convert.ToDouble(result);
            double protsent = (resultDouble / pikkusDouble) * 100;
            Console.WriteLine($"Esinemisprotsent on {protsent}%");

        }
        public static void ulesane2()
        {
            Console.Write("n = ");
            var n = int.Parse(Console.ReadLine());
            var a = new int[n];
            var r = new Random();
            var count = 0;
            for (var i = 0; i < n; i++)
            {
                a[i] = r.Next(-2000, 2000);
                if (a[i] > -100 && a[i] < 100) count++;
            }
            Console.WriteLine("{0} numbrid vahemikus -100 kuni 100", count);

        }
        public static void ulesane3()
        {
            
        }




    }
}
