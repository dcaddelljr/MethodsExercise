namespace MethodsExercise
{
    public class Program
    

    {       //EXERCISE ONE

        public static void Main(string[] args) 
        {
            Console.WriteLine("Name:");
            var favName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Favorite color:");
            var favColor = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Favorite animal:");
            var favAnimal = Console.ReadLine();
            Console.WriteLine();
            
            Console.WriteLine("Favorite band:");
            var favBand = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine($"The {favAnimal} was hiding in the bushes.  " + $"{favName} was walking down the road listening to {favBand}.  "
                +  $"{favName} was scared, ran, and used his {favColor} shirt to wipe the sweat from his face.");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("What is the value of x?");
            var num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("What is the value of y?");
            var num2 = int.Parse(Console.ReadLine());
            
            //EXERCISE TWO
            var result = Add(num1, num2);
            Console.WriteLine($"Addition answer = {result}\n");

            Console.WriteLine("What is the value of x?");
            var num3 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("What is the value of y?");
            var num4 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();

            var product = Multiply(num3, num4);
            Console.WriteLine($"Multiply answer = {product}");
            Console.WriteLine();
            Console.WriteLine();

            //CHALLENGE PORTION
            int twoSum = SumNumbers(2, 4);
            Console.WriteLine("Sum of numbers is {0}", twoSum);
            Console.WriteLine();
            int fiveSum = SumNumbers(2, 4, 6);
            Console.WriteLine("Sum of numbers is {0}", fiveSum);
            Console.WriteLine();
            int[] nums = { 1, 1, 1, 1, 1 };
            int arraySum = SumNumbers(nums);
            Console.WriteLine("Sum of array of nums is {0}", arraySum);
            Console.WriteLine();
        }

       /* public static void Main(string first)
        {
           Main();
        }*/
        public static void SayName(string first)
        {
            string favName = $"Name: {first}";
            Console.WriteLine(first);
        }

        public static void SayColor(string color)
        {
            string favColor = $"Name: {color}";
            Console.WriteLine(color);
        }

        public static void SayAnimal(string animal)
        {
            string favAnimal = $"Name: {animal}";
            Console.WriteLine(animal);
        }

        public static void SayBand(string band)
        {
            string favBand = $"Name: {band}";
            Console.WriteLine(band);
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static int Multiply(int num3, int num4)
        {
            return num3 * num4;
        }
        public static int MultiplySec(int num3, int num4)
        {
            return num3 * num4;
        }
        //CHALLENGE - PARAMS

        public static int SumNumbers(params int[] numbers)
        {
            int totalSum = 0;
            foreach (int number in numbers)
            {
                totalSum += number;
            }
            return totalSum;
        }


    }
}