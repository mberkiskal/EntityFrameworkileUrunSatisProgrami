namespace EntityUrun
{
    partial class FormAnaForm
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
            this.btnKategori = new System.Windows.Forms.Button();
            this.btnUrun = new System.Windows.Forms.Button();
            this.btnIstatistik = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKategori
            // 
            this.btnKategori.Location = new System.Drawing.Point(12, 12);
            this.btnKategori.Name = "btnKategori";
            this.btnKategori.Size = new System.Drawing.Size(196, 144);
            this.btnKategori.TabIndex = 0;
            this.btnKategori.Text = "Kategori İşlemleri";
            this.btnKategori.UseVisualStyleBackColor = true;
            this.btnKategori.Click += new System.EventHandler(this.btnKategori_Click);
            // 
            // btnUrun
            // 
            this.btnUrun.Location = new System.Drawing.Point(214, 12);
            this.btnUrun.Name = "btnUrun";
            this.btnUrun.Size = new System.Drawing.Size(196, 144);
            this.btnUrun.TabIndex = 1;
            this.btnUrun.Text = "Ürün İşlemleri";
            this.btnUrun.UseVisualStyleBackColor = true;
            this.btnUrun.Click += new System.EventHandler(this.btnUrun_Click);
            // 
            // btnIstatistik
            // 
            this.btnIstatistik.Location = new System.Drawing.Point(416, 12);
            this.btnIstatistik.Name = "btnIstatistik";
            this.btnIstatistik.Size = new System.Drawing.Size(196, 144);
            this.btnIstatistik.TabIndex = 2;
            this.btnIstatistik.Text = "İstatistikler";
            this.btnIstatistik.UseVisualStyleBackColor = true;
            this.btnIstatistik.Click += new System.EventHandler(this.btnIstatistik_Click);
            // 
            // FormAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 168);
            this.Controls.Add(this.btnIstatistik);
            this.Controls.Add(this.btnUrun);
            this.Controls.Add(this.btnKategori);
            this.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormAnaForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKategori;
        private System.Windows.Forms.Button btnUrun;
        private System.Windows.Forms.Button btnIstatistik;
    }
}