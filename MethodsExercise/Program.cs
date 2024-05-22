namespace MethodsExercise
{
    public class Program
    {

        public static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulus(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {

            var amountOfPeople = Sum(15, 12);
            var amountDeclined = Subtract(13, 2);
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

            Console.WriteLine($"What is the Amount of Poeple {amountOfPeople}?");
            Console.WriteLine($"How many people declined {amountDeclined}");
            Console.WriteLine($"How many arrived {amountArrived}");
            Console.WriteLine($"How many did not come {amountMissing}");
            Console.WriteLine($"Who els remaining {amountRemaining}");
        }
    }
}
