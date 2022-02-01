using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Balloon_IT3A
{
    public class Balloon
    {
        public Point Location { get; set; }
        public int Size { get; set; }
        public Color BalloonColor { get; set; }
        public Color BasketColor { get; set; }

        public Balloon()
        {
            Location = new Point();
            Size = 100;
            BalloonColor = Color.Yellow;
            BalloonColor = Color.Red;
        }

        public void Draw(Graphics graphics)
        {
            Pen pen = new Pen(Color.Black);
            pen.Width = Size / 50;
            Brush brushBallon = new SolidBrush(BalloonColor);
            Brush brushBasket = new SolidBrush(BasketColor);
            var basketWidth = Size / 3;
            var basketHeight = (3 * basketWidth) / 4;

            graphics.DrawLine(pen, Location.X - basketWidth / 2, Location.Y + Size - basketHeight, Location.X - Size / 2, Location.Y);

            graphics.FillRectangle(brushBasket, Location.X - basketWidth / 2, Location.Y + Size - basketHeight, basketWidth, basketHeight);
            graphics.DrawRectangle(pen, Location.X - basketWidth / 2, Location.Y + Size - basketHeight, basketWidth, basketHeight);

            graphics.FillEllipse(brushBallon, Location.X - Size / 2, Location.Y - Size / 2, Size, Size);
            graphics.DrawEllipse(pen, Location.X - Size / 2, Location.Y - Size / 2, Size, Size);
        }
    }
}
