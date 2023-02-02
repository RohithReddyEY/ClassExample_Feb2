using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassExample_Feb2
{
    class Automobile
    {
        String model = "Audi";
        String color = "Red";
        String type = "FourWheeler";
        static void Main(string[] args)
        {
            Automobile objectOne = new Automobile();
            Console.WriteLine(objectOne.model);
            Console.WriteLine(objectOne.color);
            Console.WriteLine(objectOne.type);
        }
    }
}
