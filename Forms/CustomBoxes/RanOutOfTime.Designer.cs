
namespace Coursework_0._0.Forms.CustomBoxes
{
    partial class RanOutOfTime
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
            System.Windows.Forms.Button btnGoToEasyQuestions;
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.imgInstructions = new System.Windows.Forms.PictureBox();
            this.lblInstructions = new System.Windows.Forms.Label();
            btnGoToEasyQuestions = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInstructions)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGoToEasyQuestions
            // 
            btnGoToEasyQuestions.BackColor = System.Drawing.SystemColors.ControlLight;
            btnGoToEasyQuestions.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            btnGoToEasyQuestions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnGoToEasyQuestions.Location = new System.Drawing.Point(119, 141);
            btnGoToEasyQuestions.Name = "btnGoToEasyQuestions";
            btnGoToEasyQuestions.Size = new System.Drawing.Size(77, 28);
            btnGoToEasyQuestions.TabIndex = 45;
            btnGoToEasyQuestions.Text = "Ok";
            btnGoToEasyQuestions.UseVisualStyleBackColor = false;
            btnGoToEasyQuestions.Click += new System.EventHandler(this.btnGoToEasyQuestions_Click);
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(308, 30);
            this.pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblHeader.ForeColor = System.Drawing.Color.Black;
            this.lblHeader.Location = new System.Drawing.Point(103, 2);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(102, 25);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Time\'s up!";
            // 
            // imgInstructions
            // 
            this.imgInstructions.Image = global::Coursework_0._0.Properties.Resources.hourglass_w_trans;
            this.imgInstructions.Location = new System.Drawing.Point(198, 33);
            this.imgInstructions.Name = "imgInstructions";
            this.imgInstructions.Size = new System.Drawing.Size(98, 106);
            this.imgInstructions.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgInstructions.TabIndex = 20;
            this.imgInstructions.TabStop = false;
            // 
            // lblInstructions
            // 
            this.lblInstructions.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstructions.ForeColor = System.Drawing.Color.Black;
            this.lblInstructions.Location = new System.Drawing.Point(12, 33);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(162, 118);
            this.lblInstructions.TabIndex = 21;
            this.lblInstructions.Text = "You ran out of time, no points were awarded! Push through onto the next question!" +
    "";
            this.lblInstructions.Click += new System.EventHandler(this.lblInstructions_Click);
            // 
            // RanOutOfTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(308, 172);
            this.Controls.Add(btnGoToEasyQuestions);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.imgInstructions);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RanOutOfTime";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RanOutOfTime";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgInstructions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.PictureBox imgInstructions;
        private System.Windows.Forms.Label lblInstructions;
    }
}