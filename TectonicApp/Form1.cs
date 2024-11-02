using System.Text.Json;
using TectonicApp.Controls;

namespace TectonicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _isAddingSquares = false;
        private int _areaIndex = -1;
        public Grid _grid;

        public List<Color> _colors = new List<Color>
        {
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray,
            Color.Beige, Color.Bisque,
        };

        public List<SquareCpt> _squareComponents = new List<SquareCpt>();

        public void AddSquare(int x, int y, SquareCpt sq)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                if (!_isAddingSquares)
                {
                    _areaIndex++;
                    _isAddingSquares = true;
                    labelNextColor.BackColor = _colors[_areaIndex];
                }

                labelDebug.Text = $"{x}, {y}";
                sq.SetGroup(_colors[_areaIndex], _areaIndex);
            }
            else
            {
                _isAddingSquares = false;
                labelNextColor.BackColor = _colors[_areaIndex + 1];

            }
        }

        public void Repaint()
        {
            foreach (var cc in _squareComponents)
            {
                cc.Repaint();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _areaIndex++;
            labelNextColor.BackColor = _colors[_areaIndex + 1];
        }

        private void buttonAreaCount_Click(object sender, EventArgs e)
        {
            _grid.RemoveOptionsBasedOnAreaSize();
            Repaint();
        }

        private void buttonAdjacent_Click(object sender, EventArgs e)
        {
            _grid.RemoveOptionsBasedOnAdjecantKnownNumbers();
            Repaint();
        }

        private void buttonRemoveSameArea_Click(object sender, EventArgs e)
        {
            _grid.RemoveOptionsBasedOnHavingKnownValueInSameArea();
            Repaint();
        }

        private void buttonSetOnlyOption_Click(object sender, EventArgs e)
        {
            _grid.SetBasedOnOnlyOption();
            Repaint();
        }

        private void buttonSetOnlySqInAreaHavingThisNumber_Click(object sender, EventArgs e)
        {
            _grid.SetBecauseOnlySquareInAreaHavingThisNumber();
            Repaint();
        }

        private void buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas_Click(object sender, EventArgs e)
        {
            _grid.RemoveOptionsOneNumberInAnAreaChokesAdjacentCellsInOtherAreas();
            Repaint();
        }

        private void Remove()
        {
            for (int i = 0; i < 10; i++)
            {
                _grid.RemoveOptionsBasedOnAreaSize();
                _grid.RemoveOptionsBasedOnAdjecantKnownNumbers();
                _grid.RemoveOptionsBasedOnHavingKnownValueInSameArea();
                _grid.RemoveOptionsOneNumberInAnAreaChokesAdjacentCellsInOtherAreas();
            }
        }


        private void buttonRunOne_Click(object sender, EventArgs e)
        {
            Repaint();
            Remove();
            _grid.SetBasedOnOnlyOption();
            Remove();
            _grid.SetBecauseOnlySquareInAreaHavingThisNumber();
            Repaint();
        }

        private void buttonCreateBoard_Click(object sender, EventArgs e)
        {
            _grid = new Grid(int.Parse(textBoxWidth.Text), int.Parse(textBoxHeight.Text));
            for (int x = 0; x < _grid.Width; x++)
            {
                for (int y = 0; y < _grid.Height; y++)
                {
                    var cc = new SquareCpt(this, x, y, _grid.GetSquare(x, y));
                    tableGrid.Controls.Add(cc, x, y);
                    _squareComponents.Add(cc);
                    cc.Repaint();
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var jsonstring = JsonSerializer.Serialize(_grid);
            File.WriteAllText("c:\\Temp\\Grid.json", jsonstring);
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _grid = JsonSerializer.Deserialize<Grid>(File.ReadAllText("c:\\Temp\\Grid.json"));
            for (int x = 0; x < _grid.Width; x++)
            {
                for (int y = 0; y < _grid.Height; y++)
                {
                    var cc = new SquareCpt(this, x, y, _grid.GetSquare(x, y));
                    tableGrid.Controls.Add(cc, x, y);
                    _squareComponents.Add(cc);
                    cc.Repaint();
                }
            }
        }
    }
}