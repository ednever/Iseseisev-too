using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Iseseisev_too
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variant 1
            //1 ülesanne
            //Console.WriteLine("Kirjutage midagi");
            //string line = Console.ReadLine();
            //Console.WriteLine("Kirjutage sümbol mis loeb etteantud märgi esinemisprotsenti stringis");
            //char symbol = Console.ReadKey().KeyChar;
            //Console.WriteLine();
            //char[] tahed = line.ToCharArray();
            //int counter = 0;
            //for (int i = 0; i < line.Length; i++)
            //{
            //    if (tahed[i] == symbol)
            //    {
            //        counter++;
            //    }
            //}
            //double pikkusDouble = Convert.ToDouble(line.Length);
            //double counterDouble = Convert.ToDouble(counter);
            //double protsent = (counterDouble / pikkusDouble) * 100;
            //Console.WriteLine($"Esinemisprotsent sümboli {symbol} on {protsent}%");

            //2 ülesanne
            Random rnd = new Random();
            List<int> tabel = new List<int>();
            for (int stroka = 1; stroka < 11; stroka++)
            {
                for (int rjad = 1; rjad < 11; rjad++)
                {
                    int a = rnd.Next(1, 100);
                    tabel.Add(a);
                    Console.Write($"{a,4}");
                }
                Console.WriteLine();
            }
            foreach (int number in tabel)
            {
                Console.Write(number + " ");
            }



            //3 ülesanne
            //string[] markid = new string[5];
            //string[,] arr2d = new string[3, 1] { { "Name-surname" }, { "Grupp" }, { markid } };

            Console.ReadLine();
        }
    }
}
