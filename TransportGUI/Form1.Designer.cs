namespace TransportGUI
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
            this.ddlAbfahrtsort = new System.Windows.Forms.ComboBox();
            this.lblAbfahrtsort = new System.Windows.Forms.Label();
            this.lblAnkunftsort = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.ddlAnkunftsort = new System.Windows.Forms.ComboBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.lblDatum = new System.Windows.Forms.Label();
            this.txtZeit = new System.Windows.Forms.TextBox();
            this.lblZeit = new System.Windows.Forms.Label();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.dgvAuflistung = new System.Windows.Forms.DataGridView();
            this.btnDropdownAnkunft = new System.Windows.Forms.Button();
            this.btnDropdownAbfahrt = new System.Windows.Forms.Button();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuflistung)).BeginInit();
            this.SuspendLayout();
            // 
            // ddlAbfahrtsort
            // 
            this.ddlAbfahrtsort.FormattingEnabled = true;
            this.ddlAbfahrtsort.Location = new System.Drawing.Point(12, 51);
            this.ddlAbfahrtsort.Name = "ddlAbfahrtsort";
            this.ddlAbfahrtsort.Size = new System.Drawing.Size(270, 21);
            this.ddlAbfahrtsort.TabIndex = 0;
            this.ddlAbfahrtsort.DropDown += new System.EventHandler(this.ddlAbfahrtsort_DropDown);
            // 
            // lblAbfahrtsort
            // 
            this.lblAbfahrtsort.AutoSize = true;
            this.lblAbfahrtsort.Location = new System.Drawing.Point(134, 35);
            this.lblAbfahrtsort.Name = "lblAbfahrtsort";
            this.lblAbfahrtsort.Size = new System.Drawing.Size(61, 13);
            this.lblAbfahrtsort.TabIndex = 1;
            this.lblAbfahrtsort.Text = "Abfahrtsort:";
            this.lblAbfahrtsort.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblAnkunftsort
            // 
            this.lblAnkunftsort.AutoSize = true;
            this.lblAnkunftsort.Location = new System.Drawing.Point(472, 35);
            this.lblAnkunftsort.Name = "lblAnkunftsort";
            this.lblAnkunftsort.Size = new System.Drawing.Size(64, 13);
            this.lblAnkunftsort.TabIndex = 2;
            this.lblAnkunftsort.Text = "Ankunftsort:";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(340, 117);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(312, 23);
            this.btnSuchen.TabIndex = 4;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.button1_Click);
            // 
            // ddlAnkunftsort
            // 
            this.ddlAnkunftsort.FormattingEnabled = true;
            this.ddlAnkunftsort.Location = new System.Drawing.Point(340, 51);
            this.ddlAnkunftsort.Name = "ddlAnkunftsort";
            this.ddlAnkunftsort.Size = new System.Drawing.Size(270, 21);
            this.ddlAnkunftsort.TabIndex = 2;
            this.ddlAnkunftsort.DropDown += new System.EventHandler(this.ddlAnkunftsort_DropDown);
            this.ddlAnkunftsort.SelectedIndexChanged += new System.EventHandler(this.ddlAnkunftsort_SelectedIndexChanged);
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(137, 120);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(187, 20);
            this.dtpDatum.TabIndex = 6;
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(201, 104);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(41, 13);
            this.lblDatum.TabIndex = 7;
            this.lblDatum.Text = "Datum:";
            // 
            // txtZeit
            // 
            this.txtZeit.Location = new System.Drawing.Point(12, 119);
            this.txtZeit.Name = "txtZeit";
            this.txtZeit.Size = new System.Drawing.Size(119, 20);
            this.txtZeit.TabIndex = 8;
            // 
            // lblZeit
            // 
            this.lblZeit.AutoSize = true;
            this.lblZeit.Location = new System.Drawing.Point(53, 104);
            this.lblZeit.Name = "lblZeit";
            this.lblZeit.Size = new System.Drawing.Size(28, 13);
            this.lblZeit.TabIndex = 9;
            this.lblZeit.Text = "Zeit:";
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(550, 415);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(102, 23);
            this.btnBeenden.TabIndex = 10;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(12, 415);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(102, 23);
            this.btnAbfahrtstafel.TabIndex = 11;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            // 
            // dgvAuflistung
            // 
            this.dgvAuflistung.AllowUserToAddRows = false;
            this.dgvAuflistung.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAuflistung.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvAuflistung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuflistung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Abfahrtszeit,
            this.Gleis,
            this.Ankunftsort,
            this.Ankunftszeit});
            this.dgvAuflistung.Location = new System.Drawing.Point(12, 161);
            this.dgvAuflistung.Name = "dgvAuflistung";
            this.dgvAuflistung.RowHeadersVisible = false;
            this.dgvAuflistung.Size = new System.Drawing.Size(640, 234);
            this.dgvAuflistung.TabIndex = 12;
            this.dgvAuflistung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAuflistung_CellContentClick);
            this.dgvAuflistung.SelectionChanged += new System.EventHandler(this.dgvAuflistung_SelectionChanged);
            // 
            // btnDropdownAnkunft
            // 
            this.btnDropdownAnkunft.Location = new System.Drawing.Point(616, 51);
            this.btnDropdownAnkunft.Name = "btnDropdownAnkunft";
            this.btnDropdownAnkunft.Size = new System.Drawing.Size(36, 23);
            this.btnDropdownAnkunft.TabIndex = 3;
            this.btnDropdownAnkunft.UseVisualStyleBackColor = true;
            this.btnDropdownAnkunft.Click += new System.EventHandler(this.btnDropdownAnkunft_Click);
            // 
            // btnDropdownAbfahrt
            // 
            this.btnDropdownAbfahrt.Location = new System.Drawing.Point(288, 49);
            this.btnDropdownAbfahrt.Name = "btnDropdownAbfahrt";
            this.btnDropdownAbfahrt.Size = new System.Drawing.Size(36, 23);
            this.btnDropdownAbfahrt.TabIndex = 1;
            this.btnDropdownAbfahrt.UseVisualStyleBackColor = true;
            this.btnDropdownAbfahrt.Click += new System.EventHandler(this.btnDropdownAbfahrt_Click);
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            this.Abfahrtszeit.ReadOnly = true;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Gleis / Kante";
            this.Gleis.Name = "Gleis";
            this.Gleis.ReadOnly = true;
            // 
            // Ankunftsort
            // 
            this.Ankunftsort.HeaderText = "Ankunftsort";
            this.Ankunftsort.Name = "Ankunftsort";
            this.Ankunftsort.ReadOnly = true;
            // 
            // Ankunftszeit
            // 
            this.Ankunftszeit.HeaderText = "Ankunftszeit";
            this.Ankunftszeit.Name = "Ankunftszeit";
            this.Ankunftszeit.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 450);
            this.Controls.Add(this.btnDropdownAbfahrt);
            this.Controls.Add(this.btnDropdownAnkunft);
            this.Controls.Add(this.dgvAuflistung);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.lblZeit);
            this.Controls.Add(this.txtZeit);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.ddlAnkunftsort);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.lblAnkunftsort);
            this.Controls.Add(this.lblAbfahrtsort);
            this.Controls.Add(this.ddlAbfahrtsort);
            this.Name = "Form1";
            this.Text = "Abfahrtsplan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuflistung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlAbfahrtsort;
        private System.Windows.Forms.Label lblAbfahrtsort;
        private System.Windows.Forms.Label lblAnkunftsort;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.ComboBox ddlAnkunftsort;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.TextBox txtZeit;
        private System.Windows.Forms.Label lblZeit;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.DataGridView dgvAuflistung;
        private System.Windows.Forms.Button btnDropdownAnkunft;
        private System.Windows.Forms.Button btnDropdownAbfahrt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
    }
}

