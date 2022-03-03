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
            string line = Console.ReadLine();//считываем строку
            string vowels = "aeouiy";//буквы которые надо определять
            int result = 0;//переменая для счета
            foreach (char symbol in line)//циклом foreach находим есть ли в введенной строке наши буквы и за каждую vowels результат +1
            {
                if (vowels.Contains(symbol.ToString()))
                    result++;
            }
            Console.WriteLine(result);//выводим результат на экран
            double pikkusDouble = Convert.ToDouble(line.Length);//переменные которые созданы для возможности подсчёта в процентах
            double resultDouble = Convert.ToDouble(result);
            double protsent = (resultDouble / pikkusDouble) * 100;
            Console.WriteLine($"Esinemisprotsent on {protsent}%");

        }
        public static void ulesane2()
        {
            Console.Write("n = ");//вводим произвольное число
            var n = int.Parse(Console.ReadLine());//считываем и конвертируем в интовое значение
            var a = new int[n];//переменную "а" приравниваем к переменной "n"
            var r = new Random();//для рандома
            var count = 0;//переменная счётчика
            for (var i = 0; i < n; i++)//циклк который рандомизирует энное количество цифр зависящих от ввода пользователя
            {
                a[i] = r.Next(-2000, 2000);
                if (a[i] > -100 && a[i] < 100) count++;//здесь мы считаем что если а с индеском i в пределах от -100 до 100 то счетчик +1
            }
            Console.WriteLine("{0} numbrid vahemikus -100 kuni 100", count);

        }
        public static void ulesane3()
        {
            Console.Write("sisestage oma brutopalk--> ");//ввод
            double bruto = double.Parse(Console.ReadLine());//считывем и приравниваем переменную bruto к тому что ввели 
            if (bruto<501)
            {
                Console.WriteLine("maks=0");
            }
            else if (bruto>=2100)
            {
                double nalog = (bruto * 20 / 100);
                Console.WriteLine(nalog);
            }
            else if (bruto>=1200 && bruto<=2100)
            {
                
                double nalog = 500 *1 / 900 * (bruto - 1200);
                Console.WriteLine("налог равен-->",nalog);
            }
            
        }




    }
}
