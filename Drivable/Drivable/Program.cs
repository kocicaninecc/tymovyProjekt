using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drivable
{
    class Program
    {
        static void Main(string[] args)
        {
            Motorbike new_motorbike = new Motorbike(25000, 2, 220);
            new_motorbike.Move();
            new_motorbike.Stop();

            Vehicle vehicle = new Vehicle();
            vehicle.Move();
            vehicle.Stop();

            Console.WriteLine($"The brand of the vehicle is {vehicle.Brand} ");

            Console.ReadKey();

        }
    }
}
