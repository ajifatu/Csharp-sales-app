namespace AppMenu
{
    partial class frmUtilisateur
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
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.Identifiant = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.Profil = new System.Windows.Forms.Label();
            this.cbbProfil = new System.Windows.Forms.ComboBox();
            this.btnCreer = new System.Windows.Forms.Button();
            this.btnChangerStatut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(311, 4);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.Size = new System.Drawing.Size(496, 540);
            this.dgUtilisateur.TabIndex = 0;
            // 
            // Identifiant
            // 
            this.Identifiant.AutoSize = true;
            this.Identifiant.Location = new System.Drawing.Point(13, 80);
            this.Identifiant.Name = "Identifiant";
            this.Identifiant.Size = new System.Drawing.Size(69, 18);
            this.Identifiant.TabIndex = 1;
            this.Identifiant.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(16, 111);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(253, 24);
            this.txtIdentifiant.TabIndex = 2;
            // 
            // Profil
            // 
            this.Profil.AutoSize = true;
            this.Profil.Location = new System.Drawing.Point(16, 176);
            this.Profil.Name = "Profil";
            this.Profil.Size = new System.Drawing.Size(42, 18);
            this.Profil.TabIndex = 3;
            this.Profil.Text = "Profil";
            // 
            // cbbProfil
            // 
            this.cbbProfil.FormattingEnabled = true;
            this.cbbProfil.Location = new System.Drawing.Point(19, 207);
            this.cbbProfil.Name = "cbbProfil";
            this.cbbProfil.Size = new System.Drawing.Size(250, 26);
            this.cbbProfil.TabIndex = 4;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(101, 270);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(168, 36);
            this.btnCreer.TabIndex = 5;
            this.btnCreer.Text = "Creer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // btnChangerStatut
            // 
            this.btnChangerStatut.Location = new System.Drawing.Point(101, 332);
            this.btnChangerStatut.Name = "btnChangerStatut";
            this.btnChangerStatut.Size = new System.Drawing.Size(168, 36);
            this.btnChangerStatut.TabIndex = 6;
            this.btnChangerStatut.Text = "&Changer Statut";
            this.btnChangerStatut.UseVisualStyleBackColor = true;
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 623);
            this.ControlBox = false;
            this.Controls.Add(this.btnChangerStatut);
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.cbbProfil);
            this.Controls.Add(this.Profil);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.Identifiant);
            this.Controls.Add(this.dgUtilisateur);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUtilisateur";
            this.Text = "frmUtilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.Label Identifiant;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.Label Profil;
        private System.Windows.Forms.ComboBox cbbProfil;
        private System.Windows.Forms.Button btnCreer;
        private System.Windows.Forms.Button btnChangerStatut;
    }
}