using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipForm
{
    class ParkingCollection
    {
        readonly Dictionary<string, Parking<Ship>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;
        private readonly int pictureHeight;
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Ship>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight; 
        }
        public void AddParking(string name)
        {
            if (!parkingStages.ContainsKey(name))
            {
                parkingStages.Add(name,new Parking<Ship>(pictureWidth,pictureHeight));
            }
        }
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }
        public Parking<Ship> this[string ind]
        {
            get
            {
                return parkingStages[ind];
            }
        }
    }
}
