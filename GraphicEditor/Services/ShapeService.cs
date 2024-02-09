using GraphicEditor.Interfaces;
using GraphicEditor.Models;

namespace GraphicEditor.Services
{
    public class ShapeService : DrawService, IShapeService
    {
        public IShape Selected {  get; set; }
        public bool IsDragging { get; set; }
        public PointF LastLocation { get; set; }

        public void AddRandomCircle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            var rect = new RectangleShape(new Rectangle(x, y, 100, 200));
            rect.FillColor = Color.White;

            Shapes.Add(rect);
        }

        public void AddRandomEllipse()
        {
            throw new NotImplementedException();
        }

        public void AddRandomRectangle()
        {
            Random rnd = new Random();
            int x = rnd.Next(100, 1000);
            int y = rnd.Next(100, 600);

            var rect = new RectangleShape(new Rectangle(x, y, 100, 200));
            rect.FillColor = Color.White;

            Shapes.Add(rect);
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
