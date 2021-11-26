using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using TravelApp.Contracts;
using TravelApp.Renderers;

namespace TravelApp
{
    class Program
    {
        static void Main(string[] args)
        {
            TravelsList travels = new TravelsList();
            IRender loadingRenderer = new LoadingMenu();
            IRender mainMenuRenderer = new MainMenuRenderer();
            IRender travelTypeRenderer = new TravelTypeRenderer();
            IRender editTravelRenderer = new TravelEditRenderer();
            IRender exitRender = new ExitRenderer();
            IRender travelFilterRenderer = new TravelFilterRenderer();

            loadingRenderer.Render();
            while (true)
            {
                mainMenuRenderer.Render();
                int mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        travelTypeRenderer.Render();
                        GetTravelTypeChoice(travels, travelTypeRenderer);
                        break;
                    case 2:
                        travels.PrintingTravels();
                        break;
                    case 3:
                        editTravelRenderer.Render();
                        break;
                    case 4:
                        travelFilterRenderer.Render();
                        GetTravelFilterChoice(travels, travelFilterRenderer);
                        break;
                    case 5:
                        exitRender.Render();
                        return;
                    default:
                        continue;
                }
            }
        }

        static void GetTravelTypeChoice(TravelsList travels, IRender travelTypeMenu)
        {
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    travels.AddTravel(AddSingleTravel());
                    break;
                case 2:
                    travels.AddTravel(AddMultipleTravel());
                    break;
                default:
                    travelTypeMenu.Render();
                    break;
            }
        }

        static void GetTravelFilterChoice(TravelsList travels, IRender travelFilterMenu)
        {
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    travels.FilterByShipName();
                    break;
                case 2:
                    travels.FilterByShipCaptainName();
                    break;
                case 3:
                    travels.FilterByShipPassagersCount();
                    break;
                case 4:
                    travels.FilterByRouteFrom();
                    break;
                case 5:
                    travels.FilterByRouteTo();
                    break;
                default:
                    travelFilterMenu.Render();
                    break;
            }
        }

        static TravelData AddSingleTravel()
        {
            Console.Clear();

            Console.Write("Enter Route (ex. Barcelon - Brazil): ");
            string[] input = Console.ReadLine().Split(" - ");

            Console.Write("Enter Ship name (ex. Concordia): ");
            string shipName = Console.ReadLine();

            Console.Write("Enter Captain name (ex. Vladimir Stoimov): ");
            string captainName = Console.ReadLine();

            Console.Write("Enter Passager count: ");
            string passagerCount = Console.ReadLine();

            Console.Write("Enter Ticket price: $");
            string ticketPrice = Console.ReadLine();

            Console.Write("Enter Departure date (dd/mm/yyyy): ");
            string inputDeparture = Console.ReadLine();
            DateTime dateDeparture;

            while (true)
            {
                Match match = DateValidator.IsValidFormat(inputDeparture);

                if (match.Success)
                {
                    int[] date = inputDeparture.Split('/').Select(int.Parse).ToArray();
                    dateDeparture = new DateTime(date[2], date[1], date[0]);

                    break;
                }

                Console.Write("Incorrect date! Try again: ");
                inputDeparture = Console.ReadLine();
            }

            Console.Write("Enter Returning date (dd/mm/yyyy): ");
            string inputReturning = Console.ReadLine();
            DateTime dateReturning;

            while (true)
            {
                Match match = DateValidator.IsValidFormat(inputReturning);

                if (match.Success)
                {
                    int[] date = inputReturning.Split('/').Select(int.Parse).ToArray();
                    dateReturning = new DateTime(date[2], date[1], date[0]);

                    if (dateDeparture < dateReturning)
                    {
                        break;
                    }
                }

                Console.Write("Incorrect date! Try again: ");
                inputReturning = Console.ReadLine();
            }

            TravelData travel = null;
            try
            {
                Route route = new(input[0], input[1]);
                Ship ship = new(shipName, captainName, int.Parse(passagerCount));
                Date date = new(dateDeparture, dateReturning);
                Ticket ticket = new(decimal.Parse(ticketPrice));
                travel = new(route, ship, date, ticket);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message}! You need to submit again!");
                Console.WriteLine("Press enter to submit again!");
                Console.ReadKey();
                AddSingleTravel();
            }

            Console.WriteLine(" -----Travels added!----- " + Environment.NewLine + "----Enter to continiue----");
            Console.ReadKey();
            Console.Clear();

            return travel;
        }

        static List<TravelData> AddMultipleTravel()
        {
            Console.Clear();
            List<TravelData> travels = new List<TravelData>();

            Console.Write("Travel count: ");
            int travelCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < travelCount; i++)
            {
                travels.Add(AddSingleTravel());
            }

            return travels;
        }
    }
}