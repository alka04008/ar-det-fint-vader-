// See https://aka.ms/new-console-template for more information
Console.Write("Är det fint väder?");
string strNr = Console.ReadLine();
if (strNr == "j" || strNr == "J")
    Console.WriteLine("Vi går på picknick!");
else if (strNr == "n" || strNr =="N")
    Console.WriteLine("Vi stannar inne och läser en bok!");
else
    Console.WriteLine("Jag förstår inte -__-");