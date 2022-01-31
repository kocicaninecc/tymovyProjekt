using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivable
{
    class Motorbike : IDrivable
    {
        public int Wheels { get; set; }
        public double Speed { get; set; }

        public int Price { get; set; }


        public Motorbike(int price, int wheels, double speed)
        {
            Price = price;
            Wheels = wheels;
            Speed = speed;
        }
        public void Move()
        {
            Console.WriteLine($"Motorbike  moves forward at {Speed} MPH");
        }

        public void Stop()
        {
            Console.WriteLine($"Motorbike stops");
            Speed = 0;
        }
    }
}
