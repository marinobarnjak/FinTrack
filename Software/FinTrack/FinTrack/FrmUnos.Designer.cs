namespace FinTrack
{
    partial class FrmUnos
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
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.lblVrsta = new System.Windows.Forms.Label();
            this.txtVrsta = new System.Windows.Forms.TextBox();
            this.lblKategorija = new System.Windows.Forms.Label();
            this.cboKategorija = new System.Windows.Forms.ComboBox();
            this.lblIznos = new System.Windows.Forms.Label();
            this.txtIznos = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.lblOpis = new System.Windows.Forms.Label();
            this.btnPotvrdi = new System.Windows.Forms.Button();
            this.btnPregledUnosa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNaslov
            // 
            this.txtNaslov.BackColor = System.Drawing.SystemColors.Menu;
            this.txtNaslov.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNaslov.Enabled = false;
            this.txtNaslov.Font = new System.Drawing.Font("Calibri", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.txtNaslov.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txtNaslov.Location = new System.Drawing.Point(126, 12);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ReadOnly = true;
            this.txtNaslov.Size = new System.Drawing.Size(133, 24);
            this.txtNaslov.TabIndex = 0;
            this.txtNaslov.Text = "Novi unos";
            this.txtNaslov.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNaslov.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblVrsta
            // 
            this.lblVrsta.AutoSize = true;
            this.lblVrsta.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVrsta.Location = new System.Drawing.Point(13, 57);
            this.lblVrsta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVrsta.Name = "lblVrsta";
            this.lblVrsta.Size = new System.Drawing.Size(122, 15);
            this.lblVrsta.TabIndex = 1;
            this.lblVrsta.Text = "Vrsta(prihod/rashod)";
            // 
            // txtVrsta
            // 
            this.txtVrsta.Location = new System.Drawing.Point(144, 54);
            this.txtVrsta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtVrsta.Name = "txtVrsta";
            this.txtVrsta.Size = new System.Drawing.Size(164, 20);
            this.txtVrsta.TabIndex = 2;
            // 
            // lblKategorija
            // 
            this.lblKategorija.AutoSize = true;
            this.lblKategorija.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblKategorija.Location = new System.Drawing.Point(13, 101);
            this.lblKategorija.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKategorija.Name = "lblKategorija";
            this.lblKategorija.Size = new System.Drawing.Size(60, 13);
            this.lblKategorija.TabIndex = 3;
            this.lblKategorija.Text = "Kategorija";
            // 
            // cboKategorija
            // 
            this.cboKategorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.cboKategorija.FormattingEnabled = true;
            this.cboKategorija.Location = new System.Drawing.Point(144, 101);
            this.cboKategorija.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboKategorija.Name = "cboKategorija";
            this.cboKategorija.Size = new System.Drawing.Size(164, 21);
            this.cboKategorija.TabIndex = 5;
            // 
            // lblIznos
            // 
            this.lblIznos.AutoSize = true;
            this.lblIznos.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblIznos.Location = new System.Drawing.Point(13, 145);
            this.lblIznos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIznos.Name = "lblIznos";
            this.lblIznos.Size = new System.Drawing.Size(34, 13);
            this.lblIznos.TabIndex = 6;
            this.lblIznos.Text = "Iznos";
            // 
            // txtIznos
            // 
            this.txtIznos.Location = new System.Drawing.Point(144, 142);
            this.txtIznos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtIznos.Name = "txtIznos";
            this.txtIznos.Size = new System.Drawing.Size(164, 20);
            this.txtIznos.TabIndex = 7;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dtpDatum.Location = new System.Drawing.Point(144, 189);
            this.dtpDatum.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(164, 20);
            this.dtpDatum.TabIndex = 8;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblDatum.Location = new System.Drawing.Point(13, 189);
            this.lblDatum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(42, 13);
            this.lblDatum.TabIndex = 9;
            this.lblDatum.Text = "Datum";
            // 
            // txtOpis
            // 
            this.txtOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.txtOpis.Location = new System.Drawing.Point(16, 244);
            this.txtOpis.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.Size = new System.Drawing.Size(343, 50);
            this.txtOpis.TabIndex = 10;
            // 
            // lblOpis
            // 
            this.lblOpis.AutoSize = true;
            this.lblOpis.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOpis.Location = new System.Drawing.Point(13, 228);
            this.lblOpis.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpis.Name = "lblOpis";
            this.lblOpis.Size = new System.Drawing.Size(31, 15);
            this.lblOpis.TabIndex = 11;
            this.lblOpis.Text = "Opis";
            // 
            // btnPotvrdi
            // 
            this.btnPotvrdi.BackColor = System.Drawing.Color.MediumBlue;
            this.btnPotvrdi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPotvrdi.FlatAppearance.BorderSize = 2;
            this.btnPotvrdi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnPotvrdi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPotvrdi.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnPotvrdi.ForeColor = System.Drawing.Color.White;
            this.btnPotvrdi.Location = new System.Drawing.Point(155, 317);
            this.btnPotvrdi.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnPotvrdi.Name = "btnPotvrdi";
            this.btnPotvrdi.Size = new System.Drawing.Size(82, 31);
            this.btnPotvrdi.TabIndex = 12;
            this.btnPotvrdi.Text = "Potvrdi";
            this.btnPotvrdi.UseVisualStyleBackColor = false;
            this.btnPotvrdi.Click += new System.EventHandler(this.btnPotvrdi_Click);
            // 
            // btnPregledUnosa
            // 
            this.btnPregledUnosa.BackColor = System.Drawing.SystemColors.Window;
            this.btnPregledUnosa.FlatAppearance.BorderColor = System.Drawing.SystemColors.Window;
            this.btnPregledUnosa.FlatAppearance.BorderSize = 2;
            this.btnPregledUnosa.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPregledUnosa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledUnosa.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnPregledUnosa.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnPregledUnosa.Location = new System.Drawing.Point(257, 318);
            this.btnPregledUnosa.Name = "btnPregledUnosa";
            this.btnPregledUnosa.Size = new System.Drawing.Size(102, 28);
            this.btnPregledUnosa.TabIndex = 13;
            this.btnPregledUnosa.Text = "Pregled unosa";
            this.btnPregledUnosa.UseVisualStyleBackColor = false;
            this.btnPregledUnosa.Click += new System.EventHandler(this.btnPregledUnosa_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 101);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kategorija";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(13, 145);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Iznos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(13, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "Datum";
            // 
            // FrmUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 372);
            this.Controls.Add(this.btnPregledUnosa);
            this.Controls.Add(this.btnPotvrdi);
            this.Controls.Add(this.lblOpis);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIznos);
            this.Controls.Add(this.lblIznos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboKategorija);
            this.Controls.Add(this.lblKategorija);
            this.Controls.Add(this.txtVrsta);
            this.Controls.Add(this.lblVrsta);
            this.Controls.Add(this.txtNaslov);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmUnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novi unos";
            this.Load += new System.EventHandler(this.FrmUnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label lblVrsta;
        private System.Windows.Forms.TextBox txtVrsta;
        private System.Windows.Forms.Label lblKategorija;
        private System.Windows.Forms.ComboBox cboKategorija;
        private System.Windows.Forms.Label lblIznos;
        private System.Windows.Forms.TextBox txtIznos;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label lblOpis;
        private System.Windows.Forms.Button btnPotvrdi;
        private System.Windows.Forms.Button btnPregledUnosa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

