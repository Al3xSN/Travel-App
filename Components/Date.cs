using System;

namespace TravelApp
{
    public class Date
    {
        public Date(DateTime departing, DateTime returning)
        {
            Departing = departing;
            Returning = returning;
        }

        public DateTime Departing { get; private set; }

        public DateTime Returning { get; private set; }
    }
}
