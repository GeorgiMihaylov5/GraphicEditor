namespace GraphicEditor.Interfaces
{
    public interface IDrawService
    {
        public IList<IShape> Shapes { get; set; }
        public void Draw(Graphics grfx);
        public void DrawShape(Graphics grfx, IShape shape);
    }
}
