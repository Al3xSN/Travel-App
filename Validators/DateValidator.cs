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

        public static bool IsValidDate(int[] dateDeparture, int[] dateReturning)
        {
            int departureDay = dateDeparture[0];
            int departureMonth = dateDeparture[1];
            int departureYear = dateDeparture[2];
            int returningDay = dateReturning[0];
            int returningMonth = dateReturning[1];
            int returningYear = dateReturning[2];

            return ((departureYear == returningYear && departureMonth == returningMonth && departureDay < returningDay) ||
                    (departureYear == returningYear && departureMonth < returningMonth && departureDay <= returningDay) ||
                    (departureYear < returningYear));
        }
    }
}
