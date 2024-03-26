using System;

public class RentalAgency
{
    private Vehicle[] Fleet;
    public decimal TotalRevenue { get; private set; }

    // Constructor
    public RentalAgency(int fleetSize)
    {
        Fleet = new Vehicle[fleetSize];
        TotalRevenue = 0;
    }

    // Method to add vehicles to the fleet
    public void AddVehicle(Vehicle vehicle, int index)
    {
        Fleet[index] = vehicle;
        Console.WriteLine($"Added {vehicle.Model} to the fleet.");
    }

    // Method to remove vehicles from the fleet
    public void RemoveVehicle(int index)
    {
        if (Fleet[index] != null)
        {
            Console.WriteLine($"Removed {Fleet[index].Model} from the fleet.");
            Fleet[index] = null;
        }
        else
        {
            Console.WriteLine("No vehicle found at the specified index.");
        }
    }

    // Method to rent a vehicle
    public void RentVehicle(int index, int days)
    {
        if (Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice * days;
            Console.WriteLine($"Vehicle {Fleet[index].Model} rented for {days} days.");
            RemoveVehicle(index);
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }
}
