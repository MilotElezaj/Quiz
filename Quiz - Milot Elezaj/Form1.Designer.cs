namespace Quiz___Milot_Elezaj
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
            pictureBox1 = new PictureBox();
            lblQuestion = new Label();
            btn1 = new Button();
            btn2 = new Button();
            btn4 = new Button();
            btn3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.questions;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(757, 341);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lblQuestion
            // 
            lblQuestion.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblQuestion.Location = new Point(12, 368);
            lblQuestion.Name = "lblQuestion";
            lblQuestion.Size = new Size(757, 68);
            lblQuestion.TabIndex = 1;
            lblQuestion.Text = "Question";
            lblQuestion.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btn1
            // 
            btn1.Location = new Point(9, 453);
            btn1.Name = "btn1";
            btn1.Size = new Size(390, 44);
            btn1.TabIndex = 2;
            btn1.Tag = "1";
            btn1.Text = "button1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += checkAnswerEvent;
            // 
            // btn2
            // 
            btn2.Location = new Point(425, 453);
            btn2.Name = "btn2";
            btn2.Size = new Size(344, 44);
            btn2.TabIndex = 3;
            btn2.Tag = "2";
            btn2.Text = "button2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += checkAnswerEvent;
            // 
            // btn4
            // 
            btn4.Location = new Point(425, 517);
            btn4.Name = "btn4";
            btn4.Size = new Size(344, 44);
            btn4.TabIndex = 5;
            btn4.Tag = "4";
            btn4.Text = "button4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += checkAnswerEvent;
            // 
            // btn3
            // 
            btn3.Location = new Point(9, 517);
            btn3.Name = "btn3";
            btn3.Size = new Size(390, 44);
            btn3.TabIndex = 4;
            btn3.Tag = "3";
            btn3.Text = "button3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += checkAnswerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 601);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lblQuestion);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            ImeMode = ImeMode.Off;
            Name = "Form1";
            Text = "MiniKuiz - Milot Elezaj";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lblQuestion;
        private Button btn1;
        private Button btn2;
        private Button btn4;
        private Button btn3;
    }
}
