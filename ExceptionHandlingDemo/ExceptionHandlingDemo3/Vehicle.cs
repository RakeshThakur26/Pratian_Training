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
            this.CurrentSpeed += 10;
            
            SpeedMorethanMaximumSpeedException.SpeedMorethanMaximumSpeedExceptionMethod(this.CurrentSpeed, this.MaximumSpeed);
            Console.WriteLine("Current speed : " + this.CurrentSpeed);
        }

    }
}
