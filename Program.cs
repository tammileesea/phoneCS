using System;

namespace Phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Galaxy s8 = new Galaxy("s8", 100, "T-Mobile", "Boo Ba Boo Ba");
            Nokia elevHundred = new Nokia("1100", 60, "Metro PCS", "Ring ring riiiiiing");
            s8.DisplayInfo();
        }
    }
}
