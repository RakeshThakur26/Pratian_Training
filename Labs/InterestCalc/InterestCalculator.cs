using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestCalc
{
    class InterestCalculator
    {
        public double Principle { get; set; }
        public double intRate { get; set; }
        public int Time { get; set; }

        public InterestCalculator(double principle, int time)
        {
            this.Principle = principle;
            this.Time = time;

            if (this.Time >= 5)
                this.intRate = 10;
            else
                this.intRate = 12; 
        }

        public double GetInterest()
        {
            return (this.Principle * this.Time * this.intRate) / 100;
        }
    }
}
