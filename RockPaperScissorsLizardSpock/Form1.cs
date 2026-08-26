using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace RockPaperScissorsLizardSpock
{
    public partial class Form1 : Form
    {

        private GameStatus gameStatus;
        private readonly Random RANDOM_GENERATOR = new Random();
        private const int BEST_OF_THREE_GAMES = 3;
        private const int BEST_OF_FIVE_GAMES = 5;
        private const int BEST_OF_TEN_GAMES = 10;

        private const int BEST_OF_THREE = 1;
        private const int BEST_OF_FIVE = 2;
        private const int BEST_OF_TEN = 3;

        private int[] buttonNumbers = new int[] { BEST_OF_THREE, BEST_OF_FIVE, BEST_OF_TEN };
        private int[] numberOfRounds = new int[] { BEST_OF_THREE_GAMES, BEST_OF_FIVE_GAMES, BEST_OF_TEN_GAMES };
        private Dictionary<string, string> winConditionRules = new Dictionary<string, string>();

        private int buttonId;
        private int level;
        private int turns;
        private int roundsRemaining;
        private int totalRounds;
        private int playerChoosenChoice;
        private int computerChoosenChoice;
        private int targetWin;
        private int gameWinnerIndex = -1;
        private int gameRoundWinnerIndex = -1;
        private string message;
        private string selectedModel;

        private Label[] numberOfGamesLabel;
        private Button[] numberOfGamesButton;
        private Button[] gameFlowButtons;
        private PictureBox[] gameFlowLabels;
        private int[] gameScores;
        private int[] gameRoundScores;
        private Label[] gameLabels;
        private Label[] gameRoundLabels;
        private Label activeLabel;
        private Label activeScoreLabel;
        private Label activeScoreRoundLabel;




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
