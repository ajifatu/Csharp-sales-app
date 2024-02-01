namespace AppVente
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.quitter_butt = new System.Windows.Forms.Button();
            this.se_connecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.textBox1.Location = new System.Drawing.Point(12, 72);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(368, 35);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(12, 41);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(140, 25);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Identifiant";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox4.Location = new System.Drawing.Point(12, 191);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(368, 35);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Font = new System.Drawing.Font("Harrington", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(12, 159);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(140, 26);
            this.textBox3.TabIndex = 5;
            this.textBox3.Text = "Mot De Passe";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quitter_butt
            // 
            this.quitter_butt.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.quitter_butt.Font = new System.Drawing.Font("Harrington", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitter_butt.Location = new System.Drawing.Point(30, 254);
            this.quitter_butt.Name = "quitter_butt";
            this.quitter_butt.Size = new System.Drawing.Size(111, 32);
            this.quitter_butt.TabIndex = 6;
            this.quitter_butt.Text = "Quitter";
            this.quitter_butt.UseVisualStyleBackColor = false;
            this.quitter_butt.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // se_connecter
            // 
            this.se_connecter.BackColor = System.Drawing.SystemColors.GrayText;
            this.se_connecter.Font = new System.Drawing.Font("Harrington", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.se_connecter.Location = new System.Drawing.Point(225, 254);
            this.se_connecter.Name = "se_connecter";
            this.se_connecter.Size = new System.Drawing.Size(111, 32);
            this.se_connecter.TabIndex = 7;
            this.se_connecter.Text = "Se Connecter";
            this.se_connecter.UseVisualStyleBackColor = false;
            this.se_connecter.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 324);
            this.ControlBox = false;
            this.Controls.Add(this.se_connecter);
            this.Controls.Add(this.quitter_butt);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Connexion";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button quitter_butt;
        private System.Windows.Forms.Button se_connecter;
    }
}

