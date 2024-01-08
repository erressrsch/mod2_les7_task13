namespace mod2_les7_task11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the operation number to be performed: ");
            Console.WriteLine(
                """
                1.Addition
                2.Subtraction
                3.Multiplication
                4.Division
                """
                );

            int operation = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Your result is {firstNumber + secondNumber}");
                    break;
                case 2:
                    Console.WriteLine($"Your result is {firstNumber - secondNumber}");
                    break;
                case 3:
                    Console.WriteLine($"Your result is {firstNumber * secondNumber}");
                    break;
                case 4:
                    Console.WriteLine($"Your result is {firstNumber / secondNumber}");
                    break;
            }
        }
    }
}
        
