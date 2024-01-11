namespace ABCSpot.UI
{
    partial class FrmUrun
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtNumara = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtsoyisim = new System.Windows.Forms.TextBox();
            this.txtisim = new System.Windows.Forms.TextBox();
            this.txttici = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(262, 280);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "İptal";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(181, 280);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "Tamam";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(73, 90);
            this.txtnum.Name = "txtnum";
            this.txtnum.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtnum.Size = new System.Drawing.Size(264, 20);
            this.txtnum.TabIndex = 6;
            // 
            // txtNumara
            // 
            this.txtNumara.AutoSize = true;
            this.txtNumara.Location = new System.Drawing.Point(23, 93);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(44, 13);
            this.txtNumara.TabIndex = 10;
            this.txtNumara.Text = "Numara";
            // 
            // txtSoyad
            // 
            this.txtSoyad.AutoSize = true;
            this.txtSoyad.Location = new System.Drawing.Point(25, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(42, 13);
            this.txtSoyad.TabIndex = 11;
            this.txtSoyad.Text = "Soyisim";
            // 
            // txtAd
            // 
            this.txtAd.AutoSize = true;
            this.txtAd.Location = new System.Drawing.Point(42, 41);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(25, 13);
            this.txtAd.TabIndex = 12;
            this.txtAd.Text = "İsim";
            // 
            // txtTC
            // 
            this.txtTC.AutoSize = true;
            this.txtTC.Location = new System.Drawing.Point(43, 15);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(24, 13);
            this.txtTC.TabIndex = 14;
            this.txtTC.Text = "T.C";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(73, 64);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtsoyisim.Size = new System.Drawing.Size(264, 20);
            this.txtsoyisim.TabIndex = 15;
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(73, 41);
            this.txtisim.Name = "txtisim";
            this.txtisim.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtisim.Size = new System.Drawing.Size(264, 20);
            this.txtisim.TabIndex = 16;
            // 
            // txttici
            // 
            this.txttici.Location = new System.Drawing.Point(73, 12);
            this.txttici.Name = "txttici";
            this.txttici.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txttici.Size = new System.Drawing.Size(264, 20);
            this.txttici.TabIndex = 17;
            // 
            // FrmUrun
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(355, 318);
            this.Controls.Add(this.txttici);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtNumara);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.txtTC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmUrun";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sahip Ekle";
            this.Load += new System.EventHandler(this.FrmUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.Label txtNumara;
        private System.Windows.Forms.Label txtSoyad;
        private System.Windows.Forms.Label txtAd;
        private System.Windows.Forms.Label txtTC;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txttici;
        private System.Windows.Forms.TextBox txtisim;
        private System.Windows.Forms.TextBox txtsoyisim;
    }
}