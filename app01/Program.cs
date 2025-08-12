// See https://aka.ms/new-console-template for more information
using System.Data.Common;
using Class2;

try
{
    var a = "true";
    Console.WriteLine(Convert.ToBoolean(a));
    var b = 1;
    var c = ++b;
    System.Console.WriteLine(" b= " + b + " c= " +c);
    
}
catch (Exception e)
{

    System.Console.WriteLine(e.Message);
}



// Console.WriteLine("Hello, World!  " + aa + "  : " + bb + " " + cc + " " + dd + " " + ee + " " + ff + " " + gg);
Class1 class1 = new() { Name = "as" };
class1.Ace01();