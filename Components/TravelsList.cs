using System;
using System.Collections.Generic;
using System.Linq;

namespace TravelApp
{
    public class TravelsList
    {
        internal List<TravelData> travels = new List<TravelData>();

        public TravelsList()
        {
            travels = new List<TravelData>();
        }

        public void AddTravel(TravelData travelData) => travels.Add(travelData);

        public void AddTravel(List<TravelData> travelsData)
        {
            foreach (var item in travelsData)
            {
                travels.Add(item);
            }
        }

        public void FilterByShipName() => travels.OrderBy(x => x.Ship.Name);

        public void FilterByShipCaptainName() => travels.OrderBy(x => x.Ship.CaptainName);

        public void FilterByShipPassagersCount() => travels.OrderBy(x => x.Ship.PassagersCount);

        public void FilterByRouteFrom() => travels.OrderBy(x => x.Route.From);

        public void FilterByRouteTo() => travels.OrderBy(x => x.Route.To);

        public void PrintingTravels()
        {
            Console.Clear();
            foreach (var item in travels)
            {
                Console.WriteLine($"From: {item.Route.From} \nTo: {item.Route.To} \nShip name: {item.Ship.Name} \nCaptain name: {item.Ship.CaptainName} \n" +
                                  $"Ticket price: ${item.Ticket.Price} \nPassagers: {item.Ship.PassagersCount} \n" +
                                  $"Date departing: {item.Date.Departing.Day}/{item.Date.Departing.Month}/{item.Date.Departing.Year} \n" +
                                  $"Date returning: {item.Date.Returning.Day}/{item.Date.Returning.Month}/{item.Date.Returning.Year}");
                Console.WriteLine("............................");
            }


            Console.WriteLine("Press enter to close!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
