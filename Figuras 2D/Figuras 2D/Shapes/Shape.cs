using System.Drawing;

namespace Figuras_2D.Shapes
{
    public abstract class Shape
    {
        public Pen Pen { get; set; }
        public Brush Brush { get; set; }
        public float Rotation { get; set; } = 0;

        protected Shape(Pen pen, Brush brush)
        {
            Pen = pen;
            Brush = brush;
        }

        public abstract void Draw(Graphics g);
    }
}