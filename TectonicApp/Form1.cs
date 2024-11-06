using System.Text.Json;
using System.Windows.Forms;
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
            Color.LightBlue, Color.Pink, Color.LightGreen, Color.LightGray, Color.Azure,
            Color.Purple, Color.LightCoral, Color.Yellow, Color.Orange,
        };

        public List<SquareCpt> _squareComponents = new List<SquareCpt>();

        public Color GetColor(int index)
        {
            return _colors[index % _colors.Count];
        }

        public void AddSquare(int x, int y, SquareCpt sq)
        {
            if ((Control.ModifierKeys & Keys.Shift) == Keys.Shift)
            {
                if (!_isAddingSquares)
                {
                    _areaIndex++;
                    _isAddingSquares = true;
                    labelNextColor.BackColor = GetColor(_areaIndex);
                }

                labelDebug.Text = $"{x}, {y}";
                sq.SetGroup(GetColor(_areaIndex), _areaIndex);
            }
            else
            {
                _isAddingSquares = false;
                labelNextColor.BackColor = GetColor(_areaIndex + 1);

            }
        }

        public void Repaint()
        {
            foreach (var cc in _squareComponents)
            {
                cc.SuspendLayout();
            }
            foreach (var cc in _squareComponents)
            {
                cc.Repaint();
            }
            foreach (var cc in _squareComponents)
            {
                cc.ResumeLayout();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _areaIndex++;
            labelNextColor.BackColor = GetColor(_areaIndex + 1);
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
            Remove();
            _grid.APairWillChokeAllAdjacentCells();
            Repaint();
            _grid.APairWillChokeAllCellsInSameArea();
            Repaint();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var jsonstring = JsonSerializer.Serialize(_grid);
            File.WriteAllText("c:\\Temp\\Grid.json", jsonstring);
        }

        private void SetupGrid()
        {
            tableGrid.RowCount = _grid.Height;
            tableGrid.ColumnCount = _grid.Width;

            tableGrid.RowStyles.Clear();
            tableGrid.ColumnStyles.Clear();

            for (int i = 0; i < tableGrid.ColumnCount; i++)
            {
                tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F)); // 60 pixels wide
            }

            for (int i = 0; i < tableGrid.RowCount; i++)
            {
                tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F)); // 60 pixels high
            }

            tableGrid.Width = _grid.Width * 60;
            tableGrid.Height = _grid.Height * 60;

            for (int x = 0; x < _grid.Width; x++)
            {
                for (int y = 0; y < _grid.Height; y++)
                {
                    var cc = new SquareCpt(this, x, y, _grid.GetSquare(x, y));
                    cc.Dock = DockStyle.Fill;
                    tableGrid.Controls.Add(cc, x, y);
                    _squareComponents.Add(cc);
                }
            }
            Repaint();
        }

        private void buttonCreateBoard_Click(object sender, EventArgs e)
        {
            _grid = new Grid(int.Parse(textBoxWidth.Text), int.Parse(textBoxHeight.Text));
            SetupGrid();
        }

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            _grid = JsonSerializer.Deserialize<Grid>(File.ReadAllText("c:\\Temp\\Grid.json"));
            SetupGrid();
        }

        private void buttonAPairWillChokeAllAdjacentCells_Click(object sender, EventArgs e)
        {
            _grid.APairWillChokeAllAdjacentCells();
            Repaint();
        }

        private void buttonRemoveAPairWillChokeAllCelsInSameArea_Click(object sender, EventArgs e)
        {
            _grid.APairWillChokeAllCellsInSameArea();
            Repaint();
        }
    }
}