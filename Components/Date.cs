namespace TravelApp
{
    public class Date
    {
        public Date(int[] departing, int[] returning)
        {
            Departing = departing;
            Returning = returning;
        }

        public int[] Departing { get; private set; }

        public int[] Returning { get; private set; }
    }
}
