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
    public partial class Form1 : Form
    {
        IShip ship = null;
        public Form1()
        {
            InitializeComponent();
        }
        private void DrawShip()
        {
            if (ship != null)
            {
                
                Bitmap bmp = new Bitmap(pictureBoxForCreate.Width, pictureBoxForCreate.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ship.SetPosition(5, 5, pictureBoxForCreate.Width, pictureBoxForCreate.Height);
                ship.DrawTransport(gr);
                pictureBoxForCreate.Image = bmp;
            }
        }


        private void CreateShipLabel_MouseDown(object sender, MouseEventArgs e)
        {
            CreateShipLabel.DoDragDrop(CreateShipLabel.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void CreateSteamerLabel_MouseDown(object sender, MouseEventArgs e)
        {
            CreateSteamerLabel.DoDragDrop(CreateSteamerLabel.Text, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Ship":
                    ship = new Ship(100, 500, Color.White);
                    break;
                case "Steamer":
                    ship = new ClassSteamer(100, 500, Color.White, Color.Black, true, true);
                    break;
            }
            DrawShip();
        }

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }
    }
}
