using System;
using System.Diagnostics.SymbolStore;

namespace math_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MATEMATIIKKAPELI");

            Console.WriteLine("Yritä laskea seuraavat yhteen- ja vähennyslaskut mahdollisimman nopeasti.");
            Console.WriteLine("Mitä nopeammin vastaat oikein, sitä paremmat pisteet saat.");

            Console.WriteLine("\nPaina mitä tahansa painiketta jatkaaksesi");

            Console.ReadLine();

            bool jatketaanko = true;

            int pisteet = 0;

            do
            {
                Random myRandom = new Random();

                int yhteenVaiVahennys = myRandom.Next(1, 3);

                int luku1 = myRandom.Next(1, 1000);
                int luku2 = myRandom.Next(1, 1000);

                int oikeaVastaus = 0;

                string syote = "";

                int vertailuLuku = 1;

                if (yhteenVaiVahennys == 1)
                {
                    oikeaVastaus = luku1 + luku2;

                    Console.Clear();
                    Console.WriteLine("{0} + {1}", luku1, luku2);
                    syote = Console.ReadLine();

                    if (!int.TryParse(syote, out vertailuLuku))
                    {
                        Console.Clear();
                        Console.WriteLine("Peli päättyi syöttövirheeseen!");
                        jatketaanko = false;
                    }

                    else if (int.Parse(syote) != oikeaVastaus)
                    {
                        Console.Clear();
                        Console.WriteLine("Vastasit väärin!");
                        jatketaanko = false;
                    }

                    else if (int.Parse(syote) == oikeaVastaus)
                    {
                        pisteet++;
                        Console.WriteLine("\nVastasit oikein!");
                        Console.WriteLine("Jatketaanko? (K/k)");

                        syote = Console.ReadLine();

                        if (syote == "k" || syote == "K")
                        {
                            jatketaanko = true;
                        }

                        else
                        {
                            jatketaanko = false;
                            Console.Clear();
                        }
                    }
                }

                else
                {
                    oikeaVastaus = luku1 - luku2;

                    Console.Clear();
                    Console.WriteLine("{0} - {1}", luku1, luku2);
                    syote = Console.ReadLine();

                    if (!int.TryParse(syote, out vertailuLuku))
                    {
                        Console.Clear();
                        Console.WriteLine("Peli päättyi syöttövirheeseen!");
                        jatketaanko = false;
                    }

                    else if(int.Parse(syote) != oikeaVastaus)
                    {
                        Console.Clear();
                        Console.WriteLine("Vastasit väärin!");
                        jatketaanko = false;
                    }

                    else if (int.Parse(syote) == oikeaVastaus)
                    {
                        pisteet++;
                        Console.WriteLine("\nVastasit oikein!");
                        Console.WriteLine("Jatketaanko? (K/k)");

                        syote = Console.ReadLine();

                        if (syote == "k" || syote == "K")
                        {
                            jatketaanko = true;
                        }

                        else
                        {
                            jatketaanko = false;
                            Console.Clear();
                        }
                    }
                }

            } while (jatketaanko);

            Console.WriteLine("Sait {0} pistettä", pisteet);
        }
    }
}