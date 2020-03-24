namespace Invoice_App
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
            this.register = new System.Windows.Forms.Label();
            this.regname = new System.Windows.Forms.Label();
            this.regid = new System.Windows.Forms.Label();
            this.regmol = new System.Windows.Forms.Label();
            this.regaddress = new System.Windows.Forms.Label();
            this.regphone = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.savereg = new System.Windows.Forms.Button();
            this.regcancelation = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // register
            // 
            this.register.AutoSize = true;
            this.register.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.register.Location = new System.Drawing.Point(265, 9);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(221, 24);
            this.register.TabIndex = 0;
            this.register.Text = "Форма за регистрация:";
            // 
            // regname
            // 
            this.regname.AutoSize = true;
            this.regname.Location = new System.Drawing.Point(24, 67);
            this.regname.Name = "regname";
            this.regname.Size = new System.Drawing.Size(181, 13);
            this.regname.TabIndex = 1;
            this.regname.Text = "Име на фирма/ Юридическо лице:";
            // 
            // regid
            // 
            this.regid.AutoSize = true;
            this.regid.Location = new System.Drawing.Point(24, 119);
            this.regid.Name = "regid";
            this.regid.Size = new System.Drawing.Size(58, 13);
            this.regid.TabIndex = 2;
            this.regid.Text = "ЕИК/ЕГН:";
            // 
            // regmol
            // 
            this.regmol.AutoSize = true;
            this.regmol.Location = new System.Drawing.Point(24, 176);
            this.regmol.Name = "regmol";
            this.regmol.Size = new System.Drawing.Size(35, 13);
            this.regmol.TabIndex = 3;
            this.regmol.Text = "МОЛ:";
            // 
            // regaddress
            // 
            this.regaddress.AutoSize = true;
            this.regaddress.Location = new System.Drawing.Point(24, 224);
            this.regaddress.Name = "regaddress";
            this.regaddress.Size = new System.Drawing.Size(47, 13);
            this.regaddress.TabIndex = 4;
            this.regaddress.Text = "АДРЕС:";
            this.regaddress.Click += new System.EventHandler(this.label1_Click);
            // 
            // regphone
            // 
            this.regphone.AutoSize = true;
            this.regphone.Location = new System.Drawing.Point(24, 300);
            this.regphone.Name = "regphone";
            this.regphone.Size = new System.Drawing.Size(110, 13);
            this.regphone.TabIndex = 5;
            this.regphone.Text = "Телефон за връзка:";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(90, 112);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(202, 20);
            this.maskedTextBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(225, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 20);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 169);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(457, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 217);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(457, 20);
            this.textBox3.TabIndex = 9;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(160, 293);
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(254, 20);
            this.maskedTextBox2.TabIndex = 10;
            // 
            // savereg
            // 
            this.savereg.Location = new System.Drawing.Point(215, 378);
            this.savereg.Name = "savereg";
            this.savereg.Size = new System.Drawing.Size(249, 41);
            this.savereg.TabIndex = 11;
            this.savereg.Text = "Запази";
            this.savereg.UseVisualStyleBackColor = true;
            // 
            // regcancelation
            // 
            this.regcancelation.Location = new System.Drawing.Point(513, 378);
            this.regcancelation.Name = "regcancelation";
            this.regcancelation.Size = new System.Drawing.Size(210, 41);
            this.regcancelation.TabIndex = 12;
            this.regcancelation.Text = "Отказ";
            this.regcancelation.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regcancelation);
            this.Controls.Add(this.savereg);
            this.Controls.Add(this.maskedTextBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.regphone);
            this.Controls.Add(this.regaddress);
            this.Controls.Add(this.regmol);
            this.Controls.Add(this.regid);
            this.Controls.Add(this.regname);
            this.Controls.Add(this.register);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label register;
        private System.Windows.Forms.Label regname;
        private System.Windows.Forms.Label regid;
        private System.Windows.Forms.Label regmol;
        private System.Windows.Forms.Label regaddress;
        private System.Windows.Forms.Label regphone;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Button savereg;
        private System.Windows.Forms.Button regcancelation;
    }
}