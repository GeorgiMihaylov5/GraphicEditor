using GraphicEditor.Interfaces;
using GraphicEditor.Models;

namespace GraphicEditor.Services
{
    public class DrawService : IDrawService
    {
        public DrawService()
        {
            Shapes = new List<IShape>();    
        }

        public IList<IShape> Shapes {  get; set; }

        public void Draw(Graphics grfx)
        {
            foreach (Shape item in Shapes)
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
