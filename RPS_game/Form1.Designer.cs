namespace RPS_game
{
    partial class RPS_Form
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            buttonROCK = new Button();
            buttonPAPER = new Button();
            buttonSCISSORS = new Button();
            startButton = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(343, 55);
            label1.Name = "label1";
            label1.Size = new Size(259, 38);
            label1.TabIndex = 0;
            label1.Text = "Rock Paper Scissors";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(55, 231);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(271, 372);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(611, 231);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(289, 372);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // buttonROCK
            // 
            buttonROCK.Location = new Point(383, 311);
            buttonROCK.Name = "buttonROCK";
            buttonROCK.Size = new Size(158, 61);
            buttonROCK.TabIndex = 3;
            buttonROCK.Text = "ROCK";
            buttonROCK.UseVisualStyleBackColor = true;
            buttonROCK.Click += buttonROCK_Click;
            // 
            // buttonPAPER
            // 
            buttonPAPER.Location = new Point(391, 400);
            buttonPAPER.Name = "buttonPAPER";
            buttonPAPER.Size = new Size(150, 58);
            buttonPAPER.TabIndex = 4;
            buttonPAPER.Text = "PAPER";
            buttonPAPER.UseVisualStyleBackColor = true;
            buttonPAPER.Click += buttonPAPER_Click;
            // 
            // buttonSCISSORS
            // 
            buttonSCISSORS.Location = new Point(383, 482);
            buttonSCISSORS.Name = "buttonSCISSORS";
            buttonSCISSORS.Size = new Size(171, 58);
            buttonSCISSORS.TabIndex = 5;
            buttonSCISSORS.Text = "SCISSORS";
            buttonSCISSORS.UseVisualStyleBackColor = true;
            buttonSCISSORS.Click += buttonSCISSORS_Click;
            // 
            // startButton
            // 
            startButton.BackColor = Color.Chartreuse;
            startButton.ForeColor = Color.Black;
            startButton.Location = new Point(370, 114);
            startButton.Name = "startButton";
            startButton.Size = new Size(190, 71);
            startButton.TabIndex = 6;
            startButton.Text = "START";
            startButton.UseVisualStyleBackColor = false;
            startButton.Click += startButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkOrchid;
            label2.Location = new Point(66, 658);
            label2.Name = "label2";
            label2.Size = new Size(102, 32);
            label2.TabIndex = 7;
            label2.Text = "STATUS";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 178);
            label3.Name = "label3";
            label3.Size = new Size(76, 25);
            label3.TabIndex = 8;
            label3.Text = "PLAYER:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(612, 175);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 9;
            label4.Text = "PROGRAM:";
            // 
            // RPS_Form
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(964, 805);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(startButton);
            Controls.Add(buttonSCISSORS);
            Controls.Add(buttonPAPER);
            Controls.Add(buttonROCK);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "RPS_Form";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button buttonROCK;
        private Button buttonPAPER;
        private Button buttonSCISSORS;
        private Button startButton;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}