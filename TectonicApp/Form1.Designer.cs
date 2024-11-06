namespace TectonicApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tableGrid = new TableLayoutPanel();
            bindingSource1 = new BindingSource(components);
            labelDebug = new Label();
            labelNextColor = new Label();
            button1 = new Button();
            textBoxNumber = new TextBox();
            buttonAreaCount = new Button();
            buttonAdjacent = new Button();
            buttonRemoveSameArea = new Button();
            buttonSetOnlyOption = new Button();
            buttonSetOnlySqInAreaHavingThisNumber = new Button();
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas = new Button();
            buttonRunOne = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxWidth = new TextBox();
            label3 = new Label();
            textBoxHeight = new TextBox();
            buttonCreateBoard = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            buttonAPairWillChokeAllAdjacentCells = new Button();
            panel1 = new Panel();
            buttonRemoveAPairWillChokeAllCelsInSameArea = new Button();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // tableGrid
            // 
            tableGrid.ColumnCount = 1;
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.Location = new Point(0, 0);
            tableGrid.Name = "tableGrid";
            tableGrid.RowCount = 1;
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableGrid.Size = new Size(849, 829);
            tableGrid.TabIndex = 5;
            // 
            // labelDebug
            // 
            labelDebug.AutoSize = true;
            labelDebug.Location = new Point(558, 67);
            labelDebug.Name = "labelDebug";
            labelDebug.Size = new Size(16, 15);
            labelDebug.TabIndex = 6;
            labelDebug.Text = "...";
            // 
            // labelNextColor
            // 
            labelNextColor.AutoSize = true;
            labelNextColor.Location = new Point(12, 55);
            labelNextColor.Name = "labelNextColor";
            labelNextColor.Size = new Size(62, 15);
            labelNextColor.TabIndex = 7;
            labelNextColor.Text = "Next color";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(80, 51);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Skip color";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBoxNumber
            // 
            textBoxNumber.BackColor = SystemColors.ControlDarkDark;
            textBoxNumber.Location = new Point(440, 51);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(35, 23);
            textBoxNumber.TabIndex = 9;
            // 
            // buttonAreaCount
            // 
            buttonAreaCount.BackColor = SystemColors.ControlDarkDark;
            buttonAreaCount.Location = new Point(3, 44);
            buttonAreaCount.Name = "buttonAreaCount";
            buttonAreaCount.Size = new Size(202, 27);
            buttonAreaCount.TabIndex = 10;
            buttonAreaCount.Text = "Remove area.count()";
            buttonAreaCount.UseVisualStyleBackColor = false;
            buttonAreaCount.Click += buttonAreaCount_Click;
            // 
            // buttonAdjacent
            // 
            buttonAdjacent.BackColor = SystemColors.ControlDarkDark;
            buttonAdjacent.Location = new Point(4, 75);
            buttonAdjacent.Name = "buttonAdjacent";
            buttonAdjacent.Size = new Size(201, 23);
            buttonAdjacent.TabIndex = 11;
            buttonAdjacent.Text = "Remove adjacent";
            buttonAdjacent.UseVisualStyleBackColor = false;
            buttonAdjacent.Click += buttonAdjacent_Click;
            // 
            // buttonRemoveSameArea
            // 
            buttonRemoveSameArea.BackColor = SystemColors.ControlDarkDark;
            buttonRemoveSameArea.Location = new Point(4, 104);
            buttonRemoveSameArea.Name = "buttonRemoveSameArea";
            buttonRemoveSameArea.Size = new Size(201, 23);
            buttonRemoveSameArea.TabIndex = 12;
            buttonRemoveSameArea.Text = "Remove same area";
            buttonRemoveSameArea.UseVisualStyleBackColor = false;
            buttonRemoveSameArea.Click += buttonRemoveSameArea_Click;
            // 
            // buttonSetOnlyOption
            // 
            buttonSetOnlyOption.BackColor = SystemColors.ControlDarkDark;
            buttonSetOnlyOption.Location = new Point(5, 315);
            buttonSetOnlyOption.Name = "buttonSetOnlyOption";
            buttonSetOnlyOption.Size = new Size(199, 23);
            buttonSetOnlyOption.TabIndex = 13;
            buttonSetOnlyOption.Text = "Set based on only option";
            buttonSetOnlyOption.UseVisualStyleBackColor = false;
            buttonSetOnlyOption.Click += buttonSetOnlyOption_Click;
            // 
            // buttonSetOnlySqInAreaHavingThisNumber
            // 
            buttonSetOnlySqInAreaHavingThisNumber.BackColor = SystemColors.ControlDarkDark;
            buttonSetOnlySqInAreaHavingThisNumber.Location = new Point(6, 344);
            buttonSetOnlySqInAreaHavingThisNumber.Name = "buttonSetOnlySqInAreaHavingThisNumber";
            buttonSetOnlySqInAreaHavingThisNumber.Size = new Size(198, 41);
            buttonSetOnlySqInAreaHavingThisNumber.TabIndex = 15;
            buttonSetOnlySqInAreaHavingThisNumber.Text = "Set because only one square has this number in an area";
            buttonSetOnlySqInAreaHavingThisNumber.UseVisualStyleBackColor = false;
            buttonSetOnlySqInAreaHavingThisNumber.Click += buttonSetOnlySqInAreaHavingThisNumber_Click;
            // 
            // buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas
            // 
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.BackColor = SystemColors.ControlDarkDark;
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Location = new Point(3, 133);
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Name = "buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas";
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Size = new Size(202, 41);
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.TabIndex = 16;
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Text = "Remove - one number in an area chokes adjacent cells in other areas";
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.UseVisualStyleBackColor = false;
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Click += buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas_Click;
            // 
            // buttonRunOne
            // 
            buttonRunOne.BackColor = SystemColors.ControlDarkDark;
            buttonRunOne.Location = new Point(3, 3);
            buttonRunOne.Name = "buttonRunOne";
            buttonRunOne.Size = new Size(75, 23);
            buttonRunOne.TabIndex = 17;
            buttonRunOne.Text = "Run One";
            buttonRunOne.UseVisualStyleBackColor = false;
            buttonRunOne.Click += buttonRunOne_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 55);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 18;
            label1.Text = "Set known value (click in the grid to assign):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 22);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 20;
            label2.Text = "Width:";
            // 
            // textBoxWidth
            // 
            textBoxWidth.BackColor = SystemColors.ControlDarkDark;
            textBoxWidth.Location = new Point(64, 18);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(35, 23);
            textBoxWidth.TabIndex = 19;
            textBoxWidth.Text = "8";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(109, 22);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 22;
            label3.Text = "Height:";
            // 
            // textBoxHeight
            // 
            textBoxHeight.BackColor = SystemColors.ControlDarkDark;
            textBoxHeight.Location = new Point(161, 18);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(35, 23);
            textBoxHeight.TabIndex = 21;
            textBoxHeight.Text = "8";
            // 
            // buttonCreateBoard
            // 
            buttonCreateBoard.BackColor = SystemColors.ControlDarkDark;
            buttonCreateBoard.Location = new Point(222, 18);
            buttonCreateBoard.Name = "buttonCreateBoard";
            buttonCreateBoard.Size = new Size(91, 23);
            buttonCreateBoard.TabIndex = 23;
            buttonCreateBoard.Text = "Create board";
            buttonCreateBoard.UseVisualStyleBackColor = false;
            buttonCreateBoard.Click += buttonCreateBoard_Click;
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.ControlDarkDark;
            buttonSave.Location = new Point(655, 18);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 24;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.BackColor = SystemColors.ControlDarkDark;
            buttonLoad.Location = new Point(655, 47);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 25;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = false;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonAPairWillChokeAllAdjacentCells
            // 
            buttonAPairWillChokeAllAdjacentCells.BackColor = SystemColors.ControlDarkDark;
            buttonAPairWillChokeAllAdjacentCells.Location = new Point(3, 180);
            buttonAPairWillChokeAllAdjacentCells.Name = "buttonAPairWillChokeAllAdjacentCells";
            buttonAPairWillChokeAllAdjacentCells.Size = new Size(201, 40);
            buttonAPairWillChokeAllAdjacentCells.TabIndex = 26;
            buttonAPairWillChokeAllAdjacentCells.Text = "Remove - a pair will choke all adjacent cells";
            buttonAPairWillChokeAllAdjacentCells.UseVisualStyleBackColor = false;
            buttonAPairWillChokeAllAdjacentCells.Click += buttonAPairWillChokeAllAdjacentCells_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonRemoveAPairWillChokeAllCelsInSameArea);
            panel1.Controls.Add(buttonRunOne);
            panel1.Controls.Add(buttonAPairWillChokeAllAdjacentCells);
            panel1.Controls.Add(buttonAreaCount);
            panel1.Controls.Add(buttonAdjacent);
            panel1.Controls.Add(buttonRemoveSameArea);
            panel1.Controls.Add(buttonSetOnlyOption);
            panel1.Controls.Add(buttonSetOnlySqInAreaHavingThisNumber);
            panel1.Controls.Add(buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(242, 887);
            panel1.TabIndex = 28;
            // 
            // buttonRemoveAPairWillChokeAllCelsInSameArea
            // 
            buttonRemoveAPairWillChokeAllCelsInSameArea.BackColor = SystemColors.ControlDarkDark;
            buttonRemoveAPairWillChokeAllCelsInSameArea.Location = new Point(4, 226);
            buttonRemoveAPairWillChokeAllCelsInSameArea.Name = "buttonRemoveAPairWillChokeAllCelsInSameArea";
            buttonRemoveAPairWillChokeAllCelsInSameArea.Size = new Size(201, 40);
            buttonRemoveAPairWillChokeAllCelsInSameArea.TabIndex = 27;
            buttonRemoveAPairWillChokeAllCelsInSameArea.Text = "Remove - a pair will choke all cells in same area";
            buttonRemoveAPairWillChokeAllCelsInSameArea.UseVisualStyleBackColor = false;
            buttonRemoveAPairWillChokeAllCelsInSameArea.Click += buttonRemoveAPairWillChokeAllCelsInSameArea_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonLoad);
            panel2.Controls.Add(labelDebug);
            panel2.Controls.Add(labelNextColor);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(buttonSave);
            panel2.Controls.Add(textBoxNumber);
            panel2.Controls.Add(buttonCreateBoard);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBoxWidth);
            panel2.Controls.Add(textBoxHeight);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1095, 91);
            panel2.TabIndex = 29;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(tableGrid);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(1095, 887);
            splitContainer1.SplitterDistance = 849;
            splitContainer1.TabIndex = 30;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(panel2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer1);
            splitContainer2.Size = new Size(1095, 982);
            splitContainer2.SplitterDistance = 91;
            splitContainer2.TabIndex = 31;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.WindowFrame;
            ClientSize = new Size(1095, 982);
            Controls.Add(splitContainer2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableGrid;
        private BindingSource bindingSource1;
        private Label labelDebug;
        private Label labelNextColor;
        private Button button1;
        public TextBox textBoxNumber;
        private Button buttonAreaCount;
        private Button buttonAdjacent;
        private Button buttonRemoveSameArea;
        private Button buttonSetOnlyOption;
        private Button buttonSetOnlySqInAreaHavingThisNumber;
        private Button buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas;
        private Button buttonRunOne;
        private Label label1;
        private Label label2;
        public TextBox textBoxWidth;
        private Label label3;
        public TextBox textBoxHeight;
        private Button buttonCreateBoard;
        private Button buttonSave;
        private Button buttonLoad;
        private Button buttonAPairWillChokeAllAdjacentCells;
        private Panel panel1;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private Button buttonRemoveAPairWillChokeAllCelsInSameArea;
    }
}