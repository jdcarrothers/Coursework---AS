
namespace Coursework_0._0.Forms.MainMenu.Admin
{
    partial class AdminMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMenu));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.btnRequestEdit = new System.Windows.Forms.Button();
            this.btnDeselectIndex = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAddIncorrect1 = new System.Windows.Forms.TextBox();
            this.txtAddCorrect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReplaceEdit = new System.Windows.Forms.Button();
            this.txtAddQuestion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnRemoveQuestion = new System.Windows.Forms.Button();
            this.listBoxQuestions = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddQuestionData = new System.Windows.Forms.Button();
            this.txtAddIncorrect3 = new System.Windows.Forms.TextBox();
            this.txtAddIncorrect2 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.TtAddQuestion = new System.Windows.Forms.ToolTip(this.components);
            this.infoPbANQ = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPbANQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainPanel.Controls.Add(this.infoPbANQ);
            this.mainPanel.Controls.Add(this.btnRequestEdit);
            this.mainPanel.Controls.Add(this.btnDeselectIndex);
            this.mainPanel.Controls.Add(this.label9);
            this.mainPanel.Controls.Add(this.txtAddIncorrect1);
            this.mainPanel.Controls.Add(this.txtAddCorrect);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.btnReplaceEdit);
            this.mainPanel.Controls.Add(this.txtAddQuestion);
            this.mainPanel.Controls.Add(this.label6);
            this.mainPanel.Controls.Add(this.btnRemoveQuestion);
            this.mainPanel.Controls.Add(this.listBoxQuestions);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.btnAddQuestionData);
            this.mainPanel.Controls.Add(this.txtAddIncorrect3);
            this.mainPanel.Controls.Add(this.txtAddIncorrect2);
            this.mainPanel.Location = new System.Drawing.Point(22, 50);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(539, 512);
            this.mainPanel.TabIndex = 36;
            // 
            // btnRequestEdit
            // 
            this.btnRequestEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRequestEdit.ForeColor = System.Drawing.Color.Black;
            this.btnRequestEdit.Location = new System.Drawing.Point(324, 318);
            this.btnRequestEdit.Name = "btnRequestEdit";
            this.btnRequestEdit.Size = new System.Drawing.Size(205, 35);
            this.btnRequestEdit.TabIndex = 58;
            this.btnRequestEdit.Text = "Edit";
            this.btnRequestEdit.UseVisualStyleBackColor = true;
            this.btnRequestEdit.Click += new System.EventHandler(this.btnRequestEdit_Click);
            // 
            // btnDeselectIndex
            // 
            this.btnDeselectIndex.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeselectIndex.ForeColor = System.Drawing.Color.Black;
            this.btnDeselectIndex.Location = new System.Drawing.Point(420, 138);
            this.btnDeselectIndex.Name = "btnDeselectIndex";
            this.btnDeselectIndex.Size = new System.Drawing.Size(111, 35);
            this.btnDeselectIndex.TabIndex = 57;
            this.btnDeselectIndex.Text = "Deselect";
            this.btnDeselectIndex.UseVisualStyleBackColor = true;
            this.btnDeselectIndex.Click += new System.EventHandler(this.btnDeselectIndex_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(179, 5);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(213, 44);
            this.label9.TabIndex = 56;
            this.label9.Text = "Edit questions";
            // 
            // txtAddIncorrect1
            // 
            this.txtAddIncorrect1.Enabled = false;
            this.txtAddIncorrect1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddIncorrect1.Location = new System.Drawing.Point(20, 320);
            this.txtAddIncorrect1.Name = "txtAddIncorrect1";
            this.txtAddIncorrect1.Size = new System.Drawing.Size(295, 33);
            this.txtAddIncorrect1.TabIndex = 38;
            this.txtAddIncorrect1.TextChanged += new System.EventHandler(this.Check);
            // 
            // txtAddCorrect
            // 
            this.txtAddCorrect.Enabled = false;
            this.txtAddCorrect.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddCorrect.Location = new System.Drawing.Point(20, 251);
            this.txtAddCorrect.Name = "txtAddCorrect";
            this.txtAddCorrect.Size = new System.Drawing.Size(295, 33);
            this.txtAddCorrect.TabIndex = 37;
            this.txtAddCorrect.TextChanged += new System.EventHandler(this.Check);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(15, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 30);
            this.label3.TabIndex = 43;
            this.label3.Text = "Correct answer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 30);
            this.label2.TabIndex = 42;
            this.label2.Text = "Question";
            // 
            // btnReplaceEdit
            // 
            this.btnReplaceEdit.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F);
            this.btnReplaceEdit.ForeColor = System.Drawing.Color.Black;
            this.btnReplaceEdit.Location = new System.Drawing.Point(324, 387);
            this.btnReplaceEdit.Name = "btnReplaceEdit";
            this.btnReplaceEdit.Size = new System.Drawing.Size(205, 35);
            this.btnReplaceEdit.TabIndex = 49;
            this.btnReplaceEdit.Text = "Confirm Changes";
            this.btnReplaceEdit.UseVisualStyleBackColor = true;
            this.btnReplaceEdit.Visible = false;
            this.btnReplaceEdit.Click += new System.EventHandler(this.btnReplaceEdit_Click);
            // 
            // txtAddQuestion
            // 
            this.txtAddQuestion.Enabled = false;
            this.txtAddQuestion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddQuestion.Location = new System.Drawing.Point(20, 183);
            this.txtAddQuestion.Name = "txtAddQuestion";
            this.txtAddQuestion.Size = new System.Drawing.Size(295, 33);
            this.txtAddQuestion.TabIndex = 36;
            this.txtAddQuestion.TextChanged += new System.EventHandler(this.Check);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(15, 425);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(194, 30);
            this.label6.TabIndex = 46;
            this.label6.Text = "Incorrect answer 3";
            // 
            // btnRemoveQuestion
            // 
            this.btnRemoveQuestion.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveQuestion.ForeColor = System.Drawing.Color.Black;
            this.btnRemoveQuestion.Location = new System.Drawing.Point(326, 251);
            this.btnRemoveQuestion.Name = "btnRemoveQuestion";
            this.btnRemoveQuestion.Size = new System.Drawing.Size(205, 35);
            this.btnRemoveQuestion.TabIndex = 47;
            this.btnRemoveQuestion.Text = "Remove question";
            this.btnRemoveQuestion.UseVisualStyleBackColor = true;
            this.btnRemoveQuestion.Click += new System.EventHandler(this.btnRemoveQuestion_Click);
            // 
            // listBoxQuestions
            // 
            this.listBoxQuestions.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBoxQuestions.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold);
            this.listBoxQuestions.FormattingEnabled = true;
            this.listBoxQuestions.ItemHeight = 19;
            this.listBoxQuestions.Location = new System.Drawing.Point(0, 52);
            this.listBoxQuestions.Name = "listBoxQuestions";
            this.listBoxQuestions.Size = new System.Drawing.Size(538, 80);
            this.listBoxQuestions.TabIndex = 35;
            this.listBoxQuestions.SelectedIndexChanged += new System.EventHandler(this.listBoxQuestions_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(15, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 30);
            this.label5.TabIndex = 45;
            this.label5.Text = "Incorrect answer 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(15, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 30);
            this.label4.TabIndex = 44;
            this.label4.Text = "Incorrect answer 1";
            // 
            // btnAddQuestionData
            // 
            this.btnAddQuestionData.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddQuestionData.ForeColor = System.Drawing.Color.Black;
            this.btnAddQuestionData.Location = new System.Drawing.Point(326, 183);
            this.btnAddQuestionData.Name = "btnAddQuestionData";
            this.btnAddQuestionData.Size = new System.Drawing.Size(205, 35);
            this.btnAddQuestionData.TabIndex = 41;
            this.btnAddQuestionData.Text = "Add new question";
            this.btnAddQuestionData.UseVisualStyleBackColor = true;
            this.btnAddQuestionData.Click += new System.EventHandler(this.btnAddQuestionData_Click);
            // 
            // txtAddIncorrect3
            // 
            this.txtAddIncorrect3.Enabled = false;
            this.txtAddIncorrect3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtAddIncorrect3.Location = new System.Drawing.Point(21, 458);
            this.txtAddIncorrect3.Name = "txtAddIncorrect3";
            this.txtAddIncorrect3.Size = new System.Drawing.Size(294, 33);
            this.txtAddIncorrect3.TabIndex = 40;
            this.txtAddIncorrect3.TextChanged += new System.EventHandler(this.Check);
            // 
            // txtAddIncorrect2
            // 
            this.txtAddIncorrect2.Enabled = false;
            this.txtAddIncorrect2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddIncorrect2.Location = new System.Drawing.Point(20, 389);
            this.txtAddIncorrect2.Name = "txtAddIncorrect2";
            this.txtAddIncorrect2.Size = new System.Drawing.Size(294, 33);
            this.txtAddIncorrect2.TabIndex = 39;
            this.txtAddIncorrect2.TextChanged += new System.EventHandler(this.Check);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(36, 234);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(496, 259);
            this.label7.TabIndex = 39;
            this.label7.Text = resources.GetString("label7.Text");
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(581, 50);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(539, 512);
            this.panel1.TabIndex = 57;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 44);
            this.label1.TabIndex = 56;
            this.label1.Text = "Instructions";
            // 
            // TtAddQuestion
            // 
            this.TtAddQuestion.IsBalloon = true;
            // 
            // infoPbANQ
            // 
            this.infoPbANQ.Image = global::Coursework_0._0.Properties.Resources.info_5_16;
            this.infoPbANQ.Location = new System.Drawing.Point(326, 155);
            this.infoPbANQ.Name = "infoPbANQ";
            this.infoPbANQ.Size = new System.Drawing.Size(25, 25);
            this.infoPbANQ.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.infoPbANQ.TabIndex = 59;
            this.infoPbANQ.TabStop = false;
            this.infoPbANQ.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Coursework_0._0.Properties.Resources.Capture;
            this.pictureBox1.Location = new System.Drawing.Point(183, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 57;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(335, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 178);
            this.label8.TabIndex = 58;
            this.label8.Text = "1\r\n\r\n2\r\n\r\n3\r\n\r\n4";
            // 
            // AdminMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1132, 607);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Name = "AdminMenu";
            this.Text = "AdminMenu";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infoPbANQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Button btnReplaceEdit;
        private System.Windows.Forms.Button btnRemoveQuestion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddQuestionData;
        private System.Windows.Forms.TextBox txtAddIncorrect3;
        private System.Windows.Forms.TextBox txtAddIncorrect2;
        private System.Windows.Forms.TextBox txtAddIncorrect1;
        private System.Windows.Forms.TextBox txtAddCorrect;
        private System.Windows.Forms.TextBox txtAddQuestion;
        private System.Windows.Forms.ListBox listBoxQuestions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeselectIndex;
        private System.Windows.Forms.Button btnRequestEdit;
        private System.Windows.Forms.PictureBox infoPbANQ;
        private System.Windows.Forms.ToolTip TtAddQuestion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
    }
}