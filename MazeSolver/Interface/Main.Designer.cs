﻿
namespace MazeSolver
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mazeGroupBox = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.maxMovesGroupBox = new System.Windows.Forms.GroupBox();
            this.twoHundredRadBtn = new System.Windows.Forms.RadioButton();
            this.hundredFiftyRadBtn = new System.Windows.Forms.RadioButton();
            this.twentyRadBtn = new System.Windows.Forms.RadioButton();
            this.movesLeftLbl = new System.Windows.Forms.Label();
            this.solveBtn = new System.Windows.Forms.Button();
            this.mazeTextBox = new System.Windows.Forms.TextBox();
            this.selectedMazeLbl = new System.Windows.Forms.Label();
            this.selectedMazeBox = new System.Windows.Forms.ComboBox();
            this.dataView = new System.Windows.Forms.ListView();
            this.dataHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.mazeGroupBox.SuspendLayout();
            this.maxMovesGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mazeGroupBox
            // 
            this.mazeGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mazeGroupBox.Controls.Add(this.resetBtn);
            this.mazeGroupBox.Controls.Add(this.maxMovesGroupBox);
            this.mazeGroupBox.Controls.Add(this.movesLeftLbl);
            this.mazeGroupBox.Controls.Add(this.solveBtn);
            this.mazeGroupBox.Controls.Add(this.mazeTextBox);
            this.mazeGroupBox.Controls.Add(this.selectedMazeLbl);
            this.mazeGroupBox.Controls.Add(this.selectedMazeBox);
            this.mazeGroupBox.Location = new System.Drawing.Point(7, 1);
            this.mazeGroupBox.Name = "mazeGroupBox";
            this.mazeGroupBox.Size = new System.Drawing.Size(334, 437);
            this.mazeGroupBox.TabIndex = 0;
            this.mazeGroupBox.TabStop = false;
            this.mazeGroupBox.Text = "Maze";
            // 
            // resetBtn
            // 
            this.resetBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.resetBtn.Location = new System.Drawing.Point(244, 383);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(84, 32);
            this.resetBtn.TabIndex = 7;
            this.resetBtn.Text = "Reset";
            this.resetBtn.UseVisualStyleBackColor = true;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            // 
            // maxMovesGroupBox
            // 
            this.maxMovesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.maxMovesGroupBox.Controls.Add(this.twoHundredRadBtn);
            this.maxMovesGroupBox.Controls.Add(this.hundredFiftyRadBtn);
            this.maxMovesGroupBox.Controls.Add(this.twentyRadBtn);
            this.maxMovesGroupBox.Location = new System.Drawing.Point(9, 379);
            this.maxMovesGroupBox.Name = "maxMovesGroupBox";
            this.maxMovesGroupBox.Size = new System.Drawing.Size(145, 50);
            this.maxMovesGroupBox.TabIndex = 6;
            this.maxMovesGroupBox.TabStop = false;
            this.maxMovesGroupBox.Text = "Max moves";
            // 
            // twoHundredRadBtn
            // 
            this.twoHundredRadBtn.AutoSize = true;
            this.twoHundredRadBtn.Location = new System.Drawing.Point(97, 19);
            this.twoHundredRadBtn.Name = "twoHundredRadBtn";
            this.twoHundredRadBtn.Size = new System.Drawing.Size(43, 17);
            this.twoHundredRadBtn.TabIndex = 7;
            this.twoHundredRadBtn.Text = "200";
            this.twoHundredRadBtn.UseVisualStyleBackColor = true;
            // 
            // hundredFiftyRadBtn
            // 
            this.hundredFiftyRadBtn.AutoSize = true;
            this.hundredFiftyRadBtn.Location = new System.Drawing.Point(50, 19);
            this.hundredFiftyRadBtn.Name = "hundredFiftyRadBtn";
            this.hundredFiftyRadBtn.Size = new System.Drawing.Size(43, 17);
            this.hundredFiftyRadBtn.TabIndex = 6;
            this.hundredFiftyRadBtn.Text = "150";
            this.hundredFiftyRadBtn.UseVisualStyleBackColor = true;
            // 
            // twentyRadBtn
            // 
            this.twentyRadBtn.AutoSize = true;
            this.twentyRadBtn.Checked = true;
            this.twentyRadBtn.Location = new System.Drawing.Point(7, 19);
            this.twentyRadBtn.Name = "twentyRadBtn";
            this.twentyRadBtn.Size = new System.Drawing.Size(37, 17);
            this.twentyRadBtn.TabIndex = 5;
            this.twentyRadBtn.TabStop = true;
            this.twentyRadBtn.Text = "20";
            this.twentyRadBtn.UseVisualStyleBackColor = true;
            // 
            // movesLeftLbl
            // 
            this.movesLeftLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.movesLeftLbl.AutoSize = true;
            this.movesLeftLbl.Location = new System.Drawing.Point(164, 418);
            this.movesLeftLbl.Name = "movesLeftLbl";
            this.movesLeftLbl.Size = new System.Drawing.Size(85, 13);
            this.movesLeftLbl.TabIndex = 4;
            this.movesLeftLbl.Text = "Moves left: 0/20";
            // 
            // solveBtn
            // 
            this.solveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.solveBtn.Location = new System.Drawing.Point(167, 383);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(71, 32);
            this.solveBtn.TabIndex = 1;
            this.solveBtn.Text = "Solve!";
            this.solveBtn.UseVisualStyleBackColor = true;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // mazeTextBox
            // 
            this.mazeTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.StaticText;
            this.mazeTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mazeTextBox.BackColor = System.Drawing.Color.White;
            this.mazeTextBox.Cursor = System.Windows.Forms.Cursors.Cross;
            this.mazeTextBox.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mazeTextBox.Location = new System.Drawing.Point(9, 14);
            this.mazeTextBox.Multiline = true;
            this.mazeTextBox.Name = "mazeTextBox";
            this.mazeTextBox.ReadOnly = true;
            this.mazeTextBox.ShortcutsEnabled = false;
            this.mazeTextBox.Size = new System.Drawing.Size(319, 320);
            this.mazeTextBox.TabIndex = 2;
            this.mazeTextBox.TabStop = false;
            this.mazeTextBox.WordWrap = false;
            // 
            // selectedMazeLbl
            // 
            this.selectedMazeLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectedMazeLbl.AutoSize = true;
            this.selectedMazeLbl.Location = new System.Drawing.Point(8, 337);
            this.selectedMazeLbl.Name = "selectedMazeLbl";
            this.selectedMazeLbl.Size = new System.Drawing.Size(80, 13);
            this.selectedMazeLbl.TabIndex = 1;
            this.selectedMazeLbl.Text = "Selected maze:";
            // 
            // selectedMazeBox
            // 
            this.selectedMazeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.selectedMazeBox.BackColor = System.Drawing.Color.White;
            this.selectedMazeBox.FormattingEnabled = true;
            this.selectedMazeBox.Items.AddRange(new object[] {
            "Maze 1",
            "Maze 2"});
            this.selectedMazeBox.Location = new System.Drawing.Point(9, 353);
            this.selectedMazeBox.Name = "selectedMazeBox";
            this.selectedMazeBox.Size = new System.Drawing.Size(319, 21);
            this.selectedMazeBox.TabIndex = 0;
            this.selectedMazeBox.SelectedIndexChanged += new System.EventHandler(this.selectedMazeBox_SelectedIndexChanged);
            this.selectedMazeBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.selectedMazeBox_KeyDown);
            // 
            // dataView
            // 
            this.dataView.Alignment = System.Windows.Forms.ListViewAlignment.SnapToGrid;
            this.dataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.dataHeader});
            this.dataView.HideSelection = false;
            this.dataView.Location = new System.Drawing.Point(6, 16);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(407, 413);
            this.dataView.TabIndex = 8;
            this.dataView.UseCompatibleStateImageBehavior = false;
            this.dataView.View = System.Windows.Forms.View.SmallIcon;
            // 
            // dataHeader
            // 
            this.dataHeader.Text = "Data";
            this.dataHeader.Width = 300;
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGroupBox.Controls.Add(this.dataView);
            this.dataGroupBox.Location = new System.Drawing.Point(347, 1);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(419, 437);
            this.dataGroupBox.TabIndex = 9;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Dataview";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 447);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.mazeGroupBox);
            this.MinimumSize = new System.Drawing.Size(787, 486);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Maze solver";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mazeGroupBox.ResumeLayout(false);
            this.mazeGroupBox.PerformLayout();
            this.maxMovesGroupBox.ResumeLayout(false);
            this.maxMovesGroupBox.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mazeGroupBox;
        private System.Windows.Forms.Label selectedMazeLbl;
        private System.Windows.Forms.ComboBox selectedMazeBox;
        private System.Windows.Forms.GroupBox maxMovesGroupBox;
        private System.Windows.Forms.RadioButton twoHundredRadBtn;
        private System.Windows.Forms.RadioButton hundredFiftyRadBtn;
        private System.Windows.Forms.RadioButton twentyRadBtn;
        private System.Windows.Forms.Label movesLeftLbl;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Button resetBtn;
        public System.Windows.Forms.TextBox mazeTextBox;
        private System.Windows.Forms.ListView dataView;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.ColumnHeader dataHeader;
    }
}

