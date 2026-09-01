namespace RockPaperScissorsLizardSpock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            headingLabel = new Label();
            rockButton = new Button();
            paperButton = new Button();
            scissorsButton = new Button();
            lizardButton = new Button();
            spockButton = new Button();
            resetButton = new Button();
            exitButton = new Button();
            bestOfFiveButton = new Button();
            bestOfThreeButton = new Button();
            bestOfTenButton = new Button();
            playerRoundScore = new Label();
            bestOfThreeLabel = new Label();
            bestOfTenLabel = new Label();
            bestOfFiveLabel = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label1 = new Label();
            label7 = new Label();
            computerRoundScore = new Label();
            label9 = new Label();
            playerScore = new Label();
            computerScore = new Label();
            playerChoice = new PictureBox();
            computerChoice = new PictureBox();
            printOutWhoWonLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)playerChoice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)computerChoice).BeginInit();
            SuspendLayout();
            // 
            // headingLabel
            // 
            headingLabel.Font = new Font("Snap ITC", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headingLabel.Location = new Point(85, 9);
            headingLabel.Name = "headingLabel";
            headingLabel.Size = new Size(635, 49);
            headingLabel.TabIndex = 0;
            headingLabel.Text = "Rock Paper Scissors Lizard Spock";
            headingLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // rockButton
            // 
            rockButton.BackgroundImage = (Image)resources.GetObject("rockButton.BackgroundImage");
            rockButton.BackgroundImageLayout = ImageLayout.Stretch;
            rockButton.FlatAppearance.BorderSize = 0;
            rockButton.FlatStyle = FlatStyle.Flat;
            rockButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rockButton.Location = new Point(27, 61);
            rockButton.Name = "rockButton";
            rockButton.Size = new Size(148, 54);
            rockButton.TabIndex = 1;
            rockButton.Text = "Rock";
            rockButton.UseVisualStyleBackColor = true;
            // 
            // paperButton
            // 
            paperButton.BackgroundImage = (Image)resources.GetObject("paperButton.BackgroundImage");
            paperButton.BackgroundImageLayout = ImageLayout.Stretch;
            paperButton.FlatAppearance.BorderSize = 0;
            paperButton.FlatStyle = FlatStyle.Flat;
            paperButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            paperButton.Location = new Point(181, 61);
            paperButton.Name = "paperButton";
            paperButton.Size = new Size(148, 54);
            paperButton.TabIndex = 2;
            paperButton.Text = "Paper";
            paperButton.UseVisualStyleBackColor = true;
            // 
            // scissorsButton
            // 
            scissorsButton.BackgroundImage = (Image)resources.GetObject("scissorsButton.BackgroundImage");
            scissorsButton.BackgroundImageLayout = ImageLayout.Stretch;
            scissorsButton.FlatAppearance.BorderSize = 0;
            scissorsButton.FlatStyle = FlatStyle.Flat;
            scissorsButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scissorsButton.Location = new Point(335, 61);
            scissorsButton.Name = "scissorsButton";
            scissorsButton.Size = new Size(148, 54);
            scissorsButton.TabIndex = 3;
            scissorsButton.Text = "Scissors";
            scissorsButton.UseVisualStyleBackColor = true;
            // 
            // lizardButton
            // 
            lizardButton.BackgroundImage = (Image)resources.GetObject("lizardButton.BackgroundImage");
            lizardButton.BackgroundImageLayout = ImageLayout.Stretch;
            lizardButton.FlatAppearance.BorderSize = 0;
            lizardButton.FlatStyle = FlatStyle.Flat;
            lizardButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lizardButton.Location = new Point(489, 61);
            lizardButton.Name = "lizardButton";
            lizardButton.Size = new Size(148, 54);
            lizardButton.TabIndex = 4;
            lizardButton.Text = "Lizard";
            lizardButton.UseVisualStyleBackColor = true;
            // 
            // spockButton
            // 
            spockButton.BackgroundImage = (Image)resources.GetObject("spockButton.BackgroundImage");
            spockButton.BackgroundImageLayout = ImageLayout.Stretch;
            spockButton.FlatAppearance.BorderSize = 0;
            spockButton.FlatStyle = FlatStyle.Flat;
            spockButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            spockButton.Location = new Point(640, 60);
            spockButton.Name = "spockButton";
            spockButton.Size = new Size(148, 55);
            spockButton.TabIndex = 5;
            spockButton.Text = "Spock";
            spockButton.UseVisualStyleBackColor = true;
            // 
            // resetButton
            // 
            resetButton.BackgroundImage = (Image)resources.GetObject("resetButton.BackgroundImage");
            resetButton.BackgroundImageLayout = ImageLayout.Stretch;
            resetButton.FlatAppearance.BorderSize = 0;
            resetButton.FlatStyle = FlatStyle.Flat;
            resetButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            resetButton.Location = new Point(27, 161);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(148, 54);
            resetButton.TabIndex = 6;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += resetButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackgroundImage = (Image)resources.GetObject("exitButton.BackgroundImage");
            exitButton.BackgroundImageLayout = ImageLayout.Stretch;
            exitButton.FlatAppearance.BorderSize = 0;
            exitButton.FlatStyle = FlatStyle.Flat;
            exitButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(27, 252);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(148, 54);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // bestOfFiveButton
            // 
            bestOfFiveButton.BackgroundImage = (Image)resources.GetObject("bestOfFiveButton.BackgroundImage");
            bestOfFiveButton.BackgroundImageLayout = ImageLayout.Stretch;
            bestOfFiveButton.FlatAppearance.BorderSize = 0;
            bestOfFiveButton.FlatStyle = FlatStyle.Flat;
            bestOfFiveButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bestOfFiveButton.Location = new Point(389, 359);
            bestOfFiveButton.Name = "bestOfFiveButton";
            bestOfFiveButton.Size = new Size(148, 59);
            bestOfFiveButton.TabIndex = 8;
            bestOfFiveButton.Text = "Best Of Five Games";
            bestOfFiveButton.UseVisualStyleBackColor = true;
            // 
            // bestOfThreeButton
            // 
            bestOfThreeButton.BackgroundImage = (Image)resources.GetObject("bestOfThreeButton.BackgroundImage");
            bestOfThreeButton.BackgroundImageLayout = ImageLayout.Stretch;
            bestOfThreeButton.FlatAppearance.BorderSize = 0;
            bestOfThreeButton.FlatStyle = FlatStyle.Flat;
            bestOfThreeButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bestOfThreeButton.Location = new Point(181, 363);
            bestOfThreeButton.Name = "bestOfThreeButton";
            bestOfThreeButton.Size = new Size(148, 55);
            bestOfThreeButton.TabIndex = 9;
            bestOfThreeButton.Text = "Best Of Three Games";
            bestOfThreeButton.UseVisualStyleBackColor = true;
            // 
            // bestOfTenButton
            // 
            bestOfTenButton.BackgroundImage = (Image)resources.GetObject("bestOfTenButton.BackgroundImage");
            bestOfTenButton.BackgroundImageLayout = ImageLayout.Stretch;
            bestOfTenButton.FlatAppearance.BorderSize = 0;
            bestOfTenButton.FlatStyle = FlatStyle.Flat;
            bestOfTenButton.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bestOfTenButton.Location = new Point(572, 359);
            bestOfTenButton.Name = "bestOfTenButton";
            bestOfTenButton.Size = new Size(148, 59);
            bestOfTenButton.TabIndex = 10;
            bestOfTenButton.Text = "Best Of Ten Games";
            bestOfTenButton.UseVisualStyleBackColor = true;
            // 
            // playerRoundScore
            // 
            playerRoundScore.Location = new Point(208, 344);
            playerRoundScore.Name = "playerRoundScore";
            playerRoundScore.Size = new Size(15, 15);
            playerRoundScore.TabIndex = 11;
            playerRoundScore.Text = "0";
            // 
            // bestOfThreeLabel
            // 
            bestOfThreeLabel.AutoSize = true;
            bestOfThreeLabel.Location = new Point(241, 426);
            bestOfThreeLabel.Name = "bestOfThreeLabel";
            bestOfThreeLabel.Size = new Size(13, 15);
            bestOfThreeLabel.TabIndex = 12;
            bestOfThreeLabel.Text = "0";
            // 
            // bestOfTenLabel
            // 
            bestOfTenLabel.AutoSize = true;
            bestOfTenLabel.Location = new Point(640, 426);
            bestOfTenLabel.Name = "bestOfTenLabel";
            bestOfTenLabel.Size = new Size(13, 15);
            bestOfTenLabel.TabIndex = 13;
            bestOfTenLabel.Text = "0";
            // 
            // bestOfFiveLabel
            // 
            bestOfFiveLabel.AutoSize = true;
            bestOfFiveLabel.Location = new Point(454, 426);
            bestOfFiveLabel.Name = "bestOfFiveLabel";
            bestOfFiveLabel.Size = new Size(13, 15);
            bestOfFiveLabel.TabIndex = 14;
            bestOfFiveLabel.Text = "0";
            // 
            // label2
            // 
            label2.Location = new Point(168, 345);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 15;
            label2.Text = "Player";
            // 
            // label3
            // 
            label3.Location = new Point(197, 327);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 16;
            label3.Text = "Round Score";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.Location = new Point(221, 344);
            label4.Name = "label4";
            label4.Size = new Size(14, 15);
            label4.TabIndex = 17;
            label4.Text = "-";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.Location = new Point(445, 326);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 18;
            label5.Text = "GameScore";
            // 
            // label6
            // 
            label6.Location = new Point(415, 341);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 19;
            label6.Text = "Player";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Location = new Point(471, 341);
            label1.Name = "label1";
            label1.Size = new Size(12, 15);
            label1.TabIndex = 20;
            label1.Text = "-";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.Location = new Point(489, 341);
            label7.Name = "label7";
            label7.Size = new Size(64, 13);
            label7.TabIndex = 21;
            label7.Text = "Computer";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // computerRoundScore
            // 
            computerRoundScore.Location = new Point(229, 344);
            computerRoundScore.Name = "computerRoundScore";
            computerRoundScore.Size = new Size(17, 15);
            computerRoundScore.TabIndex = 22;
            computerRoundScore.Text = "0";
            // 
            // label9
            // 
            label9.Location = new Point(241, 343);
            label9.Name = "label9";
            label9.Size = new Size(63, 15);
            label9.TabIndex = 23;
            label9.Text = "Computer";
            // 
            // playerScore
            // 
            playerScore.Location = new Point(457, 341);
            playerScore.Name = "playerScore";
            playerScore.Size = new Size(10, 15);
            playerScore.TabIndex = 24;
            playerScore.Text = "0";
            // 
            // computerScore
            // 
            computerScore.Location = new Point(480, 341);
            computerScore.Name = "computerScore";
            computerScore.Size = new Size(12, 15);
            computerScore.TabIndex = 25;
            computerScore.Text = "0";
            // 
            // playerChoice
            // 
            playerChoice.Location = new Point(216, 137);
            playerChoice.Name = "playerChoice";
            playerChoice.Size = new Size(114, 141);
            playerChoice.SizeMode = PictureBoxSizeMode.Zoom;
            playerChoice.TabIndex = 26;
            playerChoice.TabStop = false;
            // 
            // computerChoice
            // 
            computerChoice.Location = new Point(489, 137);
            computerChoice.Name = "computerChoice";
            computerChoice.Size = new Size(118, 141);
            computerChoice.SizeMode = PictureBoxSizeMode.Zoom;
            computerChoice.TabIndex = 27;
            computerChoice.TabStop = false;
            // 
            // printOutWhoWonLabel
            // 
            printOutWhoWonLabel.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            printOutWhoWonLabel.Location = new Point(241, 283);
            printOutWhoWonLabel.Name = "printOutWhoWonLabel";
            printOutWhoWonLabel.Size = new Size(341, 31);
            printOutWhoWonLabel.TabIndex = 28;
            printOutWhoWonLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(800, 450);
            Controls.Add(printOutWhoWonLabel);
            Controls.Add(computerChoice);
            Controls.Add(playerChoice);
            Controls.Add(computerScore);
            Controls.Add(playerScore);
            Controls.Add(label9);
            Controls.Add(computerRoundScore);
            Controls.Add(label7);
            Controls.Add(label1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(bestOfFiveLabel);
            Controls.Add(bestOfTenLabel);
            Controls.Add(bestOfThreeLabel);
            Controls.Add(playerRoundScore);
            Controls.Add(bestOfTenButton);
            Controls.Add(bestOfThreeButton);
            Controls.Add(bestOfFiveButton);
            Controls.Add(exitButton);
            Controls.Add(resetButton);
            Controls.Add(spockButton);
            Controls.Add(lizardButton);
            Controls.Add(scissorsButton);
            Controls.Add(paperButton);
            Controls.Add(rockButton);
            Controls.Add(headingLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)playerChoice).EndInit();
            ((System.ComponentModel.ISupportInitialize)computerChoice).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingLabel;
        private Button rockButton;
        private Button paperButton;
        private Button scissorsButton;
        private Button lizardButton;
        private Button spockButton;
        private Button resetButton;
        private Button exitButton;
        private Button bestOfFiveButton;
        private Button bestOfThreeButton;
        private Button bestOfTenButton;
        private Label playerRoundScore;
        private Label bestOfThreeLabel;
        private Label bestOfTenLabel;
        private Label bestOfFiveLabel;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label1;
        private Label label7;
        private Label computerRoundScore;
        private Label label9;
        private Label playerScore;
        private Label computerScore;
        private PictureBox playerChoice;
        private PictureBox computerChoice;
        private Label printOutWhoWonLabel;
    }
}
