using GraphicEditor.Models;

namespace GraphicEditor.Interfaces
{
    public interface IShapeService
    {
        public IList<IShape> Shapes { get; set; }
        public IShape Selected { get; set; }
        public bool IsDragging { get; set; }
        public PointF LastLocation { get; set; }
        public void AddRandomRectangle();
        public void AddRandomEllipse();
        public void AddRandomCircle();
        public IShape ContainsPoint(PointF point);
        public void TranslateTo(PointF p);
        public void RotateSelected(int angle);
    }
}
