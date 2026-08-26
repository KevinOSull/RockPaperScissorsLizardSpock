using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace RockPaperScissorsLizardSpock
{
    public partial class Form1 : Form
    {

        private GameStatus gameStatus;
        private const int BEST_OF_THREE_GAMES = 3;
        public Form1()
        {
            InitializeComponent();

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void ExitProgram()
        {
            Application.Exit();
        }
    }
}
