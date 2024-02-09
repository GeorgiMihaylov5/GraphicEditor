using GraphicEditor.Interfaces;
using System.Drawing.Drawing2D;

namespace GraphicEditor.Models
{
    public abstract class Shape : IShape
    {
        public Shape()
        {
            TransmissionMatrix = new Matrix();
        }

        public Shape(RectangleF rect)
        {
            Rectangle = rect;
            TransmissionMatrix = new Matrix();
        }

        public Shape(IShape shape)
        {
            Height = shape.Height;
            Width = shape.Width;
            Location = shape.Location;
            Rectangle = shape.Rectangle;
            FillColor = shape.FillColor;
        }

        public RectangleF Rectangle { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public PointF Location { get; set; }
        public Color FillColor { get; set; }
        public Color StrokeColor { get; set; }
        public int Opacity { get; set; }
        public Matrix TransmissionMatrix { get; set; }

        public virtual bool Contains(PointF point)
        {
            return Rectangle.Contains(point.X, point.Y);
        }

        public abstract void DrawSelf(Graphics grfx);
    }
}
