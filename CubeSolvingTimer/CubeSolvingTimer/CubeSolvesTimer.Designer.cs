namespace CubeSolvingTimer
{
    partial class CubeSolvesTimer
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
            this.labelTimer = new System.Windows.Forms.Label();
            this.labelNoSolves = new System.Windows.Forms.Label();
            this.labelSessionSolves = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.labelDoYourBest = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTimer
            // 
            this.labelTimer.AutoSize = true;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(192, 122);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(149, 39);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNoSolves
            // 
            this.labelNoSolves.AutoSize = true;
            this.labelNoSolves.Location = new System.Drawing.Point(113, 339);
            this.labelNoSolves.Name = "labelNoSolves";
            this.labelNoSolves.Size = new System.Drawing.Size(98, 17);
            this.labelNoSolves.TabIndex = 1;
            this.labelNoSolves.Tag = "No. of solves: ";
            this.labelNoSolves.Text = "No. of solves: ";
            // 
            // labelSessionSolves
            // 
            this.labelSessionSolves.AutoSize = true;
            this.labelSessionSolves.Location = new System.Drawing.Point(9, 399);
            this.labelSessionSolves.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelSessionSolves.MinimumSize = new System.Drawing.Size(195, 0);
            this.labelSessionSolves.Name = "labelSessionSolves";
            this.labelSessionSolves.Size = new System.Drawing.Size(195, 17);
            this.labelSessionSolves.TabIndex = 2;
            this.labelSessionSolves.Tag = "This session\'s last 12 solves: ";
            this.labelSessionSolves.Text = "This session\'s last 12 solves: ";
            this.labelSessionSolves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(12, 214);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(153, 87);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            this.btnStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnStart_KeyPress);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(369, 214);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(153, 87);
            this.btnStop.TabIndex = 4;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            this.btnStop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnStop_KeyPress);
            // 
            // labelDoYourBest
            // 
            this.labelDoYourBest.AutoSize = true;
            this.labelDoYourBest.Location = new System.Drawing.Point(217, 57);
            this.labelDoYourBest.Name = "labelDoYourBest";
            this.labelDoYourBest.Size = new System.Drawing.Size(0, 17);
            this.labelDoYourBest.TabIndex = 5;
            this.labelDoYourBest.Tag = "Good! but can you do better?";
            // 
            // CubeSolvesTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 490);
            this.Controls.Add(this.labelDoYourBest);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.labelSessionSolves);
            this.Controls.Add(this.labelNoSolves);
            this.Controls.Add(this.labelTimer);
            this.Name = "CubeSolvesTimer";
            this.Text = "CubeSolvesTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelNoSolves;
        private System.Windows.Forms.Label labelSessionSolves;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label labelDoYourBest;
    }
}

