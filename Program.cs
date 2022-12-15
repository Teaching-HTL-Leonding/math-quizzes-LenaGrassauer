int number = 0;
int reverse = 0;

System.Console.Write("Please enter a number: ");
number = int.Parse(Console.ReadLine()!);

int außenrum = number;

if (number < 10)
{
    System.Console.WriteLine("Your number is a Palindrome");
}
else
{
    do
    {
        
    } while (number != 0);

    if (außenrum == reverse)
    {
        Console.WriteLine("Your number is a Palindrome");
    }
    else 
    {
        Console.WriteLine("Your number is not a Palindrome");
    }
}