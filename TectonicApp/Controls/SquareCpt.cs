using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TectonicApp.Controls
{
    public partial class SquareCpt : UserControl
    {
        public Form1 _masterForm = null;
        public int _x = 0;
        public int _y = 0;
        public Square _square;
        public SquareCpt()
        {
            InitializeComponent();
        }

        public void SetGroup(Color color, int areaIndex)
        {
            this.BackColor = color;
            _square.AreaIndex = areaIndex;
        }

        public SquareCpt(Form1 masterForm, int x, int y, Square square)
        {
            _masterForm = masterForm;
            InitializeComponent();
            _x = x;
            _y = y;
            _square = square;
            this.MouseMove += Mouse_Over;
            this.label1.MouseMove += Mouse_Over;
            this.label2.MouseMove += Mouse_Over;
            this.label3.MouseMove += Mouse_Over;
            this.label4.MouseMove += Mouse_Over;
            this.label5.MouseMove += Mouse_Over;
            this.labelX.MouseMove += Mouse_Over;
            this.MouseClick += Square_MouseClick;
            this.label1.MouseClick += Square_MouseClick;
            this.label2.MouseClick += Square_MouseClick;
            this.label3.MouseClick += Square_MouseClick;
            this.label4.MouseClick += Square_MouseClick;
            this.label5.MouseClick += Square_MouseClick;
            this.labelX.MouseClick += Square_MouseClick;
        }

        public void Repaint()
        {
            if (_square.AreaIndex >= 0)
                this.BackColor = _masterForm._colors[_square.AreaIndex];
            else
                this.BackColor = Color.White;

            if (_square.Number > 0)
            {
                labelX.Visible = true;
                labelX.Text = _square.Number.ToString();
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                return;
            }

            labelX.Visible = false;
            label1.Visible = _square.ValidNumbers.Contains(1);
            label2.Visible = _square.ValidNumbers.Contains(2);
            label3.Visible = _square.ValidNumbers.Contains(3);
            label4.Visible = _square.ValidNumbers.Contains(4);
            label5.Visible = _square.ValidNumbers.Contains(5);
        }

        private void Square_MouseClick(object? sender, MouseEventArgs e)
        {
            _square.Number = int.Parse(_masterForm.textBoxNumber.Text);
            Repaint();
        }

        public void Mouse_Over(object sender, EventArgs e)
        {
            {
                _masterForm.AddSquare(_x, _y, this);
            }
        }
    }
}