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

        public bool IsTimeEnd() {
            return !(seconds > 0);
        }

        public override string ToString() {
            return $"{seconds / 60}:{seconds % 60}";
        }
    }
}
