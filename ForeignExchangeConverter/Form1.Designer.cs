namespace ForeignExchangeConverter
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
            this.components = new System.ComponentModel.Container();
            this.usText = new System.Windows.Forms.TextBox();
            this.cadText = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.usd2cadText = new System.Windows.Forms.TextBox();
            this.nisText = new System.Windows.Forms.TextBox();
            this.eurText = new System.Windows.Forms.TextBox();
            this.nis2usdText = new System.Windows.Forms.TextBox();
            this.usd2eurText = new System.Windows.Forms.TextBox();
            this.US = new System.Windows.Forms.Label();
            this.CA = new System.Windows.Forms.Label();
            this.IS = new System.Windows.Forms.Label();
            this.EU = new System.Windows.Forms.Label();
            this.USCA = new System.Windows.Forms.Label();
            this.IUS = new System.Windows.Forms.Label();
            this.USEU = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usText
            // 
            this.usText.Location = new System.Drawing.Point(12, 55);
            this.usText.Name = "usText";
            this.usText.Size = new System.Drawing.Size(100, 20);
            this.usText.TabIndex = 0;
            this.usText.Text = "1.0";
            this.usText.UseWaitCursor = true;
            this.usText.TextChanged += new System.EventHandler(this.usTextBox_TextChanged);
            // 
            // cadText
            // 
            this.cadText.Location = new System.Drawing.Point(200, 55);
            this.cadText.Name = "cadText";
            this.cadText.Size = new System.Drawing.Size(100, 20);
            this.cadText.TabIndex = 1;
            this.cadText.Text = "1.0";
            this.cadText.TextChanged += new System.EventHandler(this.cadTextBox_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // usd2cadText
            // 
            this.usd2cadText.Location = new System.Drawing.Point(200, 181);
            this.usd2cadText.Name = "usd2cadText";
            this.usd2cadText.Size = new System.Drawing.Size(100, 20);
            this.usd2cadText.TabIndex = 3;
            this.usd2cadText.Text = "1.0";
            this.usd2cadText.TextChanged += new System.EventHandler(this.us2cadTextBox_TextChanged);
            // 
            // nisText
            // 
            this.nisText.Location = new System.Drawing.Point(440, 54);
            this.nisText.Name = "nisText";
            this.nisText.Size = new System.Drawing.Size(100, 20);
            this.nisText.TabIndex = 4;
            this.nisText.Text = "1.0";
            this.nisText.TextChanged += new System.EventHandler(this.nisTextBox_TextChanged);
            // 
            // eurText
            // 
            this.eurText.Location = new System.Drawing.Point(672, 55);
            this.eurText.Name = "eurText";
            this.eurText.Size = new System.Drawing.Size(100, 20);
            this.eurText.TabIndex = 5;
            this.eurText.Text = "1.0";
            this.eurText.TextChanged += new System.EventHandler(this.eurTextBox_TextChanged);
            // 
            // nis2usdText
            // 
            this.nis2usdText.Location = new System.Drawing.Point(440, 181);
            this.nis2usdText.Name = "nis2usdText";
            this.nis2usdText.Size = new System.Drawing.Size(100, 20);
            this.nis2usdText.TabIndex = 6;
            this.nis2usdText.Text = "1.0";
            this.nis2usdText.TextChanged += new System.EventHandler(this.nis2usTextBox_TextChanged);
            // 
            // usd2eurText
            // 
            this.usd2eurText.Location = new System.Drawing.Point(673, 181);
            this.usd2eurText.Name = "usd2eurText";
            this.usd2eurText.Size = new System.Drawing.Size(100, 20);
            this.usd2eurText.TabIndex = 7;
            this.usd2eurText.Text = "1.0";
            this.usd2eurText.TextChanged += new System.EventHandler(this.us2eurTextBox_TextChanged);
            // 
            // US
            // 
            this.US.AutoSize = true;
            this.US.Location = new System.Drawing.Point(9, 21);
            this.US.Name = "US";
            this.US.Size = new System.Drawing.Size(30, 13);
            this.US.TabIndex = 8;
            this.US.Text = "USD";
            // 
            // CA
            // 
            this.CA.AutoSize = true;
            this.CA.Location = new System.Drawing.Point(200, 21);
            this.CA.Name = "CA";
            this.CA.Size = new System.Drawing.Size(29, 13);
            this.CA.TabIndex = 9;
            this.CA.Text = "CAD";
            // 
            // IS
            // 
            this.IS.AutoSize = true;
            this.IS.Location = new System.Drawing.Point(440, 21);
            this.IS.Name = "IS";
            this.IS.Size = new System.Drawing.Size(25, 13);
            this.IS.TabIndex = 10;
            this.IS.Text = "NIS";
            // 
            // EU
            // 
            this.EU.AutoSize = true;
            this.EU.Location = new System.Drawing.Point(669, 21);
            this.EU.Name = "EU";
            this.EU.Size = new System.Drawing.Size(30, 13);
            this.EU.TabIndex = 11;
            this.EU.Text = "EUR";
            // 
            // USCA
            // 
            this.USCA.AutoSize = true;
            this.USCA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USCA.Location = new System.Drawing.Point(200, 146);
            this.USCA.Name = "USCA";
            this.USCA.Size = new System.Drawing.Size(99, 24);
            this.USCA.TabIndex = 12;
            this.USCA.Text = "USD/CAD";
            // 
            // IUS
            // 
            this.IUS.AutoSize = true;
            this.IUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IUS.Location = new System.Drawing.Point(440, 145);
            this.IUS.Name = "IUS";
            this.IUS.Size = new System.Drawing.Size(90, 24);
            this.IUS.TabIndex = 13;
            this.IUS.Text = "NIS/USD";
            // 
            // USEU
            // 
            this.USEU.AutoSize = true;
            this.USEU.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.USEU.Location = new System.Drawing.Point(673, 145);
            this.USEU.Name = "USEU";
            this.USEU.Size = new System.Drawing.Size(99, 24);
            this.USEU.TabIndex = 14;
            this.USEU.Text = "USD/EUR";
            this.USEU.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.USEU);
            this.Controls.Add(this.IUS);
            this.Controls.Add(this.USCA);
            this.Controls.Add(this.EU);
            this.Controls.Add(this.IS);
            this.Controls.Add(this.CA);
            this.Controls.Add(this.US);
            this.Controls.Add(this.usd2eurText);
            this.Controls.Add(this.nis2usdText);
            this.Controls.Add(this.eurText);
            this.Controls.Add(this.nisText);
            this.Controls.Add(this.usd2cadText);
            this.Controls.Add(this.cadText);
            this.Controls.Add(this.usText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox usText;
        private System.Windows.Forms.TextBox cadText;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox usd2cadText;
        private System.Windows.Forms.TextBox nisText;
        private System.Windows.Forms.TextBox eurText;
        private System.Windows.Forms.TextBox nis2usdText;
        private System.Windows.Forms.TextBox usd2eurText;
        private System.Windows.Forms.Label US;
        private System.Windows.Forms.Label CA;
        private System.Windows.Forms.Label IS;
        private System.Windows.Forms.Label EU;
        private System.Windows.Forms.Label USCA;
        private System.Windows.Forms.Label IUS;
        private System.Windows.Forms.Label USEU;
    }
}

