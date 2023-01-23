using System;
using System.Drawing;
using System.Windows.Forms;

namespace Figures
{
    public partial class FiguresForm : Form
    {
        Random rnd = new Random();
        Bitmap bitmap;
        Graphics graphics;
        Rectangle rectangle;
        int xrec, yrec;
        Rectangle circle;
        int xcirc, ycirc;
        Rectangle ellipse;
        int xell, yell;

        int xspeedrec, yspeedrec;
        int xspeedcirc, yspeedcirc;
        int xspeedell, yspeedell;

        public int widthrec, heightrec;
        public int radiuscirc;
        public int widthell, heightell;
        private void backgroundPic_Click(object sender, EventArgs e)
        {

        }       
        public FiguresForm()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Motion();
            backgroundPic.Refresh();
        }

        private void FiguresForm_Load(object sender, EventArgs e)
        {            
            xrec = rnd.Next(0, background.Right - widthrec);
            yrec = rnd.Next(0, background.Bottom - heightrec);
            xspeedrec = rnd.Next(4, 10);
            yspeedrec = rnd.Next(4, 10);
                       
            xcirc = rnd.Next(0, background.Right - radiuscirc);
            ycirc = rnd.Next(0, background.Bottom - radiuscirc);
            xspeedcirc = rnd.Next(4, 10);
            yspeedcirc = rnd.Next(4, 10);
                       
            xell = rnd.Next(0, background.Right - widthell);
            yell = rnd.Next(0, background.Bottom - heightell);
            xspeedell = rnd.Next(4, 10);
            yspeedell = rnd.Next(4, 10);
            
            Draw(xrec, yrec, xcirc, ycirc, xell, yell);
        }

        private void Draw(int x_Rec, int y_Rec, int x_Circ, int y_Circ, int x_Ellipse, int y_Ellipse)
        {
            bitmap = new Bitmap(backgroundPic.Width, backgroundPic.Height);
            graphics = Graphics.FromImage(bitmap);

            Pen pen = new Pen(Color.Pink, 4);
            graphics.DrawRectangle(pen, x_Rec, y_Rec, widthrec, heightrec);
            rectangle = new Rectangle(x_Rec, y_Rec, widthrec, heightrec);

            Pen pen2 = new Pen(Color.Aqua, 4);
            circle = new Rectangle(x_Circ, y_Circ, radiuscirc, radiuscirc);
            graphics.DrawEllipse(pen2, circle);

            Pen pen3 = new Pen(Color.Purple, 4);
            ellipse = new Rectangle(x_Ellipse, y_Ellipse, widthell, heightell);
            graphics.DrawEllipse(pen3, ellipse);
            
            backgroundPic.Image = bitmap;
        }

        private void Motion()
        {
            xrec += xspeedrec;
            yrec += yspeedrec;
            if ((xrec + rectangle.Width >= (background.Right - xspeedrec) || (xrec <= (background.Left - xspeedrec))))
                xspeedrec = -xspeedrec;
            if ((yrec + rectangle.Height >= background.Bottom - yspeedrec) || (yrec <= background.Top - yspeedrec))
                yspeedrec = -yspeedrec;

            xcirc += xspeedcirc;
            ycirc += yspeedcirc;
            if ((xcirc + circle.Width >= background.Right - xspeedcirc) || (xcirc <= background.Left - xspeedcirc))
                xspeedcirc = -xspeedcirc;
            if ((ycirc + circle.Height >= background.Bottom - yspeedcirc) || (ycirc <= background.Top - yspeedcirc))
                yspeedcirc = -yspeedcirc;

            xell += xspeedell;
            yell += yspeedell;
            if ((xell + ellipse.Width >= background.Right - xspeedell) || (xell <= background.Left - xspeedell))
                xspeedell = -xspeedell;
            if ((yell + ellipse.Height >= background.Bottom - yspeedell) || (yell <= background.Top - yspeedell))
                yspeedell = -yspeedell;

            Draw(xrec, yrec, xcirc, ycirc, xell, yell);
        }

        private void FiguresForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
