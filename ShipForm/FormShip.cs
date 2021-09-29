using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShipForm
{
	public partial class FormShip : Form
	{
		//Graphics g;
		Ship motorShip;
		public FormShip()
		{
			InitializeComponent();
		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxShip.Width,pictureBoxShip.Height);
			Graphics g = Graphics.FromImage(bmp);
			motorShip.DrawTransport(g);
			pictureBoxShip.Image = bmp;
		}
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			motorShip = new Ship(10,2, Color.LightGray);
			motorShip.SetPosition(rand.Next(150), rand.Next(150), pictureBoxShip.Width, pictureBoxShip.Height);
			Draw();
		}
        private void buttonRight_Click(object sender, EventArgs e)
        {
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					motorShip.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					motorShip.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					motorShip.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					motorShip.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}

		private void buttonCreateSteamer_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			motorShip = new ClassSteamer(10, 2, Color.LightGray,Color.LightBlue,true,true);
			motorShip.SetPosition(rand.Next(150), rand.Next(150), pictureBoxShip.Width, pictureBoxShip.Height);
			Draw();
		}
	}
}
