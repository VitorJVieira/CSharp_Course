using AbstractMethods.Entities;
using AbstractMethods.Entities.Enums;

namespace AbstractMethods {
    internal class Program {
        static void Main(string[] args) {
            
            List<Shape> shapes = new List<Shape>();

            Console.Write("Enter the number of shapes: ");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++) {
                Console.WriteLine($"Shape #{i} data: ");
                Console.Write("Rectangle or Circle (r/c)? ");
                char shape = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Color color = Enum.Parse<Color>(Console.ReadLine());
                if (shape == 'r') {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(width, height, color));
                } else {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }         
            }

            Console.WriteLine();
            Console.WriteLine("Shapes areas: ");
            foreach (Shape shape in shapes) {
                Console.WriteLine(shape.Area().ToString("F2"));
            }

        }
    }
}