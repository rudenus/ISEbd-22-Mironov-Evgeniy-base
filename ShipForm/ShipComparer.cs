using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    public class ShipComparer : IComparer<Vessel>
    {
        public int Compare(Vessel x, Vessel y)
        {
            if (x is Ship && y is Ship)
            {
                return ComparerShip(x as Ship, y as Ship);
            }
            if (x is ClassSteamer && y is ClassSteamer)
            {
                return ComparerSteamer(x as ClassSteamer, y as ClassSteamer);
            }
            if (x is ClassSteamer && y is Ship)
            {
                return -1;
            }
            if (x is Ship && y is ClassSteamer)
            {
                return 1;
            }
            return 0;
        }
        private int ComparerShip(Ship x, Ship y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }
        private int ComparerSteamer(ClassSteamer x, ClassSteamer y)
        {
            var res = ComparerShip(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.drawPipe != y.drawPipe)
            {
                return x.drawPipe.CompareTo(y.drawPipe);
            }
            if (x.drawWindow != y.drawWindow)
            {
                return x.drawWindow.CompareTo(y.drawWindow);
            }
            return 0;
        }

    }
}
