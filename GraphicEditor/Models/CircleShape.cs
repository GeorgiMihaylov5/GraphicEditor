namespace GraphicEditor.Models
{
    public class CircleShape : Shape
    {
        public CircleShape() {   }
        public CircleShape(RectangleF rect) : base(rect) { }

        public CircleShape(RectangleShape rectangle) : base(rectangle) { }

        public override bool Contains(PointF point)
        {
            return base.Contains(point);
        }

        public override void DrawSelf(Graphics grfx)
        {
            grfx.DrawEllipse(Pens.Black, Rectangle);
            grfx.FillEllipse(new SolidBrush(Color.Yellow), Rectangle);
        }
    }
}
