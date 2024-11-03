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
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tableGrid
            // 
            tableGrid.ColumnCount = 13;
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tableGrid.Location = new Point(32, 126);
            tableGrid.Name = "tableGrid";
            tableGrid.RowCount = 12;
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableGrid.Size = new Size(788, 712);
            tableGrid.TabIndex = 5;
            // 
            // labelDebug
            // 
            labelDebug.AutoSize = true;
            labelDebug.Location = new Point(576, 61);
            labelDebug.Name = "labelDebug";
            labelDebug.Size = new Size(16, 15);
            labelDebug.TabIndex = 6;
            labelDebug.Text = "...";
            // 
            // labelNextColor
            // 
            labelNextColor.AutoSize = true;
            labelNextColor.Location = new Point(33, 96);
            labelNextColor.Name = "labelNextColor";
            labelNextColor.Size = new Size(62, 15);
            labelNextColor.TabIndex = 7;
            labelNextColor.Text = "Next color";
            // 
            // button1
            // 
            button1.Location = new Point(101, 92);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 8;
            button1.Text = "Skip color";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxNumber
            // 
            textBoxNumber.Location = new Point(461, 92);
            textBoxNumber.Name = "textBoxNumber";
            textBoxNumber.Size = new Size(35, 23);
            textBoxNumber.TabIndex = 9;
            // 
            // buttonAreaCount
            // 
            buttonAreaCount.Location = new Point(881, 88);
            buttonAreaCount.Name = "buttonAreaCount";
            buttonAreaCount.Size = new Size(202, 27);
            buttonAreaCount.TabIndex = 10;
            buttonAreaCount.Text = "Remove area.count()";
            buttonAreaCount.UseVisualStyleBackColor = true;
            buttonAreaCount.Click += buttonAreaCount_Click;
            // 
            // buttonAdjacent
            // 
            buttonAdjacent.Location = new Point(882, 119);
            buttonAdjacent.Name = "buttonAdjacent";
            buttonAdjacent.Size = new Size(201, 23);
            buttonAdjacent.TabIndex = 11;
            buttonAdjacent.Text = "Remove adjacent";
            buttonAdjacent.UseVisualStyleBackColor = true;
            buttonAdjacent.Click += buttonAdjacent_Click;
            // 
            // buttonRemoveSameArea
            // 
            buttonRemoveSameArea.Location = new Point(882, 148);
            buttonRemoveSameArea.Name = "buttonRemoveSameArea";
            buttonRemoveSameArea.Size = new Size(201, 23);
            buttonRemoveSameArea.TabIndex = 12;
            buttonRemoveSameArea.Text = "Remove same area";
            buttonRemoveSameArea.UseVisualStyleBackColor = true;
            buttonRemoveSameArea.Click += buttonRemoveSameArea_Click;
            // 
            // buttonSetOnlyOption
            // 
            buttonSetOnlyOption.Location = new Point(884, 308);
            buttonSetOnlyOption.Name = "buttonSetOnlyOption";
            buttonSetOnlyOption.Size = new Size(199, 23);
            buttonSetOnlyOption.TabIndex = 13;
            buttonSetOnlyOption.Text = "Set based on only option";
            buttonSetOnlyOption.UseVisualStyleBackColor = true;
            buttonSetOnlyOption.Click += buttonSetOnlyOption_Click;
            // 
            // buttonSetOnlySqInAreaHavingThisNumber
            // 
            buttonSetOnlySqInAreaHavingThisNumber.Location = new Point(885, 337);
            buttonSetOnlySqInAreaHavingThisNumber.Name = "buttonSetOnlySqInAreaHavingThisNumber";
            buttonSetOnlySqInAreaHavingThisNumber.Size = new Size(198, 41);
            buttonSetOnlySqInAreaHavingThisNumber.TabIndex = 15;
            buttonSetOnlySqInAreaHavingThisNumber.Text = "Set because only one square has this number in an area";
            buttonSetOnlySqInAreaHavingThisNumber.UseVisualStyleBackColor = true;
            buttonSetOnlySqInAreaHavingThisNumber.Click += buttonSetOnlySqInAreaHavingThisNumber_Click;
            // 
            // buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas
            // 
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Location = new Point(881, 177);
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Name = "buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas";
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Size = new Size(202, 41);
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.TabIndex = 16;
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Text = "Remove - one number in an area chokes adjacent cells in other areas";
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.UseVisualStyleBackColor = true;
            buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas.Click += buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas_Click;
            // 
            // buttonRunOne
            // 
            buttonRunOne.Location = new Point(882, 16);
            buttonRunOne.Name = "buttonRunOne";
            buttonRunOne.Size = new Size(75, 23);
            buttonRunOne.TabIndex = 17;
            buttonRunOne.Text = "Run One";
            buttonRunOne.UseVisualStyleBackColor = true;
            buttonRunOne.Click += buttonRunOne_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 96);
            label1.Name = "label1";
            label1.Size = new Size(238, 15);
            label1.TabIndex = 18;
            label1.Text = "Set known value (click in the grid to assign):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 16);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 20;
            label2.Text = "Width:";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(82, 12);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(35, 23);
            textBoxWidth.TabIndex = 19;
            textBoxWidth.Text = "8";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(127, 16);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 22;
            label3.Text = "Height:";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(179, 12);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(35, 23);
            textBoxHeight.TabIndex = 21;
            textBoxHeight.Text = "8";
            // 
            // buttonCreateBoard
            // 
            buttonCreateBoard.Location = new Point(240, 12);
            buttonCreateBoard.Name = "buttonCreateBoard";
            buttonCreateBoard.Size = new Size(91, 23);
            buttonCreateBoard.TabIndex = 23;
            buttonCreateBoard.Text = "Create board";
            buttonCreateBoard.UseVisualStyleBackColor = true;
            buttonCreateBoard.Click += buttonCreateBoard_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(673, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 24;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Location = new Point(673, 41);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(75, 23);
            buttonLoad.TabIndex = 25;
            buttonLoad.Text = "Load";
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // buttonAPairWillChokeAllAdjacentCells
            // 
            buttonAPairWillChokeAllAdjacentCells.Location = new Point(882, 222);
            buttonAPairWillChokeAllAdjacentCells.Name = "buttonAPairWillChokeAllAdjacentCells";
            buttonAPairWillChokeAllAdjacentCells.Size = new Size(201, 40);
            buttonAPairWillChokeAllAdjacentCells.TabIndex = 26;
            buttonAPairWillChokeAllAdjacentCells.Text = "Remove - a pair will choke all adjacent cells";
            buttonAPairWillChokeAllAdjacentCells.UseVisualStyleBackColor = true;
            buttonAPairWillChokeAllAdjacentCells.Click += buttonAPairWillChokeAllAdjacentCells_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1095, 836);
            Controls.Add(buttonAPairWillChokeAllAdjacentCells);
            Controls.Add(buttonLoad);
            Controls.Add(buttonSave);
            Controls.Add(buttonCreateBoard);
            Controls.Add(label3);
            Controls.Add(textBoxHeight);
            Controls.Add(label2);
            Controls.Add(textBoxWidth);
            Controls.Add(label1);
            Controls.Add(buttonRunOne);
            Controls.Add(buttonOneNumberInAnAreaChokesAdjacentCellsInOtherAreas);
            Controls.Add(buttonSetOnlySqInAreaHavingThisNumber);
            Controls.Add(buttonSetOnlyOption);
            Controls.Add(buttonRemoveSameArea);
            Controls.Add(buttonAdjacent);
            Controls.Add(buttonAreaCount);
            Controls.Add(textBoxNumber);
            Controls.Add(button1);
            Controls.Add(labelNextColor);
            Controls.Add(labelDebug);
            Controls.Add(tableGrid);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
    }
}