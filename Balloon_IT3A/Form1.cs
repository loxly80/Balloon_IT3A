using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Balloon_IT3A
{
    public partial class Form1 : Form
    {
        List<Balloon> balloons;

        public Form1()
        {
            InitializeComponent();
            balloons = new List<Balloon>();
            numSize.Maximum = 500;
            numSize.Value = 150;
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Balloon balloon = new Balloon();
            balloon.Location = new Point(random.Next(0, pboxCanvas.Width), random.Next(0, pboxCanvas.Height));
            balloon.Size = Convert.ToInt32(numSize.Value);
            //balloon.BalloonColor = Color.FromArgb(random.Next(0, 256), random.Next(0, 256), random.Next(0, 256));
            balloon.BalloonColor = pboxBalloonColor.BackColor;
            balloon.BasketColor = pboxBasket.BackColor;
            balloons.Add(balloon);
            pboxCanvas.Refresh();
        }

        private void pboxCanvas_Paint(object sender, PaintEventArgs e)
        {
            foreach (var balloon in balloons)
            {
                balloon.Draw(e.Graphics);
            }
        }

        private void pboxBalloonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pboxBalloonColor.BackColor;
            colorDialog1.ShowDialog();
            pboxBalloonColor.BackColor = colorDialog1.Color;
        }

        private void pboxBasket_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = pboxBasket.BackColor;
            colorDialog1.ShowDialog();
            pboxBasket.BackColor = colorDialog1.Color;
        }
    }
}
