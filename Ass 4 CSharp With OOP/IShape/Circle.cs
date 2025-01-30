using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_4_CSharp_With_OOP.IShape
{
    public class Circle : ICircle
    {
        public double Radius { get; set;  }
        public double Area => Math.PI * Radius * Radius;

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius{Radius} , Area {Area}");
        }
    }
}
