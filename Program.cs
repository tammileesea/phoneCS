using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Boo Ba Boo Ba");
            Nokia elevHundred = new Nokia("1100", 60, "Metro PCS", "Ring ring riiiiiing");
            System.Console.WriteLine("");
            s8.DisplayInfo();
            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
            System.Console.WriteLine("");

            elevHundred.DisplayInfo();
            System.Console.WriteLine(elevHundred.Ring());
            System.Console.WriteLine(elevHundred.Unlock());
            System.Console.WriteLine("");

        }
    }
}
