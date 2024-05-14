namespace MethodsExercise
{
    public class Program
    {

        public int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {

            var amountOfPeople = 15 + 13;
            var amountDeclined = 13 - 2;
            var amountArrived = 13 * 3 ;
            var amountMissing = 13 / 2;
            var amountRemaining = 13 % 2;


        Console.WriteLine("Hey, what's your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Cool! {userName}, what's your favorite color then?");
            var color = Console.ReadLine();

            Console.WriteLine("That's mine too! What's your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine("They are the cutest! Lastly, what's your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thank you for registering {userName}. Can you imagined {animal} in {color} playing your favorite song from {band}");


            // Exercise 3 Delcare 5 methods
        }
    }
}
