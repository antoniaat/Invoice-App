namespace Invoice_App
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.label1 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.job = new System.Windows.Forms.TextBox();
            this.registerBtn = new System.Windows.Forms.Button();
            this.alreadyRegistered = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.phone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.MaskedTextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(43, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Име:";
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(284, 91);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(445, 37);
            this.lastName.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(43, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имейл";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(43, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Парола:";
            // 
            // job
            // 
            this.job.Location = new System.Drawing.Point(284, 167);
            this.job.Name = "job";
            this.job.Size = new System.Drawing.Size(445, 37);
            this.job.TabIndex = 5;
            // 
            // registerBtn
            // 
            this.registerBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.registerBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.registerBtn.ForeColor = System.Drawing.Color.White;
            this.registerBtn.Location = new System.Drawing.Point(48, 303);
            this.registerBtn.Margin = new System.Windows.Forms.Padding(5);
            this.registerBtn.Name = "registerBtn";
            this.registerBtn.Size = new System.Drawing.Size(294, 82);
            this.registerBtn.TabIndex = 6;
            this.registerBtn.Text = "РЕГИСТРАЦИЯ";
            this.registerBtn.UseVisualStyleBackColor = false;
            this.registerBtn.Click += new System.EventHandler(this.RegisterBtn_Click);
            // 
            // alreadyRegistered
            // 
            this.alreadyRegistered.AutoSize = true;
            this.alreadyRegistered.BackColor = System.Drawing.SystemColors.Window;
            this.alreadyRegistered.LinkColor = System.Drawing.Color.Black;
            this.alreadyRegistered.Location = new System.Drawing.Point(43, 403);
            this.alreadyRegistered.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.alreadyRegistered.Name = "alreadyRegistered";
            this.alreadyRegistered.Size = new System.Drawing.Size(241, 30);
            this.alreadyRegistered.TabIndex = 7;
            this.alreadyRegistered.TabStop = true;
            this.alreadyRegistered.Text = "ИМАТЕ АКАУНТ?";
            this.alreadyRegistered.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.AlreadyRegistered_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(43, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 30);
            this.label4.TabIndex = 8;
            this.label4.Text = "Длъжност:";
            // 
            // phone
            // 
            this.phone.Location = new System.Drawing.Point(284, 205);
            this.phone.Name = "phone";
            this.phone.Size = new System.Drawing.Size(445, 37);
            this.phone.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(43, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(271, 30);
            this.label5.TabIndex = 10;
            this.label5.Text = "Телефон за връзка:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(284, 53);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(445, 37);
            this.firstName.TabIndex = 11;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(284, 129);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(445, 37);
            this.password.TabIndex = 12;
            this.password.UseSystemPasswordChar = true;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1145, 568);
            this.Controls.Add(this.password);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.alreadyRegistered);
            this.Controls.Add(this.registerBtn);
            this.Controls.Add(this.job);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "RegisterForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox job;
        private System.Windows.Forms.Button registerBtn;
        private System.Windows.Forms.LinkLabel alreadyRegistered;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox firstName;
        private System.Windows.Forms.TextBox password;
    }
}