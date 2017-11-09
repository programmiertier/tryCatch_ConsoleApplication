using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace tryCatch_ConsoleApplication
{
    public class A
    {
        public int zahl;
        public string kette;
        public int[] zahlen = new int[5];
    }

    public class Kalender
    {
        public int[] monat = new int[13];
        public Kalender()
        {
            monat[0] = -1;
            for (int zaehl = 1; zaehl <= 12; zaehl++)
            {
                monat[zaehl] = zaehl;
            }
        }
    }

    class Program
    {
        
        public static void testen(Kalender k)
        {
            int zahl;
            Write("Bitte geben sie einen Monat ein:\t");
            int.TryParse(ReadLine(), out zahl);
            try
            {
                WriteLine(k.monat[zahl]);     // keine Meldung vom Compiler      // maximal 0 1 2 3 4, 5 nicht mehr enthalten
            }
            catch (Exception e)
            {
                WriteLine("Es ist etwas schief gegangen");
                // WriteLine(e.ToString());
                // WriteLine(e.Data);
                WriteLine(e.GetType());
                // WriteLine(e.GetType().BaseType);
                WriteLine(e.Message);
                WriteLine("Der Maximal Index darf {0} nicht übersteigen", k.monat.Count() - 1);       // -1! maximalIndex immer eins kleiner
                WriteLine(e.Source);
                WriteLine(e.TargetSite);
                WriteLine();
            }
        }

        static void Main(string[] args)
        {
            A abject = new A();
            WriteLine(abject.zahl);
            WriteLine(abject.kette);

            // testen(abject);

            Kalender meinerTermine = new Kalender();

            testen(meinerTermine);

            ReadLine();
        }
    }
}
