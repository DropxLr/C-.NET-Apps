Console.Title = "IfElse";

Console.Write("Please Enter A Number: ");
double num = Convert.ToDouble(Console.ReadLine());

Console.Write("Thanks, Now A Letter: ");
char letter = Convert.ToChar(Console.ReadLine());

if (num >= 6)
{
    Console.WriteLine("\nNumber Exceeds 6");

    if (letter == 'C')
    {
        Console.WriteLine("Letter is C");
    }
}

else
{
    Console.WriteLine("\nNumber is 5 or Less");
}
Console.ReadKey();