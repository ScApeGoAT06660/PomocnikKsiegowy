namespace PomocnikKsiegowy
{
    partial class AddSpines
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblYear = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtTraderName = new System.Windows.Forms.TextBox();
            this.lblTraderName = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.rbSection = new System.Windows.Forms.RadioButton();
            this.lblParts = new System.Windows.Forms.Label();
            this.pnlSize = new System.Windows.Forms.Panel();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbBig = new System.Windows.Forms.RadioButton();
            this.gbSpines = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbRange = new System.Windows.Forms.RadioButton();
            this.rbNoSection = new System.Windows.Forms.RadioButton();
            this.lblSize = new System.Windows.Forms.Label();
            this.nudParts = new System.Windows.Forms.NumericUpDown();
            this.nudMonth = new System.Windows.Forms.NumericUpDown();
            this.nudMonth2 = new System.Windows.Forms.NumericUpDown();
            this.pnlSize.SuspendLayout();
            this.gbSpines.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth2)).BeginInit();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblYear.Location = new System.Drawing.Point(3, 21);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(30, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Rok";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(4, 38);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 20);
            this.txtYear.TabIndex = 1;
            // 
            // txtTraderName
            // 
            this.txtTraderName.Location = new System.Drawing.Point(4, 79);
            this.txtTraderName.Name = "txtTraderName";
            this.txtTraderName.Size = new System.Drawing.Size(262, 20);
            this.txtTraderName.TabIndex = 3;
            // 
            // lblTraderName
            // 
            this.lblTraderName.AutoSize = true;
            this.lblTraderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblTraderName.Location = new System.Drawing.Point(3, 62);
            this.lblTraderName.Name = "lblTraderName";
            this.lblTraderName.Size = new System.Drawing.Size(78, 13);
            this.lblTraderName.TabIndex = 2;
            this.lblTraderName.Text = "Nazwa Firmy";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMonth.Location = new System.Drawing.Point(109, 21);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(50, 13);
            this.lblMonth.TabIndex = 4;
            this.lblMonth.Text = "Miesiąc";
            // 
            // rbSection
            // 
            this.rbSection.AutoSize = true;
            this.rbSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbSection.Location = new System.Drawing.Point(117, 126);
            this.rbSection.Name = "rbSection";
            this.rbSection.Size = new System.Drawing.Size(64, 17);
            this.rbSection.TabIndex = 6;
            this.rbSection.TabStop = true;
            this.rbSection.Text = "Podział ";
            this.rbSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbSection.UseVisualStyleBackColor = true;
            this.rbSection.CheckedChanged += new System.EventHandler(this.rbSection_CheckedChanged);
            // 
            // lblParts
            // 
            this.lblParts.AutoSize = true;
            this.lblParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblParts.Location = new System.Drawing.Point(213, 130);
            this.lblParts.Name = "lblParts";
            this.lblParts.Size = new System.Drawing.Size(41, 13);
            this.lblParts.TabIndex = 7;
            this.lblParts.Text = "Część";
            // 
            // pnlSize
            // 
            this.pnlSize.Controls.Add(this.rbSmall);
            this.pnlSize.Controls.Add(this.rbBig);
            this.pnlSize.Location = new System.Drawing.Point(6, 123);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Size = new System.Drawing.Size(100, 50);
            this.pnlSize.TabIndex = 9;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Location = new System.Drawing.Point(3, 26);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(48, 17);
            this.rbSmall.TabIndex = 1;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "mały";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbBig
            // 
            this.rbBig.AutoSize = true;
            this.rbBig.Location = new System.Drawing.Point(3, 3);
            this.rbBig.Name = "rbBig";
            this.rbBig.Size = new System.Drawing.Size(47, 17);
            this.rbBig.TabIndex = 0;
            this.rbBig.TabStop = true;
            this.rbBig.Text = "duży";
            this.rbBig.UseVisualStyleBackColor = true;
            // 
            // gbSpines
            // 
            this.gbSpines.Controls.Add(this.nudMonth2);
            this.gbSpines.Controls.Add(this.nudMonth);
            this.gbSpines.Controls.Add(this.panel1);
            this.gbSpines.Controls.Add(this.rbNoSection);
            this.gbSpines.Controls.Add(this.lblSize);
            this.gbSpines.Controls.Add(this.nudParts);
            this.gbSpines.Controls.Add(this.pnlSize);
            this.gbSpines.Controls.Add(this.lblYear);
            this.gbSpines.Controls.Add(this.txtYear);
            this.gbSpines.Controls.Add(this.lblParts);
            this.gbSpines.Controls.Add(this.lblMonth);
            this.gbSpines.Controls.Add(this.txtTraderName);
            this.gbSpines.Controls.Add(this.lblTraderName);
            this.gbSpines.Controls.Add(this.rbSection);
            this.gbSpines.Location = new System.Drawing.Point(3, 3);
            this.gbSpines.Name = "gbSpines";
            this.gbSpines.Size = new System.Drawing.Size(280, 181);
            this.gbSpines.TabIndex = 10;
            this.gbSpines.TabStop = false;
            this.gbSpines.Text = "Grzbiet n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbRange);
            this.panel1.Location = new System.Drawing.Point(191, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 24);
            this.panel1.TabIndex = 15;
            // 
            // rbRange
            // 
            this.rbRange.AutoSize = true;
            this.rbRange.Location = new System.Drawing.Point(3, 3);
            this.rbRange.Name = "rbRange";
            this.rbRange.Size = new System.Drawing.Size(58, 17);
            this.rbRange.TabIndex = 13;
            this.rbRange.TabStop = true;
            this.rbRange.Text = "Zakres";
            this.rbRange.UseVisualStyleBackColor = true;
            this.rbRange.CheckedChanged += new System.EventHandler(this.rbRange_CheckedChanged);
            // 
            // rbNoSection
            // 
            this.rbNoSection.AutoSize = true;
            this.rbNoSection.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbNoSection.Location = new System.Drawing.Point(117, 149);
            this.rbNoSection.Name = "rbNoSection";
            this.rbNoSection.Size = new System.Drawing.Size(91, 17);
            this.rbNoSection.TabIndex = 12;
            this.rbNoSection.TabStop = true;
            this.rbNoSection.Text = "Brak podziału";
            this.rbNoSection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbNoSection.UseVisualStyleBackColor = true;
            this.rbNoSection.CheckedChanged += new System.EventHandler(this.rbNoSection_CheckedChanged);
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSize.Location = new System.Drawing.Point(6, 107);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(52, 13);
            this.lblSize.TabIndex = 11;
            this.lblSize.Text = "Rozmiar";
            // 
            // nudParts
            // 
            this.nudParts.Enabled = false;
            this.nudParts.Location = new System.Drawing.Point(214, 146);
            this.nudParts.Name = "nudParts";
            this.nudParts.Size = new System.Drawing.Size(60, 20);
            this.nudParts.TabIndex = 10;
            // 
            // nudMonth
            // 
            this.nudMonth.Location = new System.Drawing.Point(110, 39);
            this.nudMonth.Name = "nudMonth";
            this.nudMonth.Size = new System.Drawing.Size(76, 20);
            this.nudMonth.TabIndex = 16;
            // 
            // nudMonth2
            // 
            this.nudMonth2.Enabled = false;
            this.nudMonth2.Location = new System.Drawing.Point(190, 39);
            this.nudMonth2.Name = "nudMonth2";
            this.nudMonth2.Size = new System.Drawing.Size(76, 20);
            this.nudMonth2.TabIndex = 17;
            // 
            // AddSpines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSpines);
            this.Name = "AddSpines";
            this.Size = new System.Drawing.Size(286, 187);
            this.pnlSize.ResumeLayout(false);
            this.pnlSize.PerformLayout();
            this.gbSpines.ResumeLayout(false);
            this.gbSpines.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonth2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtTraderName;
        private System.Windows.Forms.Label lblTraderName;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.RadioButton rbSection;
        private System.Windows.Forms.Label lblParts;
        private System.Windows.Forms.Panel pnlSize;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.RadioButton rbBig;
        private System.Windows.Forms.GroupBox gbSpines;
        private System.Windows.Forms.NumericUpDown nudParts;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.RadioButton rbNoSection;
        private System.Windows.Forms.RadioButton rbRange;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown nudMonth2;
        private System.Windows.Forms.NumericUpDown nudMonth;
    }
}
