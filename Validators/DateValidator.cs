using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TravelApp
{
    public class DateValidator
    {
        public static Match IsValidFormat(string inputArrival)
        {
            return Regex.Match(inputArrival, @"^(?<day>[0-2][0-9]{1}|[3][01]{1})\/(?<month>[0][0-9]|[1][0-2])\/(?<year>[2][0-1][0-9]{2})$");
        }
    }
}
