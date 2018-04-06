using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Berezina_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n----------");
            StringBuilder[] sbarray_1 = new StringBuilder[2];
            sbarray_1[0] = new StringBuilder("Neva");
            sbarray_1[1] = new StringBuilder("Lena");
            StringBuilder[] sbarray_2 = (StringBuilder[])sbarray_1.Clone();
            sbarray_2[1][0] = 'C';
            Console.WriteLine(sbarray_1[0] + " " + sbarray_1[1]);
            Console.WriteLine(sbarray_2[0] + " " + sbarray_2[1]);
            //////////////////////////////////////////////////////
            Console.WriteLine("\n----------");
            StringBuilder[] sbarray1 = new StringBuilder[2];
            sbarray_1[0] = new StringBuilder("Neva");
            sbarray_1[1] = new StringBuilder("Lena");
            StringBuilder[] sbarray2 = (StringBuilder[])sbarray1.Clone();
            sbarray2[1][0] = 'C';
            Console.WriteLine(sbarray1[0] + " " + sbarray1[1]);
            Console.WriteLine(sbarray2[0] + " " + sbarray2[1]);
        }
    }
}
