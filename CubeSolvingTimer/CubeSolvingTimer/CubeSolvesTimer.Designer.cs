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
            this.BtnStart = new System.Windows.Forms.Button();
            this.BtnStop = new System.Windows.Forms.Button();
            this.labelDoYourBest = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTimer
            // 
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimer.Location = new System.Drawing.Point(0, 65);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Size = new System.Drawing.Size(534, 93);
            this.labelTimer.TabIndex = 0;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // labelNoSolves
            // 
            this.labelNoSolves.AutoSize = true;
            this.labelNoSolves.Location = new System.Drawing.Point(142, 342);
            this.labelNoSolves.Name = "labelNoSolves";
            this.labelNoSolves.Size = new System.Drawing.Size(98, 17);
            this.labelNoSolves.TabIndex = 1;
            this.labelNoSolves.Tag = "No. of solves: ";
            this.labelNoSolves.Text = "No. of solves: ";
            // 
            // labelSessionSolves
            // 
            this.labelSessionSolves.AutoSize = true;
            this.labelSessionSolves.Location = new System.Drawing.Point(45, 396);
            this.labelSessionSolves.MaximumSize = new System.Drawing.Size(400, 0);
            this.labelSessionSolves.MinimumSize = new System.Drawing.Size(195, 0);
            this.labelSessionSolves.Name = "labelSessionSolves";
            this.labelSessionSolves.Size = new System.Drawing.Size(195, 17);
            this.labelSessionSolves.TabIndex = 2;
            this.labelSessionSolves.Tag = "This session\'s last 12 solves: ";
            this.labelSessionSolves.Text = "This session\'s last 12 solves: ";
            this.labelSessionSolves.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BtnStart
            // 
            this.BtnStart.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BtnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStart.ForeColor = System.Drawing.Color.White;
            this.BtnStart.Location = new System.Drawing.Point(12, 214);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(153, 87);
            this.BtnStart.TabIndex = 3;
            this.BtnStart.Text = "Start";
            this.BtnStart.UseVisualStyleBackColor = false;
            this.BtnStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnStart_KeyPress);
            // 
            // BtnStop
            // 
            this.BtnStop.BackColor = System.Drawing.Color.Crimson;
            this.BtnStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnStop.ForeColor = System.Drawing.Color.White;
            this.BtnStop.Location = new System.Drawing.Point(369, 214);
            this.BtnStop.Name = "BtnStop";
            this.BtnStop.Size = new System.Drawing.Size(153, 87);
            this.BtnStop.TabIndex = 4;
            this.BtnStop.Text = "Stop";
            this.BtnStop.UseVisualStyleBackColor = false;
            this.BtnStop.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnStop_KeyPress);
            // 
            // labelDoYourBest
            // 
            this.labelDoYourBest.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelDoYourBest.Location = new System.Drawing.Point(0, 0);
            this.labelDoYourBest.Margin = new System.Windows.Forms.Padding(0);
            this.labelDoYourBest.Name = "labelDoYourBest";
            this.labelDoYourBest.Size = new System.Drawing.Size(534, 65);
            this.labelDoYourBest.TabIndex = 5;
            this.labelDoYourBest.Tag = "Good! but can you do better?";
            this.labelDoYourBest.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 464);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Use any keyboard key to start and stop    |    Fastest time record: 3.47 seconds";
            // 
            // CubeSolvesTimer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.ClientSize = new System.Drawing.Size(534, 490);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnStop);
            this.Controls.Add(this.BtnStart);
            this.Controls.Add(this.labelSessionSolves);
            this.Controls.Add(this.labelNoSolves);
            this.Controls.Add(this.labelTimer);
            this.Controls.Add(this.labelDoYourBest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CubeSolvesTimer";
            this.Text = "CubeSolvesTimer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTimer;
        private System.Windows.Forms.Label labelNoSolves;
        private System.Windows.Forms.Label labelSessionSolves;
        private System.Windows.Forms.Button BtnStart;
        private System.Windows.Forms.Button BtnStop;
        private System.Windows.Forms.Label labelDoYourBest;
        private System.Windows.Forms.Label label1;
    }
}

