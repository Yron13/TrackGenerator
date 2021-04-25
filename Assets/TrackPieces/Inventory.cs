using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.TrackPieces
{
    public enum Shape
    {
        STRAIGHT,
        RIGHT,
        LEFT,
        WIDERIGHT,
        WIDELEFT
    }

    class Inventory
    {
        private Dictionary<Shape, int> count;

        public Inventory(Dictionary<Shape, int> count)
        {
            this.count = count;
        }

        void Place(Shape shape)
        {
            count[shape]--;
        }

        void PutBack(Shape shape)
        {
            count[shape]++;
        }

        //void ReadFromFile(string filename)
        //{

        //}

        //void WriteToFile(string filename)
        //{
        //    string data = JsonConvert.SerializeObject(count, Newtonsoft.Json.Formatting.Indented);
        //    File.WriteAllText(@"D:\path.json", data);
        //}
    }


}
