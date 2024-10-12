namespace TPIS_1
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
            button1 = new Button();
            button2 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            label1 = new Label();
            labelturno = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.DarkBlue;
            button1.Location = new Point(50, 50);
            button1.Name = "button1";
            button1.Size = new Size(100, 100);
            button1.TabIndex = 0;
            button1.Text = " ";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.DarkBlue;
            button2.Location = new Point(150, 50);
            button2.Name = "button2";
            button2.Size = new Size(100, 100);
            button2.TabIndex = 1;
            button2.Text = " ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = Color.DarkBlue;
            button3.Location = new Point(250, 50);
            button3.Name = "button3";
            button3.Size = new Size(100, 100);
            button3.TabIndex = 2;
            button3.Text = " ";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Button1_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = Color.DarkBlue;
            button4.Location = new Point(50, 150);
            button4.Name = "button4";
            button4.Size = new Size(100, 100);
            button4.TabIndex = 5;
            button4.Text = " ";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Button1_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = Color.DarkBlue;
            button5.Location = new Point(150, 150);
            button5.Name = "button5";
            button5.Size = new Size(100, 100);
            button5.TabIndex = 4;
            button5.Text = " ";
            button5.UseVisualStyleBackColor = true;
            button5.Click += Button1_Click;
            // 
            // button6
            // 
            button6.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = Color.DarkBlue;
            button6.Location = new Point(250, 150);
            button6.Name = "button6";
            button6.Size = new Size(100, 100);
            button6.TabIndex = 3;
            button6.Text = " ";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Button1_Click;
            // 
            // button7
            // 
            button7.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.ForeColor = Color.DarkBlue;
            button7.Location = new Point(50, 250);
            button7.Name = "button7";
            button7.Size = new Size(100, 100);
            button7.TabIndex = 8;
            button7.Text = " ";
            button7.UseVisualStyleBackColor = true;
            button7.Click += Button1_Click;
            // 
            // button8
            // 
            button8.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = Color.DarkBlue;
            button8.Location = new Point(150, 250);
            button8.Name = "button8";
            button8.Size = new Size(100, 100);
            button8.TabIndex = 7;
            button8.Text = " ";
            button8.UseVisualStyleBackColor = true;
            button8.Click += Button1_Click;
            // 
            // button9
            // 
            button9.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button9.ForeColor = Color.DarkBlue;
            button9.Location = new Point(250, 250);
            button9.Name = "button9";
            button9.Size = new Size(100, 100);
            button9.TabIndex = 6;
            button9.Text = " ";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 369);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 9;
            label1.Text = "è il turno di ";
            // 
            // labelturno
            // 
            labelturno.AutoSize = true;
            labelturno.Location = new Point(169, 372);
            labelturno.Name = "labelturno";
            labelturno.Size = new Size(38, 15);
            labelturno.TabIndex = 10;
            labelturno.Text = "label2";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 392);
            Controls.Add(labelturno);
            Controls.Add(label1);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private System.Windows.Forms.Timer timer1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label label1;
        private Label labelturno;
    }
}