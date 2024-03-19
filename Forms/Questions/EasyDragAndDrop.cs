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
    public partial class EasyDragAndDrop : QuestionTemplate
    {
        int picturescore;
        public static String SelectedPicture;
        public static int tempScore;
        bool screwDriverFeedback = false;
        bool SawFeedback = false;
        bool hammerFeedback = false;
        int allowsubmit;
        bool EasySelected;
        public EasyDragAndDrop(int tempscore, bool easySelected)
        {
            base.SetNewScore(tempscore);
            InitializeComponent();
            setQuestionType(easySelected);
            EasySelected = easySelected;
            base.ClearSubmitAndNextPB();
            base.SetQuestionLabel("Match the tools with their name.");
            tempScore = tempscore;
            foreach (var pictureBox in new[] { pictureBox1, pictureBox2, pictureBox3, pictureBoxA, pictureBoxC, pictureBoxD })
            {
                pictureBox.AllowDrop = true;
                pictureBox.Cursor = Cursors.Hand;

            }//enables all the allowdrop to true
            btnNext.Enabled = false;
            btnSubmit.Enabled = false;
            timer1.Start();
        }
        //since both questions are the same, we can use a method to set the question type, since the questions are hard coded
        private void setQuestionType(bool easySelected)
        {
            if (!easySelected)
            {
                SetHardQuestions();
            }
        }
        private void SetHardQuestions()
        {
            //display all the hard questions
            base.SetQuestionLabel("Match the manufacturing process with their name");
            pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox2.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox3.SizeMode = PictureBoxSizeMode.Normal;
            pictureBox1.Image = (Image)Coursework_0._0.Properties.Resources.extrusion_blow_w_trans;
            pictureBox2.Image = (Image)Coursework_0._0.Properties.Resources.extrusion_injection_w_trans;
            pictureBox3.Image = (Image)Coursework_0._0.Properties.Resources.rot_w_trans;
            const int x = 220;
            const int y = 125;
            pictureBox1.Size = new System.Drawing.Size(x, y);
            pictureBox2.Size = new System.Drawing.Size(x, y);
            pictureBox3.Size = new System.Drawing.Size(x, y);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            label2.Text = "Blow moulding";
            label3.Text = "Injection moulding";
            label5.Text = "Rotational moulding";
        }

        //ALL THE PICTUREBOXES HAVE THE SAME EVENT HANDLERS, SO WE CAN USE THE SAME METHOD FOR ALL OF THEM, AND THEN USE THE TAG PROPERTY TO DIFFERENTIATE THEM. 
        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //when the picturebox is clicked set the vars righht
            var pictureBox = (PictureBox)sender;
            SelectedPicture = pictureBox.Tag.ToString();
            pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Copy);
        }
        private void AnswerPictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            //when the picturebox is clicked set the vars righht
            var pictureBox = (PictureBox)sender;
            SelectedPicture = pictureBox.Tag.ToString();
            pictureBox.DoDragDrop(pictureBox.Image, DragDropEffects.Copy);
            pictureBox.Image = (Image)Coursework_0._0.Properties.Resources.blank_question;
            pictureBox.AllowDrop = true;
            allowsubmit--;
        }
        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            //when the picturebox is clicked set the vars righht
            var pictureBox = (PictureBox)sender;
            pictureBox.Image = (Image)e.Data.GetData(DataFormats.Bitmap);
            pictureBox.AllowDrop = false;
            if (SelectedPicture == pictureBox.Tag.ToString())
            {
                //if the picture is dropped in the right place, set the feedback to true
                //used for marking the question later on
                if (SelectedPicture == "Screwdriver" && pictureBox.Tag.ToString() == "Screwdriver")
                    screwDriverFeedback = true;
                if (SelectedPicture == "Saw" && pictureBox.Tag.ToString() == "Saw")
                    SawFeedback = true;
                if (SelectedPicture == "Hammer" && pictureBox.Tag.ToString() == "Hammer")
                    hammerFeedback = true;
            }
            allowsubmit++;
            if (allowsubmit >= 3)
                btnSubmit.Enabled = true;
        }
        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Copy;
        }
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //when the submit button is clicked, stop the timer, and set the feedback to the user, also mark the question
            timer1.Stop();
            base.stopProgressTimer();
            btnNext.Enabled = true;
            btnSubmit.Enabled = false;
            btnReset.Enabled = false;
            pbSawFeedback.Visible = true;
            pbScrewdriverFeedback.Visible = true;
            pbHammerFeedback.Visible = true;
            btnSubmit.Text = "Submitted";
            if(EasySelected)
                picturescore += (hammerFeedback ? easyPoint : 0) + (SawFeedback ? easyPoint : 0) + (screwDriverFeedback ? easyPoint : 0);
            else//hard selected do this calc
                picturescore += (hammerFeedback ? hardPoint : 0) + (SawFeedback ? hardPoint : 0) + (screwDriverFeedback ? hardPoint : 0);
            if (picturescore == 3 || picturescore == 6)  // if they got all right in either hard or easy
                if (val < 75)   //and they scored below the 50% mark
                    if (EasySelected)//if they are in easy mode 
                        picturescore += easyBonus;//give them the easy bonus
                    else
                        picturescore += hardBonus;// if hard mode give them the hard bonus
            tempScore = tempScore + picturescore;
            base.SetNewScore(tempScore);

            //set user feedback
            pbScrewdriverFeedback.Image = screwDriverFeedback ? (Image)Coursework_0._0.Properties.Resources.Green_Tickpng : (Image)Coursework_0._0.Properties.Resources.Red_X;
            pbSawFeedback.Image = SawFeedback ? (Image)Coursework_0._0.Properties.Resources.Green_Tickpng : (Image)Coursework_0._0.Properties.Resources.Red_X;
            pbHammerFeedback.Image = hammerFeedback ? (Image)Coursework_0._0.Properties.Resources.Green_Tickpng : (Image)Coursework_0._0.Properties.Resources.Red_X;
            //tenary conditional expression x = spannerFeedBack ? (value if true) : (value if false)
            SetNewScore(tempScore);
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            EasyTextDropDown textDropDownForm = new EasyTextDropDown(tempScore, EasySelected);
            textDropDownForm.Tag = "a"; // A for active // Set the Tag property for EasyTextDropDown form
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;
            parentForm.LoadChildForm(textDropDownForm);
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            PictureBox[] pictureBoxes = { pictureBoxA, pictureBoxC, pictureBoxD };
            foreach (var pictureBox in pictureBoxes)
            {
                pictureBox.Image = (Image)Coursework_0._0.Properties.Resources.blank_question;
            }//resets all the photos back to the questionmark
            foreach (var pictureBox in new[] { pictureBox1, pictureBox2, pictureBox3, pictureBoxA, pictureBoxC, pictureBoxD })
            {
                pictureBox.AllowDrop = true;
            }//enables all the allowdrop to true
            picturescore = 0;
            SelectedPicture = "";
            screwDriverFeedback = false;
            SawFeedback = false;
            hammerFeedback = false;
            allowsubmit = 0;
            btnSubmit.Enabled = false;
        }
        int val;
        private void timer1_Tick(object sender, EventArgs e)
        {
            val++;
            if (val == 150)
            {
                Form ranOutOfTime = new RanOutOfTime();
                ranOutOfTime.ShowDialog();
                btnNext.Enabled = true;
                btnSubmit.Enabled = false;
                btnReset.Enabled = false;
                timer1.Stop();
                base.stopProgressTimer();
            }
        }
    }
}
