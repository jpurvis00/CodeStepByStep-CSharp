
//Write a class of objects named Date that remembers information about a month and day.
//Ignore leap years and don't store the year in your object. You must include the
//following public members:

//member name	    kind	        description
//Date(m, d)	    constructor	    constructs a new date representing the given month and day
//DaysInMonth()	    method	        returns the number of days in the month stored by your date object
//Day	            property	    returns the day (read-only)
//Month	            property	    returns the month (read-only)
//NextDay()	        method	        advances the Date to the next day, wrapping to the next month and/or year if necessary
//ToString()	    method	        returns a string representation such as "07/04"

//You should define the entire class including the class heading, the private fields,
//and the declarations and definitions of all the public members.


using System.Runtime.InteropServices.ComTypes;

namespace CodeStepByStep_CSharp.Classes_and_Object
{
    public class Date
    {
        public enum EnumMonth
        {
            January = 1,
            february = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }

        private readonly int[] NumberOfDaysInMonth = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        public Date(int day, int month)
        {
            Day = day;
            Month = month;
        }

        public int Month { get; set; }

        public int Day { get; set; }

        public int DaysInMonth()
        {
            return NumberOfDaysInMonth[Month - 1];
        }

        public void NextDay()
        {
            int daysInMonth = DaysInMonth();

            if ((Day + 1) > daysInMonth)
            {
                Day = 1;
            
                if ((Month + 1) < 12)
                {
                    Month++;
                }
                else
                {
                    Month = 1;
                }
            }
            else
            {
                Day++;
            }

        }

        public EnumMonth GetMonth()
        {
            return (EnumMonth)Month; 
        }

        public override string ToString()
        {
            string month = TurnDayMonthIntoString(Month);
            string day = TurnDayMonthIntoString(Day);

            return $"{day}/{month}";
        }

        private string TurnDayMonthIntoString(int checkValue)
        {
            if(checkValue < 10)
            {
                return checkValue.ToString("D2");
            }

            return checkValue.ToString();
        }
    }
}
