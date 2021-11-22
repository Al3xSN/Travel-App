namespace TravelApp
{
    public class Ticket
    {
        public Ticket(decimal price)
        {
            Price = price;
        }

        public decimal Price { get; private set; }
    }
}
