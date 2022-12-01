using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class Rectangle
    {
        public int Width { get; private set; }
        public int Length { get; private set; }

        public Rectangle(int side)
        {
            Width = side;
            Length = side;
        }

        public Rectangle(int width, int length)
        {
            Width = width;
            Length = length;
        }

        public int CalculateArea()
        {
            return Width * Length;
        }

        public void Draw()
        {
            var builder = new StringBuilder();

            for (var i = 0; i < Length; i++)
                builder.AppendLine(new string('*', Width));

            Console.WriteLine(builder.ToString());
        }
    }
}