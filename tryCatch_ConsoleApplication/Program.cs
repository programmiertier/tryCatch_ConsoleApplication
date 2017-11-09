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
            try
            {
                WriteLine(abject.zahlen[5]);     // keine Meldung vom Compiler      // maximal 0 1 2 3 4, 5 nicht mehr enthalten
            }
            catch (Exception e)
            {
                WriteLine("Es ist etwas schief gegangen");
                // WriteLine(e.ToString());
                // WriteLine(e.Data);
                // WriteLine(e.GetType());
                // WriteLine(e.GetType().BaseType);
                // WriteLine(e.Message);
                WriteLine("Der Maximal Index darf {0} nicht übersteigen", abject.zahlen.Count() - 1);       // -1! maximalIndex immer eins kleiner
            }

            ReadLine();
        }
    }
}
