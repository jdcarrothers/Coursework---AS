
namespace Coursework_0._0.Forms.Questions
{
    partial class EasyDragAndDrop
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxC = new System.Windows.Forms.PictureBox();
            this.pictureBoxA = new System.Windows.Forms.PictureBox();
            this.pictureBoxD = new System.Windows.Forms.PictureBox();
            this.pbHammerFeedback = new System.Windows.Forms.PictureBox();
            this.pbScrewdriverFeedback = new System.Windows.Forms.PictureBox();
            this.pbSawFeedback = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHammerFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrewdriverFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSawFeedback)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.Location = new System.Drawing.Point(296, 519);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(150, 66);
            this.btnSubmit.TabIndex = 41;
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
            this.btnNext.TabIndex = 42;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Coursework_0._0.Properties.Resources.screwdriverDrag;
            this.pictureBox1.Location = new System.Drawing.Point(337, 119);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 43;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "Screwdriver";
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox2.Image = global::Coursework_0._0.Properties.Resources.sawDrag;
            this.pictureBox2.Location = new System.Drawing.Point(337, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(125, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "Saw";
            this.pictureBox2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox3.Image = global::Coursework_0._0.Properties.Resources.hammerDrag;
            this.pictureBox3.Location = new System.Drawing.Point(337, 382);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(125, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 45;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "Hammer";
            this.pictureBox3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox_MouseDown);
            // 
            // pictureBoxC
            // 
            this.pictureBoxC.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxC.Image = global::Coursework_0._0.Properties.Resources.blank_question;
            this.pictureBoxC.Location = new System.Drawing.Point(682, 120);
            this.pictureBoxC.Name = "pictureBoxC";
            this.pictureBoxC.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxC.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxC.TabIndex = 46;
            this.pictureBoxC.TabStop = false;
            this.pictureBoxC.Tag = "Hammer";
            this.pictureBoxC.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.pictureBoxC.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            this.pictureBoxC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnswerPictureBox_MouseDown);
            // 
            // pictureBoxA
            // 
            this.pictureBoxA.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxA.Image = global::Coursework_0._0.Properties.Resources.blank_question;
            this.pictureBoxA.Location = new System.Drawing.Point(682, 251);
            this.pictureBoxA.Name = "pictureBoxA";
            this.pictureBoxA.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxA.TabIndex = 47;
            this.pictureBoxA.TabStop = false;
            this.pictureBoxA.Tag = "Screwdriver";
            this.pictureBoxA.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.pictureBoxA.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            this.pictureBoxA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnswerPictureBox_MouseDown);
            // 
            // pictureBoxD
            // 
            this.pictureBoxD.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBoxD.Image = global::Coursework_0._0.Properties.Resources.blank_question;
            this.pictureBoxD.Location = new System.Drawing.Point(682, 382);
            this.pictureBoxD.Name = "pictureBoxD";
            this.pictureBoxD.Size = new System.Drawing.Size(125, 125);
            this.pictureBoxD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxD.TabIndex = 48;
            this.pictureBoxD.TabStop = false;
            this.pictureBoxD.Tag = "Saw";
            this.pictureBoxD.DragDrop += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragDrop);
            this.pictureBoxD.DragEnter += new System.Windows.Forms.DragEventHandler(this.PictureBox_DragEnter);
            this.pictureBoxD.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AnswerPictureBox_MouseDown);
            // 
            // pbHammerFeedback
            // 
            this.pbHammerFeedback.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbHammerFeedback.Location = new System.Drawing.Point(1017, 152);
            this.pbHammerFeedback.Name = "pbHammerFeedback";
            this.pbHammerFeedback.Size = new System.Drawing.Size(75, 75);
            this.pbHammerFeedback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHammerFeedback.TabIndex = 49;
            this.pbHammerFeedback.TabStop = false;
            this.pbHammerFeedback.Visible = false;
            // 
            // pbScrewdriverFeedback
            // 
            this.pbScrewdriverFeedback.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbScrewdriverFeedback.Location = new System.Drawing.Point(1017, 282);
            this.pbScrewdriverFeedback.Name = "pbScrewdriverFeedback";
            this.pbScrewdriverFeedback.Size = new System.Drawing.Size(75, 75);
            this.pbScrewdriverFeedback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbScrewdriverFeedback.TabIndex = 50;
            this.pbScrewdriverFeedback.TabStop = false;
            this.pbScrewdriverFeedback.Visible = false;
            // 
            // pbSawFeedback
            // 
            this.pbSawFeedback.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pbSawFeedback.Location = new System.Drawing.Point(1017, 410);
            this.pbSawFeedback.Name = "pbSawFeedback";
            this.pbSawFeedback.Size = new System.Drawing.Size(75, 75);
            this.pbSawFeedback.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbSawFeedback.TabIndex = 51;
            this.pbSawFeedback.TabStop = false;
            this.pbSawFeedback.Visible = false;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.btnReset.Location = new System.Drawing.Point(488, 519);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(150, 66);
            this.btnReset.TabIndex = 52;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(813, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 30);
            this.label5.TabIndex = 53;
            this.label5.Text = "Hammer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(813, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 54;
            this.label2.Text = "Screwdriver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(813, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 30);
            this.label3.TabIndex = 55;
            this.label3.Text = "Saw";
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox4.Image = global::Coursework_0._0.Properties.Resources._7074781;
            this.pictureBox4.Location = new System.Drawing.Point(53, 193);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(224, 236);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 56;
            this.pictureBox4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // EasyDragAndDrop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 607);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbSawFeedback);
            this.Controls.Add(this.pbScrewdriverFeedback);
            this.Controls.Add(this.pbHammerFeedback);
            this.Controls.Add(this.pictureBoxD);
            this.Controls.Add(this.pictureBoxA);
            this.Controls.Add(this.pictureBoxC);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSubmit);
            this.Name = "EasyDragAndDrop";
            this.Text = "EasyDragAndDrop";
            this.Controls.SetChildIndex(this.btnSubmit, 0);
            this.Controls.SetChildIndex(this.btnNext, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox3, 0);
            this.Controls.SetChildIndex(this.pictureBoxC, 0);
            this.Controls.SetChildIndex(this.pictureBoxA, 0);
            this.Controls.SetChildIndex(this.pictureBoxD, 0);
            this.Controls.SetChildIndex(this.pbHammerFeedback, 0);
            this.Controls.SetChildIndex(this.pbScrewdriverFeedback, 0);
            this.Controls.SetChildIndex(this.pbSawFeedback, 0);
            this.Controls.SetChildIndex(this.btnReset, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pictureBox4, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbHammerFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbScrewdriverFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSawFeedback)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBoxC;
        private System.Windows.Forms.PictureBox pictureBoxA;
        private System.Windows.Forms.PictureBox pictureBoxD;
        private System.Windows.Forms.PictureBox pbHammerFeedback;
        private System.Windows.Forms.PictureBox pbScrewdriverFeedback;
        private System.Windows.Forms.PictureBox pbSawFeedback;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Timer timer1;
    }
}