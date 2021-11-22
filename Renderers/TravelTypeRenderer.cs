using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
