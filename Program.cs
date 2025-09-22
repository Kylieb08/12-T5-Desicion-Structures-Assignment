namespace _12_T5_Desicion_Structures_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compass();
        }

        public static void Compass()
        {
            int degree;



            Console.WriteLine("Please enter a degree between 0 and 360");

            while (!int.TryParse(Console.ReadLine(), out degree))
            {
                Console.WriteLine("Invalid input. Please try again");
            }

            if (degree < 0 || degree > 360)
            {
                if (degree < 0)
                {
                    degree = 360 + (degree % 360);
                }

                else
                    degree = degree % 360;

            }

            Console.WriteLine($"You entered {degree} degrees");

            if (degree <= 45 || degree >= 315)
            {
                Console.WriteLine("North");
            }

            else if (degree <= 135 && degree >= 46)
            {
                Console.WriteLine("East");
            }

            else if (degree <= 225 && degree >= 136)
            {
                Console.WriteLine("South");
            }

            else
                Console.WriteLine("West");
        }
    }
}
