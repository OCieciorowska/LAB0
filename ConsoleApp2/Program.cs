namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("Podaj zakres liczb:");
            if (int.TryParse(Console.ReadLine(), out int upperLimit))
            {
                FizzBuzz fizzBuzz = new FizzBuzz(upperLimit);
                fizzBuzz.PrintNumbers();
            }
            else
            {
                Console.WriteLine("Złe dane");
            }
        }
    }

}
