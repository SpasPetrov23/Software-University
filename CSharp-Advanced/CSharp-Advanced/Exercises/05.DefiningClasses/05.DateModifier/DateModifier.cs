using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public static class DateModifier
    {
        public static double GetDifferenceBetweenTwoDates(string firstDate, string secondDate)
        {
            DateTime startDate = DateTime.Parse(firstDate);
            DateTime endDate = DateTime.Parse(secondDate);

            double result = (endDate - startDate).TotalDays;
            double absResult = Math.Abs(result);
            return absResult;
        }
    }
}
