namespace LineDrawer
{
    public partial class MainForm : Form
    {
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing;
        public MainForm()
        {
            InitializeComponent();

            isDrawing = false;

            this.MouseDown += (s, e) =>
            {
                startPoint = e.Location;
                isDrawing = true;
            };

            this.MouseMove += (s, e) =>
            {
                if (isDrawing)
                {
                    endPoint = e.Location;
                    this.Invalidate();
                }
            };
            this.MouseUp += (s, e) => isDrawing = false;
            this.Paint += (s, e) =>
            {
                if (isDrawing)
                {
                    using (Graphics g = this.CreateGraphics())
                    {
                        g.DrawLine(Pens.Black, startPoint, endPoint);
                    }
                }
            };
        }
    }
}