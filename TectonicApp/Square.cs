using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TectonicApp
{
    public class Square
    {
        //public Grid Grid { get; set; }
        public int AreaIndex { get; set; }

        public List<int> ValidNumbers { get; set; }
        public int Number { get; set; }
        public int X {get; set; }
        public int Y { get; set; }

        // For JSON deserialization
        public Square()
        {
        }

        public Square(Grid grid, int areaIndex, int x, int y)
        {
            AreaIndex = areaIndex;
            X = x;
            Y = y;
            Number = 0;
            ValidNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        }

        public Square(Grid grid, int areaIndex, int x, int y, int knownNumber)
        {
            AreaIndex = areaIndex;
            X = x;
            Y = y;
            Number = knownNumber;
            ValidNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7 };
        }

    }
}
