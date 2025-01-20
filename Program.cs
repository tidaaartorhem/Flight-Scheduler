using System;

namespace SpeedyAirLy
{
class Program
{
    static void Main() {
        
       var flights = new List<Flight>()
    {
        new Flight(1, "YUL", "YYZ", 1, 20),
        new Flight(2, "YUL", "YYC", 1, 20),
        new Flight(3, "YUL", "YVR", 1, 20),
        new Flight(4, "YUL", "YYZ", 2, 20),
        new Flight(5, "YUL", "YYC", 2, 20),
        new Flight(6, "YUL", "YVR", 2, 20)
    };
    // Task 1 - Load and List Flight Schedule
    // Load flight schedule
    var flightSchedule = new FlightSchedule();
    flightSchedule.LoadFlightSchedule(flights);

    // List flights
    Console.WriteLine("Flight Schedule:");
    flightSchedule.ListFlights();
    
    // Task 2 - Assign Orders To Flights
    Console.WriteLine("Enter the full path to the orders json file: if in same parent folder then just provide the name of the file with.json");
    string filePath = Console.ReadLine();
    
    // Load orders from JSON file (replace with actual path)
    Dictionary<string, Order> orders = new OrderManager().LoadOrders(filePath);

    // Assign orders to flights
    Console.WriteLine("\nOrder Assignments:");
    new OrderManager().AssignOrdersToFlights(flights, orders);
    }
}
    
}