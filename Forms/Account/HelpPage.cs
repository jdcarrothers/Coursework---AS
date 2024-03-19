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

namespace Coursework_0._0.Forms.Questions
{
    public partial class HelpPage : Form
    {
        public HelpPage()
        {
            InitializeComponent();
        }
        //This is the help page form which is used to display the help for the user to understand how to answer the questions.
        private void txtDropDownbtn_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Combo box question";
            mainIMG.Image = (Image)Coursework_0._0.Properties.Resources.comboboxhelpform;
            lblInGrpBox.Text = "To answer an combo box question you must click on the down arrow to present you with your 4 possible answers select the one you think is correct.";
        }

        private void btnRB_Click(object sender, EventArgs e)
        {
            //click event for the radio button help button
            groupBox1.Text = "Radio button question";
            mainIMG.Image = (Image)Coursework_0._0.Properties.Resources.rdbtnhelpform1;
            lblInGrpBox.Text = "To answer a radio button question you must read the four options that you are presented with and click the one you believe is correct.";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //click event for the text fill help button
            groupBox1.Text = "User text fill question";
            lblInGrpBox.Text = "To answer an input box question you must enter your answer in the textbox presented within the time alloted.";
            mainIMG.Image = (Image)Coursework_0._0.Properties.Resources.textfillhelpform;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //click event for the drag and drop help button
            groupBox1.Text = "Drag and drop question";
            mainIMG.Image = (Image)Coursework_0._0.Properties.Resources.pbhelpform;
            lblInGrpBox.Text = "To answer a drag and drop question you must click and hold on your desired image and drag it to the question mark box beside the label that matches the image and drop it.";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //click event for the submit button
            groupBox1.Text = "Login & Register";
            mainIMG.Image = (Image)Coursework_0._0.Properties.Resources.loginreghelpform;
            lblInGrpBox.Text = "Login: Enter your username and password to login to the main menu. Note: Hit the show password to see what password you are submitting.     Register: Enter the username & password & and a avatar of your new account to proceed.";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //click event for the submit button
            groupBox1.Text = "Login & Register";
            mainIMG.Image = (Image)Coursework_0._0.Properties.Resources.loginreghelpform;
            lblInGrpBox.Text = "Login: Enter your username and password to login to the main menu. Note: Hit the show password to see what password you are submitting.     Register: Enter the username & password & and a avatar of your new account to proceed.";
        }
    }
}



