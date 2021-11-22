using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelApp.Contracts;

namespace TravelApp.Renderers
{
    public class TravelEditRenderer : IRender
    {
        public void Render()
        {
            Console.Clear();
            Console.WriteLine("1. Edit Route");
            Console.WriteLine("2. Edit Ship name");
            Console.WriteLine("3. Edit Captain name");
            Console.WriteLine("4. Edit Class");
            Console.WriteLine("5. Edit Ticket price");
            Console.WriteLine("6. Edit Passager count");
            Console.WriteLine("7. Edit Date of departure");
            Console.WriteLine("8. Edit Date of return");
        }
    }
}
