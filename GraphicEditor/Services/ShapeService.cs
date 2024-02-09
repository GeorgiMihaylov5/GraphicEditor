using GraphicEditor.Interfaces;
using GraphicEditor.Models;
using System.Xml;

namespace GraphicEditor.Services
{
    public class ShapeService : IShapeService
    {
        public ShapeService()
        {
            Shapes = new List<IShape>();   
        }

        public IList<IShape> Shapes { get; set; }
        public IShape Selected {  get; set; }
        public bool IsDragging { get; set; }
        public PointF LastLocation { get; set; }

        public void AddRandomShape<T>(int width = 100, int height = 200) where T : IShape,  new()
        {
            var rnd = new Random();
            var x = rnd.Next(100, 1000);
            var y = rnd.Next(100, 600);

            var shape = new T();
            var rect = new Rectangle(x, y, width, height);

            shape.Rectangle = rect;
            shape.FillColor = Color.White;

            Shapes.Add(shape);
        }

        public IShape ContainsPoint(PointF point)
        {
            for (int i = Shapes.Count - 1; i >= 0; i--)
            {
                if (Shapes[i].Contains(point))
                {
                    Shapes[i].FillColor = Color.Red;

                    return Shapes[i];
                }
            }
            return null;
        }

        public void RotateSelected(int angle)
        {
            if (Selected != null)
            {
                Selected.TransmissionMatrix.RotateAt(angle, new PointF(Selected.Location.X + Selected.Width / 2, Selected.Location.Y + Selected.Width / 2));
            }
        }

        public void TranslateTo(PointF p)
        {
            if (Selected != null)
            {
                Selected.Location = new PointF(Selected.Location.X + p.X - LastLocation.X, Selected.Location.Y + p.Y - LastLocation.Y);
                LastLocation = p;

            }
        }
    }
}
