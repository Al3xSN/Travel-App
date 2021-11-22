namespace TravelApp
{
    public class TravelData
    {
        public TravelData(Route route, Ship ship, Date date, Ticket ticket)
        {
            Route = route;
            Ship = ship;
            Date = date;
            Ticket = ticket;
        }

        public Route Route { get; private set; }

        public Ship Ship { get; private set; }

        public Date Date { get; private set; }

        public Ticket Ticket { get; private set; }
    }
}
