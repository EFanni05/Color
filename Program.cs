using System;

namespace Color8
{
    internal class Program
    {
        static void PrintColor(Color c)
        {
            Console.WriteLine($"({c.R()},{c.G()},{c.B()})");
        }
        static void Main(string[] args)
        {
            try
            {
                // RGBColor teszt: konstruktor
                Console.WriteLine();
                Console.WriteLine("RGBColor teszt: konstruktor");
                Color c1 = new RGBColor(123, 54, 65);

                // RGBColor teszt: R, G, B függvények
                Console.WriteLine();
                Console.WriteLine("RGBColor teszt: R, G, B");
                Color c2 = new RGBColor(29, 124, 243);
                PrintColor(c2); // (29,124,243)
                c2 = new RGBColor();
                PrintColor(c2); // (0,0,0)

                // BlackOrWhite teszt: R, G, B függvények
                Console.WriteLine();
                Console.WriteLine("BlackOrWhite teszt: R, G, B");
                Color c3 = new BlackOrWhite(true);
                PrintColor(c3); // (0,0,0)
                c3 = new BlackOrWhite(false);
                PrintColor(c3); // (255,255,255)

                // GrayScale teszt: R, G, B függvények
                Console.WriteLine();
                Console.WriteLine("GrayScale teszt: R, G, B");
                Color c4 = new GrayScale(0);
                PrintColor(c4); // (0,0,0)
                c4 = new GrayScale(1);
                PrintColor(c4); // (255,255,255)
                c4 = new GrayScale(0.5);
                PrintColor(c4); // (127,127,127) vagy (128,128,128) a módszertől függően
                c4 = new GrayScale(0.8);
                PrintColor(c4); // (204,204,204)

                // Color teszt: NumberToHex, HexToNumber függvények
                Console.WriteLine();
                Console.WriteLine("Color teszt: NumberToHex, HexToNumber");
                Console.WriteLine(Color.NumberToHex(0)); // 0
                Console.WriteLine(Color.NumberToHex(5)); // 5
                Console.WriteLine(Color.NumberToHex(9)); // 9
                Console.WriteLine(Color.NumberToHex(10)); // A
                Console.WriteLine(Color.NumberToHex(12)); // C
                Console.WriteLine(Color.NumberToHex(15)); // F
                Console.WriteLine(Color.HexToNumber('0')); // 0
                Console.WriteLine(Color.HexToNumber('3')); // 3
                Console.WriteLine(Color.HexToNumber('9')); // 9
                Console.WriteLine(Color.HexToNumber('A')); // 10
                Console.WriteLine(Color.HexToNumber('E')); // 14
                Console.WriteLine(Color.HexToNumber('F')); // 15

                // Color teszt: ToString
                Console.WriteLine();
                Console.WriteLine("Color teszt: ToString");
                Color c5 = new RGBColor(120, 65, 234);
                Console.WriteLine(c5); // #7841EA
                c5 = new RGBColor(6, 54, 15);
                Console.WriteLine(c5); // #06360F
                c5 = new RGBColor(212, 200, 253);
                Console.WriteLine(c5); // #D4C8FD
                c5 = new RGBColor(128, 96, 177);
                Console.WriteLine(c5);  // #8060B1
                c5 = new BlackOrWhite(false);
                Console.WriteLine(c5); // #FFFFFF
                c5 = new GrayScale(0.4);
                Console.WriteLine(c5); // #666666

                // TextColor teszt: R, G, B függvények
                Console.WriteLine();
                Console.WriteLine("TextColor teszt: R, G, B");
                Color c6 = new TextColor("red");
                PrintColor(c6); // (255,0,0)
                c6 = new TextColor("yellow");
                PrintColor(c6); // (255,255,0)
                c6 = new TextColor("blue");
                PrintColor(c6); // (0,0,255)
                //c6 = new TextColor("notfound"); different way of event handeling
                //realisticly i put this in try + while
                PrintColor(c6); // (0,0,0)

                // TextColor teszt: hexa konstruktor
                Console.WriteLine();
                Console.WriteLine("TextColor teszt: hexa konstruktor");
                Color c7 = new TextColor("#E4CB27");
                PrintColor(c7); // (228,203,39)
                c7 = new TextColor("#D4C8FD");
                PrintColor(c7); // (212,200,253)
                c7 = new TextColor("#FF00FF");
                PrintColor(c7); // (255,0,255)

                // TextColor teszt: ToString
                Console.WriteLine();
                Console.WriteLine("TextColor teszt: ToString");
                Color c8 = new TextColor("#666666");
                Console.WriteLine(c8); // #666666
                c8 = new TextColor("magenta");
                Console.WriteLine(c8); // magenta
                //c8 = new TextColor("not found, gonna be black"); different way of event handeling
                //realisticly i put this in try + while
                Console.WriteLine(c8); // black

                // Color teszt: egyezoseg
                Console.WriteLine();
                Console.WriteLine("Color teszt: egyezoseg");
                Color c9 = new RGBColor(212, 200, 253);
                Color c10 = new GrayScale(1);
                Color c11 = new TextColor("#D4C8FD");
                Color c12 = new TextColor("white");
                PrintColor(c9); // (212,200,253)
                PrintColor(c10); // (255,255,255)
                PrintColor(c11); // (212,200,253)
                PrintColor(c12); // (255,255,255)
                Console.WriteLine(c9.Equals(c10)); // False
                Console.WriteLine(c10.Equals(c12)); // True
                Console.WriteLine(c12.Equals(c11)); // False
                Console.WriteLine(c11.Equals(c9)); // True

                // RGBColor teszt: masik szinbol
                Console.WriteLine();
                Console.WriteLine("RGBColor teszt: masik szinbol");
                Color c13 = new TextColor("#E4CB27");
                PrintColor(c13); // (228,203,39)
                Color c14 = new RGBColor(c13);
                PrintColor(c14); // (228,203,39)
                c13 = new GrayScale(0.3);
                PrintColor(c13); // (76,76,76)
                c14 = new RGBColor(c13);
                PrintColor(c14); // (76,76,76)
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }
        }
    }
}
