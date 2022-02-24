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
            //double protsent = (Convert.ToDouble(counter) / Convert.ToDouble(line.Length)) * 100;
            //Console.WriteLine($"Esinemisprotsent sümboli {symbol} on {Math.Round(protsent,2)}%");

            //2 ülesanne
            //int[,] tabel = new int[10, 10];
            //int max = tabel[0, 0];
            //Random rnd = new Random();
            //for (int i = 0; i < tabel.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tabel.GetLength(0); j++)
            //    {
            //        tabel[i, j] = rnd.Next(1,5);
            //        Console.Write(tabel[i, j] + "  ");
            //        if (i == j)
            //        {
            //            if (max < tabel[i, j])
            //            {
            //                max = tabel[i, j];
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}            
            //Console.WriteLine("Elementide summa ridades:");
            //for (int y = 0; y < tabel.GetLength(0); y++)
            //{
            //    int summa = 0;
            //    for (int x = 0; x < tabel.GetLength(0); x++)
            //        summa += tabel[y, x];
            //    Console.Write(y + 1 + " >>> " + summa + ", ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Elementide korrutis veergudes:");
            //for (int x = 0; x < tabel.GetLength(0); x++)
            //{
            //    int korrutis = 1;
            //    for (int y = 0; y < tabel.GetLength(0); y++)
            //        korrutis *= tabel[y, x];
            //    Console.Write(x + 1 + " >>> " + korrutis + ", ");
            //}
            //Console.WriteLine();
            //Console.WriteLine("Maksimaalene element pea diagonaalis >>> " + max);


            //3 ülesanne (pole lõpuni tehtud)
            Console.WriteLine("Kui palju hinne perioodis?");
            int a = int.Parse(Console.ReadLine());
            int[] M = new int[a];
            int summa = 0;
            for (int i = 0; i < M.Length; i++)
            {
                M[i] = int.Parse(Console.ReadLine());
            }
            foreach (int number in M)
            {
                summa += number;
            }
            if (summa / M.Length >= 4)
            {
                Console.WriteLine("stipendium");
            }
            else
            {
                Console.WriteLine("mitte");
            }

            Console.ReadLine();
        }
    }
}
