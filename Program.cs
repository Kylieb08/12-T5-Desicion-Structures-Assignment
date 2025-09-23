namespace _12_T5_Desicion_Structures_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compass();
            ParkingGarageCost();
            Hurricane();
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

        public static void Hurricane()
        {
            int category;

            Console.WriteLine("There's a hurricane coming!! What category is it?");
            while (!int.TryParse(Console.ReadLine(), out category) || category < 1 || category > 5)
            {
                Console.WriteLine("I don't think that's a hurricane category");
                Console.WriteLine("What category is the hurricane that approaches us right now?");
            }

            Console.WriteLine();

            switch (category)
            {
                case 1:
                    Console.WriteLine("That hurricane could have wind speeds anywhere between 119-153 kilometers per hour!");
                    Console.WriteLine("Which is the equivalent of 64-82 knots or 74-95 miles per hour!");
                    break;

                case 2:
                    Console.WriteLine("That hurricane could have wind speeds anywhere between 154-177 kilometers per hour!");
                    Console.WriteLine("Which is the equivalent of 83-95 knots or 96-110 miles per hour!");
                    break;

                case 3:
                    Console.WriteLine("That hurricane could have wind speeds anywhere between 178-209 kilometers per hour!");
                    Console.WriteLine("Which is the equivalent of 96-113 knots or 111-130 miles per hour!");
                    break;

                case 4:
                    Console.WriteLine("That hurricane could have wind speeds anywhere between 210-249 kilometers per hour!");
                    Console.WriteLine("Which is the equivalent of 114-135 knots or 131-155 miles per hour!");
                    break;

                case 5:
                    Console.WriteLine("That hurricane has wind speeds greater than 249 kilometers per hour!");
                    Console.WriteLine("Which is the equivalent of 135 knots or 130 miles per hour!");
                    break;
            }
        }
    }
}
