// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using System.Runtime.InteropServices;
using Class2;

try
{
    while (true)
    {
        Console.Write("Enter your age: ");
        var a = Console.ReadLine();
        if (string.IsNullOrEmpty(a))
            break;

        bool isInteger = int.TryParse(a, out var value);
        if (!isInteger)
            continue;
        else
        {
            if (value > 40)
            {
                System.Console.WriteLine("old age");
            }
            else
            {
                Console.WriteLine("welcome, young man");
            }

        }

    }


}
catch (Exception e)
{

    System.Console.WriteLine(e.Message);
}



// Console.WriteLine("Hello, World!  " + aa + "  : " + bb + " " + cc + " " + dd + " " + ee + " " + ff + " " + gg);
Class1 class1 = new() { Name = "as" };
class1.Ace01();
Console.WriteLine(class1.Test01(1, 2));