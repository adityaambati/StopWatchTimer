namespace SuperTimer
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.PauseButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SecondInput = new System.Windows.Forms.TextBox();
            this.StartButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.labelhours = new System.Windows.Forms.Label();
            this.labelminutes = new System.Windows.Forms.Label();
            this.labelseconds = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(112, 43);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(355, 67);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Super Timer";
            this.labelTitle.Click += new System.EventHandler(this.labelTitle_Click);
            // 
            // PauseButton
            // 
            this.PauseButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PauseButton.Location = new System.Drawing.Point(484, 184);
            this.PauseButton.Name = "PauseButton";
            this.PauseButton.Size = new System.Drawing.Size(114, 43);
            this.PauseButton.TabIndex = 2;
            this.PauseButton.Text = "Pause";
            this.PauseButton.UseVisualStyleBackColor = true;
            this.PauseButton.Click += new System.EventHandler(this.PauseButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Time (Seconds)";
            // 
            // SecondInput
            // 
            this.SecondInput.Location = new System.Drawing.Point(186, 317);
            this.SecondInput.Name = "SecondInput";
            this.SecondInput.Size = new System.Drawing.Size(188, 24);
            this.SecondInput.TabIndex = 4;
            // 
            // StartButton
            // 
            this.StartButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartButton.Location = new System.Drawing.Point(395, 311);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(126, 36);
            this.StartButton.TabIndex = 5;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelhours
            // 
            this.labelhours.AutoSize = true;
            this.labelhours.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelhours.Location = new System.Drawing.Point(54, 159);
            this.labelhours.Name = "labelhours";
            this.labelhours.Size = new System.Drawing.Size(126, 89);
            this.labelhours.TabIndex = 6;
            this.labelhours.Text = "00";
            // 
            // labelminutes
            // 
            this.labelminutes.AutoSize = true;
            this.labelminutes.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelminutes.Location = new System.Drawing.Point(201, 159);
            this.labelminutes.Name = "labelminutes";
            this.labelminutes.Size = new System.Drawing.Size(126, 89);
            this.labelminutes.TabIndex = 7;
            this.labelminutes.Text = "00";
            // 
            // labelseconds
            // 
            this.labelseconds.AutoSize = true;
            this.labelseconds.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelseconds.Location = new System.Drawing.Point(352, 159);
            this.labelseconds.Name = "labelseconds";
            this.labelseconds.Size = new System.Drawing.Size(126, 89);
            this.labelseconds.TabIndex = 8;
            this.labelseconds.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(158, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 89);
            this.label5.TabIndex = 9;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(314, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 89);
            this.label6.TabIndex = 10;
            this.label6.Text = ":";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 406);
            this.Controls.Add(this.labelseconds);
            this.Controls.Add(this.labelminutes);
            this.Controls.Add(this.labelhours);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.SecondInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PauseButton);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button PauseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SecondInput;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelhours;
        private System.Windows.Forms.Label labelminutes;
        private System.Windows.Forms.Label labelseconds;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

