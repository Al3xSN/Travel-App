using System;
using TravelApp.Contracts;

namespace TravelApp.Renderers
{
    public class TravelFilterRenderer : IRender
    {
        public void Render()
        {
            Console.Clear();
            Console.WriteLine("1. Filter by ship name");
            Console.WriteLine("2. Filter by captain name");
            Console.WriteLine("3. Filter by passagers count");
            Console.WriteLine("4. Filter by route from");
            Console.WriteLine("5. Filter by route to");
        }
    }
}
