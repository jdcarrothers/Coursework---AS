using Coursework_0._0.Classes;
using Coursework_0._0.Forms.Question;
using Coursework_0._0.Forms.Questions;
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

namespace Coursework_0._0.Forms.MainMenu
{
    public partial class MainMenu : Form
    {
        Player currentPlayer;
        List<Player> playersList = new List<Player>();
        public MainMenu()
        {
            InitializeComponent();
            readFileToList();
            FillLeaderboardTable(playersList);
            alert.Visible = true;
        }
        private void FillLeaderboardTable(List<Player> playersList)
        {
            // Sort players by high score in descending order
            var sortedPlayers = playersList.OrderByDescending(p => p.Score).ToList();
            // Clear any existing controls and set initial table properties
            leaderBoardTable.Controls.Clear();
            leaderBoardTable.RowStyles.Clear();
            leaderBoardTable.RowCount = 3;
            leaderBoardTable.ColumnCount = 3;

            // Define column styles for the table layout
            leaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // First column
            leaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50)); // Second column
            leaderBoardTable.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 100)); // Third column as square for avatars

            // Loop through players, limiting the display to 5 rows or the available player count
            for (int i = 0; i < Math.Min(sortedPlayers.Count, 3); i++)
            {
                Player player = sortedPlayers[i];

                // Create label for displaying player's username
                Label usernameLabel = new Label();
                usernameLabel.Text = player.Username;
                usernameLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Set font properties
                usernameLabel.TextAlign = ContentAlignment.MiddleCenter;

                // Create label for displaying player's high score
                Label scoreLabel = new Label();
                scoreLabel.Text = player.Score.ToString();
                scoreLabel.Font = new Font("Segoe UI", 12, FontStyle.Bold); // Set font properties
                scoreLabel.TextAlign = ContentAlignment.MiddleCenter;

                // Create PictureBox for displaying player's avatar
                PictureBox avatarBox = new PictureBox();
                avatarBox.SizeMode = PictureBoxSizeMode.Zoom; // Change to Zoom to fit the square without distortion
                avatarBox.Image = player.Avatar; // Set the player's avatar
                avatarBox.Size = new Size(50, 50); // Set the size of the PictureBox
                avatarBox.Margin = new Padding(0, 5, 0, 0); // Set margin to shift the PictureBox up by 5 pixels

                // Add labels and avatar to the table in their respective columns and rows
                leaderBoardTable.Controls.Add(usernameLabel, 0, i);
                leaderBoardTable.Controls.Add(scoreLabel, 1, i);
                leaderBoardTable.Controls.Add(avatarBox, 2, i); // Add the avatar to the table

                // Set row style for auto-sizing rows
                leaderBoardTable.RowStyles.Add(new RowStyle(SizeType.AutoSize));
            }
        }
        private void readFileToList()
        {
            // Read the players from the file and add them to the list
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
        List<ManageQuestions> questionsList = new List<ManageQuestions>();
        private void readFileToListQuestions()
        {
            // Read the questions from the file and add them to the list
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();
            try
            {
                sr = File.OpenRead("Questions.bin");
                questionsList = (List<ManageQuestions>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnGoToEasyQuestions_Click(object sender, EventArgs e)
        {
            //load parent form variable, allowing acsess t the code
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;

            readFileToListQuestions();
            if (questionsList.Count == 0)
            {
                // if no questions, skip to second question
                MessageBox.Show("No questions of this question type are available, contact an admin. You will be pushed onto the second question", "No questions available", MessageBoxButtons.OK);
                EasyDragAndDrop easyDragAndDrop = new EasyDragAndDrop(0, true); // false represents easy and true represents hard questions
                easyDragAndDrop.Tag = "a"; // A for active // Sets the Tag property for EasyTextDropDown form// allows program to distingyu
                parentForm.LoadChildForm(easyDragAndDrop);
                parentForm.SetLabelOnLoad();
            }
            else
            {
                // Load the easy questions form - first question
                EasyRadioButtonQuestion EasyRadioButtonQuestion = new EasyRadioButtonQuestion(false); // false represents easy and true represents hard questions
                EasyRadioButtonQuestion.Tag = "a"; // A for active // Sets the Tag property for EasyTextDropDown form// allows program to distingyu
                parentForm.LoadChildForm(EasyRadioButtonQuestion);
                parentForm.SetLabelOnLoad();
            }
        }

        private void btnGoToHardQuestions_Click(object sender, EventArgs e)
        {
            // Load the hard questions form
            EasyRadioButtonQuestion EasyRadioButtonQuestion = new EasyRadioButtonQuestion(true); // false represents easy and true represents hard questions
            EasyRadioButtonQuestion.Tag = "a"; // A for active // Sets the Tag property for EasyTextDropDown form// allows program to distingyu
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;
            parentForm.LoadChildForm(EasyRadioButtonQuestion);
            parentForm.SetLabelOnLoad();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Load the current player and set the high score labels
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;
            currentPlayer = parentForm.getCurrentPlayer;
            if (currentPlayer.Score >= 20)
            {
                pictureBox6.Visible = false;
                btnGoToHardQuestions.Enabled = true;
            }
            if (currentPlayer.Score >= 30)
                alert.Text = "Be sure to check out the minigame you've unlocked by achieving 30 points!";
            toolTip1.SetToolTip(pictureBox6, "Reach 20 points to unlock the hard varient");
            lblHighScore.Text = $"High Score: {currentPlayer.HighScore}";
            lblHardHighScore.Text = $"High Score: {currentPlayer.HardHighScore}";
        }
    }
}
