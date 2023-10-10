namespace GeriSayım
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
            hourNud = new NumericUpDown();
            minuteNud = new NumericUpDown();
            secondNud = new NumericUpDown();
            hourLbl = new Label();
            label2 = new Label();
            minuteLbl = new Label();
            label4 = new Label();
            secondLbl = new Label();
            button1 = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label3 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)hourNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)minuteNud).BeginInit();
            ((System.ComponentModel.ISupportInitialize)secondNud).BeginInit();
            SuspendLayout();
            // 
            // hourNud
            // 
            hourNud.Location = new Point(158, 26);
            hourNud.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            hourNud.Name = "hourNud";
            hourNud.Size = new Size(90, 27);
            hourNud.TabIndex = 0;
            hourNud.TextAlign = HorizontalAlignment.Center;
            // 
            // minuteNud
            // 
            minuteNud.Location = new Point(158, 59);
            minuteNud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            minuteNud.Name = "minuteNud";
            minuteNud.Size = new Size(90, 27);
            minuteNud.TabIndex = 1;
            minuteNud.TextAlign = HorizontalAlignment.Center;
            // 
            // secondNud
            // 
            secondNud.Location = new Point(158, 92);
            secondNud.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            secondNud.Name = "secondNud";
            secondNud.Size = new Size(90, 27);
            secondNud.TabIndex = 2;
            secondNud.TextAlign = HorizontalAlignment.Center;
            // 
            // hourLbl
            // 
            hourLbl.AutoSize = true;
            hourLbl.Location = new Point(119, 136);
            hourLbl.Name = "hourLbl";
            hourLbl.Size = new Size(33, 20);
            hourLbl.TabIndex = 3;
            hourLbl.Text = "000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 136);
            label2.Name = "label2";
            label2.Size = new Size(12, 20);
            label2.TabIndex = 4;
            label2.Text = ":";
            // 
            // minuteLbl
            // 
            minuteLbl.AutoSize = true;
            minuteLbl.Location = new Point(170, 136);
            minuteLbl.Name = "minuteLbl";
            minuteLbl.Size = new Size(25, 20);
            minuteLbl.TabIndex = 5;
            minuteLbl.Text = "00";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 136);
            label4.Name = "label4";
            label4.Size = new Size(12, 20);
            label4.TabIndex = 6;
            label4.Text = ":";
            // 
            // secondLbl
            // 
            secondLbl.AutoSize = true;
            secondLbl.Location = new Point(215, 136);
            secondLbl.Name = "secondLbl";
            secondLbl.Size = new Size(25, 20);
            secondLbl.TabIndex = 7;
            secondLbl.Text = "00";
            // 
            // button1
            // 
            button1.Location = new Point(131, 177);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 8;
            button1.Text = "START";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 28);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 9;
            label1.Text = "Hour";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 61);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 10;
            label3.Text = "Minute";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 94);
            label5.Name = "label5";
            label5.Size = new Size(58, 20);
            label5.TabIndex = 11;
            label5.Text = "Second";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(351, 238);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(secondLbl);
            Controls.Add(label4);
            Controls.Add(minuteLbl);
            Controls.Add(label2);
            Controls.Add(hourLbl);
            Controls.Add(secondNud);
            Controls.Add(minuteNud);
            Controls.Add(hourNud);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Countdown Timer";
            ((System.ComponentModel.ISupportInitialize)hourNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)minuteNud).EndInit();
            ((System.ComponentModel.ISupportInitialize)secondNud).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private NumericUpDown hourNud;
        private NumericUpDown minuteNud;
        private NumericUpDown secondNud;
        private Label hourLbl;
        private Label label2;
        private Label minuteLbl;
        private Label label4;
        private Label secondLbl;
        private Button button1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label3;
        private Label label5;
    }
}