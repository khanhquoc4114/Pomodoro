namespace Homemade_Pomodoros
{
    partial class Pomodoros
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
            this.lbTime = new System.Windows.Forms.Label();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.btnStart = new System.Windows.Forms.Button();
            this.cbTimer = new System.Windows.Forms.ComboBox();
            this.cbRest = new System.Windows.Forms.ComboBox();
            this.cbLongRest = new System.Windows.Forms.ComboBox();
            this.lbTimer = new System.Windows.Forms.Label();
            this.lbRest = new System.Windows.Forms.Label();
            this.lbLongRest = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 80.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(152, 159);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(337, 142);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "00:00";
            // 
            // timerMain
            // 
            this.timerMain.Interval = 1000;
            // 
            // btnStart
            // 
            this.btnStart.AutoSize = true;
            this.btnStart.Location = new System.Drawing.Point(153, 331);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(111, 57);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // cbTimer
            // 
            this.cbTimer.FormattingEnabled = true;
            this.cbTimer.Items.AddRange(new object[] {
            "1",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.cbTimer.Location = new System.Drawing.Point(151, 100);
            this.cbTimer.Name = "cbTimer";
            this.cbTimer.Size = new System.Drawing.Size(98, 25);
            this.cbTimer.TabIndex = 4;
            this.cbTimer.Text = "1";
            this.cbTimer.SelectedIndexChanged += new System.EventHandler(this.cbTimer_SelectedIndexChanged);
            // 
            // cbRest
            // 
            this.cbRest.FormattingEnabled = true;
            this.cbRest.Items.AddRange(new object[] {
            "5",
            "10",
            "15"});
            this.cbRest.Location = new System.Drawing.Point(271, 100);
            this.cbRest.Name = "cbRest";
            this.cbRest.Size = new System.Drawing.Size(98, 25);
            this.cbRest.TabIndex = 4;
            this.cbRest.Text = "5";
            // 
            // cbLongRest
            // 
            this.cbLongRest.FormattingEnabled = true;
            this.cbLongRest.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30",
            "35",
            "40",
            "45",
            "50",
            "55",
            "60"});
            this.cbLongRest.Location = new System.Drawing.Point(391, 100);
            this.cbLongRest.Name = "cbLongRest";
            this.cbLongRest.Size = new System.Drawing.Size(98, 25);
            this.cbLongRest.TabIndex = 4;
            this.cbLongRest.Text = "30";
            // 
            // lbTimer
            // 
            this.lbTimer.AutoSize = true;
            this.lbTimer.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimer.ForeColor = System.Drawing.Color.White;
            this.lbTimer.Location = new System.Drawing.Point(148, 58);
            this.lbTimer.Name = "lbTimer";
            this.lbTimer.Size = new System.Drawing.Size(22, 26);
            this.lbTimer.TabIndex = 5;
            this.lbTimer.Text = "0";
            // 
            // lbRest
            // 
            this.lbRest.AutoSize = true;
            this.lbRest.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRest.ForeColor = System.Drawing.Color.White;
            this.lbRest.Location = new System.Drawing.Point(268, 58);
            this.lbRest.Name = "lbRest";
            this.lbRest.Size = new System.Drawing.Size(22, 26);
            this.lbRest.TabIndex = 5;
            this.lbRest.Text = "0";
            // 
            // lbLongRest
            // 
            this.lbLongRest.AutoSize = true;
            this.lbLongRest.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLongRest.ForeColor = System.Drawing.Color.White;
            this.lbLongRest.Location = new System.Drawing.Point(388, 58);
            this.lbLongRest.Name = "lbLongRest";
            this.lbLongRest.Size = new System.Drawing.Size(22, 26);
            this.lbLongRest.TabIndex = 5;
            this.lbLongRest.Text = "0";
            // 
            // btnStop
            // 
            this.btnStop.AutoSize = true;
            this.btnStop.Enabled = false;
            this.btnStop.Location = new System.Drawing.Point(371, 331);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(111, 57);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(148, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Timer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(268, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 26);
            this.label2.TabIndex = 5;
            this.label2.Text = "Rest";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Emoji", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(388, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 26);
            this.label3.TabIndex = 5;
            this.label3.Text = "Long Rest";
            // 
            // Pomodoros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(156)))), ((int)(((byte)(203)))));
            this.ClientSize = new System.Drawing.Size(654, 486);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbLongRest);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbRest);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbTimer);
            this.Controls.Add(this.cbLongRest);
            this.Controls.Add(this.cbRest);
            this.Controls.Add(this.cbTimer);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lbTime);
            this.Font = new System.Drawing.Font("Segoe UI Emoji", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pomodoros";
            this.Text = "Super Pomodoros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ComboBox cbTimer;
        private System.Windows.Forms.ComboBox cbRest;
        private System.Windows.Forms.ComboBox cbLongRest;
        private System.Windows.Forms.Label lbTimer;
        private System.Windows.Forms.Label lbRest;
        private System.Windows.Forms.Label lbLongRest;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

