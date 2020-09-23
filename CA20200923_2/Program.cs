using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA20200923_2
{
    enum Dolgok
    {
        cica = 0,
        kutya = 1,
        kacsacsőrűemlős = 2,
    }

    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ReadKey();
        }

        static void F001()
        {
            int x = 2;
            switch (x)
            {
                case 1:
                    Console.WriteLine("ez egy");
                    break;
                case 2:
                    {
                        Console.WriteLine("ez kettő");
                        Console.WriteLine("lehet több");
                        Console.WriteLine("sor kód is");
                    }
                    break;
                case 6:
                case 7:
                    Console.WriteLine(
                        "vagy 6 vagy 7 " +
                        "nem kell minden lehetséges ágat feltétlen lekezelni");
                    break;
                case 5:
                    Console.WriteLine("nem kell sorba lenniük");
                    break;
                case 10: Console.WriteLine("mehet minden 1 sorba is"); break;
                default:
                    Console.WriteLine(
                        "ez pedig akkor fut le, ha egyik case sem megfelelő" +
                        "default ágat nem kötelező írni" +
                        "ha nincs, és nem jó egyik case sem," +
                        "akkor egyszerűen nem fut le egyik sem");
                    break;
            }
        }
        static void F002()
        {
            var c = Console.ReadKey(true).KeyChar;

            switch (c)
            {
                case 'a':
                    Console.WriteLine("ez egy 'a' betű");
                    break;
                case 'b':
                    Console.WriteLine("ez egy 'b' betű");
                    break;
                case 's':
                    Console.WriteLine("ez egy 's' betű");
                    break;
                case 'd':
                    Console.WriteLine("ez egy 'd' betű");
                    break;
                default:
                    Console.WriteLine("ez meg valami olyan, amire nem írtam case-t");
                    break;
            }

        }
        static string F003(int x, int y)
        {
            switch (x - y)
            {
                case 0: return "nulla";
                default: return "nem nulla";
            }
        }
        static void F004()
        {
            Dolgok d = (Dolgok)rnd.Next(3);
            switch (d)
            {
                case Dolgok.cica:
                    break;
                case Dolgok.kutya:
                    break;
                case Dolgok.kacsacsőrűemlős:
                    break;
                default:
                    break;
            }
        }
    }
}
