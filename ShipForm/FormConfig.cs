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
    public partial class FormConfig : Form
    {
        Vessel ship = null;
        public Action<Vessel> eventAddShip;
        public FormConfig()
        {
            InitializeComponent();
            buttonClose.Click += (object sender, EventArgs e) => { Close(); };
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

        public void AddEvent(Action<Vessel> ev)
        {
            if (eventAddShip == null)
            {
                eventAddShip = new Action<Vessel>(ev);
            }
            else
            {
                eventAddShip += ev;
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
                    ship = new Ship((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Steamer":
                    ship = new ClassSteamer((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, 
                        Color.Black, checkBoxWindow.Checked, checkBoxPipe.Checked);
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

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Panel temp = sender as Panel;
            CreateSteamerLabel.DoDragDrop(temp.BackColor, DragDropEffects.Move |
DragDropEffects.Copy);
        }

        private void labelMColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelMColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                ship.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShip();
            }
        }

        private void labelDColor_DragDrop(object sender, DragEventArgs e)
        {
            if (ship != null)
            {
                var temp = sender as Panel;
                if(ship is ClassSteamer)
                {
                    (ship as ClassSteamer).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShip();

                }

            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            eventAddShip?.Invoke(ship);
            Close();

        }

    }
}
