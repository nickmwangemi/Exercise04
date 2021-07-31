using Exercise04;
using Exercise04ise04;

namespace Exerise04
{
    
    public class Rectangle : Shape
    {
        public override double Area
        {
            get
            {
                return Height * Width;
            }
        }

        public double Height { get; set; }
        public double Width { get; set; }
    }
}
