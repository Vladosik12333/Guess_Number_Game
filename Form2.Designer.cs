namespace _64632_Vladyslav_Babiak_Task_5
{
    partial class Form2
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
            this.numberInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.timerRestOutput = new System.Windows.Forms.Label();
            this.generatedNumberOutput = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // numberInput
            // 
            this.numberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberInput.Location = new System.Drawing.Point(129, 235);
            this.numberInput.Name = "numberInput";
            this.numberInput.Size = new System.Drawing.Size(255, 39);
            this.numberInput.TabIndex = 4;
            this.numberInput.TextChanged += new System.EventHandler(this.numberInput_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(161, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Enter Guess Number";
            // 
            // timerRestOutput
            // 
            this.timerRestOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.timerRestOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerRestOutput.Location = new System.Drawing.Point(12, 43);
            this.timerRestOutput.Name = "timerRestOutput";
            this.timerRestOutput.Size = new System.Drawing.Size(502, 69);
            this.timerRestOutput.TabIndex = 6;
            this.timerRestOutput.Text = "0";
            this.timerRestOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.timerRestOutput.Click += new System.EventHandler(this.timerRestOutput_Click);
            // 
            // generatedNumberOutput
            // 
            this.generatedNumberOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.generatedNumberOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedNumberOutput.Location = new System.Drawing.Point(12, 362);
            this.generatedNumberOutput.Name = "generatedNumberOutput";
            this.generatedNumberOutput.Size = new System.Drawing.Size(502, 69);
            this.generatedNumberOutput.TabIndex = 7;
            this.generatedNumberOutput.Text = "Let\'s guess...";
            this.generatedNumberOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.generatedNumberOutput.Click += new System.EventHandler(this.generatedNumberOutput_Click);
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(12, 504);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(502, 66);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 601);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.generatedNumberOutput);
            this.Controls.Add(this.timerRestOutput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numberInput);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox numberInput;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label timerRestOutput;
        private System.Windows.Forms.Label generatedNumberOutput;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Timer timer1;
    }
}