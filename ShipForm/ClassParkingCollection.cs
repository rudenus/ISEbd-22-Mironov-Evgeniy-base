using System;
using System.Collections.Generic;
using System.IO;
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
        private readonly char separator = ':';
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
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"ParkingCollection{Environment.NewLine}");
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    fs.Write($"Parking{separator}{level.Key}{Environment.NewLine}");
                    IShip ship = null;
                    for (int i = 0; (ship = level.Value.GetNext(i)) != null; i++)
                    {
                        if (ship != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (ship.GetType().Name == "Ship")
                            {
                                fs.Write($"Ship{separator}");
                            }
                            if (ship.GetType().Name == "ClassSteamer")
                            {
                                fs.Write($"ClassSteamer{separator}");
                            }
                            //Записываемые параметры
                            fs.Write(ship + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (StreamReader fs = new StreamReader(filename))
            {

                bufferTextFromFile = fs.ReadLine();

                if (bufferTextFromFile.Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    return false;
                }
                Ship car = null;
                string key = string.Empty;
                while(!fs.EndOfStream)
                {

                    //идем по считанным записям
                    bufferTextFromFile = fs.ReadLine();
                    if (bufferTextFromFile.Contains("Parking"))
                    {
                        //начинаем новую парковку
                        key = bufferTextFromFile.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Ship>(pictureWidth, pictureHeight));
                        continue;
                    }
                    if (string.IsNullOrEmpty(bufferTextFromFile))
                    {
                        continue;
                    }
                    if (bufferTextFromFile.Split(separator)[0] == "Ship")
                    {
                        car = new Ship(bufferTextFromFile.Split(separator)[1]);
                    }
                    else if (bufferTextFromFile.Split(separator)[0] == "ClassSteamer")
                    { 
                        car = new ClassSteamer(bufferTextFromFile.Split(separator)[1]);
                    }
                    var result = parkingStages[key] + car;
                    if (!result)
                    {
                        return false;
                    }
                }

            }
            return true;
        }
    }


}

