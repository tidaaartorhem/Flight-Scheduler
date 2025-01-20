using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json; 

namespace SpeedyAirLy
{public class FlightSchedule
{
    public List<Flight> Flights { get; set; }
    // constructor to create Flight Schedule from List<flight> object 
    public FlightSchedule()
    {
        Flights = new List<Flight>();
    }
    // Updates List of Flights
    public void LoadFlightSchedule(List<Flight> flights)
    {
        Flights.AddRange(flights);
    }
    // prints out current flight schedule 
    public void ListFlights()
    {
        foreach (var flight in Flights)
        {
            Console.WriteLine($"Flight: {flight.FlightNumber}, departure: {flight.DepartureAirport}, arrival: {flight.ArrivalAirport}, day: {flight.Day}");
        }
    }
}}