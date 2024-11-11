namespace PomocnikKsiegowy
{
    partial class Form2
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
            this.lblNowyOpis = new System.Windows.Forms.Label();
            this.txtNowyOpis = new System.Windows.Forms.TextBox();
            this.btnZapisz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNowyOpis
            // 
            this.lblNowyOpis.AutoSize = true;
            this.lblNowyOpis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblNowyOpis.Location = new System.Drawing.Point(4, 4);
            this.lblNowyOpis.Name = "lblNowyOpis";
            this.lblNowyOpis.Size = new System.Drawing.Size(67, 13);
            this.lblNowyOpis.TabIndex = 0;
            this.lblNowyOpis.Text = "Nowy Opis";
            // 
            // txtNowyOpis
            // 
            this.txtNowyOpis.Location = new System.Drawing.Point(7, 21);
            this.txtNowyOpis.Name = "txtNowyOpis";
            this.txtNowyOpis.Size = new System.Drawing.Size(197, 20);
            this.txtNowyOpis.TabIndex = 1;
            // 
            // btnZapisz
            // 
            this.btnZapisz.Location = new System.Drawing.Point(70, 47);
            this.btnZapisz.Name = "btnZapisz";
            this.btnZapisz.Size = new System.Drawing.Size(75, 23);
            this.btnZapisz.TabIndex = 2;
            this.btnZapisz.Text = "Zapisz";
            this.btnZapisz.UseVisualStyleBackColor = true;
            this.btnZapisz.Click += new System.EventHandler(this.btnZapisz_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 79);
            this.Controls.Add(this.btnZapisz);
            this.Controls.Add(this.txtNowyOpis);
            this.Controls.Add(this.lblNowyOpis);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNowyOpis;
        private System.Windows.Forms.TextBox txtNowyOpis;
        private System.Windows.Forms.Button btnZapisz;
    }
}