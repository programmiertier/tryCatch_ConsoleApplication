using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tryCatch_ConsoleApplication
{
    class A
    {
        public int zahl;
        public string kette;
        public int[] zahlen = new int[5];
    }

    class Program
    {
        static void Main(string[] args)
        {
            A abject = new A();

            WriteLine(abject.zahl);
            WriteLine(abject.kette);

        }
    }
}
