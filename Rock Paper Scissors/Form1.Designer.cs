namespace Rock_Paper_Scissors
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            p1r = new Button();
            p1p = new Button();
            p1s = new Button();
            CPUPIC = new PictureBox();
            PLAYERPIC = new PictureBox();
            lblcpu = new Label();
            lblps = new Label();
            lblcs = new Label();
            ((System.ComponentModel.ISupportInitialize)CPUPIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PLAYERPIC).BeginInit();
            SuspendLayout();
            // 
            // p1r
            // 
            p1r.BackColor = Color.Silver;
            p1r.BackgroundImageLayout = ImageLayout.Zoom;
            p1r.Cursor = Cursors.Cross;
            p1r.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            p1r.Location = new Point(50, 440);
            p1r.Name = "p1r";
            p1r.Size = new Size(140, 70);
            p1r.TabIndex = 0;
            p1r.Tag = "R";
            p1r.Text = "Rock";
            p1r.UseVisualStyleBackColor = false;
            p1r.Click += MakeChoiceEvent;
            // 
            // p1p
            // 
            p1p.BackColor = Color.Silver;
            p1p.BackgroundImageLayout = ImageLayout.Zoom;
            p1p.Cursor = Cursors.Cross;
            p1p.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            p1p.Location = new Point(320, 440);
            p1p.Name = "p1p";
            p1p.Size = new Size(140, 70);
            p1p.TabIndex = 1;
            p1p.Tag = "P";
            p1p.Text = "Paper";
            p1p.UseVisualStyleBackColor = false;
            p1p.Click += MakeChoiceEvent;
            // 
            // p1s
            // 
            p1s.BackColor = Color.Silver;
            p1s.BackgroundImageLayout = ImageLayout.Zoom;
            p1s.Cursor = Cursors.Cross;
            p1s.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            p1s.Location = new Point(590, 440);
            p1s.Name = "p1s";
            p1s.Size = new Size(140, 70);
            p1s.TabIndex = 2;
            p1s.Tag = "S";
            p1s.Text = "Scissors";
            p1s.UseVisualStyleBackColor = false;
            p1s.Click += MakeChoiceEvent;
            // 
            // CPUPIC
            // 
            CPUPIC.Location = new Point(320, 70);
            CPUPIC.Name = "CPUPIC";
            CPUPIC.Size = new Size(140, 140);
            CPUPIC.SizeMode = PictureBoxSizeMode.Zoom;
            CPUPIC.TabIndex = 4;
            CPUPIC.TabStop = false;
            // 
            // PLAYERPIC
            // 
            PLAYERPIC.Location = new Point(320, 260);
            PLAYERPIC.Name = "PLAYERPIC";
            PLAYERPIC.Size = new Size(140, 140);
            PLAYERPIC.SizeMode = PictureBoxSizeMode.Zoom;
            PLAYERPIC.TabIndex = 5;
            PLAYERPIC.TabStop = false;
            // 
            // lblcpu
            // 
            lblcpu.AutoSize = true;
            lblcpu.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblcpu.ForeColor = SystemColors.ButtonHighlight;
            lblcpu.Location = new Point(330, 20);
            lblcpu.Name = "lblcpu";
            lblcpu.Size = new Size(119, 25);
            lblcpu.TabIndex = 6;
            lblcpu.Text = "CPU Choice:";
            lblcpu.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblps
            // 
            lblps.AutoSize = true;
            lblps.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblps.ForeColor = SystemColors.ButtonHighlight;
            lblps.Location = new Point(40, 220);
            lblps.Name = "lblps";
            lblps.Size = new Size(127, 25);
            lblps.TabIndex = 7;
            lblps.Text = "Player Score:";
            lblps.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblcs
            // 
            lblcs.AutoSize = true;
            lblcs.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblcs.ForeColor = SystemColors.ButtonHighlight;
            lblcs.Location = new Point(620, 220);
            lblcs.Name = "lblcs";
            lblcs.Size = new Size(110, 25);
            lblcs.TabIndex = 8;
            lblcs.Text = "CPU Score:";
            lblcs.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(784, 561);
            Controls.Add(lblcs);
            Controls.Add(lblps);
            Controls.Add(lblcpu);
            Controls.Add(PLAYERPIC);
            Controls.Add(CPUPIC);
            Controls.Add(p1s);
            Controls.Add(p1p);
            Controls.Add(p1r);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Rock Paper Scissors";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)CPUPIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)PLAYERPIC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int s = 0;
        }

        #endregion

        private Button p1r;
        private Button p1p;
        private Button p1s;
        private PictureBox CPUPIC;
        private PictureBox PLAYERPIC;
        private Label lblcpu;
        private Label lblps;
        private Label lblcs;
    }
}