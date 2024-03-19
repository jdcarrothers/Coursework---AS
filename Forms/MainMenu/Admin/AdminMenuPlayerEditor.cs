using Coursework_0._0.Classes;
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

namespace Coursework_0._0.Forms.MainMenu.Admin
{
    public partial class AdminMenuPlayerEditor : Form
    {
        List<Player> playerList = new List<Player>();
        Player CurrentPlayer;
        public AdminMenuPlayerEditor()
        {
            InitializeComponent();
            btnRemovePlayer.Enabled = false;
        }
        // Read the questions from the file
        private List<Player> ReadPlayersFromFile()
        {
            List<Player> players = new List<Player>();
            Stream sr;
            BinaryFormatter bf = new BinaryFormatter();

            try
            {
                sr = File.OpenRead("Players.bin");
                players = (List<Player>)bf.Deserialize(sr);
                sr.Close();
            }
            catch (FileNotFoundException)
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading player data: " + ex.Message);
            }
            return players;
        }
        // Remove the selected user from the list
        private void RemoveSelectedUser()
        {
            if (listBoxPlayer.SelectedItem != null)
            {
                pbAvatar.Image = null;
                int selectedIndex = listBoxPlayer.SelectedIndex;
                playerList.RemoveAt(selectedIndex);
                SaveQuestions();
                ShowPlayers();
                btnRequestEdit.Enabled = false;
                ensureDisabledTextBoxes();
                btnConfirm.Visible = false;
                ClearTextBoxes();
                listBoxPlayer.ClearSelected();
                lblCorrections.Visible = false;
                MessageBox.Show("Player removed succsesfully");
                
            }
            else
            {
                MessageBox.Show("Make sure you have an index selected in the list box");
            }
        }
        // Clear the textboxes
        private void ClearTextBoxes()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }
        // Save the players to the players to the bin file
        private void SaveQuestions()
        {
            try
            {
                using (Stream sr = File.OpenWrite("Players.bin"))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(sr, playerList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Show the players in the listbox
        private void ShowPlayers()
        {
            listBoxPlayer.Items.Clear();
            foreach (Player player in playerList)
            {
                listBoxPlayer.Items.Add(player.Username);
            }
        }
        // When a player is selected in the listbox
        private void listBoxPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPlayer.SelectedItem != null)
            {
                int selectedIndex = listBoxPlayer.SelectedIndex;
                Player selectedPlayer = playerList[selectedIndex];
                CurrentPlayer = selectedPlayer;
                if (selectedPlayer.Username == "admin")
                {
                    ensureDisabledTextBoxes();
                    lblCorrections.Visible = false;
                    btnRemovePlayer.Enabled = false;
                    btnRequestEdit.Enabled = false;
                    label1.Visible = true;
                    label3.ForeColor = Color.Gray;
                    label12.ForeColor = Color.Gray;
                    label13.ForeColor = Color.Gray;
                    lblSelectedPlayerHighScore.ForeColor = Color.Gray;
                    lblSelectedPlayerScore.ForeColor = Color.Gray;
                    lblSelectedPlayerHardHighScore.ForeColor = Color.Gray;
                    txtPassword.Text = selectedPlayer.Password;
                    txtUsername.Text = selectedPlayer.Username;
                    checkBox1.Checked = selectedPlayer.AdminSatus ? checkBox1.Checked = true : checkBox1.Checked = false;
                    lblSelectedPlayerScore.Text = $"Score: {selectedPlayer.Score}";
                    lblSelectedPlayerHighScore.Text = $"Easy highscore: {selectedPlayer.HighScore}";
                    lblSelectedPlayerHardHighScore.Text = $"Hard highscore: {selectedPlayer.HardHighScore}";
                    pbAvatar.Image = selectedPlayer.Avatar;
                }

                else
                {
                    lblCorrections.Visible = true;
                    btnRemovePlayer.Enabled = true;
                    btnRequestEdit.Enabled = true;
                    btnConfirm.Enabled = false;
                    checkBox1.Enabled = true;
                    ensureDisabledTextBoxes();
                    label1.Visible = false;
                    label12.ForeColor = Color.Black;
                    label13.ForeColor = Color.Black;
                    lblSelectedPlayerHighScore.ForeColor = Color.Black;
                    lblSelectedPlayerHardHighScore.ForeColor = Color.Black;
                    lblSelectedPlayerScore.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    txtPassword.Text = selectedPlayer.Password;
                    txtUsername.Text = selectedPlayer.Username;
                    checkBox1.Checked = selectedPlayer.AdminSatus ? checkBox1.Checked = true : checkBox1.Checked = false;
                    lblSelectedPlayerScore.Text = $"Score: {selectedPlayer.Score}";
                    lblSelectedPlayerHighScore.Text = $"Highscore: {selectedPlayer.HighScore}";
                    lblSelectedPlayerHardHighScore.Text = $"Hard highscore: {selectedPlayer.HardHighScore}";
                    pbAvatar.Image = selectedPlayer.Avatar;
                }
            }
        }
        // Check if the password contains a number
        private bool ContainsNum(string password)
        {
            foreach (char character in password)
            {
                if (Char.IsDigit(character))
                    return true;
            }
            return false;
        }
        bool txtPasLength = false;
        bool txtNumberInPass = false;
        bool txtUsernameLength = false;
        // Check the textboxes
        private void Check(object sender, EventArgs e)
        {
            txtPasLength = txtPassword.TextLength >= 7; // Check if password length is at least 7 characters
            txtNumberInPass = ContainsNum(txtPassword.Text); // Check if password contains a number
            txtUsernameLength = txtUsername.TextLength >= 5; // Check if username length is at max  characters

            btnConfirm.Enabled = txtPasLength && txtUsernameLength && txtNumberInPass && txtUsername.Text != "admin";
            lblCorrections.Visible = true;
            if (!btnConfirm.Enabled)
            {
                if (!txtPasLength)
                {
                    lblCorrections.Text = "Password should be at least\n 7 characters";
                    lblCorrections.ForeColor = Color.Maroon;
                }
                else if (!txtNumberInPass)
                {
                    lblCorrections.Text = "Password should contain at\n least one number";
                    lblCorrections.ForeColor = Color.Maroon;
                }
                else if (!txtUsernameLength)
                {
                    lblCorrections.Text = "Username should more than\n 5 characters";
                    lblCorrections.ForeColor = Color.Maroon;
                }
            }
            else
            {
                lblCorrections.Text = "Checks Passed";
                lblCorrections.ForeColor = Color.Lime;
            }
        }
        // Edit the selected player
        private void EditSelectedQuestion(Player editedPlayer)
        {
            if (listBoxPlayer.SelectedItem != null)
            {
                int selectedIndex = listBoxPlayer.SelectedIndex;
                playerList.RemoveAt(selectedIndex);
                // Add the edited question to the list at the same index
                playerList.Insert(selectedIndex, editedPlayer);
                SaveQuestions();
                ShowPlayers();
            }
        }
        // Confirm the edit
        private void ConfirmEdit(Player CurrentPlayer)
        {
            // Get the edited data from textboxes
            string editedUsername = txtUsername.Text;
            string editedPassword = txtPassword.Text;
            int passThroughHighScore = CurrentPlayer.HighScore;
            int passThroughScore = CurrentPlayer.Score;
            Image passthroughImage = CurrentPlayer.Avatar;
            bool adminStaus = checkBox1.Checked;

            // Create the edited Player object
            Player editedPlayer = new Player();
            editedPlayer.Username = editedUsername;
            editedPlayer.Password = editedPassword;
            editedPlayer.AdminSatus = adminStaus;
            editedPlayer.HighScore = passThroughHighScore;
            editedPlayer.Score = passThroughScore;
            editedPlayer.Avatar = passthroughImage;
            // Call the method to edit the selected player
            EditSelectedQuestion(editedPlayer);
        }
        // confirm the edit when the button is clicked, and disable the textboxes again,  and clear the textboxes, and clear the selected index
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to change", "change?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                btnRequestEdit.Enabled = false;
                ensureDisabledTextBoxes();
                ConfirmEdit(CurrentPlayer);
                btnConfirm.Visible = false;
                ClearTextBoxes();
                listBoxPlayer.ClearSelected();
                lblCorrections.Visible = false;
                btnRequestEdit.Enabled = true;
            }
        }
        // Remove the selected player when the button is clicked
        private void btnRemovePlayer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove", "Remove?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoveSelectedUser();
            }
        }
        // Load the form
        private void AdminMenuPlayerEditor_Load(object sender, EventArgs e)
        {
            playerList = ReadPlayersFromFile();
            ShowPlayers();
            ensureDisabledTextBoxes();
            lblCorrections.Visible = false;
        }
        // Handells edit button click
        private void btnRequestEdit_Click(object sender, EventArgs e)
        {
            btnRequestEdit.Enabled = false;
            txtUsername.Enabled = true;
            txtPassword.Enabled = true;
            btnConfirm.Visible = true;
            btnConfirm.Enabled = true;
            checkBox1.Enabled = true;
            btnRemovePlayer.Enabled = false;
        }
        // Deselect the index
        private void btnDeselectIndex_Click(object sender, EventArgs e)
        {
            btnRemovePlayer.Enabled = false;
            btnRequestEdit.Enabled = false;
            listBoxPlayer.ClearSelected();
            ClearTextBoxes();
            ensureDisabledTextBoxes();
            lblCorrections.Visible = false;
        }
        // When the form is closed
        private void ensureDisabledTextBoxes()
        {
            txtPassword.Enabled = false;
            txtUsername.Enabled = false;
            checkBox1.Enabled = false;
        }
        // Add a new player
        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;
            parentForm.LoadChildForm(new AdminSideAddPlayer());
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
