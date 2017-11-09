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
            try
            {
                monat[0] = -1;
                for (int zaehl = 1; zaehl <= 15; zaehl++)
                {
                    if (zaehl > monat.Count() -1)
                    {
                        throw new Exception("Der Laufindex der for Schleife war zu groß");      // kann beliebige Exceptions erfinden
                    }
                    monat[zaehl] = zaehl;
                }
            }

            catch(NullReferenceException nre)
            {
                WriteLine("Da wurde wohl was vergessen: = new int[13];");
            }
            catch(IndexOutOfRangeException iore)       // speziell, immer vor allgemein!
            {
                WriteLine("Durch den IndexOutOfRange abgefangen");
                WriteLine(iore.ToString());
            }
            
        }
    }

    class Program
    {

        static public string sagtGerade()
        {
            return "gerade";
        }

        static public int sagZwei()
        {
            return 2;
        }



        public static void testen(Kalender k)
        {
            int zahl;
            Write("Bitte geben sie einen Monat ein:\t");
            if (int.TryParse(ReadLine(), out zahl))
            {
                try
                {
                    WriteLine(k.monat[zahl]);     // keine Meldung vom Compiler      // maximal 0 1 2 3 4, 5 nicht mehr enthalten
                }
                catch (IndexOutOfRangeException iore)       // speziell, immer vor allgemein!
                {
                    WriteLine("Durch den IndexOutOfRange abgefangen");
                    WriteLine(iore.ToString());
                }
                catch (Exception e)                 // muss immer zuletzt genannt werden, weil allgemein
                {
                    WriteLine("Im Kalenderkonstruktro ist etwas schief gegangen");
                    // WriteLine(e.ToString());
                    // WriteLine(e.Data);
                    WriteLine(e.GetType());
                    // WriteLine(e.GetType().BaseType);
                    WriteLine(e.Message);
                    WriteLine("Der Maximal Index darf {0} nicht übersteigen", k.monat.Count() - 1);       // -1! maximalIndex immer eins kleiner
                    WriteLine(e.Source);
                    // WriteLine(e.TargetSite);
                    WriteLine();
                }
            }
            else
            {
                WriteLine("Das ist keine Zahl");
            }
        }

        static void Main(string[] args)
        {
            A abject = new A();
            WriteLine(abject.zahl);
            WriteLine(abject.kette);

            // testen(abject);

            Kalender meineTermine = new Kalender();
            testen(meineTermine);
            ReadLine();
            /* int zahl = 2;

            if(zahl%2 == 0)
            {
                WriteLine("Zahl ist gerade");
            }
            else
            {
                WriteLine("Zahl ist ungerade");
            }   */

            ReadLine();
        }
    }
}
