using System.Drawing.Drawing2D;

namespace GraphicEditor.Interfaces
{
    public interface IShape
    {
        public RectangleF Rectangle { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
        public PointF Location { get; set; }
        public Color FillColor { get; set; }
        public Color StrokeColor { get; set; }
        public int Opacity { get; set; }
        public Matrix TransmissionMatrix { get; set; }

        public bool Contains(PointF point);
        public void DrawSelf(Graphics grfx);
    }
}
