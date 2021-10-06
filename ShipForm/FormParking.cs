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
    public partial class FormParking : Form
    {
        private readonly Parking<Ship> parking;
        public FormParking()
        {
            InitializeComponent();
            parking = new Parking<Ship>(pictureBoxParking.Width, pictureBoxParking.Height);
            Draw();
        }
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
            Graphics gr = Graphics.FromImage(bmp);
            parking.Draw(gr);
            pictureBoxParking.Image = bmp;
        }

        private void ParkingShipButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog(); if (dialog.ShowDialog() == DialogResult.OK)
            {
                var ship = new Ship(100, 1000, dialog.Color);
                if (parking + ship)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void ParkingSteamerButton_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var ship = new ClassSteamer(100, 1000, dialog.Color, dialogDop.Color, true, true);
                    if (parking + ship)
                    {
                        Draw();
                    } 
                    else
                    {
                        MessageBox.Show("Парковка переполнена");
                    } 
                }
            }
        }

        private void PickUpButton_Click(object sender, EventArgs e)
        {
            if (maskedTextBox.Text != "")
            {
                var car = parking - Convert.ToInt32(maskedTextBox.Text); if (car != null)
                {
                    FormShip form = new FormShip(); form.SetCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }
    }

}
