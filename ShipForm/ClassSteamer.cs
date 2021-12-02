using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
	class ClassSteamer: Ship
    {
        public Color DopColor { private set; get; }
        public bool drawPipe;
        public bool drawWindow;
        public ClassSteamer(int maxSpeed, int weight, Color mainColor, Color dopColor,
bool drawWindow, bool drawPipe) :
 base(maxSpeed, weight, mainColor, 170, 180)
        {
            DopColor = dopColor;
            this.drawPipe = drawPipe;
            this.drawWindow = drawWindow;
        }
		public ClassSteamer(string info) : base(info)
		{
			string[] strs = info.Split(separator);
			if (strs.Length == 6)
			{
				MaxSpeed = Convert.ToInt32(strs[0]);
				Weight = Convert.ToInt32(strs[1]);
				MainColor = Color.FromArgb(Convert.ToInt32(strs[2]));
				DopColor = Color.FromArgb(Convert.ToInt32(strs[3]));
				drawPipe = Convert.ToBoolean(strs[4]);
				drawWindow = Convert.ToBoolean(strs[5]);
			}
		}

		public override void DrawTransport(Graphics g)
        {
			base.DrawTransport(g);
			Brush brushDop = new SolidBrush(DopColor);
			Pen pen = Pens.Black;
			if (drawPipe)
			{
				g.DrawRectangle(pen, StartPosition.X + 20, StartPosition.Y + 20, 20, 49);
				g.FillRectangle(Brushes.LightGray, StartPosition.X + 21, StartPosition.Y + 21, 19, 48);
			}
			if (drawWindow)
			{
				g.DrawEllipse(pen, StartPosition.X + 30, StartPosition.Y + 120, 10, 10);
				g.DrawEllipse(pen, StartPosition.X + 45, StartPosition.Y + 120, 10, 10);
				g.DrawEllipse(pen, StartPosition.X + 60, StartPosition.Y + 120, 10, 10);
				g.DrawEllipse(pen, StartPosition.X + 75, StartPosition.Y + 120, 10, 10);
				g.DrawEllipse(pen, StartPosition.X + 90, StartPosition.Y + 120, 10, 10);
				g.FillEllipse(brushDop, StartPosition.X + 90, StartPosition.Y + 120, 10, 10);
				g.FillEllipse(brushDop, StartPosition.X + 75, StartPosition.Y + 120, 10, 10);
				g.FillEllipse(brushDop, StartPosition.X + 60, StartPosition.Y + 120, 10, 10);
				g.FillEllipse(brushDop, StartPosition.X + 45, StartPosition.Y + 120, 10, 10);
				g.FillEllipse(brushDop, StartPosition.X + 30, StartPosition.Y + 120, 10, 10);
			}
		}
		public void SetDopColor(Color color)
		{
			DopColor = color;
		}
		public override string ToString()
		{
			return
		   $"{base.ToString()}{separator}{DopColor.ToArgb()}{separator}{drawPipe}{separator}{drawWindow}";
 }


	}
}
