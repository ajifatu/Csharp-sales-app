namespace AppVente
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
            this.id = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdesignation = new System.Windows.Forms.TextBox();
            this.designation = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.description = new System.Windows.Forms.Label();
            this.txtcodeP = new System.Windows.Forms.TextBox();
            this.CodeProduit = new System.Windows.Forms.Label();
            this.txtprixP = new System.Windows.Forms.TextBox();
            this.PrixProduit = new System.Windows.Forms.Label();
            this.dgProduit = new System.Windows.Forms.DataGridView();
            this.txtqteMin = new System.Windows.Forms.TextBox();
            this.QteMin = new System.Windows.Forms.Label();
            this.txtqteCritique = new System.Windows.Forms.TextBox();
            this.QteCritique = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnrechercher = new System.Windows.Forms.Button();
            this.txtRDesignation = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategorie = new System.Windows.Forms.TextBox();
            this.Categorie = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).BeginInit();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(12, 23);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(22, 18);
            this.id.TabIndex = 1;
            this.id.Text = "ID";
            // 
            // txtid
            // 
            this.txtid.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid.Location = new System.Drawing.Point(12, 44);
            this.txtid.Multiline = true;
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(187, 26);
            this.txtid.TabIndex = 2;
            // 
            // txtdesignation
            // 
            this.txtdesignation.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtdesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdesignation.Location = new System.Drawing.Point(12, 94);
            this.txtdesignation.Multiline = true;
            this.txtdesignation.Name = "txtdesignation";
            this.txtdesignation.Size = new System.Drawing.Size(187, 26);
            this.txtdesignation.TabIndex = 4;
            this.txtdesignation.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // designation
            // 
            this.designation.AutoSize = true;
            this.designation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.designation.Location = new System.Drawing.Point(12, 73);
            this.designation.Name = "designation";
            this.designation.Size = new System.Drawing.Size(86, 18);
            this.designation.TabIndex = 3;
            this.designation.Text = "Designation";
            // 
            // txtdescription
            // 
            this.txtdescription.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(12, 144);
            this.txtdescription.Multiline = true;
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(187, 45);
            this.txtdescription.TabIndex = 6;
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.Location = new System.Drawing.Point(12, 123);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(83, 18);
            this.description.TabIndex = 5;
            this.description.Text = "Description";
            this.description.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtcodeP
            // 
            this.txtcodeP.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtcodeP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcodeP.Location = new System.Drawing.Point(12, 213);
            this.txtcodeP.Multiline = true;
            this.txtcodeP.Name = "txtcodeP";
            this.txtcodeP.Size = new System.Drawing.Size(187, 26);
            this.txtcodeP.TabIndex = 8;
            // 
            // CodeProduit
            // 
            this.CodeProduit.AutoSize = true;
            this.CodeProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeProduit.Location = new System.Drawing.Point(12, 192);
            this.CodeProduit.Name = "CodeProduit";
            this.CodeProduit.Size = new System.Drawing.Size(95, 18);
            this.CodeProduit.TabIndex = 7;
            this.CodeProduit.Text = "Code Produit";
            // 
            // txtprixP
            // 
            this.txtprixP.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtprixP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprixP.Location = new System.Drawing.Point(12, 263);
            this.txtprixP.Multiline = true;
            this.txtprixP.Name = "txtprixP";
            this.txtprixP.Size = new System.Drawing.Size(187, 26);
            this.txtprixP.TabIndex = 10;
            // 
            // PrixProduit
            // 
            this.PrixProduit.AutoSize = true;
            this.PrixProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrixProduit.Location = new System.Drawing.Point(12, 242);
            this.PrixProduit.Name = "PrixProduit";
            this.PrixProduit.Size = new System.Drawing.Size(84, 18);
            this.PrixProduit.TabIndex = 9;
            this.PrixProduit.Text = "Prix Produit";
            // 
            // dgProduit
            // 
            this.dgProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProduit.Location = new System.Drawing.Point(227, 55);
            this.dgProduit.Name = "dgProduit";
            this.dgProduit.Size = new System.Drawing.Size(561, 493);
            this.dgProduit.TabIndex = 0;
            this.dgProduit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtqteMin
            // 
            this.txtqteMin.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtqteMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqteMin.Location = new System.Drawing.Point(12, 313);
            this.txtqteMin.Multiline = true;
            this.txtqteMin.Name = "txtqteMin";
            this.txtqteMin.Size = new System.Drawing.Size(187, 26);
            this.txtqteMin.TabIndex = 12;
            // 
            // QteMin
            // 
            this.QteMin.AutoSize = true;
            this.QteMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QteMin.Location = new System.Drawing.Point(12, 292);
            this.QteMin.Name = "QteMin";
            this.QteMin.Size = new System.Drawing.Size(126, 18);
            this.QteMin.TabIndex = 11;
            this.QteMin.Text = "Quantite Minimale";
            // 
            // txtqteCritique
            // 
            this.txtqteCritique.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtqteCritique.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtqteCritique.Location = new System.Drawing.Point(12, 363);
            this.txtqteCritique.Multiline = true;
            this.txtqteCritique.Name = "txtqteCritique";
            this.txtqteCritique.Size = new System.Drawing.Size(187, 26);
            this.txtqteCritique.TabIndex = 14;
            // 
            // QteCritique
            // 
            this.QteCritique.AutoSize = true;
            this.QteCritique.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QteCritique.Location = new System.Drawing.Point(12, 342);
            this.QteCritique.Name = "QteCritique";
            this.QteCritique.Size = new System.Drawing.Size(117, 18);
            this.QteCritique.TabIndex = 13;
            this.QteCritique.Text = "Quantite Critique";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(117, 449);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 15;
            this.button1.Text = "Ajouter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(12, 468);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 34);
            this.button2.TabIndex = 16;
            this.button2.Text = "Modifier";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(15, 508);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(101, 31);
            this.button3.TabIndex = 17;
            this.button3.Text = "Supprimer";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(120, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(101, 31);
            this.button4.TabIndex = 18;
            this.button4.Text = "Sélectionner";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnrechercher
            // 
            this.btnrechercher.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrechercher.Location = new System.Drawing.Point(687, 7);
            this.btnrechercher.Name = "btnrechercher";
            this.btnrechercher.Size = new System.Drawing.Size(101, 31);
            this.btnrechercher.TabIndex = 23;
            this.btnrechercher.Text = "Rechercher";
            this.btnrechercher.UseVisualStyleBackColor = true;
            this.btnrechercher.Click += new System.EventHandler(this.btnrechercher_Click);
            // 
            // txtRDesignation
            // 
            this.txtRDesignation.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtRDesignation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRDesignation.Location = new System.Drawing.Point(440, 20);
            this.txtRDesignation.Multiline = true;
            this.txtRDesignation.Name = "txtRDesignation";
            this.txtRDesignation.Size = new System.Drawing.Size(187, 26);
            this.txtRDesignation.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(437, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "Designation";
            // 
            // txtRCode
            // 
            this.txtRCode.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtRCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRCode.Location = new System.Drawing.Point(244, 20);
            this.txtRCode.Multiline = true;
            this.txtRCode.Name = "txtRCode";
            this.txtRCode.Size = new System.Drawing.Size(187, 26);
            this.txtRCode.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(241, -1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "ID";
            // 
            // txtCategorie
            // 
            this.txtCategorie.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.txtCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategorie.Location = new System.Drawing.Point(12, 417);
            this.txtCategorie.Multiline = true;
            this.txtCategorie.Name = "txtCategorie";
            this.txtCategorie.Size = new System.Drawing.Size(187, 26);
            this.txtCategorie.TabIndex = 25;
            // 
            // Categorie
            // 
            this.Categorie.AutoSize = true;
            this.Categorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Categorie.Location = new System.Drawing.Point(9, 396);
            this.Categorie.Name = "Categorie";
            this.Categorie.Size = new System.Drawing.Size(72, 18);
            this.Categorie.TabIndex = 24;
            this.Categorie.Text = "Categorie";
            // 
            // frmProduit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 551);
            this.ControlBox = false;
            this.Controls.Add(this.txtCategorie);
            this.Controls.Add(this.Categorie);
            this.Controls.Add(this.btnrechercher);
            this.Controls.Add(this.txtRDesignation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtqteCritique);
            this.Controls.Add(this.QteCritique);
            this.Controls.Add(this.txtqteMin);
            this.Controls.Add(this.QteMin);
            this.Controls.Add(this.txtprixP);
            this.Controls.Add(this.PrixProduit);
            this.Controls.Add(this.txtcodeP);
            this.Controls.Add(this.CodeProduit);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.description);
            this.Controls.Add(this.txtdesignation);
            this.Controls.Add(this.designation);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.id);
            this.Controls.Add(this.dgProduit);
            this.Name = "frmProduit";
            this.Text = "Produit";
            this.Load += new System.EventHandler(this.frmProduit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProduit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdesignation;
        private System.Windows.Forms.Label designation;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TextBox txtcodeP;
        private System.Windows.Forms.Label CodeProduit;
        private System.Windows.Forms.TextBox txtprixP;
        private System.Windows.Forms.Label PrixProduit;
        private System.Windows.Forms.DataGridView dgProduit;
        private System.Windows.Forms.TextBox txtqteMin;
        private System.Windows.Forms.Label QteMin;
        private System.Windows.Forms.TextBox txtqteCritique;
        private System.Windows.Forms.Label QteCritique;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnrechercher;
        private System.Windows.Forms.TextBox txtRDesignation;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategorie;
        private System.Windows.Forms.Label Categorie;
    }
}