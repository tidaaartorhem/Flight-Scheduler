using System;

namespace SpeedyAirLy
{
    public class Flight
    {
    public int FlightNumber { get; set; }
    public string DepartureAirport { get; set; }
    public string ArrivalAirport { get; set; }
    public int Day { get; set; }
    public int Capacity { get; set; }
    public List<Order> AssignedOrders { get; set; }
    
    // constructor to init flight object 
    public Flight(int flightNumber, string departureAirport, string arrivalAirport, int day, int capacity)
    {
        FlightNumber = flightNumber;
        DepartureAirport = departureAirport;
        ArrivalAirport = arrivalAirport;
        Day = day;
        Capacity = capacity;
        AssignedOrders = new List<Order>();
    }
        
    
    }
}