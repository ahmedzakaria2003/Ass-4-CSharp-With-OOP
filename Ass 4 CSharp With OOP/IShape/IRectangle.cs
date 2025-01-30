using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass_4_CSharp_With_OOP.IShape
{
    internal interface IRectangle : Ishape
    {
        double Width { get; set; }
       double Height { get; set; }

      
    }
}
