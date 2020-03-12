namespace TransportGUI
{
    partial class Abfahrtsplan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Abfahrtsplan));
            this.ddlAbfahrtsort = new System.Windows.Forms.ComboBox();
            this.lblAbfahrtsort = new System.Windows.Forms.Label();
            this.lblAnkunftsort = new System.Windows.Forms.Label();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.ddlAnkunftsort = new System.Windows.Forms.ComboBox();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.dgvAuflistung = new System.Windows.Forms.DataGridView();
            this.Abfahrtszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gleis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftsort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ankunftszeit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDropdownAnkunft = new System.Windows.Forms.Button();
            this.btnDropdownAbfahrt = new System.Windows.Forms.Button();
            this.btnOrt = new System.Windows.Forms.Button();
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
            // 
            // lblAbfahrtsort
            // 
            this.lblAbfahrtsort.AutoSize = true;
            this.lblAbfahrtsort.Location = new System.Drawing.Point(134, 35);
            this.lblAbfahrtsort.Name = "lblAbfahrtsort";
            this.lblAbfahrtsort.Size = new System.Drawing.Size(61, 13);
            this.lblAbfahrtsort.TabIndex = 1;
            this.lblAbfahrtsort.Text = "Abfahrtsort:";
            // 
            // lblAnkunftsort
            // 
            this.lblAnkunftsort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAnkunftsort.AutoSize = true;
            this.lblAnkunftsort.Location = new System.Drawing.Point(472, 35);
            this.lblAnkunftsort.Name = "lblAnkunftsort";
            this.lblAnkunftsort.Size = new System.Drawing.Size(64, 13);
            this.lblAnkunftsort.TabIndex = 2;
            this.lblAnkunftsort.Text = "Ankunftsort:";
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuchen.Location = new System.Drawing.Point(340, 113);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(312, 23);
            this.btnSuchen.TabIndex = 4;
            this.btnSuchen.Text = "Verbindung suchen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.Verbindungen_Click);
            // 
            // ddlAnkunftsort
            // 
            this.ddlAnkunftsort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlAnkunftsort.FormattingEnabled = true;
            this.ddlAnkunftsort.Location = new System.Drawing.Point(340, 51);
            this.ddlAnkunftsort.Name = "ddlAnkunftsort";
            this.ddlAnkunftsort.Size = new System.Drawing.Size(270, 21);
            this.ddlAnkunftsort.TabIndex = 2;
            // 
            // btnBeenden
            // 
            this.btnBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeenden.Location = new System.Drawing.Point(550, 415);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(102, 23);
            this.btnBeenden.TabIndex = 6;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.BtnBeenden_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(12, 415);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(102, 23);
            this.btnAbfahrtstafel.TabIndex = 5;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.BtnAbfahrtstafel_Click);
            // 
            // dgvAuflistung
            // 
            this.dgvAuflistung.AllowUserToAddRows = false;
            this.dgvAuflistung.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.dgvAuflistung.TabStop = false;
            this.dgvAuflistung.SelectionChanged += new System.EventHandler(this.DgvAuflistung_SelectionChanged);
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
            // btnDropdownAnkunft
            // 
            this.btnDropdownAnkunft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDropdownAnkunft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDropdownAnkunft.BackgroundImage")));
            this.btnDropdownAnkunft.Location = new System.Drawing.Point(620, 44);
            this.btnDropdownAnkunft.Name = "btnDropdownAnkunft";
            this.btnDropdownAnkunft.Size = new System.Drawing.Size(32, 33);
            this.btnDropdownAnkunft.TabIndex = 3;
            this.btnDropdownAnkunft.UseVisualStyleBackColor = true;
            this.btnDropdownAnkunft.Click += new System.EventHandler(this.BtnDropdownAnkunft_Click);
            // 
            // btnDropdownAbfahrt
            // 
            this.btnDropdownAbfahrt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDropdownAbfahrt.BackgroundImage")));
            this.btnDropdownAbfahrt.Location = new System.Drawing.Point(288, 44);
            this.btnDropdownAbfahrt.Name = "btnDropdownAbfahrt";
            this.btnDropdownAbfahrt.Size = new System.Drawing.Size(32, 33);
            this.btnDropdownAbfahrt.TabIndex = 1;
            this.btnDropdownAbfahrt.UseVisualStyleBackColor = true;
            this.btnDropdownAbfahrt.Click += new System.EventHandler(this.BtnDropdownAbfahrt_Click);
            // 
            // btnOrt
            // 
            this.btnOrt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOrt.Location = new System.Drawing.Point(120, 415);
            this.btnOrt.Name = "btnOrt";
            this.btnOrt.Size = new System.Drawing.Size(102, 23);
            this.btnOrt.TabIndex = 13;
            this.btnOrt.Text = "Station anzeigen";
            this.btnOrt.UseVisualStyleBackColor = true;
            this.btnOrt.Click += new System.EventHandler(this.BtnOrt_Click);
            // 
            // Abfahrtsplan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 451);
            this.Controls.Add(this.btnOrt);
            this.Controls.Add(this.btnDropdownAbfahrt);
            this.Controls.Add(this.btnDropdownAnkunft);
            this.Controls.Add(this.dgvAuflistung);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.ddlAnkunftsort);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.lblAnkunftsort);
            this.Controls.Add(this.lblAbfahrtsort);
            this.Controls.Add(this.ddlAbfahrtsort);
            this.Name = "Abfahrtsplan";
            this.Text = "Abfahrtsplan";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Abfahrtsplan_FormClosing);
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
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnAbfahrtstafel;
        private System.Windows.Forms.DataGridView dgvAuflistung;
        private System.Windows.Forms.Button btnDropdownAnkunft;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
        private System.Windows.Forms.Button btnDropdownAbfahrt;
        private System.Windows.Forms.Button btnOrt;
    }
}

