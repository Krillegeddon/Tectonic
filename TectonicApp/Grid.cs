using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TectonicApp.Controls;

namespace TectonicApp
{
    public class Grid
    {
        public List<Square> Squares { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Grid(int width, int height)
        {
            Width = width;
            Height = height;
            Squares = new List<Square>();

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    var s = new Square(this, -1, x, y);
                    Squares.Add(s);
                }
            }
        }

        private List<Square> GetSquaresInArea(int areaIndex)
        {
            return Squares.Where(p => p.AreaIndex == areaIndex).ToList();
        }

        internal void RemoveOptionsBasedOnAreaSize()
        {
            foreach (var s in Squares)
            {
                foreach (var vn in s.ValidNumbers.ToList())
                {
                    if (vn > GetSquaresInArea(s.AreaIndex).Count)
                    {
                        s.ValidNumbers.Remove(vn);
                    }
                }
            }
        }

        public Square? GetSquare(int x, int y)
        {
            if (x < 0 || y < 0 || x >= Width || y >= Height)
            {
                return null;
                //throw new Exception($"No square at x: {x}, y: {y}");
            }

            return Squares.Where(p => p.X == x && p.Y == y).Single();
        }

        private int GetKnownNumber(int x, int y)
        {
            var s = GetSquare(x, y);
            if (s == null)
                return 0;
            return s.Number;
        }

        private List<int> GetKnownNumberAdjecent(int x, int y)
        {
            var retList = new List<int>();
            retList.Add(GetKnownNumber(x - 1, y - 1));
            retList.Add(GetKnownNumber(x, y - 1));
            retList.Add(GetKnownNumber(x + 1, y - 1));
            retList.Add(GetKnownNumber(x - 1, y));
            retList.Add(GetKnownNumber(x + 1, y));
            retList.Add(GetKnownNumber(x - 1, y + 1));
            retList.Add(GetKnownNumber(x, y + 1));
            retList.Add(GetKnownNumber(x + 1, y + 1));

            var retList2 = new List<int>();
            foreach (var n in retList)
            {
                if (!retList2.Contains(n))
                    retList2.Add(n);
            }

            return retList2;

        }


        internal void RemoveOptionsBasedOnAdjecantKnownNumbers()
        {
            foreach (var s in Squares)
            {
                if (s.Number > 0)
                    continue;
                var knowns = GetKnownNumberAdjecent(s.X, s.Y);
                foreach (var vn in s.ValidNumbers.ToList())
                {
                    if (knowns.Contains(vn))
                        s.ValidNumbers.Remove(vn);
                }
            }
        }

        private List<int> GetAllKnownNumberInArea(int areaIndex)
        {
            var squaresInArea = GetSquaresInArea(areaIndex);

            return squaresInArea.Where(p=>p.Number > 0).Select(p=>p.Number).ToList();
        }


        internal void RemoveOptionsBasedOnHavingKnownValueInSameArea()
        {
            foreach (var s in Squares)
            {
                var knowns = GetAllKnownNumberInArea(s.AreaIndex);
                foreach (var vn in s.ValidNumbers.ToList())
                {
                    if (knowns.Contains(vn))
                        s.ValidNumbers.Remove(vn);
                }
            }
        }

        internal void SetBasedOnOnlyOption()
        {
            foreach (var s in Squares)
            {
                if (s.Number > 0)
                    continue;

                if (s.ValidNumbers.Count == 1)
                    s.Number = s.ValidNumbers[0];
            }
        }

        private List<int> GetAreaIndexes()
        {
            return Squares.Select(p => p.AreaIndex).Distinct().ToList();
        }


        internal void SetBecauseOnlySquareInAreaHavingThisNumber()
        {
            foreach (var areaIndex in GetAreaIndexes())
            {
                var squares = GetSquaresInArea(areaIndex).Where(p=>p.Number == 0).ToList();

                for (int i = 0; i <= 9; i++)
                {
                    var squaresHavingIAsValidNumber = new List<Square>();
                    foreach (var s in squares)
                    {
                        if (s.ValidNumbers.Contains(i))
                            squaresHavingIAsValidNumber.Add(s);
                    }
                    if (squaresHavingIAsValidNumber.Count == 1)
                    {
                        squaresHavingIAsValidNumber[0].Number = i;
                    }
                }
            }

        }

        private List<Square> GetAdjacentSquares(Square square)
        {
            var retList = new List<Square>();
            var x = square.X;
            var y = square.Y;
            retList.Add(GetSquare(x - 1, y - 1));
            retList.Add(GetSquare(x, y - 1));
            retList.Add(GetSquare(x + 1, y - 1));
            retList.Add(GetSquare(x - 1, y));
            retList.Add(GetSquare(x + 1, y));
            retList.Add(GetSquare(x - 1, y + 1));
            retList.Add(GetSquare(x, y + 1));
            retList.Add(GetSquare(x + 1, y + 1));

            return retList;
        }

