namespace GraphicEditor.Interfaces
{
    public interface IDrawService
    {
        public void Draw(Graphics grfx, IList<IShape> shapes);
        public void DrawShape(Graphics grfx, IShape shape);
    }
}
