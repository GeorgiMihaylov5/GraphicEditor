using GraphicEditor.Interfaces;
using GraphicEditor.Services;

namespace GraphicEditor
{
    public partial class Form1 : Form
    {
        private readonly IShapeService shapeService;
        private readonly IDrawService drawService;

        public Form1(IShapeService shapeService, IDrawService drawService)
        {
            InitializeComponent();
            this.shapeService = shapeService;
            this.drawService = drawService;
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
            drawService.Draw(e.Graphics, shapeService.Shapes);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}