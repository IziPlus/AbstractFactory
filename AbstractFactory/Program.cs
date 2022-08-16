using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var abstractFactory = new ConceretFactory1();

                var red = abstractFactory.GetColor(Colors.RED);
                red.Fill();
                var circle = abstractFactory.GetShape(Shapes.CIRCLE);
                circle.Draw();

                var green = abstractFactory.GetColor(Colors.GREEN);
                green.Fill();
                var square = abstractFactory.GetShape(Shapes.SQUARE);
                square.Draw();
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Error : {ex.Message}.");
            }
            finally
            {
                Console.ReadLine();
            }
        }
    }
}
