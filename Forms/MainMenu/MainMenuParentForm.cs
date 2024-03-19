using Coursework_0._0.Classes;
using Coursework_0._0.Forms.MainMenu.Admin;
using Coursework_0._0.Forms.Minigames;
using Coursework_0._0.Forms.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_0._0.Forms.MainMenu
{

    public partial class MainMenuParentForm : Form
    {
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

        public MainMenuParentForm(Player currentPlayer)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            btnGamesWithSub.Image = (Image)Coursework_0._0.Properties.Resources.joystick_32;
            pbExit.Image = (Image)Coursework_0._0.Properties.Resources.Exit_icon;
            button2.Image = (Image)Coursework_0._0.Properties.Resources.pwr;
            lblUsername.Text = currentPlayer.Username;
            scoreLabel.Text = $"Points: {currentPlayer.Score}";
            pbAvatarIcon.Image = currentPlayer.Avatar;
            CurrentPlayer = currentPlayer;
            LoadChildForm(new MainMenu());
            AllowButtons();
        }
        private void AllowButtons()
        {
            // If the player has less than 30 points, the snake game button is disabled
            if (!CurrentPlayer.AdminSatus)
                btnAdmin.Visible = false;
            btnGoToSnake.Enabled = true;
            btnGoToSnake.MouseHover += (sender, e) =>
            {
                if (CurrentPlayer.Score < 30) 
                {
                    snakeToolTip.SetToolTip(btnGoToSnake, "Reach 30 Points to unlock!");
                        btnGoToSnake.Enabled = false;
                }
                else
                {
                    snakeToolTip.SetToolTip(btnGoToSnake, "Unlocked");
                        btnGoToSnake.Enabled = true;
                }
            };
        }
        public void SetLabelOnLoad()
        {
            // Set the label to the current player's score
            scoreLabel.Text = $"Points: {CurrentPlayer.Score}";
            if (!CurrentPlayer.AdminSatus)
                btnAdmin.Visible = false;
            AllowButtons();
        }
        Player CurrentPlayer;
        public Player getCurrentPlayer
        {
            get { return CurrentPlayer; }
        }
        private Form CurrentChildForm;
        private const int expandedSidebarWidth = 211;
        private const int collapsedSidebarWidth = 55;
        bool menuExpand = false;
        bool selectPromt = false;
        // Animates the menu
        private void menuTransition_Tick(object sender, EventArgs e)
        {
            const int expandedHeight = 106;
            const int collapsedHeight = 59;
            const int step = 80;

            if (!menuExpand && menuContainer.Height < expandedHeight)
            {
                menuContainer.Height += step;
                if (menuContainer.Height >= expandedHeight)
                {
                    menuContainer.Height = expandedHeight; // Ensure it reaches the exact height
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else if (menuExpand && menuContainer.Height > collapsedHeight)
            {
                menuContainer.Height -= step;
                if (menuContainer.Height <= collapsedHeight)
                {
                    menuContainer.Height = collapsedHeight; // Ensure it collapses to the exact height
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        static bool sidebarExpand = false;
        // Animates the sidebar
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

            if (sidebarExpand)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= collapsedSidebarWidth)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width >= expandedSidebarWidth)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                }
            }
        }         

        private void btnLogout_Click(object sender, EventArgs e)
        {
            //if the user is in a game, a prompt will appear to confirm the logout
            if (selectPromt)
            {
                if (MessageBox.Show("Do you wish to logout? Progress will not be saved.", "Logout?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Form form = new Login();
                    this.Close();
                    this.Dispose();
                    form.Show();
                }
            }
            else if (MessageBox.Show("Do you wish to logout?", "Logout?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form form = new Login();
                this.Close();
                this.Dispose();
                form.Show();
            }
        }
        private void pbExit_Click(object sender, EventArgs e)
        {
            //if the user is in a game, a prompt will appear to confirm the exit
            Point originalLocation = pbExit.Location;
            pbExit.Location = new Point(originalLocation.X + 2, originalLocation.Y + 2);//animates the exit button for user feedback
            System.Threading.Thread.Sleep(100);
            pbExit.Location = originalLocation;
            if (selectPromt)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to exit? Progress will not be saved.", "Exit Quiz", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                if (MessageBox.Show("Do you wish to exit the application?", "Exit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (selectPromt)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to go home? Progress will not be saved.", "Exit Quiz", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    LoadChildForm(new MainMenu());
                    selectPromt = false;
                    SetLabelOnLoad();
                }
            }
            else
            {
                LoadChildForm(new MainMenu());
                SetLabelOnLoad();
            }
        }
        public void LoadChildForm(Form childForm)
        {
            // Load the child form into the main panel
            if (CurrentChildForm != null)
            {
                CurrentChildForm.Close();
                CurrentChildForm.Dispose();
            }
            // Open the child form

            CurrentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(childForm);
            mainPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            if (childForm.Tag != null && childForm.Tag.ToString() == "a")
            {
                selectPromt = true;
            }
        }
        // Changes the select prompt
        public void ChangeSelectPromt(bool value)
        {
            selectPromt = false;        
        }
        
        private void btnGamesWithSub_Click(object sender, EventArgs e)
        {
            // Load the games form transition
            menuTransition.Start();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            // Load the admin menu transitim
            adminTransition.Start();
        }

        private void btnOpenSideBar_Click_1(object sender, EventArgs e)
        {
            // Load the sidebar transition
            sidebarTransition.Start();
        }
        bool adminExpand = false;

        private void adminTransition_Tick(object sender, EventArgs e)
        {
            // Animates the admin menu
            const int expandedHeight = 160;
            const int collapsedHeight = 46;
            const int step = 80;

            if (!adminExpand && adminPanelSideBar.Height < expandedHeight)
            {
                adminPanelSideBar.Height += step;
                if (adminPanelSideBar.Height >= expandedHeight)
                {
                    adminPanelSideBar.Height = expandedHeight;
                    adminTransition.Stop();
                    adminExpand = true;
                }
            }
            else if (adminExpand && adminPanelSideBar.Height > collapsedHeight)
            {
                adminPanelSideBar.Height -= step;
                if (adminPanelSideBar.Height <= collapsedHeight)
                {
                    adminPanelSideBar.Height = collapsedHeight;
                    adminTransition.Stop();
                    adminExpand = false;
                }
            }
        }

        private void btnQuestions_Click(object sender, EventArgs e)
        {
            //same as prev comment, should of been a method in hindsight
            if (selectPromt)
            {
                DialogResult result = MessageBox.Show("Do you wish to open admin menu? Progress will not be saved.", "Exit Quiz", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    LoadChildForm(new AdminMenu());
                    selectPromt = false;
                }
            }
            else
            {
                LoadChildForm(new AdminMenu());
            }
        }

        private void btnPlayerEditor_Click(object sender, EventArgs e)
        {
            if (selectPromt)
            {
                DialogResult result = MessageBox.Show("Do you wish to open admin menu? Progress will not be saved.", "Exit Quiz", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    LoadChildForm(new AdminMenuPlayerEditor());
                    selectPromt = false;
                }
            }
            else
            {
                LoadChildForm(new AdminMenuPlayerEditor());
            }
        }

        private void btnGoToSnake_Click(object sender, EventArgs e)
        {
            LoadChildForm(new SnakeForm());
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (selectPromt)
            {
                DialogResult result = MessageBox.Show("Do you wish the help menu? Progress will not be saved.", "Exit Quiz", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    LoadChildForm(new HelpPage());
                    selectPromt = false;
                }
            }
            else
            {
                LoadChildForm(new HelpPage());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectPromt)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to quit? Progress will not be saved.", "Quit", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
            else
            {
                if (MessageBox.Show("Do you wish to quit?", "Quit", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                } 
            }
        }
    }
}
