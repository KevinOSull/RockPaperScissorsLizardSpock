using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Diagnostics;

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
        private string blueButtonImagePath = "Resources/button_bg.png";
        private string redButtonImagePath = "Resources/button_bg2.png";

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
            //LoadMessagesTextFile();
            InitializeGameState();

        }

        private void InitializeGameState()
        {
            numberOfGamesLabel = InitArray(bestOfThreeLabel, bestOfFiveLabel, bestOfTenLabel);
            numberOfGamesButton = InitArray(bestOfThreeButton, bestOfFiveButton, bestOfTenButton);
            gameFlowButtons = InitArray(rockButton, paperButton, scissorsButton, lizardButton, spockButton);
            gameScores = new int[2];
            gameRoundScores = new int[2];
            gameRoundLabels = InitArray(playerRoundScore, computerRoundScore);
            gameLabels = InitArray(playerScore, computerScore);
            gameFlowLabels = InitArray(playerChoice,computerChoice);
            SetButtonState(gameFlowButtons, false, "Resources/button_bg2.png");
        }

        private void LoadMessagesTextFile()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,"GameData", "winConditions.txt");
                using StreamReader reader = new(filePath);
                string? line;
                while((line = reader.ReadLine()) != null)
                {
                    if (line.Contains('='))
                    {
                        string[] values = line.Split('=');
                        if(values.Length == 2)
                        {
                            winConditionRules.Add(values[0].Trim(), values[1].Trim());
                            MessageBox.Show("FILE READ");
                        }
                    }
                }
            }catch(IOException e)
            {
                MessageBox.Show("THE FILE CANNOT BE READ! " + e.Message);
            }
        }

        private void SetButtonState(Button[]button,bool isEnabled,string imageFilePath)
        {
            Image backGroundImage = Image.FromFile(imageFilePath);
            for (int i = 0; i < button.Length; i++)
            {
                button[i].Enabled = isEnabled;
                button[i].BackgroundImage = backGroundImage;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void ExitProgram()
        {
            Application.Exit();
        }


        private Button[] InitArray(params Button[] items)
        {
            return items;
        }

        private Label[] InitArray(params Label[] items)
        {
            return items;
        }

        private PictureBox[] InitArray(params PictureBox[] items)
        {
            return items;
        }
    }
}
