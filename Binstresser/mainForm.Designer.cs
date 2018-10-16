namespace OFFINERY
{
    partial class mainForm
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
            if (disposing & (components != null))
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.serveripBox = new System.Windows.Forms.TextBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.targetipBox = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.powerBox = new System.Windows.Forms.TrackBar();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.durationBox = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.progress = new System.Windows.Forms.ProgressBar();
            this.curtarget = new System.Windows.Forms.Label();
            this.curlatency = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerBox)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.serveripBox);
            this.groupBox2.Controls.Add(this.usernameBox);
            this.groupBox2.Controls.Add(this.passwordBox);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(319, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 126);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Info";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(67, 71);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(130, 20);
            this.passwordBox.TabIndex = 5;
            // 
            // serveripBox
            // 
            this.serveripBox.Location = new System.Drawing.Point(67, 19);
            this.serveripBox.Name = "serveripBox";
            this.serveripBox.Size = new System.Drawing.Size(131, 20);
            this.serveripBox.TabIndex = 1;
            this.serveripBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(12, 257);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(511, 60);
            this.attackButton.TabIndex = 2;
            this.attackButton.Text = "OFFINE";
            this.attackButton.UseVisualStyleBackColor = true;
            this.attackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(67, 45);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(130, 20);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.Text = "root";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "Address";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Password";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(7, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Username";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.curlatency);
            this.groupBox3.Controls.Add(this.curtarget);
            this.groupBox3.Controls.Add(this.progress);
            this.groupBox3.Location = new System.Drawing.Point(319, 145);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 104);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Stats";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.targetipBox);
            this.groupBox4.Location = new System.Drawing.Point(7, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(287, 54);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Target IP Address";
            // 
            // targetipBox
            // 
            this.targetipBox.Location = new System.Drawing.Point(7, 20);
            this.targetipBox.Name = "targetipBox";
            this.targetipBox.Size = new System.Drawing.Size(274, 20);
            this.targetipBox.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.powerBox);
            this.groupBox5.Location = new System.Drawing.Point(7, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 79);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Threads";
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // powerBox
            // 
            this.powerBox.LargeChange = 1;
            this.powerBox.Location = new System.Drawing.Point(7, 20);
            this.powerBox.Maximum = 40;
            this.powerBox.Minimum = 1;
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(268, 45);
            this.powerBox.TabIndex = 0;
            this.powerBox.Value = 1;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.durationBox);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(6, 166);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(288, 59);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Duration";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seconds";
            // 
            // durationBox
            // 
            this.durationBox.Location = new System.Drawing.Point(59, 23);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(217, 20);
            this.durationBox.TabIndex = 1;
            this.durationBox.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.durationBox.ValueChanged += new System.EventHandler(this.durationBox_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Target";
            // 
            // progress
            // 
            this.progress.Location = new System.Drawing.Point(7, 75);
            this.progress.Name = "progress";
            this.progress.Size = new System.Drawing.Size(187, 23);
            this.progress.TabIndex = 0;
            // 
            // curtarget
            // 
            this.curtarget.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curtarget.ForeColor = System.Drawing.SystemColors.ControlText;
            this.curtarget.Location = new System.Drawing.Point(10, 16);
            this.curtarget.Name = "curtarget";
            this.curtarget.Size = new System.Drawing.Size(184, 26);
            this.curtarget.TabIndex = 1;
            this.curtarget.Text = "Current Target: None";
            this.curtarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // curlatency
            // 
            this.curlatency.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curlatency.Location = new System.Drawing.Point(10, 42);
            this.curlatency.Name = "curlatency";
            this.curlatency.Size = new System.Drawing.Size(184, 26);
            this.curlatency.TabIndex = 2;
            this.curlatency.Text = "Target Latency: None";
            this.curlatency.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 329);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "OFFINERY - By: Coopyy";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerBox)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.durationBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox serveripBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label curlatency;
        private System.Windows.Forms.Label curtarget;
        private System.Windows.Forms.ProgressBar progress;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox targetipBox;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar powerBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown durationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

