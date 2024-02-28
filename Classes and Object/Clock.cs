
//Suppose that you are provided with a pre-written class Clock as described below,
//where a Clock object represents an hour:minute time during the day or night,
//such as 10:45 AM or 6:27 PM.Assume that the fields, constructor, properties,
//and methods shown are already implemented. You may refer to them or use them in
//solving this problem if necessary.

//member name	                    type	    description
//new Clock(hour, minute, amPm)     constructor constructs a new clock representing the given time
//clock.Hour	                    property	the hour as an integer, from 1-12 (read-only)
//clock.Minute	                    property	the minute as an integer, from 00-59 (read-only)
//clock.AmPm	                    property	the AM or PM, as a string of either "AM" or "PM" (read-only)
//clock.ToString()	                method	    returns a string representation such as "10:07 PM"
//clock.Equals(other)	            method	    returns true if two clocks represent the same time

//Write an instance method named Advance that will be placed inside the Clock class
//to become a part of each Clock object's behavior. The advance method accepts a
//number of minutes as its parameter and moves your object forward in time by that
//amount of minutes. The minutes passed could be any non-negative number, even a
//large number such as 500 or 1000000. If necessary, your object might wrap into
//the next hour or day, or it might wrap from the morning ("AM") to the evening ("PM")
//or vice versa. A Clock object doesn't care about what day it is; if you
//advance by 1 minute from 11:59 PM, it becomes 12:00 AM.

//For example, if the following object is declared in client code:

//Clock time = new Clock(6, 27, "PM");
//The following calls to your method would modify the object's state as indicated in the comments:

//time.Advance(1);       //  6:28 PM
//time.Advance(30);      //  6:58 PM
//time.Advance(5);       //  7:03 PM
//time.Advance(60);      //  8:03 PM
//time.Advance(128);     // 10:11 PM
//time.Advance(180);     //  1:11 AM
//time.Advance(1440);    //  1:11 AM  (1 day later)
//time.Advance(21075);   //  4:26 PM  (2 weeks later)

//Assume that the state of the object is valid at the start of the call and that the amPm field stores either "AM" or "PM".



namespace CodeStepByStep_CSharp.Classes_and_Object
{
    public class Clock
    {
        public Clock(int hour, int minute, string amPm)
        {
            Hour = hour;
            Minute = minute;
            AmPm = amPm;
        }

        private int Hour { get; set; }
        
        private int Minute { get; set; }
        
        private string AmPm { get; set; }

        public void Advance(int minutes)
        {
            if(minutes < 0)
            {
                Console.WriteLine("Minutes must be greater than 0.");
                return;
            }

            if (minutes <= 60)
            {  
                if (minutes == 60)
                {
                    ResetHourIfGreaterThanTwelve(1);
                }
                else if ((minutes + Minute) < 60)
                {
                    Minute += minutes;
                }
                else
                {
                    ResetHourIfGreaterThanTwelve(1);
                    
                    Minute = (minutes + Minute) - 60;

                }
            }
            else //minutes is > 60
            {
                int hours = minutes / 60;
                int mins = minutes % 60;

                ResetHourIfGreaterThanTwelve(hours);

                Minute += mins;

                if(Minute == 60)
                {
                    ResetHourIfGreaterThanTwelve(1);

                    Minute = 00;
                }
            }
        }

        private void ResetHourIfGreaterThanTwelve(int hours)
        {
            if ((Hour + hours) > 12)
            {
                Hour = (Hour + hours) % 12;
                ChangeAmPm();
            }
            else
            {
                Hour += hours;
            }
        }

        //Not sure how to get this to work for times greater than multiple days.
        private void ChangeAmPm()
        {
                if (string.Equals(AmPm.ToLower(), "am"))
                {
                    AmPm = "PM";
                }
                else
                {
                    AmPm = "AM";
                }
        }

        public override string ToString()
        {
            if(Minute == 0)
            {
                string strMinute = Minute.ToString("D2");
                return $"{Hour}:{strMinute} {AmPm}";
            }
            else if (Minute < 10)
            {
                string strMinute = Minute.ToString("D2");
                return $"{Hour}:{strMinute} {AmPm}";
            }
                
            return $"{Hour}:{Minute} {AmPm}";
        }
    }
}
