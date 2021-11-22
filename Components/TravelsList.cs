﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelApp
{
    public class TravelsList
    {
        private const int EmptyLinesCount = 2;

        private List<TravelData> travels = new List<TravelData>();

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
            foreach (var item in travels)
            {
                Console.WriteLine($"From: {item.Route.From} To: {item.Route.To} | Ship name: {item.Ship.Name} | Captain name: {item.Ship.CaptainName} | " +
                                  $"Ticket price: ${item.Ticket.Price} | " +
                                  $"Passagers: {item.Ship.PassagersCount} | Date departing: {item.Date.Departing[0]}/{item.Date.Departing[1]}/{item.Date.Departing[2]} | " +
                                  $"Date returning: {item.Date.Returning[0]}/{item.Date.Returning[1]}/{item.Date.Returning[2]}");
            }

            for (int i = 0; i < EmptyLinesCount; i++)
            {
                Console.WriteLine();
            }

            Console.WriteLine("Press enter to close!");
            Console.ReadKey();
            Console.Clear();
        }
    }
}