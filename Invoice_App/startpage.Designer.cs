namespace Invoice_App
{
    partial class startpage
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
            this.addinvoice = new System.Windows.Forms.Button();
            this.invoicelist = new System.Windows.Forms.Button();
            this.partner = new System.Windows.Forms.Button();
            this.mycompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addinvoice
            // 
            this.addinvoice.Location = new System.Drawing.Point(446, 236);
            this.addinvoice.Name = "addinvoice";
            this.addinvoice.Size = new System.Drawing.Size(272, 112);
            this.addinvoice.TabIndex = 1;
            this.addinvoice.Text = "+ Създаване на ф-ра";
            this.addinvoice.UseVisualStyleBackColor = true;
            // 
            // invoicelist
            // 
            this.invoicelist.Location = new System.Drawing.Point(446, 53);
            this.invoicelist.Name = "invoicelist";
            this.invoicelist.Size = new System.Drawing.Size(272, 104);
            this.invoicelist.TabIndex = 2;
            this.invoicelist.Text = "Преглед на списък с издадени ф-ри";
            this.invoicelist.UseVisualStyleBackColor = true;
            // 
            // partner
            // 
            this.partner.Location = new System.Drawing.Point(116, 240);
            this.partner.Name = "partner";
            this.partner.Size = new System.Drawing.Size(224, 108);
            this.partner.TabIndex = 3;
            this.partner.Text = "Партньори";
            this.partner.UseVisualStyleBackColor = true;
            // 
            // mycompany
            // 
            this.mycompany.Location = new System.Drawing.Point(116, 53);
            this.mycompany.Name = "mycompany";
            this.mycompany.Size = new System.Drawing.Size(224, 104);
            this.mycompany.TabIndex = 4;
            this.mycompany.Text = "Моята Фирма";
            this.mycompany.UseVisualStyleBackColor = true;
            // 
            // startpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mycompany);
            this.Controls.Add(this.partner);
            this.Controls.Add(this.invoicelist);
            this.Controls.Add(this.addinvoice);
            this.Name = "startpage";
            this.Text = "Начало";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addinvoice;
        private System.Windows.Forms.Button invoicelist;
        private System.Windows.Forms.Button partner;
        private System.Windows.Forms.Button mycompany;
    }
}