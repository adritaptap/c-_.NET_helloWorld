using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld2
{
    class Message
    {
        private int hour = DateTime.Now.Hour;
        private string day = DateTime.Now.DayOfWeek.ToString();
        private string message;
        private int minMorning;
        private int maxMorning;
        private int maxAfternoon;

        public Message()
        {
            this.minMorning = 8;
            this.maxMorning = 13;
            this.maxAfternoon = 18;
        }

        public Message(int minM, int maxM, int maxA)
        {
            this.minMorning = minM;
            this.maxMorning = maxM;
            this.maxAfternoon = maxA;
        }

        public string HelloMessage
        {
            get
            {
                if ((day == "sunday") || (day == "saturday") || (day == "monday" && hour < minMorning) || (hour > maxAfternoon && day == "friday"))
                {
                    message = "Bon weekend";
                }
                else
                {
                    if (hour > minMorning && hour < maxMorning)
                    {
                        message = "Bonjour";

                    }
                    else if (hour >= maxMorning && hour <= maxAfternoon)
                    {
                        message = "Bon après-midi";
                    }
                    else
                    {
                        message = "Bonsoir";
                    }


                }
                return message;
            }
        }
    }
}
