namespace Invoice_App
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
            this.invoice = new System.Windows.Forms.Label();
            this.poluchatel = new System.Windows.Forms.GroupBox();
            this.dostavchik = new System.Windows.Forms.GroupBox();
            this.name2 = new System.Windows.Forms.Label();
            this.id2 = new System.Windows.Forms.Label();
            this.address2 = new System.Windows.Forms.Label();
            this.mol2 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.Label();
            this.id1 = new System.Windows.Forms.Label();
            this.address1 = new System.Windows.Forms.Label();
            this.mol1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.id = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.TextBox();
            this.mol = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.numberofinvoice = new System.Windows.Forms.Label();
            this.dateofinvoice = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.added1 = new System.Windows.Forms.Button();
            this.delete1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.poluchatel.SuspendLayout();
            this.dostavchik.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoice
            // 
            this.invoice.AutoSize = true;
            this.invoice.Location = new System.Drawing.Point(335, 60);
            this.invoice.Name = "invoice";
            this.invoice.Size = new System.Drawing.Size(61, 13);
            this.invoice.TabIndex = 0;
            this.invoice.Text = "ФАКТУРА";
            this.invoice.Click += new System.EventHandler(this.label1_Click);
            // 
            // poluchatel
            // 
            this.poluchatel.Controls.Add(this.mol);
            this.poluchatel.Controls.Add(this.address);
            this.poluchatel.Controls.Add(this.id);
            this.poluchatel.Controls.Add(this.name);
            this.poluchatel.Controls.Add(this.mol1);
            this.poluchatel.Controls.Add(this.address1);
            this.poluchatel.Controls.Add(this.id1);
            this.poluchatel.Controls.Add(this.name1);
            this.poluchatel.Location = new System.Drawing.Point(12, 60);
            this.poluchatel.Name = "poluchatel";
            this.poluchatel.Size = new System.Drawing.Size(275, 137);
            this.poluchatel.TabIndex = 1;
            this.poluchatel.TabStop = false;
            this.poluchatel.Text = "Получател:";
            // 
            // dostavchik
            // 
            this.dostavchik.Controls.Add(this.textBox4);
            this.dostavchik.Controls.Add(this.textBox3);
            this.dostavchik.Controls.Add(this.textBox2);
            this.dostavchik.Controls.Add(this.textBox1);
            this.dostavchik.Controls.Add(this.mol2);
            this.dostavchik.Controls.Add(this.address2);
            this.dostavchik.Controls.Add(this.id2);
            this.dostavchik.Controls.Add(this.name2);
            this.dostavchik.Location = new System.Drawing.Point(455, 59);
            this.dostavchik.Name = "dostavchik";
            this.dostavchik.Size = new System.Drawing.Size(246, 138);
            this.dostavchik.TabIndex = 2;
            this.dostavchik.TabStop = false;
            this.dostavchik.Text = "Доставчик:";
            this.dostavchik.Enter += new System.EventHandler(this.dostavchik_Enter);
            // 
            // name2
            // 
            this.name2.AutoSize = true;
            this.name2.Location = new System.Drawing.Point(16, 25);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(32, 13);
            this.name2.TabIndex = 0;
            this.name2.Text = "Име:";
            // 
            // id2
            // 
            this.id2.AutoSize = true;
            this.id2.Location = new System.Drawing.Point(18, 48);
            this.id2.Name = "id2";
            this.id2.Size = new System.Drawing.Size(30, 13);
            this.id2.TabIndex = 1;
            this.id2.Text = "ИД :";
            // 
            // address2
            // 
            this.address2.AutoSize = true;
            this.address2.Location = new System.Drawing.Point(18, 79);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(41, 13);
            this.address2.TabIndex = 2;
            this.address2.Text = "Адрес:";
            // 
            // mol2
            // 
            this.mol2.AutoSize = true;
            this.mol2.Location = new System.Drawing.Point(22, 111);
            this.mol2.Name = "mol2";
            this.mol2.Size = new System.Drawing.Size(35, 13);
            this.mol2.TabIndex = 3;
            this.mol2.Text = "МОЛ:";
            // 
            // name1
            // 
            this.name1.AutoSize = true;
            this.name1.Location = new System.Drawing.Point(19, 24);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(32, 13);
            this.name1.TabIndex = 0;
            this.name1.Text = "Име:";
            // 
            // id1
            // 
            this.id1.AutoSize = true;
            this.id1.Location = new System.Drawing.Point(18, 47);
            this.id1.Name = "id1";
            this.id1.Size = new System.Drawing.Size(27, 13);
            this.id1.TabIndex = 1;
            this.id1.Text = "ИД:";
            // 
            // address1
            // 
            this.address1.AutoSize = true;
            this.address1.Location = new System.Drawing.Point(18, 78);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(41, 13);
            this.address1.TabIndex = 2;
            this.address1.Text = "Адрес:";
            // 
            // mol1
            // 
            this.mol1.AutoSize = true;
            this.mol1.Location = new System.Drawing.Point(19, 110);
            this.mol1.Name = "mol1";
            this.mol1.Size = new System.Drawing.Size(35, 13);
            this.mol1.TabIndex = 3;
            this.mol1.Text = "МОЛ:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(70, 17);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(180, 20);
            this.name.TabIndex = 4;
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(70, 45);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(180, 20);
            this.id.TabIndex = 5;
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(70, 71);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(180, 20);
            this.address.TabIndex = 6;
            // 
            // mol
            // 
            this.mol.Location = new System.Drawing.Point(70, 103);
            this.mol.Name = "mol";
            this.mol.Size = new System.Drawing.Size(180, 20);
            this.mol.TabIndex = 7;
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(362, 94);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(71, 20);
            this.number.TabIndex = 3;
            // 
            // numberofinvoice
            // 
            this.numberofinvoice.AutoSize = true;
            this.numberofinvoice.Location = new System.Drawing.Point(304, 101);
            this.numberofinvoice.Name = "numberofinvoice";
            this.numberofinvoice.Size = new System.Drawing.Size(44, 13);
            this.numberofinvoice.TabIndex = 4;
            this.numberofinvoice.Text = "Номер:";
            this.numberofinvoice.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // dateofinvoice
            // 
            this.dateofinvoice.AutoSize = true;
            this.dateofinvoice.Location = new System.Drawing.Point(304, 131);
            this.dateofinvoice.Name = "dateofinvoice";
            this.dateofinvoice.Size = new System.Drawing.Size(36, 13);
            this.dateofinvoice.TabIndex = 5;
            this.dateofinvoice.Text = "Дата:";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(362, 124);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(71, 20);
            this.date.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(63, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(63, 45);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(63, 79);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(169, 20);
            this.textBox3.TabIndex = 6;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(63, 104);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(169, 20);
            this.textBox4.TabIndex = 7;
            // 
            // added1
            // 
            this.added1.Location = new System.Drawing.Point(12, 21);
            this.added1.Name = "added1";
            this.added1.Size = new System.Drawing.Size(110, 29);
            this.added1.TabIndex = 7;
            this.added1.Text = "Добави в списък";
            this.added1.UseVisualStyleBackColor = true;
            // 
            // delete1
            // 
            this.delete1.Location = new System.Drawing.Point(150, 15);
            this.delete1.Name = "delete1";
            this.delete1.Size = new System.Drawing.Size(60, 41);
            this.delete1.TabIndex = 8;
            this.delete1.Text = "Изтри";
            this.delete1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(247, 13);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 37);
            this.button3.TabIndex = 9;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.delete1);
            this.Controls.Add(this.added1);
            this.Controls.Add(this.date);
            this.Controls.Add(this.dateofinvoice);
            this.Controls.Add(this.numberofinvoice);
            this.Controls.Add(this.number);
            this.Controls.Add(this.dostavchik);
            this.Controls.Add(this.poluchatel);
            this.Controls.Add(this.invoice);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.poluchatel.ResumeLayout(false);
            this.poluchatel.PerformLayout();
            this.dostavchik.ResumeLayout(false);
            this.dostavchik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label invoice;
        private System.Windows.Forms.GroupBox poluchatel;
        private System.Windows.Forms.TextBox mol;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label mol1;
        private System.Windows.Forms.Label address1;
        private System.Windows.Forms.Label id1;
        private System.Windows.Forms.Label name1;
        private System.Windows.Forms.GroupBox dostavchik;
        private System.Windows.Forms.Label mol2;
        private System.Windows.Forms.Label address2;
        private System.Windows.Forms.Label id2;
        private System.Windows.Forms.Label name2;
        private System.Windows.Forms.TextBox number;
        private System.Windows.Forms.Label numberofinvoice;
        private System.Windows.Forms.Label dateofinvoice;
        private System.Windows.Forms.TextBox date;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button added1;
        private System.Windows.Forms.Button delete1;
        private System.Windows.Forms.Button button3;
    }
}

