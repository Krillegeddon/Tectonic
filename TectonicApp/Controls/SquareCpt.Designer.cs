namespace TectonicApp.Controls
{
    partial class SquareCpt
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            labelX = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(13, 15);
            label1.TabIndex = 0;
            label1.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(39, 0);
            label2.Name = "label2";
            label2.Size = new Size(13, 15);
            label2.TabIndex = 1;
            label2.Text = "2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 20);
            label3.Name = "label3";
            label3.Size = new Size(13, 15);
            label3.TabIndex = 2;
            label3.Text = "3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 40);
            label4.Name = "label4";
            label4.Size = new Size(13, 15);
            label4.TabIndex = 3;
            label4.Text = "4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(39, 40);
            label5.Name = "label5";
            label5.Size = new Size(13, 15);
            label5.TabIndex = 4;
            label5.Text = "5";
            // 
            // labelX
            // 
            labelX.AutoSize = true;
            labelX.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            labelX.Location = new Point(3, 1);
            labelX.Name = "labelX";
            labelX.Size = new Size(47, 54);
            labelX.TabIndex = 5;
            labelX.Text = "X";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(0, 20);
            label6.Name = "label6";
            label6.Size = new Size(13, 15);
            label6.TabIndex = 6;
            label6.Text = "6";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 20);
            label7.Name = "label7";
            label7.Size = new Size(13, 15);
            label7.TabIndex = 7;
            label7.Text = "7";
            // 
            // SquareCpt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelX);
            Name = "SquareCpt";
            Size = new Size(55, 55);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label labelX;
        private Label label6;
        private Label label7;
    }
}
