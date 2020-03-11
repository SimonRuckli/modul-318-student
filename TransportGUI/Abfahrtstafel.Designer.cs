namespace TransportGUI
{
    partial class Abfahrtstafel
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
            this.btnDropdownAbfahrt = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.dgvAuflistung = new System.Windows.Forms.DataGridView();
            this.lblAbfahrtsort = new System.Windows.Forms.Label();
            this.btnAbfahrtsplan = new System.Windows.Forms.Button();
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
            this.ddlAbfahrtsort.TabIndex = 1;
            // 
            // btnDropdownAbfahrt
            // 
            this.btnDropdownAbfahrt.Location = new System.Drawing.Point(288, 51);
            this.btnDropdownAbfahrt.Name = "btnDropdownAbfahrt";
            this.btnDropdownAbfahrt.Size = new System.Drawing.Size(36, 23);
            this.btnDropdownAbfahrt.TabIndex = 2;
            this.btnDropdownAbfahrt.UseVisualStyleBackColor = true;
            this.btnDropdownAbfahrt.Click += new System.EventHandler(this.BtnDropdownAbfahrt_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Location = new System.Drawing.Point(340, 49);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(312, 23);
            this.btnSuchen.TabIndex = 5;
            this.btnSuchen.Text = "Abfahrten anzeigen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.AbfahrtenAnzeigen_Click);
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
            this.dgvAuflistung.TabIndex = 13;
            this.dgvAuflistung.SelectionChanged += new System.EventHandler(this.DgvAuflistung_SelectionChanged);
            // 
            // lblAbfahrtsort
            // 
            this.lblAbfahrtsort.AutoSize = true;
            this.lblAbfahrtsort.Location = new System.Drawing.Point(114, 35);
            this.lblAbfahrtsort.Name = "lblAbfahrtsort";
            this.lblAbfahrtsort.Size = new System.Drawing.Size(61, 13);
            this.lblAbfahrtsort.TabIndex = 14;
            this.lblAbfahrtsort.Text = "Abfahrtsort:";
            // 
            // btnAbfahrtsplan
            // 
            this.btnAbfahrtsplan.Location = new System.Drawing.Point(12, 416);
            this.btnAbfahrtsplan.Name = "btnAbfahrtsplan";
            this.btnAbfahrtsplan.Size = new System.Drawing.Size(102, 23);
            this.btnAbfahrtsplan.TabIndex = 15;
            this.btnAbfahrtsplan.Text = "Abfahrtsplan";
            this.btnAbfahrtsplan.UseVisualStyleBackColor = true;
            this.btnAbfahrtsplan.Click += new System.EventHandler(this.BtnAbfahrtsplan_Click);
            // 
            // Abfahrtszeit
            // 
            this.Abfahrtszeit.HeaderText = "Abfahrtszeit";
            this.Abfahrtszeit.Name = "Abfahrtszeit";
            this.Abfahrtszeit.ReadOnly = true;
            // 
            // Gleis
            // 
            this.Gleis.HeaderText = "Zug- / Busname";
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
            this.Ankunftszeit.HeaderText = "Operator";
            this.Ankunftszeit.Name = "Ankunftszeit";
            this.Ankunftszeit.ReadOnly = true;
            // 
            // Abfahrtstafel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 451);
            this.Controls.Add(this.btnAbfahrtsplan);
            this.Controls.Add(this.lblAbfahrtsort);
            this.Controls.Add(this.dgvAuflistung);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.btnDropdownAbfahrt);
            this.Controls.Add(this.ddlAbfahrtsort);
            this.Name = "Abfahrtstafel";
            this.Text = "Abfahrtstafel";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuflistung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox ddlAbfahrtsort;
        private System.Windows.Forms.Button btnDropdownAbfahrt;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.DataGridView dgvAuflistung;
        private System.Windows.Forms.Label lblAbfahrtsort;
        private System.Windows.Forms.Button btnAbfahrtsplan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Abfahrtszeit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gleis;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftsort;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ankunftszeit;
    }
}