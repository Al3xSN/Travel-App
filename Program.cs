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
            IRender loadingMenu = new LoadingMenu();
            IRender mainMenu = new MainMenuRenderer();
            IRender travelTypeMenu = new TravelTypeRenderer();
            IRender editTravelMenu = new TravelEditRenderer();
            IRender exitRender = new ExitRenderer();

            loadingMenu.Render();
            while (true)
            {
                mainMenu.Render();
                int mainMenuChoice = int.Parse(Console.ReadLine());

                switch (mainMenuChoice)
                {
                    case 1:
                        travelTypeMenu.Render();
                        int choice = int.Parse(Console.ReadLine());

                        if (choice == 1)
                        {
                            travels.AddTravel(AddSingleTravel());
                        }
                        else if (choice == 2)
                        {
                            travels.AddTravel(AddMultipleTravel());
                        }
                        else
                        {
                            travelTypeMenu.Render();
                        }
                        break;
                    case 2:
                        travels.PrintingTravels();
                        break;
                    case 3:
                        editTravelMenu.Render();
                        break;
                    case 4:
                        break;
                    case 5:
                        exitRender.Render();
                        return;
                    default:
                        continue;
                }
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
            int[] dateDeparture = new int[3];

            while (true)
            {
                Match match = DateValidator.IsValidFormat(inputDeparture);

                if (match.Success)
                {
                    dateDeparture = inputDeparture.Split('/').Select(int.Parse).ToArray();
                    break;
                }

                Console.Write("Incorrect date! Try again: ");
                inputDeparture = Console.ReadLine();
            }

            Console.Write("Enter Returning date (dd/mm/yyyy): ");
            string inputReturning = Console.ReadLine();
            int[] dateReturning = new int[3];

            while (true)
            {
                Match match = DateValidator.IsValidFormat(inputReturning);

                if (match.Success)
                {
                    dateReturning = inputReturning.Split('/').Select(int.Parse).ToArray();

                    if (DateValidator.IsValidDate(dateDeparture, dateReturning))
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