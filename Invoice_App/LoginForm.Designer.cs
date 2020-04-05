namespace Invoice_App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.LoginPasswordTexbox = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dontHaveAnAccount = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 103);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 30);
            this.textBox1.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // LoginPasswordTexbox
            // 
            this.LoginPasswordTexbox.Location = new System.Drawing.Point(51, 185);
            this.LoginPasswordTexbox.Margin = new System.Windows.Forms.Padding(5);
            this.LoginPasswordTexbox.Name = "LoginPasswordTexbox";
            this.LoginPasswordTexbox.Size = new System.Drawing.Size(308, 30);
            this.LoginPasswordTexbox.TabIndex = 2;
            this.LoginPasswordTexbox.UseSystemPasswordChar = true;
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.LightSeaGreen;
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.loginBtn.ForeColor = System.Drawing.Color.White;
            this.loginBtn.Location = new System.Drawing.Point(51, 269);
            this.loginBtn.Margin = new System.Windows.Forms.Padding(5);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(174, 89);
            this.loginBtn.TabIndex = 3;
            this.loginBtn.Text = "ВХОД";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(46, 151);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Парола";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(46, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Потребителско име";
            // 
            // dontHaveAnAccount
            // 
            this.dontHaveAnAccount.AutoSize = true;
            this.dontHaveAnAccount.BackColor = System.Drawing.SystemColors.Window;
            this.dontHaveAnAccount.LinkColor = System.Drawing.Color.Black;
            this.dontHaveAnAccount.Location = new System.Drawing.Point(46, 373);
            this.dontHaveAnAccount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.dontHaveAnAccount.Name = "dontHaveAnAccount";
            this.dontHaveAnAccount.Size = new System.Drawing.Size(197, 25);
            this.dontHaveAnAccount.TabIndex = 6;
            this.dontHaveAnAccount.TabStop = true;
            this.dontHaveAnAccount.Text = "НЯМАТЕ АКАУНТ?";
            this.dontHaveAnAccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DontHaveAnAccount_LinkClicked);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1122, 582);
            this.Controls.Add(this.dontHaveAnAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.LoginPasswordTexbox);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.Text = "Вход";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox LoginPasswordTexbox;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel dontHaveAnAccount;
    }
}