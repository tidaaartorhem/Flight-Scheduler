using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json; 

namespace SpeedyAirLy
{ 
    public class OrderManager
    
{
   // Loads orders from a json file
    public  Dictionary<string, Order>? LoadOrders(string filePath)
    {
        string json = File.ReadAllText(filePath);
      if (string.IsNullOrEmpty(json)) 
    {
        return null; 
    }
        
        Dictionary<string, Order> orders = JsonSerializer.Deserialize<Dictionary<string, Order>>(json); 
       
        return orders;
    }
    // assigns orders to flights based on capacity and destination
  public void AssignOrdersToFlights(List<Flight> flights, Dictionary<string, Order> orders)
{
    foreach (var order in orders)
        {
            bool assigned = false;
            Flight assignedFlight = null;
        
            foreach (var flight in flights)
            {    
                if (flight.ArrivalAirport == order.Value.destination && flight.AssignedOrders.Count < flight.Capacity)
                {
                    flight.AssignedOrders.Add(order.Value);
                    assigned = true;
                    assignedFlight = flight;
              
                    break;
                }
            }

            if (assigned)
            {
                Console.WriteLine($"order: {order.Key}, flightNumber: {assignedFlight.FlightNumber}, departure: {assignedFlight.DepartureAirport}, arrival: {assignedFlight.ArrivalAirport}, day: {assignedFlight.Day}");
            }
            else
            {
                Console.WriteLine($"order: {order.Key}, flightNumber: not scheduled");
            }
        }
    }
}}