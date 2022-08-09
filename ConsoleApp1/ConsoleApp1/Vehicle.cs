using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Vehicle
    {
        public string Name { get; set; }
        public virtual void Go()
        {
            Console.WriteLine("Vehicle is going"    );
        }
    }
}
