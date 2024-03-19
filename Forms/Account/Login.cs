using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using Coursework_0._0.Classes;
using Coursework_0._0.Forms;
using Coursework_0._0.Forms.MainMenu;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Coursework_0._0
{
    public partial class Login : Form
    {
        List<ManageQuestions> questionsList = new List<ManageQuestions>();
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public Login()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            AdminRegeneration();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Get the username and password from the text boxes
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            // Read the list of players from the file
            List<Player> players = ReadPlayersFromFile();
            Player foundPlayer = players.Find(player => player.Username == username && player.Password == password);

            if (foundPlayer != null)
            {
                this.Hide();
                Form newMainMenu = new MainMenuParentForm(foundPlayer);
                newMainMenu.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }

            UpdateListWithAllAskedBeforeFalse();

        }
        List<Player> players;
        //checks if the admin account exists
        private bool usernameExistsInList()
        {
            foreach (Player player in players)
            {
                if (player.Username == "admin")
                    return true;
            }
            return false;

        }
        //if the admin account does not exist, it will be created
        private void AdminRegeneration()
        {
            players = ReadPlayersFromFile(); //reads from file
            bool YesAdminExist = usernameExistsInList();

            if (!YesAdminExist) //no master admin exists
            {
                Player adminPlayer = new Player();
                adminPlayer.Username = "admin";
                adminPlayer.Password = "admin";
                adminPlayer.AdminSatus = true; //grant the admin account with all of the requirements so nothing is locked
                adminPlayer.Score = 100;
                adminPlayer.HighScore = 20;
                adminPlayer.HardHighScore = 25;
                players.Add(adminPlayer);
                Stream sw;
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    sw = File.OpenWrite("Players.bin");
                    bf.Serialize(sw, players);
                    sw.Close();
                }
                catch (SerializationException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        //reads the questions from the file
        private void readFileToListQuestions()
        {
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
        //saves the questions has seen atributes to true to the file
        private void SaveQuestions()
        {
            try
            {
                using (Stream sr = File.OpenWrite("Questions.bin"))
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(sr, questionsList);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //sets all questions to false
        private void UpdateListWithAllAskedBeforeFalse()
        {
            readFileToListQuestions();
            foreach (ManageQuestions question in questionsList)
            {
                question.AskedBefore = false;
            }
            SaveQuestions(); // saves all questions as false;
        }
        //reads the players from the file
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
                // Handle the case where the file does not exist.
                // You may want to create the file if it doesn't exist initially.
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while reading player data: " + ex.Message);
            }

            return players;
        }
        //checks if the admin account exists
        private void checkBoxShowPas_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
        //opens the register form
        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form RegisterForm = new Register();
            RegisterForm.Show();
        }
        //closes the application
        private void pbExit_Click(object sender, EventArgs e)
        {
            Point originalLocation = pbExit.Location;
            pbExit.Location = new Point(originalLocation.X + 2, originalLocation.Y + 2);//animates the exit button for user feedback
            System.Threading.Thread.Sleep(100);
            pbExit.Location = originalLocation;
            if (MessageBox.Show("Do you wish to exit the application?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //closes the application
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to quit?", "Quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        bool usernameEntered = false;
        bool passwordEntered = false;
        //btnLogin disabled on load
        //btnLogin enabled when both username and password are entered
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            usernameEntered = txtUsername.Text.Length >= 1;
            UpdateLoginButtonState();

        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            passwordEntered = txtPassword.Text.Length >= 1;
            UpdateLoginButtonState();
        }
        private void UpdateLoginButtonState()
        {
            // Enable the login button only if both username and password have been entered
            btnLogin.Enabled = usernameEntered && passwordEntered;
        }
    }
}
