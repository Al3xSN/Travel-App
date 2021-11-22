using System;
using TravelApp.Contracts;

namespace TravelApp.Renderers
{
    public class MainMenuRenderer : IRender
    {
        public void Render()
        {
            Console.Clear();
            Console.WriteLine("1. Add travel");
            Console.WriteLine("2. Show travels");
            Console.WriteLine("3. Edit");
            Console.WriteLine("4. Filter");
            Console.WriteLine("5. Exit");
        }
    }
}
