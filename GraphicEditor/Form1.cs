using GraphicEditor.Services;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {
        private ShapeService shapeService = new ShapeService();
        public Form1()
        {
            InitializeComponent();
        }

        private void DrawRectangleBtn_Click(object sender, EventArgs e)
        {
            shapeService.AddRandomRectangle();

            //statusBar.Items[0].Text = "Последно действие: Рисуване на правоъгълник";
            Invalidate();
        }

        private void SelectShapeBtn_Click(object sender, EventArgs e)
        {

        }

        private void ReDraw(object sender, PaintEventArgs e)
        {
            //TODO see ReDraw in dialogProcessor. There is a graphics setting
            shapeService.Draw(e.Graphics);
        }
    }
}