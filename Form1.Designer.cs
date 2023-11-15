
namespace TekYonluBaglıList
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtnumara = new System.Windows.Forms.TextBox();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.btnsonaekle = new System.Windows.Forms.Button();
            this.btnarayaekle = new System.Windows.Forms.Button();
            this.btndugumsil = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kisisilbul = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.kisisilbul);
            this.groupBox1.Controls.Add(this.txtnumara);
            this.groupBox1.Controls.Add(this.txtsoyad);
            this.groupBox1.Controls.Add(this.txtad);
            this.groupBox1.Controls.Add(this.lblNumara);
            this.groupBox1.Controls.Add(this.lblSoyad);
            this.groupBox1.Controls.Add(this.lblAd);
            this.groupBox1.Location = new System.Drawing.Point(155, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 201);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtnumara
            // 
            this.txtnumara.Location = new System.Drawing.Point(132, 113);
            this.txtnumara.Name = "txtnumara";
            this.txtnumara.Size = new System.Drawing.Size(100, 20);
            this.txtnumara.TabIndex = 1;
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(132, 69);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(100, 20);
            this.txtsoyad.TabIndex = 1;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(132, 36);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(100, 20);
            this.txtad.TabIndex = 1;
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(21, 113);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(44, 13);
            this.lblNumara.TabIndex = 0;
            this.lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(21, 69);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(37, 13);
            this.lblSoyad.TabIndex = 0;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(21, 36);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // btnsonaekle
            // 
            this.btnsonaekle.Location = new System.Drawing.Point(501, 95);
            this.btnsonaekle.Name = "btnsonaekle";
            this.btnsonaekle.Size = new System.Drawing.Size(75, 23);
            this.btnsonaekle.TabIndex = 1;
            this.btnsonaekle.Text = "Sona Ekle";
            this.btnsonaekle.UseVisualStyleBackColor = true;
            this.btnsonaekle.Click += new System.EventHandler(this.btnsonaekle_Click);
            // 
            // btnarayaekle
            // 
            this.btnarayaekle.Location = new System.Drawing.Point(501, 137);
            this.btnarayaekle.Name = "btnarayaekle";
            this.btnarayaekle.Size = new System.Drawing.Size(75, 23);
            this.btnarayaekle.TabIndex = 1;
            this.btnarayaekle.Text = "Araya Ekle";
            this.btnarayaekle.UseVisualStyleBackColor = true;
            // 
            // btndugumsil
            // 
            this.btndugumsil.Location = new System.Drawing.Point(501, 173);
            this.btndugumsil.Name = "btndugumsil";
            this.btndugumsil.Size = new System.Drawing.Size(75, 23);
            this.btndugumsil.TabIndex = 1;
            this.btndugumsil.Text = "Düğüm Sil";
            this.btndugumsil.UseVisualStyleBackColor = true;
            this.btndugumsil.Click += new System.EventHandler(this.btndugumsil_Click);
            // 
            // btnListe
            // 
            this.btnListe.Location = new System.Drawing.Point(417, 283);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(75, 23);
            this.btnListe.TabIndex = 1;
            this.btnListe.Text = "Listeyi Yaz";
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView.Location = new System.Drawing.Point(257, 333);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(344, 87);
            this.dataGridView.TabIndex = 2;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ad";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Soyad";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Numara";
            this.Column3.Name = "Column3";
            // 
            // kisisilbul
            // 
            this.kisisilbul.Location = new System.Drawing.Point(239, 113);
            this.kisisilbul.Name = "kisisilbul";
            this.kisisilbul.Size = new System.Drawing.Size(52, 23);
            this.kisisilbul.TabIndex = 2;
            this.kisisilbul.Text = "bul";
            this.kisisilbul.UseVisualStyleBackColor = true;
            this.kisisilbul.Click += new System.EventHandler(this.kisisilbul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.btndugumsil);
            this.Controls.Add(this.btnarayaekle);
            this.Controls.Add(this.btnsonaekle);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtnumara;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnsonaekle;
        private System.Windows.Forms.Button btnarayaekle;
        private System.Windows.Forms.Button btndugumsil;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button kisisilbul;
    }
}

