using System.Text;
using test;

namespace concatenation_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bunnyRectangle = new Rectangle(2, 5);

            // cant modify cause its a private set
            // bunnyRectangle.Length = 10;

            Console.WriteLine(
                $"Rectangle width: {bunnyRectangle.Width}" +
                $"\nRectangle length: {bunnyRectangle.Length}" +
                $"\nRectangle area: {bunnyRectangle.CalculateArea()}" +
                $"\nRectangle shape:\n"
            );

            bunnyRectangle.Draw();

            var bunnySquare = new Rectangle(3);
            Console.WriteLine(
                $"Square width: {bunnySquare.Width}" +
                $"\nSquare length: {bunnySquare.Length}" +
                $"\nSquare area: {bunnySquare.CalculateArea()}" +
                $"\nSquare shape:\n"
            );

            bunnySquare.Draw();
        }
    }
}