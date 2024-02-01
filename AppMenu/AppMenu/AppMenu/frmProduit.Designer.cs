namespace AppMenu
{
    partial class frmProduit
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
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtDesignation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrixUnitaire = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantiteMinimal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtQuantiteCritique = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbCategorie = new System.Windows.Forms.ComboBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgProduit
            // 
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(350, 51);
            this.dgProduit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.Size = new System.Drawing.Size(811, 535);
            this.dgProduit.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(15, 98);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(280, 24);
            this.txtCode.TabIndex = 1;
            // 
            // txtDesignation
            // 
            this.txtDesignation.Location = new System.Drawing.Point(15, 156);
            this.txtDesignation.Name = "txtDesignation";
            this.txtDesignation.Size = new System.Drawing.Size(280, 24);
            this.txtDesignation.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designation";
            // 
            // txtPrixUnitaire
            // 
            this.txtPrixUnitaire.Location = new System.Drawing.Point(15, 218);
            this.txtPrixUnitaire.Name = "txtPrixUnitaire";
            this.txtPrixUnitaire.Size = new System.Drawing.Size(280, 24);
            this.txtPrixUnitaire.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prix Unitaire";
            // 
            // txtQuantiteMinimal
            // 
            this.txtQuantiteMinimal.Location = new System.Drawing.Point(15, 281);
            this.txtQuantiteMinimal.Name = "txtQuantiteMinimal";
            this.txtQuantiteMinimal.Size = new System.Drawing.Size(280, 24);
            this.txtQuantiteMinimal.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantite Minimal";
            // 
            // txtQuantiteCritique
            // 
            this.txtQuantiteCritique.Location = new System.Drawing.Point(15, 343);
            this.txtQuantiteCritique.Name = "txtQuantiteCritique";
            this.txtQuantiteCritique.Size = new System.Drawing.Size(280, 24);
            this.txtQuantiteCritique.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quantite critique";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 387);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 11;
            this.label6.Text = "Categorie";
            // 
            // cbbCategorie
            // 
            this.cbbCategorie.FormattingEnabled = true;
            this.cbbCategorie.ItemHeight = 18;
            this.cbbCategorie.Location = new System.Drawing.Point(15, 409);
            this.cbbCategorie.Name = "cbbCategorie";
            this.cbbCategorie.Size = new System.Drawing.Size(280, 26);
            this.cbbCategorie.TabIndex = 6;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(181, 35);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(113, 27);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "S&elect";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(181, 456);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(113, 30);
            this.btnAjouter.TabIndex = 8;
            this.btnAjouter.Text = "A&jouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(181, 503);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(113, 28);
            this.btnModifier.TabIndex = 9;
            this.btnModifier.Text = "M&odifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(181, 548);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(113, 28);
            this.btnSupprimer.TabIndex = 10;
            this.btnSupprimer.Text = "S&upprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 621);
            this.ControlBox = false;
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cbbCategorie);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQuantiteCritique);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtQuantiteMinimal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPrixUnitaire);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDesignation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgProduit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmProduit";
            this.Text = "frmProduit";
            this.Load += new System.EventHandler(this.frmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtDesignation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrixUnitaire;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantiteMinimal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantiteCritique;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbCategorie;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSupprimer;
    }
}