
namespace Coursework_0._0.Forms.Questions
{
    partial class EasyTextDropDown
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
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblA = new System.Windows.Forms.Label();
            this.cbQuestionA = new System.Windows.Forms.ComboBox();
            this.pbADropDown = new System.Windows.Forms.PictureBox();
            this.lblB = new System.Windows.Forms.Label();
            this.cbQuestionB = new System.Windows.Forms.ComboBox();
            this.pbBDropDown = new System.Windows.Forms.PictureBox();
            this.lblC = new System.Windows.Forms.Label();
            this.cbQuestionC = new System.Windows.Forms.ComboBox();
            this.pbCDropDown = new System.Windows.Forms.PictureBox();
            this.lblD = new System.Windows.Forms.Label();
            this.cbQuestionD = new System.Windows.Forms.ComboBox();
            this.pbDDropDown = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbADropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCDropDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDDropDown)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(296, 519);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 66);
            this.btnSubmit.TabIndex = 42;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(657, 519);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 66);
            this.btnNext.TabIndex = 43;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Coursework_0._0.Properties.Resources.hammerWithLetters;
            this.pictureBox5.Location = new System.Drawing.Point(79, 131);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(413, 382);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            // 
            // lblA
            // 
            this.lblA.AutoSize = true;
            this.lblA.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblA.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblA.Location = new System.Drawing.Point(553, 166);
            this.lblA.Name = "lblA";
            this.lblA.Size = new System.Drawing.Size(382, 30);
            this.lblA.TabIndex = 45;
            this.lblA.Text = "What does the letter A correspond to?";
            // 
            // cbQuestionA
            // 
            this.cbQuestionA.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbQuestionA.FormattingEnabled = true;
            this.cbQuestionA.Location = new System.Drawing.Point(580, 199);
            this.cbQuestionA.Name = "cbQuestionA";
            this.cbQuestionA.Size = new System.Drawing.Size(212, 38);
            this.cbQuestionA.TabIndex = 46;
            this.cbQuestionA.Tag = "A";
            this.cbQuestionA.SelectedIndexChanged += new System.EventHandler(this.allowSubmitbtn);
            // 
            // pbADropDown
            // 
            this.pbADropDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbADropDown.Location = new System.Drawing.Point(941, 159);
            this.pbADropDown.Name = "pbADropDown";
            this.pbADropDown.Size = new System.Drawing.Size(75, 75);
            this.pbADropDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbADropDown.TabIndex = 47;
            this.pbADropDown.TabStop = false;
            this.pbADropDown.Visible = false;
            // 
            // lblB
            // 
            this.lblB.AutoSize = true;
            this.lblB.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblB.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblB.Location = new System.Drawing.Point(555, 240);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(381, 30);
            this.lblB.TabIndex = 48;
            this.lblB.Text = "What does the letter B correspond to?";
            // 
            // cbQuestionB
            // 
            this.cbQuestionB.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbQuestionB.FormattingEnabled = true;
            this.cbQuestionB.Location = new System.Drawing.Point(578, 277);
            this.cbQuestionB.Name = "cbQuestionB";
            this.cbQuestionB.Size = new System.Drawing.Size(212, 38);
            this.cbQuestionB.TabIndex = 49;
            this.cbQuestionB.Tag = "B";
            this.cbQuestionB.SelectedIndexChanged += new System.EventHandler(this.allowSubmitbtn);
            // 
            // pbBDropDown
            // 
            this.pbBDropDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbBDropDown.Location = new System.Drawing.Point(942, 240);
            this.pbBDropDown.Name = "pbBDropDown";
            this.pbBDropDown.Size = new System.Drawing.Size(75, 75);
            this.pbBDropDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBDropDown.TabIndex = 50;
            this.pbBDropDown.TabStop = false;
            this.pbBDropDown.Visible = false;
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblC.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblC.Location = new System.Drawing.Point(553, 327);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(381, 30);
            this.lblC.TabIndex = 51;
            this.lblC.Text = "What does the letter C correspond to?";
            // 
            // cbQuestionC
            // 
            this.cbQuestionC.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbQuestionC.FormattingEnabled = true;
            this.cbQuestionC.Location = new System.Drawing.Point(580, 371);
            this.cbQuestionC.Name = "cbQuestionC";
            this.cbQuestionC.Size = new System.Drawing.Size(210, 38);
            this.cbQuestionC.TabIndex = 52;
            this.cbQuestionC.Tag = "C";
            this.cbQuestionC.SelectedIndexChanged += new System.EventHandler(this.allowSubmitbtn);
            // 
            // pbCDropDown
            // 
            this.pbCDropDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbCDropDown.Location = new System.Drawing.Point(940, 327);
            this.pbCDropDown.Name = "pbCDropDown";
            this.pbCDropDown.Size = new System.Drawing.Size(75, 75);
            this.pbCDropDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCDropDown.TabIndex = 53;
            this.pbCDropDown.TabStop = false;
            this.pbCDropDown.Visible = false;
            // 
            // lblD
            // 
            this.lblD.AutoSize = true;
            this.lblD.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblD.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblD.Location = new System.Drawing.Point(553, 412);
            this.lblD.Name = "lblD";
            this.lblD.Size = new System.Drawing.Size(383, 30);
            this.lblD.TabIndex = 54;
            this.lblD.Text = "What does the letter D correspond to?";
            // 
            // cbQuestionD
            // 
            this.cbQuestionD.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.cbQuestionD.FormattingEnabled = true;
            this.cbQuestionD.Location = new System.Drawing.Point(580, 449);
            this.cbQuestionD.Name = "cbQuestionD";
            this.cbQuestionD.Size = new System.Drawing.Size(210, 38);
            this.cbQuestionD.TabIndex = 55;
            this.cbQuestionD.Tag = "D";
            this.cbQuestionD.SelectedIndexChanged += new System.EventHandler(this.allowSubmitbtn);
            // 
            // pbDDropDown
            // 
            this.pbDDropDown.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbDDropDown.Location = new System.Drawing.Point(940, 412);
            this.pbDDropDown.Name = "pbDDropDown";
            this.pbDDropDown.Size = new System.Drawing.Size(75, 75);
            this.pbDDropDown.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDDropDown.TabIndex = 56;
            this.pbDDropDown.TabStop = false;
            this.pbDDropDown.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EasyTextDropDown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 607);
            this.Controls.Add(this.pbDDropDown);
            this.Controls.Add(this.cbQuestionD);
            this.Controls.Add(this.lblD);
            this.Controls.Add(this.pbCDropDown);
            this.Controls.Add(this.cbQuestionC);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.pbBDropDown);
            this.Controls.Add(this.cbQuestionB);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.pbADropDown);
            this.Controls.Add(this.cbQuestionA);
            this.Controls.Add(this.lblA);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSubmit);
            this.Name = "EasyTextDropDown";
            this.Text = "EasyTextDropDown";
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.lblA, 0);
            this.Controls.SetChildIndex(this.cbQuestionA, 0);
            this.Controls.SetChildIndex(this.pbADropDown, 0);
            this.Controls.SetChildIndex(this.lblB, 0);
            this.Controls.SetChildIndex(this.cbQuestionB, 0);
            this.Controls.SetChildIndex(this.pbBDropDown, 0);
            this.Controls.SetChildIndex(this.lblC, 0);
            this.Controls.SetChildIndex(this.cbQuestionC, 0);
            this.Controls.SetChildIndex(this.pbCDropDown, 0);
            this.Controls.SetChildIndex(this.lblD, 0);
            this.Controls.SetChildIndex(this.cbQuestionD, 0);
            this.Controls.SetChildIndex(this.pbDDropDown, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbADropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCDropDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDDropDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblA;
        private System.Windows.Forms.ComboBox cbQuestionA;
        private System.Windows.Forms.PictureBox pbADropDown;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.ComboBox cbQuestionB;
        private System.Windows.Forms.PictureBox pbBDropDown;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.ComboBox cbQuestionC;
        private System.Windows.Forms.PictureBox pbCDropDown;
        private System.Windows.Forms.Label lblD;
        private System.Windows.Forms.ComboBox cbQuestionD;
        private System.Windows.Forms.PictureBox pbDDropDown;
        private System.Windows.Forms.Timer timer1;
    }
}