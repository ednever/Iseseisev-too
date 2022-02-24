using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iseseisev_too
{
    public class Funktsioonid
    {
        public static int[] Arvud_Massiiviisse(int n)
        {
            Random rnd = new Random();
            int[] arvud = new int[n];
            for (int i = 0; i < n; i++)
            {
                arvud[i] = rnd.Next(1, 100);
            }
            return arvud;
        }
    }
}
