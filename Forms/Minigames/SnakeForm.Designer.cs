
namespace Coursework_0._0.Forms.Minigames
{
    partial class SnakeForm
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
            this.btnStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.imgSnakeArea = new System.Windows.Forms.PictureBox();
            this.lblGameOver = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgSnakeArea)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(26, 43);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(143, 42);
            this.btnStart.TabIndex = 18;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // imgSnakeArea
            // 
            this.imgSnakeArea.BackColor = System.Drawing.Color.Silver;
            this.imgSnakeArea.Location = new System.Drawing.Point(183, 74);
            this.imgSnakeArea.Name = "imgSnakeArea";
            this.imgSnakeArea.Size = new System.Drawing.Size(810, 491);
            this.imgSnakeArea.TabIndex = 20;
            this.imgSnakeArea.TabStop = false;
            this.imgSnakeArea.Paint += new System.Windows.Forms.PaintEventHandler(this.imgSnakeArea_Paint);
            // 
            // lblGameOver
            // 
            this.lblGameOver.BackColor = System.Drawing.Color.Silver;
            this.lblGameOver.Font = new System.Drawing.Font("Imprint MT Shadow", 24F);
            this.lblGameOver.Location = new System.Drawing.Point(183, 280);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(810, 101);
            this.lblGameOver.TabIndex = 21;
            this.lblGameOver.Text = "Start the game. \r\nUse W/A/S/D to navigate the snake.";
            this.lblGameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.lblScore.Location = new System.Drawing.Point(926, 41);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(67, 30);
            this.lblScore.TabIndex = 22;
            this.lblScore.Text = "Score";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(474, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 30);
            this.label2.TabIndex = 24;
            this.label2.Text = "Snake game.";
            // 
            // SnakeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 607);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.imgSnakeArea);
            this.Controls.Add(this.btnStart);
            this.Name = "SnakeForm";
            this.Text = "SnakeForm";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SnakeForm_KeyPress);
            this.Controls.SetChildIndex(this.btnStart, 0);
            this.Controls.SetChildIndex(this.imgSnakeArea, 0);
            this.Controls.SetChildIndex(this.lblGameOver, 0);
            this.Controls.SetChildIndex(this.lblScore, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            ((System.ComponentModel.ISupportInitialize)(this.imgSnakeArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox imgSnakeArea;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label2;
    }
}