using System.Xml.Serialization;
using Exerise04;
using System.Xml.Serialization;


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