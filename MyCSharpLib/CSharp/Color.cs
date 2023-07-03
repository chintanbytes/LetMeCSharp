using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCSharpLib.CSharp
{
    internal class Color
    {
        public static readonly Color Black = new(0, 0, 0);
        public static readonly Color White = new(255, 255, 255);
        public static readonly Color Red = new(255, 0, 0);
        public static readonly Color Green = new(0, 255, 0);
        public static readonly Color Blue = new(0, 0, 255);

        public byte R;
        public byte G;
        public byte B;

        public Color(byte r, byte g, byte b)
        => (R,G,B) = (r,g,b);
    }
}
