namespace Appvente
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdentifiant = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbProfil = new System.Windows.Forms.ComboBox();
            this.dgUtilisateur = new System.Windows.Forms.DataGridView();
            this.btnBloquer = new System.Windows.Forms.Button();
            this.btnCreer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Identifiant";
            // 
            // txtIdentifiant
            // 
            this.txtIdentifiant.Location = new System.Drawing.Point(76, 63);
            this.txtIdentifiant.Name = "txtIdentifiant";
            this.txtIdentifiant.Size = new System.Drawing.Size(262, 24);
            this.txtIdentifiant.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(76, 162);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(262, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Profil";
            // 
            // cbbProfil
            // 
            this.cbbProfil.FormattingEnabled = true;
            this.cbbProfil.Location = new System.Drawing.Point(76, 265);
            this.cbbProfil.Name = "cbbProfil";
            this.cbbProfil.Size = new System.Drawing.Size(262, 26);
            this.cbbProfil.TabIndex = 5;
            // 
            // dgUtilisateur
            // 
            this.dgUtilisateur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgUtilisateur.Location = new System.Drawing.Point(408, 63);
            this.dgUtilisateur.Name = "dgUtilisateur";
            this.dgUtilisateur.Size = new System.Drawing.Size(301, 338);
            this.dgUtilisateur.TabIndex = 6;
            // 
            // btnBloquer
            // 
            this.btnBloquer.Location = new System.Drawing.Point(160, 366);
            this.btnBloquer.Name = "btnBloquer";
            this.btnBloquer.Size = new System.Drawing.Size(178, 35);
            this.btnBloquer.TabIndex = 7;
            this.btnBloquer.Text = "&Bloquer/Debloquer";
            this.btnBloquer.UseVisualStyleBackColor = true;
            // 
            // btnCreer
            // 
            this.btnCreer.Location = new System.Drawing.Point(160, 324);
            this.btnCreer.Name = "btnCreer";
            this.btnCreer.Size = new System.Drawing.Size(178, 36);
            this.btnCreer.TabIndex = 8;
            this.btnCreer.Text = "&Creer";
            this.btnCreer.UseVisualStyleBackColor = true;
            this.btnCreer.Click += new System.EventHandler(this.btnCreer_Click);
            // 
            // frmUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 476);
            this.ControlBox = false;
            this.Controls.Add(this.btnCreer);
            this.Controls.Add(this.btnBloquer);
            this.Controls.Add(this.dgUtilisateur);
            this.Controls.Add(this.cbbProfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdentifiant);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmUtilisateur";
            this.Text = "Utilisateur";
            this.Load += new System.EventHandler(this.frmUtilisateur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgUtilisateur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdentifiant;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbProfil;
        private System.Windows.Forms.DataGridView dgUtilisateur;
        private System.Windows.Forms.Button btnBloquer;
        private System.Windows.Forms.Button btnCreer;
    }
}