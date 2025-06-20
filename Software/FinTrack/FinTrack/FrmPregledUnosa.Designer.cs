namespace FinTrack
{
    partial class FrmPregledUnosa
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
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnPretrazi = new System.Windows.Forms.Button();
            this.dgvUnosi = new System.Windows.Forms.DataGridView();
            this.btnObrisi = new System.Windows.Forms.Button();
            this.btnUredi = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStatistika = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnosi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPretraga
            // 
            this.txtPretraga.Location = new System.Drawing.Point(22, 55);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(185, 20);
            this.txtPretraga.TabIndex = 0;
            this.txtPretraga.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnPretrazi
            // 
            this.btnPretrazi.BackColor = System.Drawing.SystemColors.Window;
            this.btnPretrazi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPretrazi.Location = new System.Drawing.Point(213, 51);
            this.btnPretrazi.Name = "btnPretrazi";
            this.btnPretrazi.Size = new System.Drawing.Size(79, 27);
            this.btnPretrazi.TabIndex = 2;
            this.btnPretrazi.Text = "Pretraži";
            this.btnPretrazi.UseVisualStyleBackColor = false;
            this.btnPretrazi.Click += new System.EventHandler(this.btnPretrazi_Click);
            // 
            // dgvUnosi
            // 
            this.dgvUnosi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnosi.Location = new System.Drawing.Point(15, 100);
            this.dgvUnosi.Name = "dgvUnosi";
            this.dgvUnosi.Size = new System.Drawing.Size(562, 187);
            this.dgvUnosi.TabIndex = 3;
            this.dgvUnosi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnosi_CellContentClick);
            // 
            // btnObrisi
            // 
            this.btnObrisi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnObrisi.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnObrisi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnObrisi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnObrisi.Location = new System.Drawing.Point(513, 304);
            this.btnObrisi.Name = "btnObrisi";
            this.btnObrisi.Size = new System.Drawing.Size(64, 28);
            this.btnObrisi.TabIndex = 4;
            this.btnObrisi.Text = "Obriši";
            this.btnObrisi.UseVisualStyleBackColor = false;
            this.btnObrisi.Click += new System.EventHandler(this.btnObrisi_Click);
            // 
            // btnUredi
            // 
            this.btnUredi.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnUredi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnUredi.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnUredi.Location = new System.Drawing.Point(15, 306);
            this.btnUredi.Name = "btnUredi";
            this.btnUredi.Size = new System.Drawing.Size(62, 26);
            this.btnUredi.TabIndex = 5;
            this.btnUredi.Text = "Uredi";
            this.btnUredi.UseVisualStyleBackColor = false;
            this.btnUredi.Click += new System.EventHandler(this.btnUredi_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(248, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(176, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Pregled unosa";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnStatistika
            // 
            this.btnStatistika.BackColor = System.Drawing.Color.Navy;
            this.btnStatistika.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnStatistika.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnStatistika.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStatistika.Location = new System.Drawing.Point(443, 55);
            this.btnStatistika.Name = "btnStatistika";
            this.btnStatistika.Size = new System.Drawing.Size(134, 32);
            this.btnStatistika.TabIndex = 7;
            this.btnStatistika.Text = "Statistika";
            this.btnStatistika.UseVisualStyleBackColor = false;
            this.btnStatistika.Click += new System.EventHandler(this.btnStatistika_Click);
            // 
            // FrmPregledUnosa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 344);
            this.Controls.Add(this.btnStatistika);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnUredi);
            this.Controls.Add(this.btnObrisi);
            this.Controls.Add(this.dgvUnosi);
            this.Controls.Add(this.btnPretrazi);
            this.Controls.Add(this.txtPretraga);
            this.Name = "FrmPregledUnosa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pregled unosa";
            this.Load += new System.EventHandler(this.FrmPregledUnosa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnosi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnPretrazi;
        private System.Windows.Forms.DataGridView dgvUnosi;
        private System.Windows.Forms.Button btnObrisi;
        private System.Windows.Forms.Button btnUredi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStatistika;
    }
}