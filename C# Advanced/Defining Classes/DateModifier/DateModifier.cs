using System;

namespace DateModifier
{
    public class DateModifierExercise
    {
        public static double DifferenceBetweenDates(string firstDate, string secondDate) 
        {
            DateTime d1 = DateTime.Parse(firstDate);
            DateTime d2 = DateTime.Parse(secondDate);
            return (d1 - d2).TotalDays;
        }
    }
}