        private List<Square> GetAdjacentToMultiple(List<Square> list)
        {
            var retList = new List<Square>();
            var isFirst = true;
            foreach (var square in list)
            {
                var adjs = GetAdjacentSquares(square).Where(p=> p != null && p.AreaIndex != square.AreaIndex && p.Number == 0).ToList();
                if (isFirst)
                {
                    retList.AddRange(adjs);
                    isFirst = false;
                    continue;
                }

                foreach (var r in retList.ToList())
                {
                    if (!adjs.Where(p => p.X == r.X && p.Y == r.Y).Any())
                    {
                        retList.Remove(r);
                    }
                }

            }

            return retList;
        }

        internal void RemoveOptionsOneNumberInAnAreaChokesAdjacentCellsInOtherAreas()
        {
            for (int i = 1; i <= 9; i++)
            {
                foreach (var areaIndex in GetAreaIndexes())
                {
                    var ssx = GetSquaresInArea(areaIndex);

                    // Get one area at the time... and see which cells have the number i.
                    var squaresInMyAreaWithIAsAvailable = GetSquaresInArea(areaIndex).Where(p=>p.Number ==0 && p.ValidNumbers.Contains(i)).ToList();
                    var adjToThose = GetAdjacentToMultiple(squaresInMyAreaWithIAsAvailable);
                    foreach (var adj in adjToThose)
                    {
                        adj.ValidNumbers.Remove(i);
                    }
                }
            }
        }

        private void RemoveOptionsFromSquare(Square square, List<int> numbersToRemove)
        {
            foreach (var nn in square.ValidNumbers.ToList())
            {
                if (numbersToRemove.Contains(nn))
                    square.ValidNumbers.Remove(nn);
            }
        }

        internal void APairWillChokeAllAdjacentCells()
        {
            foreach (var s in Squares.Where(p => p.ValidNumbers.Count == 2 && p.Number == 0).ToList())
            {
                var pairs = new List<Square>();

                var adjs = GetAdjacentSquares(s).Where(p=> p != null && p.Number == 0).ToList();
                foreach (var adj in adjs)
                {
                    if (adj.ValidNumbers.Count != s.ValidNumbers.Count)
                        continue;
                    for (var ix = 0; ix < s.ValidNumbers.Count; ix++)
                    {
                        if (adj.ValidNumbers[ix] != s.ValidNumbers[ix])
                            goto notSame;
                    }

                    // We have a pair! Let's check all adjacent cells to these guys and remove these two numbers!
                    pairs.Add(adj);

                notSame:
                    int bb = 9;

                }

                foreach (var possiblePair in pairs)
                {
                    var list = new List<Square>()
                    {
                        s, possiblePair
                    };
                    var pairAdj = GetAdjacentToMultiple(list);

                    // We found adjecent cells to this pair! Remove the two number as valid numbers on them!
                    foreach (var ss in pairAdj)
                    {
                        RemoveOptionsFromSquare(ss, s.ValidNumbers);
                    }
                }
            }
        }


        internal void APairWillChokeAllCellsInSameArea()
        {
            foreach (var s in Squares.Where(p => p.ValidNumbers.Count == 2 && p.Number == 0).ToList())
            {
                if (s.X == 3 && s.Y == 1)
                {
                    int bb = 9;
                }

                var pairs = new List<Square>();

                var adjs = GetSquaresInArea(s.AreaIndex).Where(p => p != null && p.Number == 0 && !(p.X == s.X && p.Y == s.Y)).ToList();
                foreach (var adj in adjs)
                {
                    if (adj.ValidNumbers.Count != s.ValidNumbers.Count)
                        continue;
                    for (var ix = 0; ix < s.ValidNumbers.Count; ix++)
                    {
                        if (adj.ValidNumbers[ix] != s.ValidNumbers[ix])
                            goto notSame;
                    }

                    // We have a pair! Let's check all adjacent cells to these guys and remove these two numbers!
                    pairs.Add(adj);

                notSame:
                    int bb = 9;
                }

                if (pairs.Count != 1)
                    continue;


                var othersInSameArea = GetSquaresInArea(s.AreaIndex).Where(p => p != null && p.Number == 0 && !(p.X == s.X && p.Y == s.Y) && !(p.X == pairs[0].X && p.Y == pairs[0].Y)).ToList();
                foreach (var ss in othersInSameArea)
                {
                    RemoveOptionsFromSquare(ss, s.ValidNumbers);
                }
            }

        }



    }
}
