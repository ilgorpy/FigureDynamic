using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figures
{
    public partial class Menu : Form
    {

        FiguresForm figureForm_;
        Random rnd = new Random();
        public Menu()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            figureForm_ = new FiguresForm();
            
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    figureForm_.timer1.Interval = 100;                    
                    break;
                case 1:
                    figureForm_.timer1.Interval = 75;                    
                    break;
                case 2:
                    figureForm_.timer1.Interval = 50;                 
                    break;
                case 3:
                    figureForm_.timer1.Interval = 25;                  
                    break;
            }
            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    figureForm_.widthrec = rnd.Next(50, 50);
                    figureForm_.heightrec = rnd.Next(50, 50);
                    figureForm_.radiuscirc = rnd.Next(50, 50);
                    figureForm_.widthell = rnd.Next(50, 100);
                    figureForm_.heightell = rnd.Next(50, 100);
                    break;
                case 1:
                    figureForm_.widthrec = rnd.Next(100, 100);
                    figureForm_.heightrec = rnd.Next(100, 100);
                    figureForm_.radiuscirc = rnd.Next(100, 100);
                    figureForm_.widthell = rnd.Next(75, 150);
                    figureForm_.heightell = rnd.Next(75, 150);
                    break;
                case 2:
                    figureForm_.widthrec = rnd.Next(150, 150);
                    figureForm_.heightrec = rnd.Next(150, 150);
                    figureForm_.radiuscirc = rnd.Next(200, 200);
                    figureForm_.widthell = rnd.Next(200, 200);
                    figureForm_.heightell = rnd.Next(100, 175);
                    break;
            }
            figureForm_.Show();
            Hide();
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
