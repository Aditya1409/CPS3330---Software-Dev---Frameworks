namespace Lab2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int num3 = int.Parse(Console.ReadLine());

        if (num1 > num2 && num1 > num3)
        {
            Console.WriteLine("The max is " + num1);
        }
        else if (num2 > num1 && num2 > num3)
        {
            Console.WriteLine("The max is " + num2);
        }
        else
        {
            Console.WriteLine("The max is " + num3);
        }
    }
}
