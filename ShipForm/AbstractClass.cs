using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
	public abstract class vessel:IShip
	{
        public Point StartPosition;
        protected int pictureWidth;
        protected int pictureHeight;
        public int MaxSpeed { protected set; get; }
        public float Weight { protected set; get; }
        public Color MainColor { protected set; get; }
        public abstract void DrawTransport(Graphics g);
        public abstract void MoveTransport(Direction direction);

        public void SetPosition(int x, int y,int width, int height)
        {
            StartPosition.X = x;
            StartPosition.Y = y;
            pictureWidth = width;
            pictureHeight = height;
        }
    }
}
