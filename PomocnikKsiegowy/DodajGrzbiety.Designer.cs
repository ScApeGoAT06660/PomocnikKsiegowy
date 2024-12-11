namespace PomocnikKsiegowy
{
    partial class DodajGrzbiety
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
            this.lblRok = new System.Windows.Forms.Label();
            this.txtRok = new System.Windows.Forms.TextBox();
            this.txtNazwaFirmy = new System.Windows.Forms.TextBox();
            this.lblNazwaFirmy = new System.Windows.Forms.Label();
            this.txtMiesiac = new System.Windows.Forms.TextBox();
            this.lblMiesiac = new System.Windows.Forms.Label();
            this.rbPodzial = new System.Windows.Forms.RadioButton();
            this.lblCzesc = new System.Windows.Forms.Label();
            this.pnlRozmiary = new System.Windows.Forms.Panel();
            this.rbMaly = new System.Windows.Forms.RadioButton();
            this.rbDuzy = new System.Windows.Forms.RadioButton();
            this.gbGrzbiety = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbZakres = new System.Windows.Forms.RadioButton();
            this.txtMiesiac2 = new System.Windows.Forms.TextBox();
            this.rbBrakPodziału = new System.Windows.Forms.RadioButton();
            this.lblRozmiar = new System.Windows.Forms.Label();
            this.nudCzesc = new System.Windows.Forms.NumericUpDown();
            this.pnlRozmiary.SuspendLayout();
            this.gbGrzbiety.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCzesc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRok
            // 
            this.lblRok.AutoSize = true;
            this.lblRok.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRok.Location = new System.Drawing.Point(3, 21);
            this.lblRok.Name = "lblRok";
            this.lblRok.Size = new System.Drawing.Size(30, 13);
            this.lblRok.TabIndex = 0;
            this.lblRok.Text = "Rok";
            // 
            // txtRok
            // 
            this.txtRok.Location = new System.Drawing.Point(4, 38);
            this.txtRok.Name = "txtRok";
            this.txtRok.Size = new System.Drawing.Size(100, 20);
            this.txtRok.TabIndex = 1;
            // 
            // txtNazwaFirmy
            // 
            this.txtNazwaFirmy.Location = new System.Drawing.Point(4, 79);
            this.txtNazwaFirmy.Name = "txtNazwaFirmy";
            this.txtNazwaFirmy.Size = new System.Drawing.Size(262, 20);
            this.txtNazwaFirmy.TabIndex = 3;
            // 
            // lblNazwaFirmy
            // 
            this.lblNazwaFirmy.AutoSize = true;
            this.lblNazwaFirmy.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNazwaFirmy.Location = new System.Drawing.Point(3, 62);
            this.lblNazwaFirmy.Name = "lblNazwaFirmy";
            this.lblNazwaFirmy.Size = new System.Drawing.Size(78, 13);
            this.lblNazwaFirmy.TabIndex = 2;
            this.lblNazwaFirmy.Text = "Nazwa Firmy";
            // 
            // txtMiesiac
            // 
            this.txtMiesiac.Location = new System.Drawing.Point(110, 38);
            this.txtMiesiac.Name = "txtMiesiac";
            this.txtMiesiac.Size = new System.Drawing.Size(75, 20);
            this.txtMiesiac.TabIndex = 5;
            // 
            // lblMiesiac
            // 
            this.lblMiesiac.AutoSize = true;
            this.lblMiesiac.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMiesiac.Location = new System.Drawing.Point(109, 21);
            this.lblMiesiac.Name = "lblMiesiac";
            this.lblMiesiac.Size = new System.Drawing.Size(50, 13);
            this.lblMiesiac.TabIndex = 4;
            this.lblMiesiac.Text = "Miesiąc";
            // 
            // rbPodzial
            // 
            this.rbPodzial.AutoSize = true;
            this.rbPodzial.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPodzial.Location = new System.Drawing.Point(117, 126);
            this.rbPodzial.Name = "rbPodzial";
            this.rbPodzial.Size = new System.Drawing.Size(64, 17);
            this.rbPodzial.TabIndex = 6;
            this.rbPodzial.TabStop = true;
            this.rbPodzial.Text = "Podział ";
            this.rbPodzial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbPodzial.UseVisualStyleBackColor = true;
            this.rbPodzial.CheckedChanged += new System.EventHandler(this.rbPodzial_CheckedChanged);
            // 
            // lblCzesc
            // 
            this.lblCzesc.AutoSize = true;
            this.lblCzesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblCzesc.Location = new System.Drawing.Point(213, 130);
            this.lblCzesc.Name = "lblCzesc";
            this.lblCzesc.Size = new System.Drawing.Size(41, 13);
            this.lblCzesc.TabIndex = 7;
            this.lblCzesc.Text = "Część";
            // 
            // pnlRozmiary
            // 
            this.pnlRozmiary.Controls.Add(this.rbMaly);
            this.pnlRozmiary.Controls.Add(this.rbDuzy);
            this.pnlRozmiary.Location = new System.Drawing.Point(6, 123);
            this.pnlRozmiary.Name = "pnlRozmiary";
            this.pnlRozmiary.Size = new System.Drawing.Size(100, 50);
            this.pnlRozmiary.TabIndex = 9;
            // 
            // rbMaly
            // 
            this.rbMaly.AutoSize = true;
            this.rbMaly.Location = new System.Drawing.Point(3, 26);
            this.rbMaly.Name = "rbMaly";
            this.rbMaly.Size = new System.Drawing.Size(48, 17);
            this.rbMaly.TabIndex = 1;
            this.rbMaly.TabStop = true;
            this.rbMaly.Text = "mały";
            this.rbMaly.UseVisualStyleBackColor = true;
            // 
            // rbDuzy
            // 
            this.rbDuzy.AutoSize = true;
            this.rbDuzy.Location = new System.Drawing.Point(3, 3);
            this.rbDuzy.Name = "rbDuzy";
            this.rbDuzy.Size = new System.Drawing.Size(47, 17);
            this.rbDuzy.TabIndex = 0;
            this.rbDuzy.TabStop = true;
            this.rbDuzy.Text = "duży";
            this.rbDuzy.UseVisualStyleBackColor = true;
            // 
            // gbGrzbiety
            // 
            this.gbGrzbiety.Controls.Add(this.panel1);
            this.gbGrzbiety.Controls.Add(this.txtMiesiac2);
            this.gbGrzbiety.Controls.Add(this.rbBrakPodziału);
            this.gbGrzbiety.Controls.Add(this.lblRozmiar);
            this.gbGrzbiety.Controls.Add(this.nudCzesc);
            this.gbGrzbiety.Controls.Add(this.txtMiesiac);
            this.gbGrzbiety.Controls.Add(this.pnlRozmiary);
            this.gbGrzbiety.Controls.Add(this.lblRok);
            this.gbGrzbiety.Controls.Add(this.txtRok);
            this.gbGrzbiety.Controls.Add(this.lblCzesc);
            this.gbGrzbiety.Controls.Add(this.lblMiesiac);
            this.gbGrzbiety.Controls.Add(this.txtNazwaFirmy);
            this.gbGrzbiety.Controls.Add(this.lblNazwaFirmy);
            this.gbGrzbiety.Controls.Add(this.rbPodzial);
            this.gbGrzbiety.Location = new System.Drawing.Point(3, 3);
            this.gbGrzbiety.Name = "gbGrzbiety";
            this.gbGrzbiety.Size = new System.Drawing.Size(280, 181);
            this.gbGrzbiety.TabIndex = 10;
            this.gbGrzbiety.TabStop = false;
            this.gbGrzbiety.Text = "Grzbiet n";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbZakres);
            this.panel1.Location = new System.Drawing.Point(191, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(62, 24);
            this.panel1.TabIndex = 15;
            // 
            // rbZakres
            // 
            this.rbZakres.AutoSize = true;
            this.rbZakres.Location = new System.Drawing.Point(3, 3);
            this.rbZakres.Name = "rbZakres";
            this.rbZakres.Size = new System.Drawing.Size(58, 17);
            this.rbZakres.TabIndex = 13;
            this.rbZakres.TabStop = true;
            this.rbZakres.Text = "Zakres";
            this.rbZakres.UseVisualStyleBackColor = true;
            this.rbZakres.CheckedChanged += new System.EventHandler(this.rbZakres_CheckedChanged);
            // 
            // txtMiesiac2
            // 
            this.txtMiesiac2.Enabled = false;
            this.txtMiesiac2.Location = new System.Drawing.Point(191, 38);
            this.txtMiesiac2.Name = "txtMiesiac2";
            this.txtMiesiac2.Size = new System.Drawing.Size(75, 20);
            this.txtMiesiac2.TabIndex = 14;
            // 
            // rbBrakPodziału
            // 
            this.rbBrakPodziału.AutoSize = true;
            this.rbBrakPodziału.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.3F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbBrakPodziału.Location = new System.Drawing.Point(117, 149);
            this.rbBrakPodziału.Name = "rbBrakPodziału";
            this.rbBrakPodziału.Size = new System.Drawing.Size(91, 17);
            this.rbBrakPodziału.TabIndex = 12;
            this.rbBrakPodziału.TabStop = true;
            this.rbBrakPodziału.Text = "Brak podziału";
            this.rbBrakPodziału.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBrakPodziału.UseVisualStyleBackColor = true;
            this.rbBrakPodziału.CheckedChanged += new System.EventHandler(this.rbBrakPodziału_CheckedChanged);
            // 
            // lblRozmiar
            // 
            this.lblRozmiar.AutoSize = true;
            this.lblRozmiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.471698F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblRozmiar.Location = new System.Drawing.Point(6, 107);
            this.lblRozmiar.Name = "lblRozmiar";
            this.lblRozmiar.Size = new System.Drawing.Size(52, 13);
            this.lblRozmiar.TabIndex = 11;
            this.lblRozmiar.Text = "Rozmiar";
            // 
            // nudCzesc
            // 
            this.nudCzesc.Enabled = false;
            this.nudCzesc.Location = new System.Drawing.Point(214, 146);
            this.nudCzesc.Name = "nudCzesc";
            this.nudCzesc.Size = new System.Drawing.Size(60, 20);
            this.nudCzesc.TabIndex = 10;
            // 
            // DodajGrzbiety
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbGrzbiety);
            this.Name = "DodajGrzbiety";
            this.Size = new System.Drawing.Size(286, 187);
            this.pnlRozmiary.ResumeLayout(false);
            this.pnlRozmiary.PerformLayout();
            this.gbGrzbiety.ResumeLayout(false);
            this.gbGrzbiety.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCzesc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRok;
        private System.Windows.Forms.TextBox txtRok;
        private System.Windows.Forms.TextBox txtNazwaFirmy;
        private System.Windows.Forms.Label lblNazwaFirmy;
        private System.Windows.Forms.TextBox txtMiesiac;
        private System.Windows.Forms.Label lblMiesiac;
        private System.Windows.Forms.RadioButton rbPodzial;
        private System.Windows.Forms.Label lblCzesc;
        private System.Windows.Forms.Panel pnlRozmiary;
        private System.Windows.Forms.RadioButton rbMaly;
        private System.Windows.Forms.RadioButton rbDuzy;
        private System.Windows.Forms.GroupBox gbGrzbiety;
        private System.Windows.Forms.NumericUpDown nudCzesc;
        private System.Windows.Forms.Label lblRozmiar;
        private System.Windows.Forms.RadioButton rbBrakPodziału;
        private System.Windows.Forms.TextBox txtMiesiac2;
        private System.Windows.Forms.RadioButton rbZakres;
        private System.Windows.Forms.Panel panel1;
    }
}
