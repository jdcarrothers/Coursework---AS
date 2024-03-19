using Coursework_0._0.Forms.CustomBoxes;
using Coursework_0._0.Forms.MainMenu;
using Coursework_0._0.Forms.Templates;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_0._0.Forms.Questions
{
    public partial class EasyTextUserFill : QuestionTemplate
    {
        int tempScore;
        int txtDropDownTempScore;
        bool q1 = false;
        bool q2 = false;
        bool q3 = false;
        bool q4 = false;
        bool EasySelected;
        public EasyTextUserFill(int tempscore, bool easySelected)
        {
            InitializeComponent();
            if (!easySelected)
                InitiateHardQuestion();
            tempScore = tempscore;
            EasySelected = easySelected;
            base.SetNewScore(tempscore);
            base.SetQuestionLabel("Fill in the blanks");
            btnSubmit.Enabled = false;
            btnNext.Enabled = false;
            timer1.Start();
            needExtraTime = true;
        }
        private void InitiateHardQuestion()
        {
            //Changes the location of the labels and textboxes to fit the hard question
            pictureBox1.Visible = false;
            const int x = 100;
            lblQ3.Location = new System.Drawing.Point(x, 332);
            lblQ1.Location = new System.Drawing.Point(x, 143);
            lblQ4.Location = new System.Drawing.Point(x, 434);
            lblQ2.Location = new System.Drawing.Point(x, 235);
            txtBoxQuestionOne.Location = new System.Drawing.Point(166, 143);
            txtBoxQuestionFour.Location = new System.Drawing.Point(155, 237);
            txtBoxQuestionTwo.Location = new System.Drawing.Point(566, 334);
            txtBoxQuestionThree.Location = new System.Drawing.Point(510, 436);
            pbQuestionOneFeedback.Location = new System.Drawing.Point(962, 125);
            pbQuestionFourFeedback.Location = new System.Drawing.Point(721,215);
            pbQuestionTwoFeedback.Location = new System.Drawing.Point(798, 313);
            pbQuestionThreeFeedback.Location = new System.Drawing.Point(745, 413);
            lblQ3.Text = "A tool used to hold material in place is called a";//vice
            lblQ1.Text = "A                                         is used for marking and checking 90° angles on wood pieces.";//trysquare
            lblQ4.Text = "The vaccum forming process requires a ";//mould
            lblQ2.Text = "A                                       is used to create holes in various materials.";//drill
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Stops the timer and the progress bar
            timer1.Stop();
            base.stopProgressTimer();
            //marks the questions depending on the difficulty
            if (EasySelected)
            {
                EvaluateQuestion(txtBoxQuestionOne, pbQuestionOneFeedback, "plane");
                EvaluateQuestion(txtBoxQuestionTwo, pbQuestionTwoFeedback, "bending");
                EvaluateQuestion(txtBoxQuestionThree, pbQuestionThreeFeedback, "knife");
                EvaluateQuestion(txtBoxQuestionFour, pbQuestionFourFeedback, "circular");
                if (txtDropDownTempScore == 4)
                    if (val < 125)
                        txtDropDownTempScore += easyBonus;
            }
            else
            {
                EvaluateQuestion(txtBoxQuestionOne, pbQuestionOneFeedback, "trysquare");
                EvaluateQuestion(txtBoxQuestionTwo, pbQuestionTwoFeedback, "vice");
                EvaluateQuestion(txtBoxQuestionThree, pbQuestionThreeFeedback, "mould");
                EvaluateQuestion(txtBoxQuestionFour, pbQuestionFourFeedback, "drill");
                if (txtDropDownTempScore == 8)
                    if (val < 125)
                        txtDropDownTempScore += hardPoint;

            }
            //adds the score to the total score
            tempScore += txtDropDownTempScore;
            btnNext.Enabled = true;
            SetNewScore(tempScore);
            btnSubmit.Enabled = false;
            btnSubmit.Text = "Submitted";
        }
        private void EvaluateQuestion(TextBox textBox, PictureBox pictureBox, string correctAnswer)
        {
            //Checks if the answer is correct and changes the picturebox to a tick or a cross
            string userAnswer = textBox.Text.ToLower().Replace(" ", "");
            bool isCorrect = userAnswer == correctAnswer;

            pictureBox.Visible = true;
            if (isCorrect)
            {
                if(EasySelected)
                    txtDropDownTempScore = txtDropDownTempScore + easyPoint;
                else
                    txtDropDownTempScore = txtDropDownTempScore + hardPoint;
                pictureBox.Image = (Image)Properties.Resources.Green_Tickpng;
            }
            else
            {
                pictureBox.Image = (Image)Coursework_0._0.Properties.Resources.Red_X;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            //Loads the next form
            EasySummaryScreen EasySummaryScreen = new EasySummaryScreen(tempScore, EasySelected);
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;
            needExtraTime = false;
            parentForm.ChangeSelectPromt(false);
            parentForm.LoadChildForm(EasySummaryScreen);
            parentForm.ChangeSelectPromt(false);
        }
        private void EnableSubmitButton(object sender, EventArgs e)
        {
            //Enables the submit button when all the textboxes have been filled
            var txtBox = (TextBox)sender;
            if (txtBox.Tag.ToString() == "Q1")
                q1 = true;
            if (txtBox.Tag.ToString() == "Q2")
                q2 = true;
            if (txtBox.Tag.ToString() == "Q3")
                q3 = true;
            if (txtBox.Tag.ToString() == "Q4")
                q4 = true;
            btnSubmit.Enabled = q1 && q2 && q3 && q4;
        }
        int val;
        private void timer1_Tick(object sender, EventArgs e)
        {
            val++;
            if (val == 250)
            {
                Form ranOutOfTime = new RanOutOfTime();
                ranOutOfTime.ShowDialog();
                txtBoxQuestionOne.Enabled = false;
                txtBoxQuestionTwo.Enabled = false;
                txtBoxQuestionThree.Enabled = false;
                txtBoxQuestionFour.Enabled = false;
                lblQ1.ForeColor = Color.Gray;
                lblQ3.ForeColor = Color.Gray;
                lblQ4.ForeColor = Color.Gray;
                lblQ2.ForeColor = Color.Gray;
                timer1.Stop();
                btnSubmit.Enabled = false;
                btnNext.Enabled = true;
            }
        }
    }
}
