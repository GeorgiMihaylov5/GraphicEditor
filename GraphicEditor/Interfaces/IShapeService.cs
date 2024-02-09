using GraphicEditor.Models;

namespace GraphicEditor.Interfaces
{
    public interface IShapeService
    {
        public IList<IShape> Shapes { get; set; }
        public IShape Selected { get; set; }
        public bool IsDragging { get; set; }
        public PointF LastLocation { get; set; }
        public void AddRandomShape<T>(int width = 100, int height = 200) where T : IShape, new();
        public IShape ContainsPoint(PointF point);
        public void TranslateTo(PointF p);
        public void RotateSelected(int angle);
    }
}
