using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of vehicles
        Car car = new Car("Civic", "Honda", 2022, 50.00m, 5, "Petrol", "Automatic", false);
        Truck truck = new Truck("F-150", "Ford", 2020, 80.00m, 2, "Pickup", true);
        Motorcycle motorcycle = new Motorcycle("Ninja 300", "Kawasaki", 2021, 30.00m, 300, "Petrol", true);

        // Displaying vehicle details
        Console.WriteLine("Car Details:");
        car.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Truck Details:");
        truck.DisplayDetails();
        Console.WriteLine();

        Console.WriteLine("Motorcycle Details:");
        motorcycle.DisplayDetails();
        Console.WriteLine();

        // Testing RentalAgency
        RentalAgency agency = new RentalAgency(3);
        agency.AddVehicle(car, 0);
        agency.AddVehicle(truck, 1);
        agency.AddVehicle(motorcycle, 2);

        while (true)
        {
            Console.WriteLine("Select a vehicle to rent (1 - Car, 2 - Truck, 3 - Motorcycle, 0 - Exit):");
            int choice = Convert.ToInt32(Console.ReadLine());

            if (choice == 0)
                break;

            Console.WriteLine("Enter number of days to rent:");
            int days = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    agency.RentVehicle(0, days); // Rent car
                    break;
                case 2:
                    agency.RentVehicle(1, days); // Rent truck
                    break;
                case 3:
                    agency.RentVehicle(2, days); // Rent motorcycle
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }

        Console.WriteLine($"Total revenue of the rental agency: {agency.TotalRevenue:C}");
    }
}
