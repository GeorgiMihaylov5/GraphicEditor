using GraphicEditor.Interfaces;
using GraphicEditor.Models;

namespace GraphicEditor.Services
{
    public class DrawService : IDrawService
    {
        public void Draw(Graphics grfx, IList<IShape> shapes)
        {
            foreach (Shape item in shapes)
            {
                DrawShape(grfx, item);
            }
        }

        public void DrawShape(Graphics grfx, IShape shape)
        {
            shape.DrawSelf(grfx);
        }
    }
}
