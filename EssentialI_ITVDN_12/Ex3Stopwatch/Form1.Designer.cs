namespace Ex3Stopwatch
{
    partial class Form1
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
            this.Start_Button = new System.Windows.Forms.Button();
            this.Pause_Button = new System.Windows.Forms.Button();
            this.Reset_Button = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TimerTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Start_Button
            // 
            this.Start_Button.Location = new System.Drawing.Point(12, 151);
            this.Start_Button.Name = "Start_Button";
            this.Start_Button.Size = new System.Drawing.Size(260, 75);
            this.Start_Button.TabIndex = 0;
            this.Start_Button.Text = "Start";
            this.Start_Button.UseVisualStyleBackColor = true;
            this.Start_Button.Click += new System.EventHandler(this.Start_Button_Click);
            // 
            // Pause_Button
            // 
            this.Pause_Button.Location = new System.Drawing.Point(278, 151);
            this.Pause_Button.Name = "Pause_Button";
            this.Pause_Button.Size = new System.Drawing.Size(198, 75);
            this.Pause_Button.TabIndex = 1;
            this.Pause_Button.Text = "Pause";
            this.Pause_Button.UseVisualStyleBackColor = true;
            this.Pause_Button.Click += new System.EventHandler(this.Pause_Button_Click);
            // 
            // Reset_Button
            // 
            this.Reset_Button.Location = new System.Drawing.Point(521, 12);
            this.Reset_Button.Name = "Reset_Button";
            this.Reset_Button.Size = new System.Drawing.Size(75, 214);
            this.Reset_Button.TabIndex = 2;
            this.Reset_Button.Text = "Reset";
            this.Reset_Button.UseVisualStyleBackColor = true;
            this.Reset_Button.Click += new System.EventHandler(this.Reset_Button_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TimerTextBox
            // 
            this.TimerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 82F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimerTextBox.Location = new System.Drawing.Point(12, 12);
            this.TimerTextBox.Multiline = true;
            this.TimerTextBox.Name = "TimerTextBox";
            this.TimerTextBox.Size = new System.Drawing.Size(464, 133);
            this.TimerTextBox.TabIndex = 3;
            this.TimerTextBox.TextChanged += new System.EventHandler(this.TimerTextBox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 238);
            this.Controls.Add(this.TimerTextBox);
            this.Controls.Add(this.Reset_Button);
            this.Controls.Add(this.Pause_Button);
            this.Controls.Add(this.Start_Button);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Start_Button;
        private System.Windows.Forms.Button Pause_Button;
        private System.Windows.Forms.Button Reset_Button;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox TimerTextBox;
    }
}

