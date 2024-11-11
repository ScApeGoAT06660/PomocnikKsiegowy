namespace PomocnikKsiegowy
{
    partial class Form1
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

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPaliwo = new System.Windows.Forms.TabPage();
            this.rb25 = new System.Windows.Forms.RadioButton();
            this.rb75 = new System.Windows.Forms.RadioButton();
            this.btnWynik = new System.Windows.Forms.Button();
            this.lblWynik = new System.Windows.Forms.Label();
            this.txtWynik = new System.Windows.Forms.TextBox();
            this.lblMnoznik = new System.Windows.Forms.Label();
            this.chbLeasing = new System.Windows.Forms.CheckBox();
            this.txtNetto = new System.Windows.Forms.TextBox();
            this.lblNetto = new System.Windows.Forms.Label();
            this.txtVAT = new System.Windows.Forms.TextBox();
            this.lblVAT = new System.Windows.Forms.Label();
            this.tab50 = new System.Windows.Forms.TabPage();
            this.txtWynikNaPol = new System.Windows.Forms.TextBox();
            this.lblWynikNaPol = new System.Windows.Forms.Label();
            this.txtLiczba = new System.Windows.Forms.TextBox();
            this.lblLiczba = new System.Windows.Forms.Label();
            this.btnPodziel = new System.Windows.Forms.Button();
            this.tabKalkulator = new System.Windows.Forms.TabPage();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnDodawanie = new System.Windows.Forms.Button();
            this.btnDzielenie = new System.Windows.Forms.Button();
            this.btnMnozenie = new System.Windows.Forms.Button();
            this.btnWynikKalkulator = new System.Windows.Forms.Button();
            this.btnCyfra0 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCyfra9 = new System.Windows.Forms.Button();
            this.btnCyfra8 = new System.Windows.Forms.Button();
            this.btnCyfra7 = new System.Windows.Forms.Button();
            this.btnCyfra6 = new System.Windows.Forms.Button();
            this.btnCyfra5 = new System.Windows.Forms.Button();
            this.btnCyfra4 = new System.Windows.Forms.Button();
            this.btnCyfra3 = new System.Windows.Forms.Button();
            this.btnCyfra2 = new System.Windows.Forms.Button();
            this.btnCyfra1 = new System.Windows.Forms.Button();
            this.txtWynikKalkulator = new System.Windows.Forms.TextBox();
            this.tabKopiowanie = new System.Windows.Forms.TabPage();
            this.lblSchowek = new System.Windows.Forms.Label();
            this.txtSchowek1 = new System.Windows.Forms.TextBox();
            this.txtSchowek2 = new System.Windows.Forms.TextBox();
            this.lbOpisy = new System.Windows.Forms.ListBox();
            this.lblWyciag = new System.Windows.Forms.Label();
            this.btnWczytajOpisy = new System.Windows.Forms.Button();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.tabCropper = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPaliwo.SuspendLayout();
            this.tab50.SuspendLayout();
            this.tabKalkulator.SuspendLayout();
            this.tabKopiowanie.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPaliwo);
            this.tabControl1.Controls.Add(this.tab50);
            this.tabControl1.Controls.Add(this.tabKalkulator);
            this.tabControl1.Controls.Add(this.tabKopiowanie);
            this.tabControl1.Controls.Add(this.tabCropper);
            this.tabControl1.Location = new System.Drawing.Point(8, 9);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(295, 297);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPaliwo
            // 
            this.tabPaliwo.Controls.Add(this.rb25);
            this.tabPaliwo.Controls.Add(this.rb75);
            this.tabPaliwo.Controls.Add(this.btnWynik);
            this.tabPaliwo.Controls.Add(this.lblWynik);
            this.tabPaliwo.Controls.Add(this.txtWynik);
            this.tabPaliwo.Controls.Add(this.lblMnoznik);
            this.tabPaliwo.Controls.Add(this.chbLeasing);
            this.tabPaliwo.Controls.Add(this.txtNetto);
            this.tabPaliwo.Controls.Add(this.lblNetto);
            this.tabPaliwo.Controls.Add(this.txtVAT);
            this.tabPaliwo.Controls.Add(this.lblVAT);
            this.tabPaliwo.Location = new System.Drawing.Point(4, 22);
            this.tabPaliwo.Name = "tabPaliwo";
            this.tabPaliwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPaliwo.Size = new System.Drawing.Size(287, 271);
            this.tabPaliwo.TabIndex = 0;
            this.tabPaliwo.Text = "Paliwo";
            this.tabPaliwo.UseVisualStyleBackColor = true;
            // 
            // rb25
            // 
            this.rb25.AutoSize = true;
            this.rb25.Location = new System.Drawing.Point(148, 47);
            this.rb25.Name = "rb25";
            this.rb25.Size = new System.Drawing.Size(45, 17);
            this.rb25.TabIndex = 12;
            this.rb25.TabStop = true;
            this.rb25.Text = "25%";
            this.rb25.UseVisualStyleBackColor = true;
            // 
            // rb75
            // 
            this.rb75.AutoSize = true;
            this.rb75.Location = new System.Drawing.Point(148, 23);
            this.rb75.Name = "rb75";
            this.rb75.Size = new System.Drawing.Size(45, 17);
            this.rb75.TabIndex = 11;
            this.rb75.TabStop = true;
            this.rb75.Text = "75%";
            this.rb75.UseVisualStyleBackColor = true;
            // 
            // btnWynik
            // 
            this.btnWynik.Location = new System.Drawing.Point(6, 119);
            this.btnWynik.Name = "btnWynik";
            this.btnWynik.Size = new System.Drawing.Size(75, 23);
            this.btnWynik.TabIndex = 10;
            this.btnWynik.Text = "Oblicz";
            this.btnWynik.UseVisualStyleBackColor = true;
            this.btnWynik.Click += new System.EventHandler(this.btnWczytaj);
            // 
            // lblWynik
            // 
            this.lblWynik.AutoSize = true;
            this.lblWynik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWynik.Location = new System.Drawing.Point(3, 158);
            this.lblWynik.Name = "lblWynik";
            this.lblWynik.Size = new System.Drawing.Size(42, 13);
            this.lblWynik.TabIndex = 9;
            this.lblWynik.Text = "Wynik";
            // 
            // txtWynik
            // 
            this.txtWynik.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtWynik.Location = new System.Drawing.Point(6, 174);
            this.txtWynik.Name = "txtWynik";
            this.txtWynik.Size = new System.Drawing.Size(107, 20);
            this.txtWynik.TabIndex = 8;
            // 
            // lblMnoznik
            // 
            this.lblMnoznik.AutoSize = true;
            this.lblMnoznik.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblMnoznik.Location = new System.Drawing.Point(145, 5);
            this.lblMnoznik.Name = "lblMnoznik";
            this.lblMnoznik.Size = new System.Drawing.Size(54, 13);
            this.lblMnoznik.TabIndex = 6;
            this.lblMnoznik.Text = "Mnożnik";
            // 
            // chbLeasing
            // 
            this.chbLeasing.AutoSize = true;
            this.chbLeasing.Location = new System.Drawing.Point(148, 74);
            this.chbLeasing.Name = "chbLeasing";
            this.chbLeasing.Size = new System.Drawing.Size(85, 17);
            this.chbLeasing.TabIndex = 4;
            this.chbLeasing.Text = "Czy leasing?";
            this.chbLeasing.UseVisualStyleBackColor = true;
            // 
            // txtNetto
            // 
            this.txtNetto.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.txtNetto.Location = new System.Drawing.Point(6, 71);
            this.txtNetto.Name = "txtNetto";
            this.txtNetto.Size = new System.Drawing.Size(107, 20);
            this.txtNetto.TabIndex = 3;
            // 
            // lblNetto
            // 
            this.lblNetto.AutoSize = true;
            this.lblNetto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNetto.Location = new System.Drawing.Point(3, 55);
            this.lblNetto.Name = "lblNetto";
            this.lblNetto.Size = new System.Drawing.Size(38, 13);
            this.lblNetto.TabIndex = 2;
            this.lblNetto.Text = "Netto";
            // 
            // txtVAT
            // 
            this.txtVAT.Location = new System.Drawing.Point(6, 21);
            this.txtVAT.Name = "txtVAT";
            this.txtVAT.Size = new System.Drawing.Size(107, 20);
            this.txtVAT.TabIndex = 1;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblVAT.Location = new System.Drawing.Point(3, 5);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(31, 13);
            this.lblVAT.TabIndex = 0;
            this.lblVAT.Text = "VAT";
            // 
            // tab50
            // 
            this.tab50.Controls.Add(this.txtWynikNaPol);
            this.tab50.Controls.Add(this.lblWynikNaPol);
            this.tab50.Controls.Add(this.txtLiczba);
            this.tab50.Controls.Add(this.lblLiczba);
            this.tab50.Controls.Add(this.btnPodziel);
            this.tab50.Location = new System.Drawing.Point(4, 22);
            this.tab50.Name = "tab50";
            this.tab50.Padding = new System.Windows.Forms.Padding(3);
            this.tab50.Size = new System.Drawing.Size(287, 271);
            this.tab50.TabIndex = 1;
            this.tab50.Text = "50%";
            this.tab50.UseVisualStyleBackColor = true;
            // 
            // txtWynikNaPol
            // 
            this.txtWynikNaPol.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtWynikNaPol.Location = new System.Drawing.Point(7, 77);
            this.txtWynikNaPol.Name = "txtWynikNaPol";
            this.txtWynikNaPol.Size = new System.Drawing.Size(100, 20);
            this.txtWynikNaPol.TabIndex = 4;
            // 
            // lblWynikNaPol
            // 
            this.lblWynikNaPol.AutoSize = true;
            this.lblWynikNaPol.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWynikNaPol.Location = new System.Drawing.Point(6, 61);
            this.lblWynikNaPol.Name = "lblWynikNaPol";
            this.lblWynikNaPol.Size = new System.Drawing.Size(42, 13);
            this.lblWynikNaPol.TabIndex = 3;
            this.lblWynikNaPol.Text = "Wynik";
            // 
            // txtLiczba
            // 
            this.txtLiczba.Location = new System.Drawing.Point(7, 23);
            this.txtLiczba.Name = "txtLiczba";
            this.txtLiczba.Size = new System.Drawing.Size(100, 20);
            this.txtLiczba.TabIndex = 2;
            // 
            // lblLiczba
            // 
            this.lblLiczba.AutoSize = true;
            this.lblLiczba.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblLiczba.Location = new System.Drawing.Point(6, 7);
            this.lblLiczba.Name = "lblLiczba";
            this.lblLiczba.Size = new System.Drawing.Size(44, 13);
            this.lblLiczba.TabIndex = 1;
            this.lblLiczba.Text = "Liczba";
            // 
            // btnPodziel
            // 
            this.btnPodziel.Location = new System.Drawing.Point(122, 21);
            this.btnPodziel.Name = "btnPodziel";
            this.btnPodziel.Size = new System.Drawing.Size(75, 23);
            this.btnPodziel.TabIndex = 0;
            this.btnPodziel.Text = "Podziel";
            this.btnPodziel.UseVisualStyleBackColor = true;
            this.btnPodziel.Click += new System.EventHandler(this.btnPodziel_Click);
            // 
            // tabKalkulator
            // 
            this.tabKalkulator.Controls.Add(this.btnMinus);
            this.tabKalkulator.Controls.Add(this.btnDodawanie);
            this.tabKalkulator.Controls.Add(this.btnDzielenie);
            this.tabKalkulator.Controls.Add(this.btnMnozenie);
            this.tabKalkulator.Controls.Add(this.btnWynikKalkulator);
            this.tabKalkulator.Controls.Add(this.btnCyfra0);
            this.tabKalkulator.Controls.Add(this.btnClear);
            this.tabKalkulator.Controls.Add(this.btnCyfra9);
            this.tabKalkulator.Controls.Add(this.btnCyfra8);
            this.tabKalkulator.Controls.Add(this.btnCyfra7);
            this.tabKalkulator.Controls.Add(this.btnCyfra6);
            this.tabKalkulator.Controls.Add(this.btnCyfra5);
            this.tabKalkulator.Controls.Add(this.btnCyfra4);
            this.tabKalkulator.Controls.Add(this.btnCyfra3);
            this.tabKalkulator.Controls.Add(this.btnCyfra2);
            this.tabKalkulator.Controls.Add(this.btnCyfra1);
            this.tabKalkulator.Controls.Add(this.txtWynikKalkulator);
            this.tabKalkulator.Location = new System.Drawing.Point(4, 22);
            this.tabKalkulator.Name = "tabKalkulator";
            this.tabKalkulator.Padding = new System.Windows.Forms.Padding(3);
            this.tabKalkulator.Size = new System.Drawing.Size(287, 271);
            this.tabKalkulator.TabIndex = 2;
            this.tabKalkulator.Text = "Kalkulator";
            this.tabKalkulator.UseVisualStyleBackColor = true;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(210, 208);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(50, 50);
            this.btnMinus.TabIndex = 16;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnDodawanie
            // 
            this.btnDodawanie.Location = new System.Drawing.Point(210, 152);
            this.btnDodawanie.Name = "btnDodawanie";
            this.btnDodawanie.Size = new System.Drawing.Size(50, 50);
            this.btnDodawanie.TabIndex = 15;
            this.btnDodawanie.Text = "+";
            this.btnDodawanie.UseVisualStyleBackColor = true;
            this.btnDodawanie.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnDzielenie
            // 
            this.btnDzielenie.Location = new System.Drawing.Point(210, 96);
            this.btnDzielenie.Name = "btnDzielenie";
            this.btnDzielenie.Size = new System.Drawing.Size(50, 50);
            this.btnDzielenie.TabIndex = 14;
            this.btnDzielenie.Text = "/";
            this.btnDzielenie.UseVisualStyleBackColor = true;
            this.btnDzielenie.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnMnozenie
            // 
            this.btnMnozenie.Location = new System.Drawing.Point(210, 40);
            this.btnMnozenie.Name = "btnMnozenie";
            this.btnMnozenie.Size = new System.Drawing.Size(50, 50);
            this.btnMnozenie.TabIndex = 13;
            this.btnMnozenie.Text = "*";
            this.btnMnozenie.UseVisualStyleBackColor = true;
            this.btnMnozenie.Click += new System.EventHandler(this.btnOperator_Click);
            // 
            // btnWynikKalkulator
            // 
            this.btnWynikKalkulator.Location = new System.Drawing.Point(133, 209);
            this.btnWynikKalkulator.Name = "btnWynikKalkulator";
            this.btnWynikKalkulator.Size = new System.Drawing.Size(50, 50);
            this.btnWynikKalkulator.TabIndex = 12;
            this.btnWynikKalkulator.Text = "=";
            this.btnWynikKalkulator.UseVisualStyleBackColor = true;
            this.btnWynikKalkulator.Click += new System.EventHandler(this.btnWynikKalkulator_Click);
            // 
            // btnCyfra0
            // 
            this.btnCyfra0.Location = new System.Drawing.Point(77, 209);
            this.btnCyfra0.Name = "btnCyfra0";
            this.btnCyfra0.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra0.TabIndex = 11;
            this.btnCyfra0.Text = "0";
            this.btnCyfra0.UseVisualStyleBackColor = true;
            this.btnCyfra0.Click += new System.EventHandler(this.btnLiczba);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnClear.Location = new System.Drawing.Point(21, 209);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(50, 50);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCyfra9
            // 
            this.btnCyfra9.Location = new System.Drawing.Point(133, 152);
            this.btnCyfra9.Name = "btnCyfra9";
            this.btnCyfra9.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra9.TabIndex = 9;
            this.btnCyfra9.Text = "9";
            this.btnCyfra9.UseVisualStyleBackColor = true;
            this.btnCyfra9.Click += new System.EventHandler(this.btnLiczba);
            // 
            // btnCyfra8
            // 
            this.btnCyfra8.Location = new System.Drawing.Point(77, 152);
            this.btnCyfra8.Name = "btnCyfra8";
            this.btnCyfra8.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra8.TabIndex = 8;
            this.btnCyfra8.Text = "8";
            this.btnCyfra8.UseVisualStyleBackColor = true;
            this.btnCyfra8.Click += new System.EventHandler(this.btnLiczba);
            // 
            // btnCyfra7
            // 
            this.btnCyfra7.Location = new System.Drawing.Point(21, 152);
            this.btnCyfra7.Name = "btnCyfra7";
            this.btnCyfra7.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra7.TabIndex = 7;
            this.btnCyfra7.Text = "7";
            this.btnCyfra7.UseVisualStyleBackColor = true;
            this.btnCyfra7.Click += new System.EventHandler(this.btnLiczba);
            // 
            // btnCyfra6
            // 
            this.btnCyfra6.Location = new System.Drawing.Point(133, 96);
            this.btnCyfra6.Name = "btnCyfra6";
            this.btnCyfra6.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra6.TabIndex = 6;
            this.btnCyfra6.Text = "6";
            this.btnCyfra6.UseVisualStyleBackColor = true;
            this.btnCyfra6.Click += new System.EventHandler(this.btnLiczba);
            // 
            // btnCyfra5
            // 
            this.btnCyfra5.Location = new System.Drawing.Point(77, 96);
            this.btnCyfra5.Name = "btnCyfra5";
            this.btnCyfra5.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra5.TabIndex = 5;
            this.btnCyfra5.Text = "5";
            this.btnCyfra5.UseVisualStyleBackColor = true;
            this.btnCyfra5.Click += new System.EventHandler(this.btnLiczba);
            // 
            // btnCyfra4
            // 
            this.btnCyfra4.Location = new System.Drawing.Point(21, 96);
            this.btnCyfra4.Name = "btnCyfra4";
            this.btnCyfra4.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra4.TabIndex = 4;
            this.btnCyfra4.Text = "4";
            this.btnCyfra4.UseVisualStyleBackColor = true;
            this.btnCyfra4.Click += new System.EventHandler(this.btnLiczba);
            // 
            // btnCyfra3
            // 
            this.btnCyfra3.Location = new System.Drawing.Point(133, 40);
            this.btnCyfra3.Name = "btnCyfra3";
            this.btnCyfra3.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra3.TabIndex = 3;
            this.btnCyfra3.Text = "3";
            this.btnCyfra3.UseVisualStyleBackColor = true;
            this.btnCyfra3.Click += new System.EventHandler(this.btnLiczba);
            // 
            // btnCyfra2
            // 
            this.btnCyfra2.Location = new System.Drawing.Point(77, 40);
            this.btnCyfra2.Name = "btnCyfra2";
            this.btnCyfra2.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra2.TabIndex = 2;
            this.btnCyfra2.Text = "2";
            this.btnCyfra2.UseVisualStyleBackColor = true;
            this.btnCyfra2.Click += new System.EventHandler(this.btnLiczba);
            // 
            // btnCyfra1
            // 
            this.btnCyfra1.Location = new System.Drawing.Point(21, 40);
            this.btnCyfra1.Name = "btnCyfra1";
            this.btnCyfra1.Size = new System.Drawing.Size(50, 50);
            this.btnCyfra1.TabIndex = 1;
            this.btnCyfra1.Text = "1";
            this.btnCyfra1.UseVisualStyleBackColor = true;
            this.btnCyfra1.Click += new System.EventHandler(this.btnLiczba);
            // 
            // txtWynikKalkulator
            // 
            this.txtWynikKalkulator.BackColor = System.Drawing.Color.MistyRose;
            this.txtWynikKalkulator.Location = new System.Drawing.Point(21, 13);
            this.txtWynikKalkulator.Name = "txtWynikKalkulator";
            this.txtWynikKalkulator.Size = new System.Drawing.Size(239, 20);
            this.txtWynikKalkulator.TabIndex = 0;
            // 
            // tabKopiowanie
            // 
            this.tabKopiowanie.Controls.Add(this.btnDodaj);
            this.tabKopiowanie.Controls.Add(this.btnWczytajOpisy);
            this.tabKopiowanie.Controls.Add(this.lblWyciag);
            this.tabKopiowanie.Controls.Add(this.lbOpisy);
            this.tabKopiowanie.Controls.Add(this.txtSchowek2);
            this.tabKopiowanie.Controls.Add(this.txtSchowek1);
            this.tabKopiowanie.Controls.Add(this.lblSchowek);
            this.tabKopiowanie.Location = new System.Drawing.Point(4, 22);
            this.tabKopiowanie.Name = "tabKopiowanie";
            this.tabKopiowanie.Padding = new System.Windows.Forms.Padding(3);
            this.tabKopiowanie.Size = new System.Drawing.Size(287, 271);
            this.tabKopiowanie.TabIndex = 3;
            this.tabKopiowanie.Text = "Kopiowanie";
            this.tabKopiowanie.UseVisualStyleBackColor = true;
            // 
            // lblSchowek
            // 
            this.lblSchowek.AutoSize = true;
            this.lblSchowek.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblSchowek.Location = new System.Drawing.Point(7, 7);
            this.lblSchowek.Name = "lblSchowek";
            this.lblSchowek.Size = new System.Drawing.Size(59, 13);
            this.lblSchowek.TabIndex = 0;
            this.lblSchowek.Text = "Schowek";
            // 
            // txtSchowek1
            // 
            this.txtSchowek1.Location = new System.Drawing.Point(10, 24);
            this.txtSchowek1.Name = "txtSchowek1";
            this.txtSchowek1.Size = new System.Drawing.Size(262, 20);
            this.txtSchowek1.TabIndex = 1;
            // 
            // txtSchowek2
            // 
            this.txtSchowek2.Location = new System.Drawing.Point(10, 50);
            this.txtSchowek2.Name = "txtSchowek2";
            this.txtSchowek2.Size = new System.Drawing.Size(262, 20);
            this.txtSchowek2.TabIndex = 2;
            // 
            // lbOpisy
            // 
            this.lbOpisy.FormattingEnabled = true;
            this.lbOpisy.Location = new System.Drawing.Point(10, 97);
            this.lbOpisy.Name = "lbOpisy";
            this.lbOpisy.Size = new System.Drawing.Size(181, 160);
            this.lbOpisy.TabIndex = 3;
            this.lbOpisy.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbOpisy_KeyDown);
            // 
            // lblWyciag
            // 
            this.lblWyciag.AutoSize = true;
            this.lblWyciag.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblWyciag.Location = new System.Drawing.Point(7, 81);
            this.lblWyciag.Name = "lblWyciag";
            this.lblWyciag.Size = new System.Drawing.Size(90, 13);
            this.lblWyciag.TabIndex = 4;
            this.lblWyciag.Text = "Wyciąg - opisy";
            // 
            // btnWczytajOpisy
            // 
            this.btnWczytajOpisy.Location = new System.Drawing.Point(197, 97);
            this.btnWczytajOpisy.Name = "btnWczytajOpisy";
            this.btnWczytajOpisy.Size = new System.Drawing.Size(75, 23);
            this.btnWczytajOpisy.TabIndex = 5;
            this.btnWczytajOpisy.Text = "Wczytaj";
            this.btnWczytajOpisy.UseVisualStyleBackColor = true;
            this.btnWczytajOpisy.Click += new System.EventHandler(this.btnWczytajOpisy_Click);
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(197, 126);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 6;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            // 
            // tabCropper
            // 
            this.tabCropper.Location = new System.Drawing.Point(4, 22);
            this.tabCropper.Name = "tabCropper";
            this.tabCropper.Padding = new System.Windows.Forms.Padding(3);
            this.tabCropper.Size = new System.Drawing.Size(287, 271);
            this.tabCropper.TabIndex = 4;
            this.tabCropper.Text = "PDF Cropper";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 318);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Pomocnik ";
            this.tabControl1.ResumeLayout(false);
            this.tabPaliwo.ResumeLayout(false);
            this.tabPaliwo.PerformLayout();
            this.tab50.ResumeLayout(false);
            this.tab50.PerformLayout();
            this.tabKalkulator.ResumeLayout(false);
            this.tabKalkulator.PerformLayout();
            this.tabKopiowanie.ResumeLayout(false);
            this.tabKopiowanie.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPaliwo;
        private System.Windows.Forms.TabPage tab50;
        private System.Windows.Forms.TabPage tabKalkulator;
        private System.Windows.Forms.TabPage tabKopiowanie;
        private System.Windows.Forms.TextBox txtNetto;
        private System.Windows.Forms.Label lblNetto;
        private System.Windows.Forms.TextBox txtVAT;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblWynik;
        private System.Windows.Forms.TextBox txtWynik;
        private System.Windows.Forms.Label lblMnoznik;
        private System.Windows.Forms.CheckBox chbLeasing;
        private System.Windows.Forms.Button btnWynik;
        private System.Windows.Forms.RadioButton rb25;
        private System.Windows.Forms.RadioButton rb75;
        private System.Windows.Forms.TextBox txtWynikNaPol;
        private System.Windows.Forms.Label lblWynikNaPol;
        private System.Windows.Forms.TextBox txtLiczba;
        private System.Windows.Forms.Label lblLiczba;
        private System.Windows.Forms.Button btnPodziel;
        private System.Windows.Forms.Button btnCyfra1;
        private System.Windows.Forms.TextBox txtWynikKalkulator;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnDodawanie;
        private System.Windows.Forms.Button btnDzielenie;
        private System.Windows.Forms.Button btnMnozenie;
        private System.Windows.Forms.Button btnWynikKalkulator;
        private System.Windows.Forms.Button btnCyfra0;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCyfra9;
        private System.Windows.Forms.Button btnCyfra8;
        private System.Windows.Forms.Button btnCyfra7;
        private System.Windows.Forms.Button btnCyfra6;
        private System.Windows.Forms.Button btnCyfra5;
        private System.Windows.Forms.Button btnCyfra4;
        private System.Windows.Forms.Button btnCyfra3;
        private System.Windows.Forms.Button btnCyfra2;
        private System.Windows.Forms.Label lblWyciag;
        private System.Windows.Forms.ListBox lbOpisy;
        private System.Windows.Forms.TextBox txtSchowek2;
        private System.Windows.Forms.TextBox txtSchowek1;
        private System.Windows.Forms.Label lblSchowek;
        private System.Windows.Forms.Button btnWczytajOpisy;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TabPage tabCropper;
    }
}

