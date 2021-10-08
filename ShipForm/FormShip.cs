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
		private IShip iship;
		public FormShip()
		{
			InitializeComponent();
		}
		public void SetShip(IShip iship)
		{
			this.iship = iship; 
			Draw();

		}
		private void Draw()
		{
			Bitmap bmp = new Bitmap(pictureBoxShip.Width,pictureBoxShip.Height);
			Graphics g = Graphics.FromImage(bmp);
			iship?.DrawTransport(g);
			pictureBoxShip.Image = bmp;
		}
		private void buttonCreate_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			iship = new Ship(10,2, Color.LightGray);
			iship.SetPosition(rand.Next(150), rand.Next(150), pictureBoxShip.Width, pictureBoxShip.Height);
			Draw();
		}
        private void buttonRight_Click(object sender, EventArgs e)
        {
			string name = (sender as Button).Name;
			switch (name)
			{
				case "buttonUp":
					iship?.MoveTransport(Direction.Up);
					break;
				case "buttonDown":
					iship?.MoveTransport(Direction.Down);
					break;
				case "buttonLeft":
					iship?.MoveTransport(Direction.Left);
					break;
				case "buttonRight":
					iship?.MoveTransport(Direction.Right);
					break;
			}
			Draw();
		}

		private void buttonCreateSteamer_Click(object sender, EventArgs e)
		{
			Random rand = new Random();
			iship = new ClassSteamer(10, 2, Color.LightGray,Color.LightBlue,true,true);
			iship.SetPosition(rand.Next(150), rand.Next(150), pictureBoxShip.Width, pictureBoxShip.Height);
			Draw();
		}
	}
}
