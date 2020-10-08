using System;

namespace First
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Egyszerű változók és változó típusok
            /*
             Változó típusok:
             - Integrált típusok (sbyte, byte, short, ushort, int, long, ulong, char)
             - Lebegőpontos típusok (float, double)
             - Decimális (szám) típusok
             - Logikai típusok (bool - igaz, hamish értékeket tárol)

             C#-ban a változók szintaxis-a:
             <adatt_típus> <változó_neve>;
             
             Lehetséges előre értéket adni a változóknak:
             <adatt_típus> <változó_neve> = <érték>;
             */

            //Példa:

            // Adatok
            short a;
            int  b; 
            double c;

            // Értékadás
            a = 5;
            b = 15;
            c = a + b;

            //Kiírás
            Console.WriteLine("a = {0}, b = {1}, c = {2:.00}",a,b,c);
            Console.ReadKey(); // Várakozás egy gomb lenyomására

            //Konzol törlése a szebb végeredményért
            Console.Clear();

            // C változó értékének növelése 0.0123 -el.
            c += 0.0123d;

            //Kiírás
            Console.WriteLine("a = {0}, b = {1}, c = {2:.00}", a, b, c);
            Console.ReadKey(); // Várakozás egy gomb lenyomására
            #endregion

            //Részek közötti törlés
            Console.Clear();

            #region Operátorok

            /*
             * Számítást végző operátorok:
             * + , - , * , / , % , ++ , --
             * 
             * Relációs operátorok:
             * == , != , > , < , >= , <= 
             * 
             * Logikai operátorok:
             * && , || , !
             * 
             * Bitenkénti operátorok:
             * & , | , ^ , ~ , << , >>
             * 
             * Feladatot végző / kijelölő operátorok:
             * = , += , -= , *= , /= , %= , stb...
             */

            #endregion

            //Részek közötti törlés
            Console.Clear();

            #region Elágazások és ciklusok

            int d = 5, e = 6;

            #region Ha elágazás
            if (d == e)
            {
                Console.WriteLine("d ({0}) értéke egyenlő az e ({1}) értékével!",d,e);
            }else if (d > e)
            {
                Console.WriteLine("d ({0}) értéke nagyobb mint az e ({1}) értéke!", d, e);
            }
            else
            {
                Console.WriteLine("d ({0}) értéke nem egyenlő az e ({1}) értékével!", d, e);
            }
            #endregion

            Console.ReadKey();
            Console.Clear();

            int f = 2;
            #region Switch
            switch (f)
            {
                case 0:
                case 1:
                case 2:
                    {
                        Console.WriteLine("f változó értéke: {0}", f);
                        break; 
                    }
                default:
                    {
                        Console.WriteLine("Az f változó értéke nem 0,1 vagy 2!");
                        break;
                    }
            }
            #endregion

            Console.ReadKey();
            Console.Clear();

            #region Ciklusok

            /*
             * A ciklusoknak több fajtája van.
             * 3 fő típust különböztetünk meg:
             * - Számlálós (for)
             * - Elöltesztelős (while)
             * - Hátultesztelős (do-while)
             * 
             * Ezen kívül vannak még ciklusok, de azok valamilyen módon ezeket az alapvetőket használják
             * ilyen például a foreach amit majd a tömböknél fogok bemutatni
             */

            #region Számlálós (for) ciklus
            for (int i = 0; i < 3; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            #endregion

            int g = 0;
            #region Elöltesztelős (while) ciklus
            while (g++ < 2)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            #endregion

            int h = 0;
            #region Hátultesztelős (while) ciklus
            do
            {
                h += 1;

                Console.Write("*");
            } while (h < 0);
            Console.WriteLine();
            #endregion

            #endregion

            #endregion
        }
    }
}
