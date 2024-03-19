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
    public partial class AdminMenu : Form
    {
        List<ManageQuestions> questionsList = new List<ManageQuestions>();
        private bool changesMade = false;
        public AdminMenu()
        {
            InitializeComponent();
            readFileToListQuestions();
            ShowQuestions();
            btnRemoveQuestion.Enabled = false;
            btnReplaceEdit.Enabled = false;
            ChangeTextEnabed(true);
            TtAddQuestion.SetToolTip(infoPbANQ, "Ensure all text boxes are filled, and no question is selected");
        }
        private void Check(object sender, EventArgs e)
        {
            // Check if all textboxes are filled
            if (String.IsNullOrEmpty(txtAddQuestion.Text) ||
            String.IsNullOrEmpty(txtAddCorrect.Text) ||
            String.IsNullOrEmpty(txtAddIncorrect1.Text) ||
            String.IsNullOrEmpty(txtAddIncorrect2.Text) ||
            String.IsNullOrEmpty(txtAddIncorrect3.Text))
            {
                btnAddQuestionData.Enabled = false;
                infoPbANQ.Visible = true;
            }
            else
            {
                btnAddQuestionData.Enabled = true;
                infoPbANQ.Visible = false;
            }
            changesMade = true;
            EnableReplaceEditButton(); // Check for changes made
        }
        // Read the questions from the file and add them to the list
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
        // Show the questions in the listbox
        private void ShowQuestions()
        {
            listBoxQuestions.Items.Clear();
            foreach (ManageQuestions question in questionsList)
            {
                listBoxQuestions.Items.Add(question.Question);
            }
        }
        // Add a question to the list
        private void AddQuestion(ManageQuestions newQuestion)
        {
            questionsList.Add(newQuestion);
            SaveQuestions();
            ShowQuestions(); 
            ClearTextBoxes();
        }
        // Save the questions to the file
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
        // Check if the question is already in the list
        private bool IsQuestionDuplicate(ManageQuestions newQuestion)
        {
            foreach (ManageQuestions question in questionsList)
            {
                if (question.Question.Equals(newQuestion.Question))
                {
                    return true;
                }
            }
            return false;
        }
        // Edit the selected question
        private void EditSelectedQuestion(ManageQuestions editedQuestion)
        {
            if (listBoxQuestions.SelectedItem != null)
            {
                int selectedIndex = listBoxQuestions.SelectedIndex;
                questionsList.RemoveAt(selectedIndex);
                questionsList.Insert(selectedIndex, editedQuestion);
                SaveQuestions();
                ShowQuestions();
            }
        }
        // Enable the replace edit button
        private void EnableReplaceEditButton()
        {
            btnReplaceEdit.Enabled = listBoxQuestions.SelectedItem != null && changesMade;
        }
        // Remove the selected question
        private void RemoveSelectedQuestion()
        {
            if (listBoxQuestions.SelectedItem != null)
            {
                int selectedIndex = listBoxQuestions.SelectedIndex;
                questionsList.RemoveAt(selectedIndex);
                SaveQuestions();
                ShowQuestions();
                ClearTextBoxes();
                MessageBox.Show("Question removed succsesfully");
            }
            else
            {
                MessageBox.Show("Make sure you have an index selected in the list box");
            }
        }
        // Clear the textboxes
        private void ClearTextBoxes()
        {
            txtAddQuestion.Text = string.Empty;
            txtAddCorrect.Text = string.Empty;
            txtAddIncorrect1.Text = string.Empty;
            txtAddIncorrect2.Text = string.Empty;
            txtAddIncorrect3.Text = string.Empty;
        }
        // Confirm the edit
        private void ConfirmEdit()
        {
            string editedQuestionText = txtAddQuestion.Text;
            string editedCorrectAnswer = txtAddCorrect.Text;
            string editedIncorrectAnswer1 = txtAddIncorrect1.Text;
            string editedIncorrectAnswer2 = txtAddIncorrect2.Text;
            string editedIncorrectAnswer3 = txtAddIncorrect3.Text;
            ManageQuestions editedQuestion = new ManageQuestions(editedQuestionText, editedCorrectAnswer);
            editedQuestion.IncorrectAnswer1 = editedIncorrectAnswer1;
            editedQuestion.IncorrectAnswer2 = editedIncorrectAnswer2;
            editedQuestion.IncorrectAnswer3 = editedIncorrectAnswer3;
            EditSelectedQuestion(editedQuestion);
        }
        // Event handlers
        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem != null)
            {
                int selectedIndex = listBoxQuestions.SelectedIndex;
                ManageQuestions selectedQuestion = questionsList[selectedIndex];
                txtAddQuestion.Text = selectedQuestion.Question;
                txtAddCorrect.Text = selectedQuestion.CorrectAnswer;
                txtAddIncorrect1.Text = selectedQuestion.IncorrectAnswer1;
                txtAddIncorrect2.Text = selectedQuestion.IncorrectAnswer2;
                txtAddIncorrect3.Text = selectedQuestion.IncorrectAnswer3;
                changesMade = false;
                btnRemoveQuestion.Enabled = true;
                btnAddQuestionData.Enabled = false;
                infoPbANQ.Visible = true;
                EnableReplaceEditButton();
                ChangeTextEnabed(false);
            }
            else
            {
                listBoxQuestions.ClearSelected();
                ClearTextBoxes();
                btnRemoveQuestion.Enabled = false;
                btnReplaceEdit.Enabled = false; // Disable btnReplaceEdit when no item is selected
            }
        }
        // logic for handellling the save changed button
        private void btnReplaceEdit_Click(object sender, EventArgs e)
        {
            ConfirmEdit();
            changesMade = false;
            EnableReplaceEditButton();
            ChangeTextEnabed(false);
            btnReplaceEdit.Visible = false;
            listBoxQuestions.ClearSelected();
            ClearTextBoxes();
            btnRemoveQuestion.Enabled = false;
            btnRequestEdit.Enabled = true;
        }   
        // Event handlers for removing questions
        private void btnRemoveQuestion_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to remove", "Remove?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                RemoveSelectedQuestion();
            }
            //listBoxQuestions.ClearSelected();
            //ClearTextBoxes();
            //ChangeTextEnabed(true);
            //btnAddQuestionData.Enabled = true;
            //infoPbANQ.Visible = false;
            AdminMenu textDropDownForm = new AdminMenu();
            textDropDownForm.Tag = "n"; // A for active // Set the Tag property for EasyTextDropDown form
            MainMenuParentForm parentForm = (MainMenuParentForm)this.ParentForm;
            parentForm.LoadChildForm(textDropDownForm);
        }
        // Event handlers for adding questions
        private void btnAddQuestionData_Click(object sender, EventArgs e)
        {
            //get the data from textboxes
            string questionText = txtAddQuestion.Text;
            string correctAnswer = txtAddCorrect.Text;
            string incorrectAnswer1 = txtAddIncorrect1.Text;
            string incorrectAnswer2 = txtAddIncorrect2.Text;
            string incorrectAnswer3 = txtAddIncorrect3.Text;
            if (string.IsNullOrEmpty(questionText) || string.IsNullOrEmpty(correctAnswer) ||
                string.IsNullOrEmpty(incorrectAnswer1) || string.IsNullOrEmpty(incorrectAnswer2) ||
                string.IsNullOrEmpty(incorrectAnswer3))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            ManageQuestions newQuestion = new ManageQuestions(questionText, correctAnswer);
            newQuestion.IncorrectAnswer1 = incorrectAnswer1;
            newQuestion.IncorrectAnswer2 = incorrectAnswer2;
            newQuestion.IncorrectAnswer3 = incorrectAnswer3;
            if (IsQuestionDuplicate(newQuestion))
            {
                MessageBox.Show("This question already exists.");
                ClearTextBoxes();
            }
            else
                AddQuestion(newQuestion);
        }
        // Event handlers for the deselect button
        private void btnDeselectIndex_Click(object sender, EventArgs e)
        {
            listBoxQuestions.ClearSelected();
            ClearTextBoxes();
            ChangeTextEnabed(true);
            infoPbANQ.Visible = true;

        }
        // Event handlers for requesting an edit, and enabling the textboxes for editing the question data 
        private void btnRequestEdit_Click(object sender, EventArgs e)
        {
            btnReplaceEdit.Visible = true;
            ChangeTextEnabed(true);
            
        }
        // Event handlers  for enabling the textboxes for editing the question data
        private void ChangeTextEnabed (bool enable)
        {
            txtAddQuestion.Enabled = (enable) ? true : false;
            txtAddCorrect.Enabled = (enable) ? true : false;
            txtAddIncorrect1.Enabled = (enable) ? true : false;
            txtAddIncorrect2.Enabled = (enable) ? true : false;
            txtAddIncorrect3.Enabled = (enable) ? true : false;
        }
    }
}
