using MazeSolver.Source;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MazeSolver
{
    public partial class Main : Form
    {
        private Mazes mazes;
        private Solver mazeSolver;
        private ImageList imageList;

        public Main()
        {
            mazes = new Mazes();
            imageList = new ImageList();
            InitializeComponent();
        }

        public void UpdateDisplay(int movesLeft, int maxMoves)
        {
            mazeTextBox.Clear();
            mazeTextBox.Text = mazes.GetMaze();
            movesLeftLbl.Text = "Moves left: " + movesLeft.ToString() + "/" + maxMoves.ToString();
        }

        void UpdateControls(bool enableControls)
        {
            solveBtn.Enabled = enableControls;
            selectedMazeBox.Enabled = enableControls;
            maxMovesGroupBox.Enabled = enableControls;
            string moveAmount = maxMovesGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;
            movesLeftLbl.Text = "Moves left: " + moveAmount + "/" + moveAmount;
        }

        public void PrintEvent(string text, Icons icon)
        {
            Bitmap image = null;
            switch (icon)
            {
                case Icons.START:
                    image = Properties.Resources.start;
                    break;
                case Icons.MOVE:
                    image = Properties.Resources.move;
                    break;
                case Icons.FAILED_MOVE:
                    image = Properties.Resources.fail;
                    break;
                case Icons.EXIT:
                    image = Properties.Resources.exit;
                    break;
                case Icons.INFO:
                    image = Properties.Resources.info;
                    break;
            }
            imageList.Images.Add(image);
            eventView.SmallImageList = imageList;
            eventView.View = View.Details;
            eventView.Items.Add(new ListViewItem { ImageIndex = imageList.Images.Count - 1, Text = text});
        }

        private void Main_Load(object sender, EventArgs e)
        {
            selectedMazeBox.SelectedIndex = 0;
            mazes.SetMaze(0);
            mazeTextBox.Text = mazes.GetMaze();
        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            int selectedMoves = int.Parse(maxMovesGroupBox.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text);
            UpdateControls(false);
            mazeSolver = new Solver(this, mazes, selectedMoves);
            mazeSolver.SolveMaze();
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            mazes.SetMaze(selectedMazeBox.SelectedIndex);
            mazeTextBox.Text = mazes.GetMaze();
            UpdateControls(true);
            eventView.Items.Clear();
        }

        private void selectedMazeBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Force read only
            e.SuppressKeyPress = true;
        }

        private void selectedMazeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            mazes.SetMaze(selectedMazeBox.SelectedIndex);
            mazeTextBox.Text = mazes.GetMaze();
        }
    }
}
