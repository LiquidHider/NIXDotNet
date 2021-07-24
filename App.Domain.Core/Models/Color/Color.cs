
namespace App.Domain.Core
{
    public struct Color
    {
        private byte r;
        private byte g;
        private byte b;
        public Color RGB(byte r, byte g, byte b) => new Color(r, g, b);
        public static Color Red => new Color(255, 0, 0);
        public static Color Green => new Color(0, 255, 0);
        public static Color Blue => new Color(0, 0, 255);
        public static Color Black => new Color(0, 0, 0);
        public static Color White => new Color(255, 255, 255);
        private Color(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }
    }
}
