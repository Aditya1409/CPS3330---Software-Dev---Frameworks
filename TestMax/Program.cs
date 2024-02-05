
namespace TestMax
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.Write("Enter the third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int ans1 = MaxLibrary.FindMax.max(num1, num2);
            int ans2 = MaxLibrary.FindMax.max(num1, num2, num3);


            Console.WriteLine("Testing with first two numbers. The max is " + ans1);
            Console.WriteLine("Testing with three numbers. The max is " + ans2);

        }
    }
}
