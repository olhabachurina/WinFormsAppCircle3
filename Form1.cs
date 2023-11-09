namespace WinFormsAppCircle3
{
    public partial class Form1 : Form
    {
            private readonly Random random = new Random();
            public Form1()
            {
                InitializeComponent();
                this.MouseClick += Forma1_MouseClick;
            }
            private void Forma1_MouseClick(object? sender, MouseEventArgs e)
            {
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                int randomSize = random.Next(10, 100);
                int centerX = e.X - randomSize / 2;
                int centerY = e.Y - randomSize / 2;
                using (Graphics g = this.CreateGraphics())
                {
                    g.FillEllipse(new SolidBrush(randomColor), centerX, centerY, randomSize, randomSize);// залитая форма
                    /* g.DrawEllipse(new Pen(randomColor), centerX, centerY, randomSize, randomSize);//контур окружности без заливки*/
                }
            }
        }
    }
