using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
	public interface IShip
	{
		void SetPosition(int x, int y,int width,int weight);
		void MoveTransport(Direction direction);
		void DrawTransport(Graphics g);
		void SetMainColor(Color color);
	}
}
