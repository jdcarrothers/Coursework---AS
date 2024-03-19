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
    public partial class EasyTextDropDown : QuestionTemplate
    {
        int tempScore;
        int EnableSbmt;
        bool EasySelected;

        public EasyTextDropDown(int tempscore, bool easySelected)
        {
            EasySelected = easySelected;
            base.SetNewScore(tempscore);
            tempScore = tempscore;
            InitializeComponent();
            if (easySelected)
            {
                InitializeEasyComboBoxes();
                base.SetQuestionLabel("Match the letter to the part of a hammer");
            }
            else
            {
                InitializeHardComboBoxes();
                base.SetQuestionLabel("Match the letter to the part of a lathe");
            }
            btnNext.Enabled = false;
            timer1.Start();
            btnSubmit.Enabled = false;
        }
        private void InitializeHardComboBoxes()
        {
            //changes items to hard
            pictureBox5.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox5.Image = (Image)Properties.Resources.trans;//changes image to lsthe
            pictureBox5.Size = new System.Drawing.Size(453, 382);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            ComboBox[] comboBoxes = { cbQuestionA, cbQuestionB, cbQuestionC, cbQuestionD };//creates the array of cb boxes
            string[] items = { "Tailstock", "Bed", "Turret", "Spindle" };  //adds all possible options to a array
            Random random = new Random();       //creates random order
            items = items.OrderBy(x => random.Next()).ToArray();    //shuffles them in that orderr
            foreach (var comboBox in comboBoxes)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;    //makes it so each cb box cannot have text entered in them

                // Add shuffled items to each ComboBox
                foreach (var item in items)
                {
                    comboBox.Items.Add(item);
                }
            }
        }
        private void InitializeEasyComboBoxes()
        {
            //changes items to easy
            ComboBox[] comboBoxes = { cbQuestionA, cbQuestionB, cbQuestionC, cbQuestionD };//creates the array of cb boxes
            string[] items = { "Handle", "Claw", "Neck", "Face" };  //adds all possible options to a array
            Random random = new Random();       //creates random order
            items = items.OrderBy(x => random.Next()).ToArray();    //shuffles them in that orderr
            foreach (var comboBox in comboBoxes)
            {
                comboBox.DropDownStyle = ComboBoxStyle.DropDownList;    //makes it so each cb box cannot have text entered in them

                // Add shuffled items to each ComboBox
                foreach (var item in items)
                {
                    comboBox.Items.Add(item);
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //stops the timer and the progress bar
            base.stopProgressTimer();
            timer1.Stop();
            string[] correctAnswers;
            int[] points;
            int bonus;
            //marks the answers and adds the points depending on the difficulty selected
            if (EasySelected)
            {
                correctAnswers = new string[] { "Handle", "Claw", "Neck", "Face" };
                points = new int[] { easyPoint, easyPoint, easyPoint, easyPoint };
                bonus = easyBonus;
            }
            else
            {
                correctAnswers = new string[] { "Spindle", "Turret", "Tailstock", "Bed" };
                points = new int[] { hardPoint, hardPoint, hardPoint, hardPoint };
                bonus = hardBonus;
            }

            int checkedscore = CalculateScore(correctAnswers, points, bonus);
            tempScore += checkedscore;

            btnNext.Enabled = true;
            btnSubmit.Enabled = false;
            btnSubmit.Text = "Submitted";
            SetNewScore(tempScore);
        }
        private int CalculateScore(string[] correctAnswers, int[] points, int bonus)
        {
            //due to the fact that the answers are in a random order, the checks are done in a loop - slightly different to the other questions.
            ComboBox[] comboBoxes = { cbQuestionA, cbQuestionB, cbQuestionC, cbQuestionD };
            bool[] checks = new bool[4];
            PictureBox[] pictureBoxes = { pbADropDown, pbBDropDown, pbCDropDown, pbDDropDown };
            for (int i = 0; i < 4; i++)
            {
                checks[i] = comboBoxes[i].SelectedItem.ToString() == correctAnswers[i];
                pictureBoxes[i].Visible = true;
                pictureBoxes[i].Image = checks[i] ?
                    (Image)Properties.Resources.Green_Tickpng :
                    (Image)Coursework_0._0.Properties.Resources.Red_X;
            }
            int totalScore = 0;
            for (int i = 0; i < 4; i++)
            {
                totalScore += checks[i] ? points[i] : 0;
            }
            if (totalScore == (EasySelected ? 4 : 8) && val < 75)
            {
                totalScore += bonus;
            }
            return totalScore;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //loads the next question
            EasyTextUserFill EasyTextUserFill = new EasyTextUserFill(tempScore, EasySelected);
            EasyTextUserFill.Tag = "a"; // A for active // Set the Tag property for EasyTextDropDown form
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;
            parentForm.LoadChildForm(EasyTextUserFill);
        }
        private void allowSubmitbtn(object sender, EventArgs e)
        {
            //enables the submit button
            var ComboBox = (ComboBox)sender;
            if (ComboBox.Tag.ToString() != "Selected")
            {
                EnableSbmt++;
                ComboBox.Tag = "Selected";
            }
            if (EnableSbmt == 4)
                btnSubmit.Enabled = true;
        }
        int val;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer for the question
            val++;
            if (val == 150)
            {
                Form ranOutOfTime = new RanOutOfTime();
                ranOutOfTime.ShowDialog();
                timer1.Stop();
                base.stopProgressTimer();
                cbQuestionA.Enabled = false;
                cbQuestionB.Enabled = false;
                cbQuestionC.Enabled = false;
                cbQuestionD.Enabled = false;
                btnSubmit.Enabled = false;
                btnNext.Enabled = true;
            }
        }
    }
}
