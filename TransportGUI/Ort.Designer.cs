namespace TransportGUI
{
    partial class Ort
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ort));
            this.ddlStation = new System.Windows.Forms.ComboBox();
            this.lblStation = new System.Windows.Forms.Label();
            this.btnDropdownStation = new System.Windows.Forms.Button();
            this.btnSuchen = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.btnAbfahrtsplan = new System.Windows.Forms.Button();
            this.btnAbfahrtstafel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ddlStation
            // 
            this.ddlStation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddlStation.FormattingEnabled = true;
            this.ddlStation.Location = new System.Drawing.Point(12, 25);
            this.ddlStation.Name = "ddlStation";
            this.ddlStation.Size = new System.Drawing.Size(282, 21);
            this.ddlStation.TabIndex = 0;
            // 
            // lblStation
            // 
            this.lblStation.AutoSize = true;
            this.lblStation.Location = new System.Drawing.Point(109, 9);
            this.lblStation.Name = "lblStation";
            this.lblStation.Size = new System.Drawing.Size(40, 13);
            this.lblStation.TabIndex = 15;
            this.lblStation.Text = "Station";
            // 
            // btnDropdownStation
            // 
            this.btnDropdownStation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDropdownStation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDropdownStation.BackgroundImage")));
            this.btnDropdownStation.Location = new System.Drawing.Point(300, 18);
            this.btnDropdownStation.Name = "btnDropdownStation";
            this.btnDropdownStation.Size = new System.Drawing.Size(32, 33);
            this.btnDropdownStation.TabIndex = 1;
            this.btnDropdownStation.UseVisualStyleBackColor = true;
            this.btnDropdownStation.Click += new System.EventHandler(this.BtnDropdownStation_Click);
            // 
            // btnSuchen
            // 
            this.btnSuchen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSuchen.Location = new System.Drawing.Point(11, 68);
            this.btnSuchen.Name = "btnSuchen";
            this.btnSuchen.Size = new System.Drawing.Size(283, 23);
            this.btnSuchen.TabIndex = 2;
            this.btnSuchen.Text = "Station anzeigen";
            this.btnSuchen.UseVisualStyleBackColor = true;
            this.btnSuchen.Click += new System.EventHandler(this.BtnSuchen_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBeenden.Location = new System.Drawing.Point(228, 119);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(104, 23);
            this.btnBeenden.TabIndex = 5;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.BtnBeenden_Click);
            // 
            // btnAbfahrtsplan
            // 
            this.btnAbfahrtsplan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbfahrtsplan.Location = new System.Drawing.Point(12, 119);
            this.btnAbfahrtsplan.Name = "btnAbfahrtsplan";
            this.btnAbfahrtsplan.Size = new System.Drawing.Size(102, 23);
            this.btnAbfahrtsplan.TabIndex = 3;
            this.btnAbfahrtsplan.Text = "Abfahrtsplan";
            this.btnAbfahrtsplan.UseVisualStyleBackColor = true;
            this.btnAbfahrtsplan.Click += new System.EventHandler(this.BtnAbfahrtsplan_Click);
            // 
            // btnAbfahrtstafel
            // 
            this.btnAbfahrtstafel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAbfahrtstafel.Location = new System.Drawing.Point(120, 119);
            this.btnAbfahrtstafel.Name = "btnAbfahrtstafel";
            this.btnAbfahrtstafel.Size = new System.Drawing.Size(102, 23);
            this.btnAbfahrtstafel.TabIndex = 4;
            this.btnAbfahrtstafel.Text = "Abfahrtstafel";
            this.btnAbfahrtstafel.UseVisualStyleBackColor = true;
            this.btnAbfahrtstafel.Click += new System.EventHandler(this.BtnAbfahrtstafel_Click);
            // 
            // Ort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 154);
            this.Controls.Add(this.btnAbfahrtstafel);
            this.Controls.Add(this.btnAbfahrtsplan);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnSuchen);
            this.Controls.Add(this.btnDropdownStation);
            this.Controls.Add(this.lblStation);
            this.Controls.Add(this.ddlStation);
            this.Name = "Ort";
            this.Text = "Ort";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Ort_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox ddlStation;
        private System.Windows.Forms.Label lblStation;
        private System.Windows.Forms.Button btnDropdownStation;
        private System.Windows.Forms.Button btnSuchen;
        private System.Windows.Forms.Button btnBeenden;
        private System.Windows.Forms.Button btnAbfahrtsplan;
        private System.Windows.Forms.Button btnAbfahrtstafel;
    }
}