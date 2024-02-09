namespace GraphicEditor.Models
{
    public class EllipseShape : Shape
    {
        public EllipseShape() : base() { }
        public EllipseShape(RectangleF rect) : base(rect) { }

        public EllipseShape(RectangleShape rectangle) : base(rectangle) { }

        public override bool Contains(PointF point)
        {
            float a = Width / 2;
            float b = Height / 2;
            float xc = Location.X + a;
            float yc = Location.Y + b;

            return base.Contains(point);
            //return Math.Pow((point.X - xc) / a, 2) + Math.Pow((point.Y - yc)/b,2);
        }

        public override void DrawSelf(Graphics grfx)
        {
            var c = Color.FromArgb(Opacity, FillColor);
            grfx.DrawEllipse(Pens.Black, Rectangle);
            grfx.FillEllipse(new SolidBrush(c), Rectangle);
        }
    }
}
