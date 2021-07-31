

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathXml = @"/home/nickmwangemi/Dev/Shapes.xml";

            // create a list of Shapes to serialize
            var listOfShapes = new List<Shape>
            {
                new Circle { Colour = "Red", Radius = 2.5 },
                new Rectangle { Colour = "Blue", Height = 20.0, Width = 10.0 },
                new Circle { Colour = "Green", Radius = 8 },
                new Circle { Colour = "Purple", Radius = 12.3 },
                new Rectangle { Colour = "Blue", Height = 45.0, Width = 18.0 }
            };

            var serializerXml = new XmlSerializer(typeof(List<Shape>));
            FileStream fileXml = File.Create(pathXml);
            serializerXml.Serialize(fileXml, listOfShapes);
            fileXml.Dispose();

            WriteLine("Loading shapes from XML:");
            fileXml = File.Open(pathXml, FileMode.Open);
            List<Shape> loadedShapesXml = serializerXml.Deserialize(fileXml) as List<Shape>;
            fileXml.Dispose();
            foreach (Shape item in loadedShapesXml)
                WriteLine($"{item.GetType().Name} is {Shape.Colour} and has an area of {item.Area}");
        }
    }
}
