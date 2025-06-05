using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DataClasses
{
    public class Time
    {
        private int seconds;

        public Time(Training training) {
            seconds = training.TimerTime * 60;
        }
        
        public void Decrement() {
            seconds--;
        }

        public void Increment(int incSeconds) {
            seconds += incSeconds;
        }

        public bool IsTimeEnd() {
            return !(seconds > 0);
        }

        public override string ToString() {
            int inMinutes = seconds / 60;
            int inSeconds = seconds % 60;

            string formatMinutes = $"{inMinutes + 100}".Substring(1, 2);
            string formatSeconds = $"{inSeconds + 100}".Substring(1, 2);

            return $"{formatMinutes}:{formatSeconds}";
        }
    }
}
