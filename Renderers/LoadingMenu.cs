using System;
using System.Threading;
using TravelApp.Contracts;

namespace TravelApp.Renderers
{
    public class LoadingMenu : IRender
    {
        public void Render()
        {
            Console.WriteLine("Welcome to the TravelApp.com");
            Console.WriteLine("Loading...");
            Thread.Sleep(1500);
        }
    }
}
