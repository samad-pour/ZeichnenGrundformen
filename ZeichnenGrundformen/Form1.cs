namespace ZeichnenGrundformen
{
    public partial class Form1 : Form
    {
        private Graphics z;
        private Pen stift = new Pen(Color.Red, 2);
        private SolidBrush pinsel = new SolidBrush(Color.Red);
        private Color[] colorFeld =
        { Color.Red, Color.Green, Color.Blue };

        public Form1()
        {
            InitializeComponent();

            z = CreateGraphics();
            LstFarbe.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnLinie_Click(object sender, EventArgs e)
        {
            z.DrawLine(stift, 100, 40, 100, 60);
        }

        private void BtnRechteck_Click(object sender, EventArgs e)
        {
            if (ChkFuellen.Checked)
            {
                z.FillRectangle(pinsel, 10, 10, 180, 180);
                ChkFuellen.Checked = false;
            }
            else
                z.DrawRectangle(stift, 10, 10, 180, 180);
        }

        private void BtnPolygon_Click(object sender, EventArgs e)
        {
            Point[] point_feld = { new Point(90, 80), new Point(110, 80), new Point(100, 120) };
            if (ChkFuellen.Checked)
            {
                z.FillPolygon(pinsel, point_feld);
                ChkFuellen.Checked = false;
            }
            else
                z.DrawPolygon(stift, point_feld);
        }

        private void BtnEllipse_Click(object sender, EventArgs e)
        {
            if (ChkFuellen.Checked)
            {
                z.FillEllipse(pinsel, 10, 10, 180, 180);
                ChkFuellen.Checked = false;
            }
            else
                z.DrawEllipse(stift, 10, 10, 180, 180);
        }

        private void NumPenWidth_ValueChanged(object sender, EventArgs e)
        {
            stift.Width = (float)NumPenWidth.Value;
        }

        private void LstFarbe_SelectedIndexChanged(object sender, EventArgs e)
        {
            stift.Color = colorFeld[LstFarbe.SelectedIndex];
            pinsel.Color = colorFeld[LstFarbe.SelectedIndex];
        }

        private void BtnLoeschen_Click(object sender, EventArgs e)
        {
            z.Clear(BackColor);
        }
    }
}