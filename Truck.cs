using System;

public class Truck : Vehicle
{
    // Additional properties specific to trucks
    public int Capacity { get; set; }
    public string TruckType { get; set; }
    public bool FourWheelDrive { get; set; }

    // Constructor
    public Truck(string model, string manufacturer, int year, decimal rentalPrice,
                 int capacity, string truckType, bool fourWheelDrive)
        : base(model, manufacturer, year, rentalPrice)
    {
        Capacity = capacity;
        TruckType = truckType;
        FourWheelDrive = fourWheelDrive;
    }

    // Override method to display truck details
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine($"Capacity: {Capacity} tons");
        Console.WriteLine($"Truck Type: {TruckType}");
        Console.WriteLine($"Four Wheel Drive: {(FourWheelDrive ? "Yes" : "No")}");
    }
}
