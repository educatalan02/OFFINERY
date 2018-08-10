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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.durationBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.powerBox = new System.Windows.Forms.TrackBar();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.targetipBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.serveripBox = new System.Windows.Forms.TextBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.durationBox)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerBox)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
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
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Seconds";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.powerBox);
            this.groupBox5.Location = new System.Drawing.Point(7, 81);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 79);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Power";
            // 
            // powerBox
            // 
            this.powerBox.LargeChange = 1;
            this.powerBox.Location = new System.Drawing.Point(7, 20);
            this.powerBox.Maximum = 5;
            this.powerBox.Minimum = 1;
            this.powerBox.Name = "powerBox";
            this.powerBox.Size = new System.Drawing.Size(268, 45);
            this.powerBox.TabIndex = 0;
            this.powerBox.Value = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.groupBox8);
            this.groupBox2.Controls.Add(this.groupBox7);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(319, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 237);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server Info";
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(6, 19);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(179, 20);
            this.passwordBox.TabIndex = 5;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(6, 20);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(179, 20);
            this.usernameBox.TabIndex = 3;
            this.usernameBox.Text = "root";
            // 
            // serveripBox
            // 
            this.serveripBox.Location = new System.Drawing.Point(6, 20);
            this.serveripBox.Name = "serveripBox";
            this.serveripBox.Size = new System.Drawing.Size(179, 20);
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.serveripBox);
            this.groupBox3.Location = new System.Drawing.Point(7, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 54);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Server IP Address";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.usernameBox);
            this.groupBox7.Location = new System.Drawing.Point(7, 81);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(191, 65);
            this.groupBox7.TabIndex = 7;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Server Username";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.passwordBox);
            this.groupBox8.Location = new System.Drawing.Point(7, 153);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(191, 55);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Server Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 329);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.Text = "OFFINERY - By: Coopyy";
            this.groupBox1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.durationBox)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerBox)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox serveripBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown durationBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TrackBar powerBox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox targetipBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

