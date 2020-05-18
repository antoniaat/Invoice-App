namespace Invoice_App
{
    partial class NewPartner
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.egnbul = new System.Windows.Forms.Label();
            this.partnertype = new System.Windows.Forms.Label();
            this.namelbl = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.Label();
            this.telephone = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Физическо лице",
            "Юридическо лице"});
            this.comboBox1.Location = new System.Drawing.Point(157, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // egnbul
            // 
            this.egnbul.AutoSize = true;
            this.egnbul.BackColor = System.Drawing.Color.Transparent;
            this.egnbul.Location = new System.Drawing.Point(33, 46);
            this.egnbul.Name = "egnbul";
            this.egnbul.Size = new System.Drawing.Size(107, 17);
            this.egnbul.TabIndex = 1;
            this.egnbul.Text = "ЕГН/БУЛСТАТ:";
            // 
            // partnertype
            // 
            this.partnertype.AutoSize = true;
            this.partnertype.BackColor = System.Drawing.Color.Transparent;
            this.partnertype.Location = new System.Drawing.Point(32, 107);
            this.partnertype.Name = "partnertype";
            this.partnertype.Size = new System.Drawing.Size(87, 17);
            this.partnertype.TabIndex = 2;
            this.partnertype.Text = "Тип клиент:";
            // 
            // namelbl
            // 
            this.namelbl.AutoSize = true;
            this.namelbl.BackColor = System.Drawing.Color.Transparent;
            this.namelbl.Location = new System.Drawing.Point(33, 163);
            this.namelbl.Name = "namelbl";
            this.namelbl.Size = new System.Drawing.Size(86, 17);
            this.namelbl.TabIndex = 3;
            this.namelbl.Text = "Пълно Име:";
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.BackColor = System.Drawing.Color.Transparent;
            this.email.Location = new System.Drawing.Point(33, 214);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(51, 17);
            this.email.TabIndex = 6;
            this.email.Text = "E-mail:";
            // 
            // telephone
            // 
            this.telephone.AutoSize = true;
            this.telephone.BackColor = System.Drawing.Color.Transparent;
            this.telephone.Location = new System.Drawing.Point(33, 267);
            this.telephone.Name = "telephone";
            this.telephone.Size = new System.Drawing.Size(82, 17);
            this.telephone.TabIndex = 7;
            this.telephone.Text = "Тел.номер:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Location = new System.Drawing.Point(33, 316);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(52, 17);
            this.address.TabIndex = 8;
            this.address.Text = "Адрес:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 43);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Физическо лице",
            "Юридическо лице"});
            this.comboBox2.Location = new System.Drawing.Point(157, 104);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(157, 163);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(283, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(157, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(283, 22);
            this.textBox3.TabIndex = 12;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(157, 264);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBox1.TabIndex = 13;
            this.maskedTextBox1.ValidatingType = typeof(int);
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(157, 313);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(283, 22);
            this.textBox4.TabIndex = 14;
            // 
            // NewPartner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Invoice_App.Properties.Resources._92165337_530614627645564_8151430491346567168_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(817, 466);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.address);
            this.Controls.Add(this.telephone);
            this.Controls.Add(this.email);
            this.Controls.Add(this.namelbl);
            this.Controls.Add(this.partnertype);
            this.Controls.Add(this.egnbul);
            this.Controls.Add(this.comboBox1);
            this.DoubleBuffered = true;
            this.Name = "NewPartner";
            this.Text = "Нов Партньор";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label egnbul;
        private System.Windows.Forms.Label partnertype;
        private System.Windows.Forms.Label namelbl;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label telephone;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox textBox4;
    }
}