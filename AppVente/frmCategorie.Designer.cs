namespace AppVente
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
            this.code = new System.Windows.Forms.Label();
            this.textCode = new System.Windows.Forms.TextBox();
            this.textLibelle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnSup = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.dgCategorie = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).BeginInit();
            this.SuspendLayout();
            // 
            // code
            // 
            this.code.AutoSize = true;
            this.code.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code.Location = new System.Drawing.Point(12, 26);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(41, 18);
            this.code.TabIndex = 0;
            this.code.Text = "code";
            // 
            // textCode
            // 
            this.textCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCode.Location = new System.Drawing.Point(12, 47);
            this.textCode.Multiline = true;
            this.textCode.Name = "textCode";
            this.textCode.Size = new System.Drawing.Size(338, 38);
            this.textCode.TabIndex = 1;
            // 
            // textLibelle
            // 
            this.textLibelle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textLibelle.Location = new System.Drawing.Point(9, 125);
            this.textLibelle.Multiline = true;
            this.textLibelle.Name = "textLibelle";
            this.textLibelle.Size = new System.Drawing.Size(341, 34);
            this.textLibelle.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Libellé";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjout.Location = new System.Drawing.Point(202, 188);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(104, 37);
            this.btnAjout.TabIndex = 4;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifier.Location = new System.Drawing.Point(202, 249);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(104, 37);
            this.btnModifier.TabIndex = 5;
            this.btnModifier.Text = "Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnSup
            // 
            this.btnSup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSup.Location = new System.Drawing.Point(202, 315);
            this.btnSup.Name = "btnSup";
            this.btnSup.Size = new System.Drawing.Size(104, 37);
            this.btnSup.TabIndex = 6;
            this.btnSup.Text = "Supprimer";
            this.btnSup.UseVisualStyleBackColor = true;
            this.btnSup.Click += new System.EventHandler(this.btnSup_Click);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(302, 1);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(104, 37);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Sélectionner";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // dgCategorie
            // 
            this.dgCategorie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCategorie.Location = new System.Drawing.Point(453, 1);
            this.dgCategorie.Name = "dgCategorie";
            this.dgCategorie.Size = new System.Drawing.Size(583, 351);
            this.dgCategorie.TabIndex = 8;
            // 
            // frmCategorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 379);
            this.ControlBox = false;
            this.Controls.Add(this.dgCategorie);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSup);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.textLibelle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textCode);
            this.Controls.Add(this.code);
            this.Name = "frmCategorie";
            this.Text = "Categorie";
            ((System.ComponentModel.ISupportInitialize)(this.dgCategorie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label code;
        private System.Windows.Forms.TextBox textCode;
        private System.Windows.Forms.TextBox textLibelle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnSup;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridView dgCategorie;
    }
}