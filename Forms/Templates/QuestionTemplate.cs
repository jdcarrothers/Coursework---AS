using Coursework_0._0.Classes;
using Coursework_0._0.Forms.MainMenu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_0._0.Forms.Templates
{
    public partial class QuestionTemplate : Form
    {
        protected AudioManager audioManager;
        public static Timer questionBarTimer;
        public static int easyPoint = 1;
        public static int hardPoint = 2;
        public static int easyBonus = 2;
        public static int hardBonus = 3;
        public static bool selectedGame = false;
        public QuestionTemplate()
        {
            InitializeComponent();
            timer.Start();
		}
        //method to set the question label in derived forms
        public void SetQuestionLabel(string question) 
        {
            lblQuestion.Text = $"{question}";
        }
        public void SetNewScore(int score)
        {
            //method to set the score in derived forms
            lblScore.Text = $"Score: {score}";
        }
        public void EasySetSummaryScreen(string totalscore)
        {//method to set the summary screen in derived forms
            lblScore.Text= $"You scored {totalscore} ";
        }
        public void ClearSubmitAndNextPB()
        {//method to make the submit and next button invisible in derived forms
            nextTemp.Visible = false;
            btnSubmitTemp.Visible = false;
        }
        public void ClearProgressBar()
        {
            QuestionProgressBar.Visible = false;
            timer.Stop();//stops the progress bar and inturn stops the noise from playing.
        }
        public void stopProgressTimer()//method to stop bar timer in derived classes
        {
            timer.Stop();
        }
        public void setUpdatedHS(int HS, bool easySelected)
        {
            //method to set the highscore in derived forms
            if(easySelected)
                lblHighScore.Text = $"Easy Highscore: {HS}";
            else
                lblHighScore.Text = $"Hard Highscore: {HS}";
        
        }

        public static bool needExtraTime = false;
        private void timer_Tick(object sender, EventArgs e)
        {
            //progress bar controller
            if (needExtraTime)
            {
                QuestionProgressBar.Maximum = 250;
                if (QuestionProgressBar.Value != 250)
                {
                    if (QuestionProgressBar.Value == 220)
                    {
                        audioManager = new AudioManager();
                        audioManager.PlayCountdownSound();
                    }
                    QuestionProgressBar.Value += 1;
                }
            }
            else
            {
                if (QuestionProgressBar.Value != 150)
                {
                    if (QuestionProgressBar.Value ==120)
                    {
                        audioManager = new AudioManager();
                        audioManager.PlayCountdownSound();
                    }
                    QuestionProgressBar.Value += 1;
                }
            }
        }
        Player currentPlayer;
        private void QuestionTemplate_Load(object sender, EventArgs e)
        {
            if (this.ParentForm is MainMenuParentForm parentForm)
            {
                currentPlayer = parentForm.getCurrentPlayer;
                int scoreDisplayed;
                if (!selectedGame)
                    scoreDisplayed = currentPlayer.HighScore;
                else
                    scoreDisplayed = currentPlayer.HardHighScore;
                if (!selectedGame)
                    lblHighScore.Text = $"Easy Highscore: {scoreDisplayed}";
                else
                    lblHighScore.Text = $"Hard Highscore: {scoreDisplayed}";
            }
        }
    }
}
