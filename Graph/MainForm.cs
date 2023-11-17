namespace Graph
{
    public partial class MainForm : Form
    {
        private const int ChartWidth = 600;
        private const int ChartHeight = 400;
        private const int Margin = 30;

        private Point origin;
        private Pen axisPen;
        private Pen graphPen;
        private Font axisFont;
        public MainForm()
        {
            InitializeComponent();

            ClientSize = new Size(ChartWidth + 2 * Margin, ChartHeight + 2 * Margin);
            Text = "Currency Exchange Rate Graph";

            origin = new Point(Margin, ChartHeight + Margin);

            axisPen = new Pen(Color.Black, 2);
            graphPen = new Pen(Color.Blue, 2);
            axisFont = new Font("Arial", 8);

            Paint += (s, e) =>
            {
                DrawAxes(e.Graphics);
                DrawGraph(e.Graphics);
            };

        }

        private void DrawAxes(Graphics g)
        {
            g.DrawLine(axisPen, origin.X, origin.Y, origin.X + ChartWidth, origin.Y);
            g.DrawLine(axisPen, origin.X, origin.Y, origin.X, origin.Y - ChartHeight);

            int numDivisions = 5;
            float divisionSpacingX = ChartWidth / (float)numDivisions;
            float divisionSpacingY = ChartHeight / (float)numDivisions;

            for (int i = 1; i <= numDivisions; i++)
            {
                float x = origin.X + i * divisionSpacingX;
                g.DrawLine(axisPen, x, origin.Y - 5, x, origin.Y + 5);
                g.DrawString(i.ToString(), axisFont, Brushes.Black, x - 10, origin.Y + 5);
            }

            for (int i = 1; i <= numDivisions; i++)
            {
                float y = origin.Y - i * divisionSpacingY;
                g.DrawLine(axisPen, origin.X - 5, y, origin.X + 5, y);
                g.DrawString(i.ToString(), axisFont, Brushes.Black, origin.X - 25, y - 7);
            }
        }

        private void DrawGraph(Graphics g)
        {

            float[] exchangeRates = { 1.2f, 1.5f, 1.8f, 2.0f, 1.7f, 1.3f, 1.6f, 1.9f, 2.2f, 2.5f, 2.3f, 2.1f };

            float xScale = ChartWidth / (float)(exchangeRates.Length - 1);
            float yScale = ChartHeight / 3.0f;
            for (int i = 0; i < exchangeRates.Length - 1; i++)
            {
                float x1 = origin.X + i * xScale;
                float y1 = origin.Y - exchangeRates[i] * yScale;

                float x2 = origin.X + (i + 1) * xScale;
                float y2 = origin.Y - exchangeRates[i + 1] * yScale;

                g.DrawLine(graphPen, x1, y1, x2, y2);
            }
        }
    }
}