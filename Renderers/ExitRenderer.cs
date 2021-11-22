using System;
using System.Threading;
using TravelApp.Contracts;

namespace TravelApp.Renderers
{
    public class ExitRenderer : IRender
    {
        public void Render()
        {
            Console.Clear();
            Console.WriteLine("Goodbye...!");
            Thread.Sleep(1500);
        }
    }
}
