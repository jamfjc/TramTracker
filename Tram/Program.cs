namespace tramtram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number of stations
            int N = Convert.ToInt32(Console.ReadLine());

            int totalPassengers = 0;
            int currentPassengers = 0;
            int maxPassengersGettingOn = 0;
            int stationWithMostGettingOn = 0;

            for (int i = 1; i <= N; i++)
            {
                // Read the number of passengers getting on and off
                string[] input = Console.ReadLine().Split();
                int passengersOn = int.Parse(input[0]);
                int passengersOff = int.Parse(input[1]);

                // Update the count of people currently on the tram
                currentPassengers += passengersOn;
                currentPassengers -= passengersOff;

                // Track the total number of people who traveled (total passengers who got on)
                totalPassengers += passengersOn;

                // Track the station with the maximum number of passengers getting on
                if (passengersOn > maxPassengersGettingOn)
                {
                    maxPassengersGettingOn = passengersOn;
                    stationWithMostGettingOn = i;
                }
            }
            // Output the total number of passengers who traveled
            Console.WriteLine(totalPassengers);

            // Output the station index with the most passengers getting on
            Console.WriteLine(stationWithMostGettingOn);
        }     
    }
}
