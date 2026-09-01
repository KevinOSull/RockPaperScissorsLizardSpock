using System.Drawing;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

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
        private String[] roundNumbers = new String[] { "Best of Three", "Best of Five", "Best of Ten" };
        private Dictionary<string, string> winConditionRules = new Dictionary<string, string>();
        private Dictionary<int, int[]> conditions;

        private int buttonId;
        private int level;
        private int turns;
        private int roundsRemaining;
        private int totalRounds;
        private int playerChoosenChoice;
        private int computerChoosenChoice;
        private int targetWins;
        private int gameWinnerIndex = -1;
        private int gameRoundWinnerIndex = -1;
        private string message;
        private string selectedMode;
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
            LoadMessagesTextFile();
            gameStatus = GameStatus.GAME_IN_PROGRESS;
            InitializeGameState();
            InitializeNumberOfGamesButtonsListener();
            InitializeGamePlayButtonsListener();

        }

        private void InitializeGameState()
        {
            InitializeWinningConditions();
            numberOfGamesLabel = InitArray(bestOfThreeLabel, bestOfFiveLabel, bestOfTenLabel);
            numberOfGamesButton = InitArray(bestOfThreeButton, bestOfFiveButton, bestOfTenButton);
            gameFlowButtons = InitArray(rockButton, paperButton, scissorsButton, lizardButton, spockButton);
            gameScores = new int[2];
            gameRoundScores = new int[2];
            gameRoundLabels = InitArray(playerRoundScore, computerRoundScore);
            gameLabels = InitArray(playerScore, computerScore);
            gameFlowLabels = InitArray(playerChoice, computerChoice);
            SetButtonState(gameFlowButtons, false, "Resources/button_bg2.png");
        }

        private async Task RunDelayedTasks(int timeDelay, Action action)
        {
            await Task.Delay(timeDelay);
            action();
        }

        private void LoadMessagesTextFile()
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "GameData", "winConditions.txt");
                using StreamReader reader = new(filePath);
                string? line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.Contains('='))
                    {
                        string[] values = line.Split('=');
                        if (values.Length == 2)
                        {
                            winConditionRules.Add(values[0].Trim(), values[1].Trim());
                        }
                    }
                }
            }
            catch (IOException e)
            {
                MessageBox.Show("THE FILE CANNOT BE READ! " + e.Message);
            }
        }

        private void SetButtonState(Button[] button, bool isEnabled, string imageFilePath)
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

        private void resetButton_Click(object sender, EventArgs e)
        {
            ResetGameButton();
        }

        private void ResetGameButton()
        {
            ResetScores(gameScores, gameLabels);
            ResetScores(gameRoundScores, gameRoundLabels);
            SetButtonState(numberOfGamesButton, true, blueButtonImagePath);
            SetButtonState(gameFlowButtons, false, redButtonImagePath);
        }

        private void ExitProgram()
        {
            Application.Exit();
        }

        private void InitializeGamePlayButtonsListener()
        {
            for (int i = 0; i < gameFlowButtons.Length; i++)
            {
                GamePlayButtons(gameFlowButtons[i]);
            }
        }

        private void InitializeNumberOfGamesButtonsListener()
        {
            for (int i = 0; i < numberOfGamesButton.Length; i++)
            {
                NumberOfGamesButtonListener(numberOfGamesButton[i]);
            }
        }

        private void NumberOfGamesButtonListener(Button buttons)
        {
            buttons.Click += (sender, e) =>
            {
                turns = SetNumberOfGames(sender, e);
                turns = level;
            };
        }

        private void GamePlayButtons(Button buttons)
        {
            buttons.Click += (sender, e) =>
            {
                if (gameStatus == GameStatus.GAME_IN_PROGRESS)
                {
                    SetChoice(sender, e);
                    ResolveRound();
                }
            };
        }

        private void SetChoice(Object sender, EventArgs e)
        {
            Object source = sender;
            for (int i = 0; i < gameFlowButtons.Length; i++)
            {
                if (source == gameFlowButtons[i])
                {
                    playerChoosenChoice = i;
                    PrintOutPlayerChoice(gameFlowLabels[0], Images.gameImages[i]);
                }
            }
        }

        private void PrintOutPlayerChoice(PictureBox pb, Image image)
        {
            pb.Image = image;
        }

        private int SetNumberOfGames(Object sender, EventArgs e)
        {
            Object source = sender;
            for (int i = 0; i < numberOfGamesButton.Length; i++)
            {
                if (source == numberOfGamesButton[i])
                {
                    buttonId = buttonNumbers[i];
                    selectedMode = roundNumbers[i];
                }
            }
            SetButtonState(numberOfGamesButton, false, "Resources/button_bg2.png");
            SetButtonState(gameFlowButtons, true, "Resources/button_bg.png");
            turns = ProcessButtonClicked();
            return buttonId;

        }

        private void ResolveRound()
        {
            computerChoosenChoice = GetComputerChoice();
            SetComputerImage();
            CheckWhoWon();
            ClearImageTask();

        }

        private int GetComputerChoice()
        {
            return RANDOM_GENERATOR.Next(Images.gameImages.Length);
        }

        private void SetComputerImage()
        {
            computerChoice.Image = Images.gameImages[computerChoosenChoice];
        }

        private int ProcessButtonClicked()
        {
            for (int i = 0; i < buttonNumbers.Length; i++)
            {
                if (buttonId == buttonNumbers[i])
                {
                    level = numberOfRounds[i];
                    roundsRemaining = level;
                    targetWins = CalculateTargetWins(level);
                    activeLabel = numberOfGamesLabel[i];
                    PrintOutNumberOfGamesSelected(activeLabel, numberOfRounds[i]);
                }
            }
            return buttonId;
        }

        private void InitializeWinningConditions()
        {
            conditions = new Dictionary<int, int[]>
            {
                { 0,new int[] {2,3}},
                { 1,new int[] {0,4}},
                { 2,new int[] {1,3}},
                { 3,new int[] {1,4}},
                { 4,new int[] {0,2}}
            };
        }

        private void CheckWhoWon()
        {
            Dictionary<string, Func<bool>> winConditions = new Dictionary<string, Func<bool>>
            {
                { GetGameMessage("computerWon"),()=>HasComputerWon()},
                { GetGameMessage("playerWon"),()=>HasPlayerWon() },
                { GetGameMessage("gameIsDraw"),()=>IsGameDrawn() }
            };
            foreach (var gameCondition in winConditions)
            {
                if (gameCondition.Value())
                {
                    PrintOutWhoWonGame(gameCondition.Key);
                    ScheduleClearScreenText();
                    int winnerResultIndex = GetWinnerIndex();
                    UpdateScores(gameScores, gameLabels, winnerResultIndex);
                    CheckRoundWinner();
                    break;
                }
            }
        }

        private string GetGameMessage(string key)
        {
            if (winConditionRules.TryGetValue(key, out string? message))
            {
                return message;
            }
            else
            {
                return "MESSAGE NOT FOUND FOR KEY! " + key;
            }
        }

        private async void ClearImageTask()
        {
            await RunDelayedTasks(3000, ResetGameImage);
        }

        private async void ScheduleClearScreenText()
        {
            await RunDelayedTasks(3000, () =>
            {
                PrintOutWhoWonGame("");
            });
        }

        private bool HasComputerWon()
        {
            return conditions[computerChoosenChoice].Contains(playerChoosenChoice);
        }

        private bool HasPlayerWon()
        {
            return conditions[playerChoosenChoice].Contains(computerChoosenChoice);
        }

        private bool IsGameDrawn()
        {
            return computerChoosenChoice == playerChoosenChoice;
        }



        private int CalculateTargetWins(int totalRounds)
        {
            return (totalRounds / 2) + 1;
        }

        private void PrintOutNumberOfGamesSelected(Label label, int numberOfGames)
        {
            label.Text = $"{numberOfGames}";
        }

        private void PrintOutWhoWonGame(string message)
        {
            printOutWhoWonLabel.Text = message;
        }

        private int GetWinnerIndex()
        {
            int winnerIndex = gameWinnerIndex;
            if (HasPlayerWon())
            {
                return winnerIndex = 0;
            }else if (HasComputerWon())
            {
                return winnerIndex = 1;
            }
            return -1;
        }

        private void CheckRoundWinner()
        {
            for(int i = 0; i<gameScores.Length; i++)
            {
                if (gameScores[i] >= level)
                {
                    UpdateScores(gameRoundScores, gameRoundLabels, i);
                    roundsRemaining--;
                    ResetScores(gameScores, gameLabels);
                    PrintOutCurrentScores(gameScores[0], gameLabels[0]);
                    PrintOutCurrentScores(gameScores[1], gameLabels[1]);
                    PrintOutNumberOfGamesSelected(activeLabel, roundsRemaining);
                    CheckRoundTurns();
                    break;

                }
            }
        }

        private void CheckRoundTurns()
        {
            for(int i = 0; i < gameRoundScores.Length; i++)
            {
                if (gameRoundScores[i] >= targetWins)
                {
                    gameStatus = GameStatus.GAME_OVER;
                    PrintOutWhoWonGame("GAME OVER! " + message + "WINS!");
                    SetButtonState(gameFlowButtons, false, redButtonImagePath);
                    SetButtonState(numberOfGamesButton, true, blueButtonImagePath);
                    ResetScores(gameScores, gameLabels);
                    ResetScores(gameScores, gameRoundLabels);
                }
            }
        }

        private void UpdateScores(int[] scores, Label[] scoreLabel, int index)
        {
            for(int i = 0; i < scores.Length; i++)
            {
                if(i == index)
                {
                    scores[i]++;
                    PrintOutCurrentScores(scores[i], scoreLabel[i]);
                }
            }
        }

        private void ResetGameImage()
        {
            for (int i = 0; i < gameFlowLabels.Length; i++)
            {
                gameFlowLabels[i].Image = null;
            }
        }

        private void ResetScores(int[] scores, Label[] label)
        {
            for(int i = 0; i < scores.Length; i++)
            {
                scores[i] = 0;
                PrintOutCurrentScores(scores[i], label[i]);
            }
        }

        private void PrintOutCurrentScores(int scores,Label label)
        {
            label.Text = $"{scores}";
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

        





        //private bool HasComputerWon()
        //{
        //    return (computerChoosenChoice == 0 && playerChoosenChoice == 2) ||
        //          (computerChoosenChoice == 0 && playerChoosenChoice == 3) ||
        //          (computerChoosenChoice == 2 && playerChoosenChoice == 1) ||
        //          (computerChoosenChoice == 2 && playerChoosenChoice == 3) ||
        //          (computerChoosenChoice == 1 && playerChoosenChoice == 0) ||
        //          (computerChoosenChoice == 1 && playerChoosenChoice == 4) ||
        //          (computerChoosenChoice == 3 && playerChoosenChoice == 1) ||
        //          (computerChoosenChoice == 3 && playerChoosenChoice == 4) ||
        //          (computerChoosenChoice == 4 && playerChoosenChoice == 0) ||
        //          (computerChoosenChoice == 4 && playerChoosenChoice == 2);
        //}

        //private bool HasPlayerWon()
        //{
        //    return(playerChoosenChoice == 0 && computerChoosenChoice == 3) ||
        //          (playerChoosenChoice == 0 && computerChoosenChoice == 2) ||
        //          (playerChoosenChoice == 2 && computerChoosenChoice == 1) ||
        //          (playerChoosenChoice == 2 && computerChoosenChoice == 3) ||
        //          (playerChoosenChoice == 1 && computerChoosenChoice == 0) ||
        //          (playerChoosenChoice == 1 && computerChoosenChoice == 4) ||
        //          (playerChoosenChoice == 3 && computerChoosenChoice == 1) ||
        //          (playerChoosenChoice == 3 && computerChoosenChoice == 4) ||
        //          (playerChoosenChoice == 4 && computerChoosenChoice == 0) ||
        //          (playerChoosenChoice == 4 && computerChoosenChoice == 2);

        //}

        //private bool IsGameDrawn()
        //{
        //    return playerChoosenChoice == computerChoosenChoice;
        //}
    }
}
