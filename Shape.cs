

using Exerise04;

namespace Exercise04
{
    [XmlInclude(typeof(Circle))]
    [XmlInclude(typeof(Rectangle))]
    public abstract class Shape
    {
        public static string Colour { get; set; }
        public abstract double Area { get; }
    }
}