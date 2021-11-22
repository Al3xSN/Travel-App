namespace TravelApp
{
    public class Route
    {
        public Route(string from, string to)
        {
            From = from;
            To = to;
        }

        public string From { get; private set; }

        public string To { get; private set; }
    }
}
