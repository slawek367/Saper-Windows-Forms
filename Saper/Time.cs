using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Saper
{
    public class Time
    {

        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public Time(uint h, uint m, uint s)
        {
            if (h > 23 || m > 59 || s > 59)
            {
                throw new ArgumentException("Invalid time specified");
            }
            Hours = (int)h; Minutes = (int)m; Seconds = (int)s;
        }

        public Time(DateTime dt)
        {
            Hours = dt.Hour;
            Minutes = dt.Minute;
            Seconds = dt.Second;
        }

        public override string ToString()
        {
            string time = "";


            if (this.Minutes < 10)
            {
                time += "0" + Convert.ToString(this.Minutes);
            }
            else
            {
                time += Convert.ToString(this.Minutes);
            }

            time += ":";

            if (this.Seconds < 10)
            {
                time += "0" + Convert.ToString(this.Seconds);
            }
            else
            {
                time += Convert.ToString(this.Seconds);
            }


            return time;
        }

        public void AddHours(uint h)
        {
            this.Hours += (int)h;
        }

        public void AddMinutes(uint m)
        {
            this.Minutes += (int)m;

            if (this.Minutes == 60)
            {
                this.Minutes = 0;
                this.AddHours(1);
            }
        }

        public void AddSeconds(uint s)
        {
            this.Seconds += (int)s;
            
            if(this.Seconds==60)
            {
                this.Seconds = 0;
                this.AddMinutes(1);
            }
        }
    }
}
