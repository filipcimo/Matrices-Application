using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opakovani_2.rocniku
{
    class Program
    {
        public static void printArr(int[] pole)
        {
            for (int i = 0; i < pole.Length; i++)
            {
                Console.Write(pole[i] + " ");
            }
            Console.WriteLine('\n');
        }


        public static void printArr(int[,] pole)
        {
            for (int i = 0; i <= pole.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= pole.GetUpperBound(1); k++)
                {
                    Console.Write(pole[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public static void nacti_cisla(int[] pole)
        {
            Random rn = new Random();
            for (int i = 0; i < pole.Length; i++)
            {
                pole[i] = rn.Next(0, 10);
            }
        }


        public static void nacti_cisla(int[,] pole)
        {
            Random rn = new Random();

            for (int i = 0; i <= pole.GetUpperBound(0); i++)
            {
                for (int k = 0; k <= pole.GetUpperBound(1); k++)
                {
                    pole[i, k] = rn.Next(0, 10);
                }
            }
        }


        public static void secteni_matic()
        {
            int[,] pole = null;
            int[,] pole2 = null;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Pocet radku - matice 1: ");
            Console.ForegroundColor = ConsoleColor.White;
            int radku = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet sloupcu - matice 1: ");
            Console.ForegroundColor = ConsoleColor.White;
            int sloupcu = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet radku - matice 2: ");
            Console.ForegroundColor = ConsoleColor.White;
            int radku2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet sloupcu - matice 2: ");
            Console.ForegroundColor = ConsoleColor.White;
            int sloupcu2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (radku != radku2)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine();
                Console.WriteLine("Pocet radku prvni matice se musi rovnat poctu radku druhe matice!");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            else if (sloupcu != sloupcu2)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine();
                Console.WriteLine("Pocet sloupcu prvni matice se musi rovnat poctu sloupcu druhe matice!");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            pole = new int[radku, sloupcu];
            pole2 = new int[radku, sloupcu];

            nacti_cisla(pole);
            nacti_cisla(pole2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Matice 1:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Matice 2:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole2);

            for (int i = 0; i < radku; i++)
            {
                for (int k = 0; k < sloupcu; k++)
                {
                    pole[i, k] += pole2[i, k];
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vysledna matice:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole);
            Console.WriteLine();
        }


        public static void odecteni_matic()
        {
            int[,] pole = null;
            int[,] pole2 = null;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Pocet radku - matice 1: ");
            Console.ForegroundColor = ConsoleColor.White;
            int radku = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet sloupcu - matice 1: ");
            Console.ForegroundColor = ConsoleColor.White;
            int sloupcu = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet radku - matice 2: ");
            Console.ForegroundColor = ConsoleColor.White;
            int radku2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet sloupcu - matice 2: ");
            Console.ForegroundColor = ConsoleColor.White;
            int sloupcu2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            if (radku != radku2)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine();
                Console.WriteLine("Pocet radku prvni matice se musi rovnat poctu radku druhe matice!");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            else if (sloupcu != sloupcu2)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine();
                Console.WriteLine("Pocet sloupcu prvni matice se musi rovnat poctu sloupcu druhe matice!");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                return;
            }

            pole = new int[radku, sloupcu];
            pole2 = new int[radku, sloupcu];

            nacti_cisla(pole);
            nacti_cisla(pole2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Matice 1:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Matice 2:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole2);


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Jak si prejete matice odecist ? (A-B nebo B-A)");
            Console.ForegroundColor = ConsoleColor.White;
            string jakOdecist = Console.ReadLine();

            if (compstr(jakOdecist, "A-B") || compstr(jakOdecist, "A - B") || compstr(jakOdecist, "a-b") || compstr(jakOdecist, "a - b"))
            {
                for (int i = 0; i < radku; i++)
                {
                    for (int k = 0; k < sloupcu; k++)
                    {
                        pole[i, k] -= pole2[i, k];
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vysledna matice:");
                Console.ForegroundColor = ConsoleColor.White;
                printArr(pole);
                Console.WriteLine();
            }

            else if (compstr(jakOdecist, "B-A") || compstr(jakOdecist, "B - A") || compstr(jakOdecist, "b-a") || compstr(jakOdecist, "b - a"))
            {
                for (int i = 0; i < radku; i++)
                {
                    for (int k = 0; k < sloupcu; k++)
                    {
                        pole2[i, k] -= pole[i, k];
                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vysledna matice:");
                Console.ForegroundColor = ConsoleColor.White;
                printArr(pole2);
                Console.WriteLine();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine();
                Console.WriteLine("Tyto matice se nedaji odecist!");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.White;
                return;
            }
        }


        public static void transpozice_matic()
        {
            int[,] pole = null;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Pocet radku: ");
            Console.ForegroundColor = ConsoleColor.White;
            int radku = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet sloupcu: ");
            Console.ForegroundColor = ConsoleColor.White;
            int sloupcu = int.Parse(Console.ReadLine());


            pole = new int[radku, sloupcu];
            int[,] pole2 = new int[sloupcu, radku];

            nacti_cisla(pole);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Matice:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole);

            for (int i = 0; i < radku; i++)
            {
                for (int k = 0; k < sloupcu; k++)
                {
                    pole2[k, i] = pole[i, k];
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vysledna matice:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole2);
            Console.WriteLine();
        }


        public static void nasobeni_cislem()
        {
            int[,] pole = null;


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Pocet radku: ");
            Console.ForegroundColor = ConsoleColor.White;
            int radku = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet sloupcu: ");
            Console.ForegroundColor = ConsoleColor.White;
            int sloupcu = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Cislo: ");
            Console.ForegroundColor = ConsoleColor.White;
            int num = int.Parse(Console.ReadLine());

            pole = new int[radku, sloupcu];

            nacti_cisla(pole);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Matice:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole);

            for (int i = 0; i < radku; i++)
            {
                for (int k = 0; k < sloupcu; k++)
                {
                    pole[i, k] *= num;
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Vysledna matice:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole);
            Console.WriteLine();
        }


        public static void nasobeni_matic()
        {
            int[,] pole = null;
            int[,] pole2 = null;


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("Pocet radku - matice 1: ");
            Console.ForegroundColor = ConsoleColor.White;
            int radku = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet sloupcu - matice 1: ");
            Console.ForegroundColor = ConsoleColor.White;
            int sloupcu = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet radku - matice 2: ");
            Console.ForegroundColor = ConsoleColor.White;
            int radku2 = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("Pocet sloupcu - matice 2: ");
            Console.ForegroundColor = ConsoleColor.White;
            int sloupcu2 = int.Parse(Console.ReadLine());

            if (sloupcu > sloupcu2)
            {
                if (radku2 != sloupcu)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine();
                    Console.WriteLine("Pocet slopucu prvni matice se musi rovnat poctu radku druhe matice!");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }

            else if (sloupcu < sloupcu2)
            {
                if (radku != sloupcu2)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine();
                    Console.WriteLine("Pocet slopucu prvni matice se musi rovnat poctu radku druhe matice!");
                    Console.WriteLine();

                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
            }

            pole = new int[radku, sloupcu];
            pole2 = new int[radku2, sloupcu2];

            nacti_cisla(pole);
            nacti_cisla(pole2);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Matice 1:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole);

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Matice 2:");
            Console.ForegroundColor = ConsoleColor.White;
            printArr(pole2);

            if ((sloupcu2 < sloupcu || sloupcu == sloupcu2) && radku == radku2)
            {
                int[,] vys = new int[radku2, sloupcu2];
                int vr = 0;
                int vs = 0;

                int citac = 0;

                for (int i = 0; i < radku2; i++)
                {
                    for (int k = 0; k < sloupcu2; k++)
                    {
                        for (int x = 0; x < sloupcu; x++)
                        {
                            vys[i, k] += (pole[i, citac] * pole2[vr, vs]);
                            citac += 1;
                            vr += 1;
                        }

                        citac = 0;
                        vr = 0;
                        vs += 1;
                    }

                    vr = 0;
                    vs = 0;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vysledna matice:");
                Console.ForegroundColor = ConsoleColor.White;
                printArr(vys);
                Console.WriteLine();
            }

            else if (sloupcu2 > sloupcu && radku == radku2)
            {
                int[,] vys = new int[radku, sloupcu];
                int vr = 0;
                int vs = 0;

                int citac = 0;

                for (int i = 0; i < radku; i++)
                {
                    for (int k = 0; k < sloupcu; k++)
                    {
                        for (int x = 0; x < sloupcu2; x++)
                        {
                            vys[i, k] += (pole2[i, citac] * pole[vr, vs]);
                            vr += 1;
                            citac += 1;
                        }

                        citac = 0;
                        vr = 0;
                        vs += 1;
                    }

                    vr = 0;
                    vs = 0;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vysledna matice:");
                Console.ForegroundColor = ConsoleColor.White;
                printArr(vys);
                Console.WriteLine();
            }


            else if (radku > radku2 && sloupcu < sloupcu2)
            {
                int[,] vys = new int[radku, sloupcu2];

                int vr = 0;
                int vs = 0;

                int citac = 0;

                for (int i = 0; i < radku; i++)
                {
                    for (int k = 0; k < sloupcu2; k++)
                    {
                        for (int x = 0; x < sloupcu; x++)
                        {
                            vys[i, k] += (pole[i, citac] * pole2[vr, vs]);
                            vr += 1;
                            citac += 1;
                        }

                        citac = 0;
                        vr = 0;
                        vs += 1;
                    }

                    vr = 0;
                    vs = 0;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vysledna matice:");
                Console.ForegroundColor = ConsoleColor.White;
                printArr(vys);
                Console.WriteLine();
            }

            else if (radku < radku2 && sloupcu > sloupcu2)
            {
                int[,] vys = new int[radku, sloupcu2];

                int vr = 0;
                int vs = 0;

                int citac = 0;

                for (int i = 0; i < radku; i++)
                {
                    for (int k = 0; k < sloupcu2; k++)
                    {
                        for (int x = 0; x < sloupcu; x++)
                        {
                            vys[i, k] += (pole[i, citac] * pole2[vr, vs]);
                            vr += 1;
                            citac += 1;
                        }

                        citac = 0;
                        vr = 0;
                        vs += 1;
                    }

                    vr = 0;
                    vs = 0;
                }

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Vysledna matice:");
                Console.ForegroundColor = ConsoleColor.White;
                printArr(vys);
                Console.WriteLine();
            }

        }


        public static bool menu()
        {
            bool run = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Menu:");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1.) Scitani matic");
            Console.WriteLine("2.) Odecitani matic");
            Console.WriteLine("3.) Nasobeni matic cislem");
            Console.WriteLine("4.) Nasobeni matic");
            Console.WriteLine("5.) Transpozice matic");
            Console.WriteLine("6.) Odejit");
            string s = Console.ReadLine();

            if (s[0] - '0' == 1 || compstr(s, "Scitani"))
            {
                secteni_matic();
                run = true;
            }

            else if (s[0] - '0' == 2 || compstr(s, "Odcitani"))
            {
                odecteni_matic();
                run = true;
            }

            else if (s[0] - '0' == 3 || compstr(s, "Nasobeni s cislem"))
            {
                nasobeni_cislem();
                run = true;
            }

            else if (s[0] - '0' == 4 || compstr(s, "Nasobeni"))
            {
                nasobeni_matic();
                run = true;
            }

            else if (s[0] - '0' == 5 || compstr(s, "Otoceni"))
            {
                transpozice_matic();
                run = true;
            }

            else if (s[0] - '0' == 6 || compstr(s, "Odejit"))
            {
                run = false;
            }

            else
            {
                Console.WriteLine('\n');
                menu();
            }

            return run;
        }

        public static bool compstr(string s, string s2)
        {
            s.ToLower();
            s2.ToLower();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] != s2[i]) { return false; }
            }

            return true;
        }

        static void Main(string[] args)
        {
            while (true)
            {
                bool run = menu();
                if (run == true) { continue; }
                else if (run == false) { break; }
            }
        }
    }
}
