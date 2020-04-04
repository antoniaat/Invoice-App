namespace Invoice_App
{
    partial class StartPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartPage));
            this.addinvoice = new System.Windows.Forms.Button();
            this.invoicelist = new System.Windows.Forms.Button();
            this.partner = new System.Windows.Forms.Button();
            this.mycompany = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addinvoice
            // 
            this.addinvoice.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addinvoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.addinvoice.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addinvoice.Location = new System.Drawing.Point(68, 470);
            this.addinvoice.Margin = new System.Windows.Forms.Padding(4);
            this.addinvoice.Name = "addinvoice";
            this.addinvoice.Size = new System.Drawing.Size(305, 101);
            this.addinvoice.TabIndex = 1;
            this.addinvoice.Text = "+ Създаване на ф-ра";
            this.addinvoice.UseVisualStyleBackColor = false;
            this.addinvoice.Click += new System.EventHandler(this.addinvoice_Click);
            // 
            // invoicelist
            // 
            this.invoicelist.BackColor = System.Drawing.Color.LightSeaGreen;
            this.invoicelist.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.invoicelist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.invoicelist.Location = new System.Drawing.Point(68, 338);
            this.invoicelist.Margin = new System.Windows.Forms.Padding(4);
            this.invoicelist.Name = "invoicelist";
            this.invoicelist.Size = new System.Drawing.Size(305, 101);
            this.invoicelist.TabIndex = 2;
            this.invoicelist.Text = "Преглед на списък с издадени ф-ри";
            this.invoicelist.UseVisualStyleBackColor = false;
            this.invoicelist.Click += new System.EventHandler(this.invoicelist_Click);
            // 
            // partner
            // 
            this.partner.BackColor = System.Drawing.Color.LightSeaGreen;
            this.partner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.partner.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partner.Location = new System.Drawing.Point(68, 202);
            this.partner.Margin = new System.Windows.Forms.Padding(4);
            this.partner.Name = "partner";
            this.partner.Size = new System.Drawing.Size(305, 101);
            this.partner.TabIndex = 3;
            this.partner.Text = "Партньори";
            this.partner.UseVisualStyleBackColor = false;
            this.partner.Click += new System.EventHandler(this.partner_Click);
            // 
            // mycompany
            // 
            this.mycompany.BackColor = System.Drawing.Color.LightSeaGreen;
            this.mycompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.mycompany.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.mycompany.Location = new System.Drawing.Point(68, 68);
            this.mycompany.Margin = new System.Windows.Forms.Padding(4);
            this.mycompany.Name = "mycompany";
            this.mycompany.Size = new System.Drawing.Size(305, 101);
            this.mycompany.TabIndex = 4;
            this.mycompany.Text = "Моята Фирма";
            this.mycompany.UseVisualStyleBackColor = false;
            this.mycompany.Click += new System.EventHandler(this.Mycompany_Click);
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1148, 646);
            this.Controls.Add(this.mycompany);
            this.Controls.Add(this.partner);
            this.Controls.Add(this.invoicelist);
            this.Controls.Add(this.addinvoice);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StartPage";
            this.Text = "Начало";
            this.Load += new System.EventHandler(this.StartPage_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addinvoice;
        private System.Windows.Forms.Button invoicelist;
        private System.Windows.Forms.Button partner;
        private System.Windows.Forms.Button mycompany;
    }
}