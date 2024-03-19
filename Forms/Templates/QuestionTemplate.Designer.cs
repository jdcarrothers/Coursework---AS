
namespace Coursework_0._0.Forms.Templates
{
    partial class QuestionTemplate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.QuestionProgressBar = new Coursework_0._0.Forms.CustomBoxes.CustomProgressBar();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnSubmitTemp = new System.Windows.Forms.PictureBox();
            this.nextTemp = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmitTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.QuestionProgressBar);
            this.panel1.Controls.Add(this.lblHighScore);
            this.panel1.Controls.Add(this.lblScore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 53);
            this.panel1.TabIndex = 1;
            // 
            // QuestionProgressBar
            // 
            this.QuestionProgressBar.BackColor = System.Drawing.SystemColors.Control;
            this.QuestionProgressBar.Location = new System.Drawing.Point(198, 15);
            this.QuestionProgressBar.Maximum = 150;
            this.QuestionProgressBar.Name = "QuestionProgressBar";
            this.QuestionProgressBar.ProgressBarColor = System.Drawing.Color.Gray;
            this.QuestionProgressBar.Size = new System.Drawing.Size(724, 23);
            this.QuestionProgressBar.TabIndex = 15;
            // 
            // lblHighScore
            // 
            this.lblHighScore.AutoSize = true;
            this.lblHighScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblHighScore.Location = new System.Drawing.Point(928, 15);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(136, 30);
            this.lblHighScore.TabIndex = 14;
            this.lblHighScore.Text = "Highscore: 0";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(48, 9);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(91, 30);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score: 0";
            // 
            // lblQuestion
            // 
            this.lblQuestion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(12, 81);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1108, 32);
            this.lblQuestion.TabIndex = 9;
            this.lblQuestion.Text = "Question:";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmitTemp
            // 
            this.btnSubmitTemp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSubmitTemp.Location = new System.Drawing.Point(296, 519);
            this.btnSubmitTemp.Name = "btnSubmitTemp";
            this.btnSubmitTemp.Size = new System.Drawing.Size(150, 66);
            this.btnSubmitTemp.TabIndex = 10;
            this.btnSubmitTemp.TabStop = false;
            // 
            // nextTemp
            // 
            this.nextTemp.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nextTemp.Location = new System.Drawing.Point(657, 519);
            this.nextTemp.Name = "nextTemp";
            this.nextTemp.Size = new System.Drawing.Size(150, 66);
            this.nextTemp.TabIndex = 11;
            this.nextTemp.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(13, 78);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1108, 548);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // QuestionTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1132, 607);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.nextTemp);
            this.Controls.Add(this.btnSubmitTemp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "QuestionTemplate";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.QuestionTemplate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSubmitTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nextTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.PictureBox btnSubmitTemp;
        private System.Windows.Forms.PictureBox nextTemp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label lblHighScore;
        private CustomBoxes.CustomProgressBar QuestionProgressBar;
    }
}