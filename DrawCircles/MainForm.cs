namespace DrawCircles
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.MouseClick += (s, e) =>
            {
                Random rnd = new();
                int size = rnd.Next(0, 100);
                int x = e.X - size / 2;
                int y = e.Y - size / 2;

                Color color = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));

                Graphics g = this.CreateGraphics();

                g.DrawEllipse(new Pen(color, 5), x, y, size, size);

                g.Dispose();
            };
        }
    }
}