using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_4_CSharp_With_OOP.IShape
{
    public class Rectangle : IRectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public double Area => Width * Height;   

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Width = {Width} , Height = {Height} , Area = {Area}");
        }
    }
}
