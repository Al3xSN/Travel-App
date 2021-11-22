using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
