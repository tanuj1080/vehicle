namespace vehicle
{
    internal class Program
    {
        // Create a new vehicle
        Vehicle myVehicle = new Vehicle();

        // Start and stop the vehicle
        myVehicle.Start();
        Console.WriteLine("Taking the vehicle for a ride...");
        myVehicle.Stop();

        Console.ReadLine(); // To keep the console window open
    }
}
