using System;

namespace Iseseisevtöö_Gužov
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(" Mul on 5 variant! Milles ülesane tahab kontrollida? ül1,ül2,ül3?");
            string vastus = Console.ReadLine().ToLower();
            while (true)
            {
                if (vastus == "ül1")
                {
                    funktsionid.ulesane1();
                }
                else if (vastus == "ül2")
                {
                    funktsionid.ulesane2();
                }
                else if (vastus == "ül3")
                {

                }
                else  
                {
                    Console.Write("Midagi läks valesti");
                    break;
                }
            
            
            
            
            }
            
        }
    }
}
