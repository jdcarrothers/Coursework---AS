
namespace Coursework_0._0.Forms.Question
{
    partial class EasyRadioButtonQuestion
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
            this.lblRadioButtonQuestion = new System.Windows.Forms.Label();
            this.rbIncorrect_1 = new System.Windows.Forms.RadioButton();
            this.rbCorrect = new System.Windows.Forms.RadioButton();
            this.rbIncorrect_2 = new System.Windows.Forms.RadioButton();
            this.rbIncorrect_3 = new System.Windows.Forms.RadioButton();
            this.pbIncorrect1 = new System.Windows.Forms.PictureBox();
            this.pbCorrect = new System.Windows.Forms.PictureBox();
            this.pbIncorrect2 = new System.Windows.Forms.PictureBox();
            this.pbIncorrect3 = new System.Windows.Forms.PictureBox();
            this.HiddenDefaultBtn = new System.Windows.Forms.RadioButton();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRadioButtonQuestion
            // 
            this.lblRadioButtonQuestion.AutoSize = true;
            this.lblRadioButtonQuestion.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblRadioButtonQuestion.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblRadioButtonQuestion.Location = new System.Drawing.Point(407, 133);
            this.lblRadioButtonQuestion.Name = "lblRadioButtonQuestion";
            this.lblRadioButtonQuestion.Size = new System.Drawing.Size(197, 30);
            this.lblRadioButtonQuestion.TabIndex = 9;
            this.lblRadioButtonQuestion.Text = "lblPrimaryQuestion";
            // 
            // rbIncorrect_1
            // 
            this.rbIncorrect_1.AutoSize = true;
            this.rbIncorrect_1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbIncorrect_1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbIncorrect_1.Location = new System.Drawing.Point(412, 194);
            this.rbIncorrect_1.Name = "rbIncorrect_1";
            this.rbIncorrect_1.Size = new System.Drawing.Size(156, 34);
            this.rbIncorrect_1.TabIndex = 10;
            this.rbIncorrect_1.Text = "lblIncorrectQ";
            this.rbIncorrect_1.UseVisualStyleBackColor = false;
            this.rbIncorrect_1.CheckedChanged += new System.EventHandler(this.EnableSubmit);
            // 
            // rbCorrect
            // 
            this.rbCorrect.AutoSize = true;
            this.rbCorrect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbCorrect.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbCorrect.Location = new System.Drawing.Point(412, 265);
            this.rbCorrect.Name = "rbCorrect";
            this.rbCorrect.Size = new System.Drawing.Size(141, 34);
            this.rbCorrect.TabIndex = 11;
            this.rbCorrect.Text = "lblCorrectQ";
            this.rbCorrect.UseVisualStyleBackColor = false;
            this.rbCorrect.CheckedChanged += new System.EventHandler(this.EnableSubmit);
            // 
            // rbIncorrect_2
            // 
            this.rbIncorrect_2.AutoSize = true;
            this.rbIncorrect_2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbIncorrect_2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbIncorrect_2.Location = new System.Drawing.Point(412, 337);
            this.rbIncorrect_2.Name = "rbIncorrect_2";
            this.rbIncorrect_2.Size = new System.Drawing.Size(156, 34);
            this.rbIncorrect_2.TabIndex = 12;
            this.rbIncorrect_2.Text = "lblIncorrectQ";
            this.rbIncorrect_2.UseVisualStyleBackColor = false;
            this.rbIncorrect_2.CheckedChanged += new System.EventHandler(this.EnableSubmit);
            // 
            // rbIncorrect_3
            // 
            this.rbIncorrect_3.AutoSize = true;
            this.rbIncorrect_3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.rbIncorrect_3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold);
            this.rbIncorrect_3.Location = new System.Drawing.Point(412, 403);
            this.rbIncorrect_3.Name = "rbIncorrect_3";
            this.rbIncorrect_3.Size = new System.Drawing.Size(156, 34);
            this.rbIncorrect_3.TabIndex = 13;
            this.rbIncorrect_3.Text = "lblIncorrectQ";
            this.rbIncorrect_3.UseVisualStyleBackColor = false;
            this.rbIncorrect_3.CheckedChanged += new System.EventHandler(this.EnableSubmit);
            // 
            // pbIncorrect1
            // 
            this.pbIncorrect1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbIncorrect1.Image = global::Coursework_0._0.Properties.Resources.Red_X;
            this.pbIncorrect1.Location = new System.Drawing.Point(841, 178);
            this.pbIncorrect1.Name = "pbIncorrect1";
            this.pbIncorrect1.Size = new System.Drawing.Size(75, 75);
            this.pbIncorrect1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIncorrect1.TabIndex = 34;
            this.pbIncorrect1.TabStop = false;
            this.pbIncorrect1.UseWaitCursor = true;
            this.pbIncorrect1.Visible = false;
            // 
            // pbCorrect
            // 
            this.pbCorrect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbCorrect.Image = global::Coursework_0._0.Properties.Resources.Green_Tickpng;
            this.pbCorrect.Location = new System.Drawing.Point(841, 244);
            this.pbCorrect.Name = "pbCorrect";
            this.pbCorrect.Size = new System.Drawing.Size(75, 75);
            this.pbCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCorrect.TabIndex = 35;
            this.pbCorrect.TabStop = false;
            this.pbCorrect.Visible = false;
            // 
            // pbIncorrect2
            // 
            this.pbIncorrect2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbIncorrect2.Image = global::Coursework_0._0.Properties.Resources.Red_X;
            this.pbIncorrect2.Location = new System.Drawing.Point(841, 312);
            this.pbIncorrect2.Name = "pbIncorrect2";
            this.pbIncorrect2.Size = new System.Drawing.Size(75, 75);
            this.pbIncorrect2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIncorrect2.TabIndex = 36;
            this.pbIncorrect2.TabStop = false;
            this.pbIncorrect2.Visible = false;
            // 
            // pbIncorrect3
            // 
            this.pbIncorrect3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbIncorrect3.Image = global::Coursework_0._0.Properties.Resources.Red_X;
            this.pbIncorrect3.Location = new System.Drawing.Point(841, 371);
            this.pbIncorrect3.Name = "pbIncorrect3";
            this.pbIncorrect3.Size = new System.Drawing.Size(75, 75);
            this.pbIncorrect3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbIncorrect3.TabIndex = 37;
            this.pbIncorrect3.TabStop = false;
            this.pbIncorrect3.Visible = false;
            // 
            // HiddenDefaultBtn
            // 
            this.HiddenDefaultBtn.AutoSize = true;
            this.HiddenDefaultBtn.Checked = true;
            this.HiddenDefaultBtn.Location = new System.Drawing.Point(1039, 56);
            this.HiddenDefaultBtn.Name = "HiddenDefaultBtn";
            this.HiddenDefaultBtn.Size = new System.Drawing.Size(93, 17);
            this.HiddenDefaultBtn.TabIndex = 38;
            this.HiddenDefaultBtn.TabStop = true;
            this.HiddenDefaultBtn.Text = "HiddenDefault";
            this.HiddenDefaultBtn.UseVisualStyleBackColor = true;
            this.HiddenDefaultBtn.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnNext.Location = new System.Drawing.Point(657, 519);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(150, 66);
            this.btnNext.TabIndex = 39;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(296, 519);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 66);
            this.btnSubmit.TabIndex = 40;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Image = global::Coursework_0._0.Properties.Resources.tf_w_trans;
            this.pictureBox1.Location = new System.Drawing.Point(53, 133);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(283, 289);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EasyRadioButtonQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 607);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.HiddenDefaultBtn);
            this.Controls.Add(this.pbIncorrect3);
            this.Controls.Add(this.pbIncorrect2);
            this.Controls.Add(this.pbCorrect);
            this.Controls.Add(this.pbIncorrect1);
            this.Controls.Add(this.rbIncorrect_3);
            this.Controls.Add(this.rbIncorrect_2);
            this.Controls.Add(this.rbCorrect);
            this.Controls.Add(this.rbIncorrect_1);
            this.Controls.Add(this.lblRadioButtonQuestion);
            this.Name = "EasyRadioButtonQuestion";
            this.Text = "EasyRadioButtonQuestion";
            this.Load += new System.EventHandler(this.EasyRadioButtonQuestion_Load);
            this.Controls.SetChildIndex(this.lblRadioButtonQuestion, 0);
            this.Controls.SetChildIndex(this.rbIncorrect_1, 0);
            this.Controls.SetChildIndex(this.rbCorrect, 0);
            this.Controls.SetChildIndex(this.rbIncorrect_2, 0);
            this.Controls.SetChildIndex(this.rbIncorrect_3, 0);
            this.Controls.SetChildIndex(this.pbIncorrect1, 0);
            this.Controls.SetChildIndex(this.pbCorrect, 0);
            this.Controls.SetChildIndex(this.pbIncorrect2, 0);
            this.Controls.SetChildIndex(this.pbIncorrect3, 0);
            this.Controls.SetChildIndex(this.HiddenDefaultBtn, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbIncorrect3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRadioButtonQuestion;
        private System.Windows.Forms.RadioButton rbIncorrect_1;
        private System.Windows.Forms.RadioButton rbCorrect;
        private System.Windows.Forms.RadioButton rbIncorrect_2;
        private System.Windows.Forms.RadioButton rbIncorrect_3;
        private System.Windows.Forms.PictureBox pbIncorrect1;
        private System.Windows.Forms.PictureBox pbCorrect;
        private System.Windows.Forms.PictureBox pbIncorrect2;
        private System.Windows.Forms.PictureBox pbIncorrect3;
        private System.Windows.Forms.RadioButton HiddenDefaultBtn;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}