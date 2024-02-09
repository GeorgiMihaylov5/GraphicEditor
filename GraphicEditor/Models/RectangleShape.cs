namespace GraphicEditor.Models
{
    public class RectangleShape : Shape
    {
        public RectangleShape(RectangleF rect) : base(rect)
        { }

        public RectangleShape(RectangleShape rectangle) : base(rectangle)
        { }

        public override void DrawSelf(Graphics grfx)
        {
            grfx.FillRectangle(new SolidBrush(FillColor), Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
            grfx.DrawRectangle(Pens.Black, Rectangle.X, Rectangle.Y, Rectangle.Width, Rectangle.Height);
        }
    }
}
