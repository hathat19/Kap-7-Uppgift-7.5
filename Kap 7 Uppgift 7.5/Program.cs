using System;
using System.Collections.Generic;
namespace Uppgift7_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> månadslöner = new List<int>();

            Console.WriteLine("Lägg till månadslöner. Skriver du \"0\" kommer programmet att gå vidare.");
            
            while (true)
            {
                int currentMånadslön = ReadInt();
                if (currentMånadslön == 0)
                {
                    break;
                }
                else
                {
                    månadslöner.Add(currentMånadslön);
                }
            }

            månadslöner.Sort();

            int sum = 0;
            double average = 0;
            double median = 0;
            //Medelvärde
            foreach (int månadslön in månadslöner)
            {
                sum += månadslön;
            }
            average = (double)sum / (månadslöner.Count());

            //Median
            if (månadslöner.Count() % 2 == 1)
            {
                median = månadslöner[månadslöner.Count()/2];
            }
            else
            {
                median = månadslöner[månadslöner.Count() / 2 - 1];
                median += månadslöner[månadslöner.Count() / 2];
                median /= 2;
            }

            //Utskrift
            Console.WriteLine("Medelvärdet: " + average);
            Console.WriteLine("Medianen: " + median);
        }
        static int ReadInt()
        {
            int integer;
            Console.WriteLine("Skriv in din månadslön:");
            while (int.TryParse(Console.ReadLine(), out integer) == false)
            {
                Console.WriteLine("Du skrev inte in ett heltal. Försök igen.");
            }
            return integer;
        }
    }
}

/*Uppgift 5
Skapa ett konsolprogram där användaren ska få skriva in sina senaste månadslöner.
Användaren ska inte behöva ange hur många månadslöner som ska skrivas in när
programmet börjar. Användaren ska fortsätta att skriva in månadslöner till hen
skriver in lönen 0, talet 0 avslutar endast inmatningen och ska inte räknas som en
månadslön. Beräkna och skriv ut användarens medel- och medianlön.*/