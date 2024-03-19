using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Coursework_0._0
{
    public partial class InstructionBox : Form
    {
        private string instructions;
        private Image instructionImage;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
       (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // height of ellipse
           int nHeightEllipse // width of ellipse
       );
        public InstructionBox()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }
        public InstructionBox(string instructions, Image instructionImage)
        {
            InitializeComponent();
            this.instructions = instructions;
            this.instructionImage = instructionImage;
        }
        private void InstructionBox_Load(object sender, EventArgs e)
        {
            lblInstructions.Text = instructions;
            imgInstructions.Image = instructionImage;
        }

        private void InstructionBox_Paint(object sender, PaintEventArgs e) => ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.White, 1, ButtonBorderStyle.Solid, Color.White, 1, ButtonBorderStyle.Solid, Color.White, 1, ButtonBorderStyle.Solid, Color.White, 1, ButtonBorderStyle.Solid);
        private void pbExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
