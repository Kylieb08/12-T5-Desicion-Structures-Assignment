namespace _12_T5_Desicion_Structures_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compass();
            ParkingGarageCost();
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

            else // <= 314 && >= 226
                Console.WriteLine("West");
        }

        public static void ParkingGarageCost()
        {
            double hoursParked, totalCost, minutes;
            

            Console.WriteLine("How many minutes were you parked in the garage?");

            while (!double.TryParse(Console.ReadLine(), out minutes) || minutes < 0)
            {
                Console.WriteLine("Invalid input. Please try again");
            }

            hoursParked = Math.Ceiling(minutes / 60);

            if (hoursParked == 0)
            {
                Console.WriteLine("You did not park in this garage");
            }

            else if (hoursParked > 0)
            {
                totalCost = 2.00 + (hoursParked * 2);

                if (totalCost > 20)
                    totalCost = 20;

                Console.WriteLine($"You were parked for {hoursParked} hour(s)");
                Console.WriteLine($"Total parking cost: {totalCost.ToString("C")}");
            }
        }
    }
}
