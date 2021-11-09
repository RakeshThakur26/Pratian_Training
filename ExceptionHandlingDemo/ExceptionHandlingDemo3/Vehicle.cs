using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingDemo3
{
    class Vehicle
    {
        public int CurrentSpeed { get; set; }
        public int MaximumSpeed { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(int current_speed, int max_speed)
        {
            this.CurrentSpeed = current_speed;
            this.MaximumSpeed = max_speed;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <exception cref="SpeedMorethanMaximumSpeedException"></exception>
        public void IncreaseSpeed()
        {
            this.CurrentSpeed += 5;
            if (this.CurrentSpeed > this.MaximumSpeed)
                throw new SpeedMorethanMaximumSpeedException("Current Speed Exceeds Max Speed");
        }

    }
}
