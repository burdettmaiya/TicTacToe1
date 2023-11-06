namespace TicTacToe1
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
            components = new System.ComponentModel.Container();
            process1 = new System.Diagnostics.Process();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            CPUwatch = new System.Windows.Forms.Timer(components);
            tryagain = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // process1
            // 
            process1.StartInfo.Domain = "";
            process1.StartInfo.LoadUserProfile = false;
            process1.StartInfo.Password = null;
            process1.StartInfo.StandardErrorEncoding = null;
            process1.StartInfo.StandardInputEncoding = null;
            process1.StartInfo.StandardOutputEncoding = null;
            process1.StartInfo.UserName = "";
            process1.SynchronizingObject = this;
            // 
            // label1
            // 
            label1.Font = new Font("Broadway", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(32, 84);
            label1.Name = "label1";
            label1.Size = new Size(23, 31);
            label1.TabIndex = 0;
            label1.Text = "-";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Broadway", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.Fuchsia;
            label2.Location = new Point(427, 81);
            label2.Name = "label2";
            label2.Size = new Size(16, 19);
            label2.TabIndex = 1;
            label2.Text = "-";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaptionText;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DeepPink;
            button1.Location = new Point(70, 84);
            button1.Name = "button1";
            button1.Size = new Size(115, 114);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = false;
            button1.Click += PlayerClickButton;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaptionText;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(179, 84);
            button2.Name = "button2";
            button2.Size = new Size(115, 114);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = false;
            button2.Click += PlayerClickButton;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ActiveCaptionText;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ButtonHighlight;
            button3.Location = new Point(288, 84);
            button3.Name = "button3";
            button3.Size = new Size(115, 114);
            button3.TabIndex = 4;
            button3.UseVisualStyleBackColor = false;
            button3.Click += PlayerClickButton;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ActiveCaptionText;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(288, 184);
            button4.Name = "button4";
            button4.Size = new Size(115, 114);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = false;
            button4.Click += PlayerClickButton;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaptionText;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.ButtonHighlight;
            button5.Location = new Point(179, 184);
            button5.Name = "button5";
            button5.Size = new Size(115, 114);
            button5.TabIndex = 6;
            button5.UseVisualStyleBackColor = false;
            button5.Click += PlayerClickButton;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaptionText;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ButtonHighlight;
            button6.Location = new Point(70, 184);
            button6.Name = "button6";
            button6.Size = new Size(115, 114);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = false;
            button6.Click += PlayerClickButton;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ActiveCaptionText;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = SystemColors.ButtonHighlight;
            button7.Location = new Point(288, 288);
            button7.Name = "button7";
            button7.Size = new Size(115, 114);
            button7.TabIndex = 10;
            button7.UseVisualStyleBackColor = false;
            button7.Click += PlayerClickButton;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ActiveCaptionText;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(179, 288);
            button8.Name = "button8";
            button8.Size = new Size(115, 114);
            button8.TabIndex = 9;
            button8.UseVisualStyleBackColor = false;
            button8.Click += PlayerClickButton;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ActiveCaptionText;
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Font = new Font("Calibri", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = SystemColors.ButtonHighlight;
            button9.Location = new Point(70, 288);
            button9.Name = "button9";
            button9.Size = new Size(115, 114);
            button9.TabIndex = 8;
            button9.UseVisualStyleBackColor = false;
            button9.Click += PlayerClickButton;
            // 
            // CPUwatch
            // 
            CPUwatch.Interval = 1000;
            CPUwatch.Tick += CPUmove;
            // 
            // tryagain
            // 
            tryagain.BackColor = Color.Transparent;
            tryagain.Location = new Point(150, 413);
            tryagain.Name = "tryagain";
            tryagain.Size = new Size(176, 36);
            tryagain.TabIndex = 11;
            tryagain.Text = "Try Again";
            tryagain.UseVisualStyleBackColor = false;
            tryagain.Click += RestartGame;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.O;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(71, 69);
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.X;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(401, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(71, 66);
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(484, 461);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(tryagain);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "THE BEST TIC TAC TOE";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Diagnostics.Process process1;
        private Label label1;
        private Label label2;

        private Button button7;
        private Button button8;
        private Button button9;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button3;
        private Button button2;
        private Button button1;
        private System.Windows.Forms.Timer CPUwatch;
        private Button tryagain;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}