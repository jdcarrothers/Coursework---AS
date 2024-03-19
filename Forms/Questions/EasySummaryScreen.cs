using Coursework_0._0.Classes;
using Coursework_0._0.Forms.MainMenu;
using Coursework_0._0.Forms.Question;
using Coursework_0._0.Forms.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_0._0.Forms.Questions
{
    public partial class EasySummaryScreen : QuestionTemplate
    {
        Player currentPlayer;
        int tempScore;
        List<Player> playersList = new List<Player>();
        string EasyMessage;
        char result;
        bool EasySelected;
        public EasySummaryScreen(int tempscore, bool easySelected)
        {
            InitializeComponent();
            tempScore = tempscore;
            EasySelected = easySelected;
            base.SetNewScore(tempscore);
        }

        private void EasySummaryScreen_Load(object sender, EventArgs e)
        {
            // Load the current player
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;
            currentPlayer = parentForm.getCurrentPlayer;
            currentPlayer.Score += tempScore;
            if (EasySelected)
            {
                if (currentPlayer.HighScore == tempScore)
                {
                    EasyMessage = "You scored the same your highscore";
                    result = 'S';//s for same
                }
                else if (currentPlayer.HighScore > tempScore)
                {
                    EasyMessage = "You scored less than last time";
                    result = 'L';// l for less

                }
                else if (currentPlayer.HighScore < tempScore && currentPlayer.HighScore != 0)
                {
                    currentPlayer.HighScore = tempScore;
                    EasyMessage = "Congratulations, you beat your high score";
                    result = 'B';// b for beat
                }
                else if (currentPlayer.HighScore == 0)
                {
                    currentPlayer.HighScore = tempScore;
                    EasyMessage = "Your first attempt on the easy quiz!";
                    result = 'F';// F for first attempt
                }
                base.SetQuestionLabel("Easy quiz leaderboard:");
            }
            else
            {
                if (currentPlayer.HardHighScore == tempScore)
                {
                    EasyMessage = "You scored the same your highscore";
                    result = 'S';//s for same
                }
                else if (currentPlayer.HardHighScore > tempScore)
                {
                    EasyMessage = "You scored less than last time";
                    result = 'L';// l for less

                }
                else if (currentPlayer.HardHighScore < tempScore && currentPlayer.HardHighScore != 0)
                {
                    currentPlayer.HardHighScore = tempScore;
                    EasyMessage = "Congratulations, you beat your high score";
                    result = 'B';// b for beat
                }
                else if (currentPlayer.HardHighScore == 0)
                {
                    currentPlayer.HardHighScore = tempScore;
                    EasyMessage = "Your first attempt at the hard quiz!";
                    result = 'F';// F for first attempt
                }
                base.SetQuestionLabel("Hard quiz leaderboard:");
            }
            SaveNewScoreToFile(currentPlayer);
            readFileToList();
            FillLeaderboardTable(playersList);
            SupportMessage(result);
            base.EasySetSummaryScreen($"{tempScore}                          {EasyMessage}");
            parentForm.SetLabelOnLoad();
            base.ClearSubmitAndNextPB();
            base.ClearProgressBar();
            if (EasySelected)
                base.setUpdatedHS(currentPlayer.HighScore, EasySelected);
        }
        private void SupportMessage(char result)
        {
            // Display a message based on the result of the quiz
            switch (result)
            {
                case 'S':
                    lblResultMessage.Text = "Bravo! Scoring the same as your previous high score is a testament to your consistency and knowledge. Even though you didn't exceed your record, maintaining this level of achievement is remarkable. Keep nurturing your skills and exploring new horizons. Your commitment shows that you're on the right path towards continuous improvement!";
                    break;
                case 'L':
                    lblResultMessage.Text = "Don't be discouraged! Even though you didn't surpass your previous high score, remember that every attempt is a step forward. Use this as motivation to keep learning and exploring the fascinating world of technology and design. Your persistence will undoubtedly lead to new accomplishments in the future!";
                    break;
                case 'B':
                    lblResultMessage.Text = "Congratulations! You've surpassed your previous high score! Your dedication and improvement are truly commendable. This achievement showcases your progress and dedication to mastering technology and design. Keep up the fantastic work, and continue pushing your boundaries—you're on an incredible learning journey!";
                    break;
                case 'F':
                    lblResultMessage.Text = $"Congratulations on taking the plunge into the Tech and Design Quiz! Your decision to embark on this adventure speaks volumes about your curiosity and willingness to learn. Every attempt here is a testament to your courage and eagerness to explore the intricate world of technology and design. Your journey begins now, filled with exciting challenges and valuable discoveries.";
                        break;
                default:
                    break;
            }

        }
        private void readFileToList()
        {
            // Read the players from the file and store them in a list
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                sr = File.OpenRead("Players.bin");
                playersList = (List<Player>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveNewScoreToFile(Player player)
        {
            // Save the updated player score to the file
            try
            {
                List<Player> playersFromFile;
                using (Stream stream = File.OpenRead("Players.bin"))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    playersFromFile = (List<Player>)bf.Deserialize(stream);
                }
                var existingPlayer = playersFromFile.FirstOrDefault(p => p.Username == player.Username);
                if (existingPlayer != null)
                {
                    if (EasySelected)
                        existingPlayer.HighScore = player.HighScore;
                    else
                        existingPlayer.HardHighScore = player.HardHighScore;
                    existingPlayer.Score = player.Score;
                    using (Stream stream = File.OpenWrite("Players.bin"))
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        stream.Seek(0, SeekOrigin.Begin); // Move to the beginning of the file
                        bf.Serialize(stream, playersFromFile); // Serialize the updated player list
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        List<Player> sortedPlayers;
        private void FillLeaderboardTable(List<Player> playersList)
        {
            // Fill the leaderboard table with the top 5 players
            if (EasySelected)
            {
                sortedPlayers = playersList.OrderByDescending(p => p.HighScore).ToList();
            }
            else
            {
                sortedPlayers = playersList.OrderByDescending(p => p.HardHighScore).ToList();
            }
            leaderBoardTable.Controls.Clear();
            leaderBoardTable.RowStyles.Clear();
            leaderBoardTable.RowCount = 5;
            leaderBoardTable.ColumnCount = 3;
            leaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            leaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            leaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100));
            for (int i = 0; i < Math.Min(sortedPlayers.Count, 5); i++)
            {
                Player player = sortedPlayers[i];
                Label usernameLabel = new Label();
                usernameLabel.Text = player.Username;
                usernameLabel.Font = new Font("Segoe UI Semibold", 15, FontStyle.Bold);
                usernameLabel.TextAlign = ContentAlignment.MiddleCenter;
                Label scoreLabel = new Label();
                if(EasySelected)
                    scoreLabel.Text = player.HighScore.ToString();
                else
                    scoreLabel.Text = player.HardHighScore.ToString();
                scoreLabel.Font = new Font("Segoe UI Semibold", 15, FontStyle.Bold); 
                scoreLabel.TextAlign = ContentAlignment.MiddleCenter;
                PictureBox avatarBox = new PictureBox();
                avatarBox.SizeMode = PictureBoxSizeMode.Zoom;
                avatarBox.Image = player.Avatar;
                leaderBoardTable.Controls.Add(usernameLabel, 0, i);
                leaderBoardTable.Controls.Add(scoreLabel, 1, i);
                leaderBoardTable.Controls.Add(avatarBox, 2, i);
                leaderBoardTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }


        private void btnReplay_Click(object sender, EventArgs e)
        {
            // Replay the quiz
            EasyRadioButtonQuestion rb = new EasyRadioButtonQuestion(!EasySelected);
            rb.Tag = "a";
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;
            parentForm.LoadChildForm(rb);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
