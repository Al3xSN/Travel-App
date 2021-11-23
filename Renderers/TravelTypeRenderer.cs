using System;
using TravelApp.Contracts;

namespace TravelApp.Renderers
{
    public class TravelTypeRenderer : IRender
    {
        public void Render()
        {
            Console.Clear();
            Console.WriteLine("1. Single travel");
            Console.WriteLine("2. Multiple travels");
        }
    }
}
