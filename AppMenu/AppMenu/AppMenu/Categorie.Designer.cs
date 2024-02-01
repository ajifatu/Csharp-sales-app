namespace AppMenu
{
    partial class frmCategorie
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
            this.dgCategorie = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSuuprimer = new System.Windows.Forms.Button();
            this.btnSelectionner = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // dgCategorie
            // 
            this.dgCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorie.Location = new System.Drawing.Point(360, 0);
            this.dgCategorie.Name = "dgCategorie";
            this.dgCategorie.Size = new System.Drawing.Size(464, 430);
            this.dgCategorie.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Code";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(33, 119);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(283, 24);
            this.txtCode.TabIndex = 1;
            // 
            // txtLibelle
            // 
            this.txtLibelle.Location = new System.Drawing.Point(33, 202);
            this.txtLibelle.Name = "txtLibelle";
            this.txtLibelle.Size = new System.Drawing.Size(283, 24);
            this.txtLibelle.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Libelle";
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(199, 254);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(117, 32);
            this.btnAjouter.TabIndex = 4;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(199, 297);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(117, 32);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSuuprimer
            // 
            this.btnSuuprimer.Location = new System.Drawing.Point(199, 340);
            this.btnSuuprimer.Name = "btnSuuprimer";
            this.btnSuuprimer.Size = new System.Drawing.Size(117, 32);
            this.btnSuuprimer.TabIndex = 6;
            this.btnSuuprimer.Text = "&Supprimer";
            this.btnSuuprimer.UseVisualStyleBackColor = true;
            this.btnSuuprimer.Click += new System.EventHandler(this.btnSuuprimer_Click);
            // 
            // btnSelectionner
            // 
            this.btnSelectionner.Location = new System.Drawing.Point(199, 22);
            this.btnSelectionner.Name = "btnSelectionner";
            this.btnSelectionner.Size = new System.Drawing.Size(117, 32);
            this.btnSelectionner.TabIndex = 3;
            this.btnSelectionner.Text = "S&electionner";
            this.btnSelectionner.UseVisualStyleBackColor = true;
            this.btnSelectionner.Click += new System.EventHandler(this.btnSelectionner_Click);
            // 
            // frmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(823, 429);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelectionner);
            this.Controls.Add(this.btnSuuprimer);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.txtLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgCategorie);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCategorie";
            this.Text = "Categorie";
            this.Load += new System.EventHandler(this.frmCategorie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgCategorie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSuuprimer;
        private System.Windows.Forms.Button btnSelectionner;
    }
}