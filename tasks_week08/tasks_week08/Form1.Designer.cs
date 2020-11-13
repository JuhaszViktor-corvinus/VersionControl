namespace tasks_week08
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.BALL = new System.Windows.Forms.Button();
            this.PRESENT = new System.Windows.Forms.Button();
            this.CAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Blue = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.Button();
            this.Yellow = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.Yellow);
            this.mainPanel.Controls.Add(this.Red);
            this.mainPanel.Controls.Add(this.Blue);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.CAR);
            this.mainPanel.Controls.Add(this.PRESENT);
            this.mainPanel.Controls.Add(this.BALL);
            this.mainPanel.Location = new System.Drawing.Point(1, 2);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(804, 449);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // BALL
            // 
            this.BALL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BALL.Location = new System.Drawing.Point(130, 26);
            this.BALL.Name = "BALL";
            this.BALL.Size = new System.Drawing.Size(104, 85);
            this.BALL.TabIndex = 0;
            this.BALL.Text = "BALL";
            this.BALL.UseVisualStyleBackColor = true;
            this.BALL.Click += new System.EventHandler(this.BALL_Click);
            // 
            // PRESENT
            // 
            this.PRESENT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PRESENT.Location = new System.Drawing.Point(240, 26);
            this.PRESENT.Name = "PRESENT";
            this.PRESENT.Size = new System.Drawing.Size(104, 85);
            this.PRESENT.TabIndex = 1;
            this.PRESENT.Text = "PRESENT";
            this.PRESENT.UseVisualStyleBackColor = true;
            this.PRESENT.Click += new System.EventHandler(this.PRESENT_Click);
            // 
            // CAR
            // 
            this.CAR.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CAR.Location = new System.Drawing.Point(20, 26);
            this.CAR.Name = "CAR";
            this.CAR.Size = new System.Drawing.Size(104, 85);
            this.CAR.TabIndex = 2;
            this.CAR.Text = "CAR";
            this.CAR.UseVisualStyleBackColor = true;
            this.CAR.Click += new System.EventHandler(this.CAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(355, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coming Next:";
            // 
            // Blue
            // 
            this.Blue.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Blue.Location = new System.Drawing.Point(143, 135);
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(90, 24);
            this.Blue.TabIndex = 4;
            this.Blue.UseVisualStyleBackColor = false;
            // 
            // Red
            // 
            this.Red.BackColor = System.Drawing.Color.Red;
            this.Red.Location = new System.Drawing.Point(254, 135);
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(90, 24);
            this.Red.TabIndex = 5;
            this.Red.UseVisualStyleBackColor = false;
            // 
            // Yellow
            // 
            this.Yellow.BackColor = System.Drawing.Color.Yellow;
            this.Yellow.Location = new System.Drawing.Point(254, 174);
            this.Yellow.Name = "Yellow";
            this.Yellow.Size = new System.Drawing.Size(90, 24);
            this.Yellow.TabIndex = 6;
            this.Yellow.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button CAR;
        private System.Windows.Forms.Button PRESENT;
        private System.Windows.Forms.Button BALL;
        private System.Windows.Forms.Button Yellow;
        private System.Windows.Forms.Button Red;
        private System.Windows.Forms.Button Blue;
    }
}

