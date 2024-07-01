// Program.cs 

using System; 

using System.Collections.Generic; 

using System.Linq; 

using System.Text; 

using System.Threading.Tasks; 

 

namespace Hlozek 

{ 

    class Program 

    { 

        static void Main(string[] args) 

        { 

            const int cenaZaMetr = 1670; 

 

            Console.WriteLine("Program pro vypocet ceny a velikosti pozemku (pole)"); 

            // Vytvoril Tobias Hlozek IT2A 

 

            ConsoleManager cislo = new ConsoleManager(); 

            Vypocty hodnota = new Vypocty(); 

 

                Console.Write("Zadej jednu stranu pole: "); 

                double a = cislo.Nacteni(); 

                Console.Write("Zadej druhou stranu pole: "); 

                double b = cislo.Nacteni(); 

 

                Console.WriteLine("Zadal jsi pole o velikosti {0}x{1} metru.", a, b); 

 

            Console.WriteLine("Tve pole ma obvod {0} metru a obsah {1} metru ctverecnich.", hodnota.obvodPole(a, b), hodnota.plochaPole(a, b)); 

            Console.WriteLine("Pri cene {0} za metr ctverecni ma tvoje pole hodnotu {1} Kc.", cenaZaMetr, hodnota.cenaPlochy(a, b, cenaZaMetr)); 

 

            Console.ReadKey(); 

        } 

    } 

} 

 

// ConsoleManager.cs 

 

using System; 

using System.Collections.Generic; 

using System.Linq; 

using System.Text; 

using System.Threading.Tasks; 

 

namespace Hlozek 

{ 

    class ConsoleManager 

    { 

        public double Nacteni() 

        { 

            return double.Parse(Console.ReadLine()); 

        } 

    } 

} 

 

// Vypocty.cs 

 

using System; 

using System.Collections.Generic; 

using System.Linq; 

using System.Text; 

using System.Threading.Tasks; 

 

namespace Hlozek 

{ 

    class Vypocty 

    { 

        public double obvodPole(double a, double b) 

        { 

            return a + a + b + b; 

        } 

 

        public double plochaPole(double a, double b) 

        { 

            return a * b; 

        } 

 

        public double cenaPlochy(double a, double b, int cenaZaMetr) 

        { 

            return (a * b) * cenaZaMetr; 

        } 

    } 

} 

 

 
