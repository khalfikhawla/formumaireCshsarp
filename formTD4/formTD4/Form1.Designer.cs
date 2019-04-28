namespace formTD4
{
    partial class formTD4
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
            this.ajoute = new System.Windows.Forms.Button();
            this.cherche = new System.Windows.Forms.Button();
            this.supprime = new System.Windows.Forms.Button();
            this.modifer = new System.Windows.Forms.Button();
            this.prenomTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.nomTextBox = new System.Windows.Forms.TextBox();
            this.effacer = new System.Windows.Forms.Button();
            this.prenom = new System.Windows.Forms.Label();
            this.nom = new System.Windows.Forms.Label();
            this.identifiant = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ajoute
            // 
            this.ajoute.Location = new System.Drawing.Point(87, 167);
            this.ajoute.Name = "ajoute";
            this.ajoute.Size = new System.Drawing.Size(96, 27);
            this.ajoute.TabIndex = 0;
            this.ajoute.Text = "Ajoute";
            this.ajoute.UseVisualStyleBackColor = true;
            this.ajoute.Click += new System.EventHandler(this.ajoute_Click);
            // 
            // cherche
            // 
            this.cherche.Location = new System.Drawing.Point(451, 167);
            this.cherche.Name = "cherche";
            this.cherche.Size = new System.Drawing.Size(96, 27);
            this.cherche.TabIndex = 1;
            this.cherche.Text = "Cherche";
            this.cherche.UseVisualStyleBackColor = true;
            this.cherche.Click += new System.EventHandler(this.cherche_Click);
            // 
            // supprime
            // 
            this.supprime.Location = new System.Drawing.Point(255, 167);
            this.supprime.Name = "supprime";
            this.supprime.Size = new System.Drawing.Size(96, 27);
            this.supprime.TabIndex = 2;
            this.supprime.Text = "Supprime";
            this.supprime.UseVisualStyleBackColor = true;
            this.supprime.Click += new System.EventHandler(this.supprime_Click);
            // 
            // modifer
            // 
            this.modifer.Location = new System.Drawing.Point(661, 167);
            this.modifer.Name = "modifer";
            this.modifer.Size = new System.Drawing.Size(96, 27);
            this.modifer.TabIndex = 3;
            this.modifer.Text = "Modifer";
            this.modifer.UseVisualStyleBackColor = true;
            this.modifer.Click += new System.EventHandler(this.modifer_Click);
            // 
            // prenomTextBox
            // 
            this.prenomTextBox.Location = new System.Drawing.Point(634, 69);
            this.prenomTextBox.Name = "prenomTextBox";
            this.prenomTextBox.Size = new System.Drawing.Size(174, 22);
            this.prenomTextBox.TabIndex = 4;
            this.prenomTextBox.TextChanged += new System.EventHandler(this.prenomBox_TextChanged);
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(87, 62);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(174, 22);
            this.idTextBox.TabIndex = 5;
            this.idTextBox.TextChanged += new System.EventHandler(this.idBox_TextChanged);
            // 
            // nomTextBox
            // 
            this.nomTextBox.Location = new System.Drawing.Point(340, 64);
            this.nomTextBox.Name = "nomTextBox";
            this.nomTextBox.Size = new System.Drawing.Size(174, 22);
            this.nomTextBox.TabIndex = 7;
            this.nomTextBox.TextChanged += new System.EventHandler(this.nomBox_TextChanged);
            // 
            // effacer
            // 
            this.effacer.Location = new System.Drawing.Point(290, 256);
            this.effacer.Name = "effacer";
            this.effacer.Size = new System.Drawing.Size(247, 30);
            this.effacer.TabIndex = 8;
            this.effacer.Text = "Effacer";
            this.effacer.UseVisualStyleBackColor = true;
            this.effacer.Click += new System.EventHandler(this.effacer_Click);
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Location = new System.Drawing.Point(539, 69);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(57, 17);
            this.prenom.TabIndex = 9;
            this.prenom.Text = "Prenom";
            this.prenom.Click += new System.EventHandler(this.label1_Click);
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Location = new System.Drawing.Point(287, 67);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(37, 17);
            this.nom.TabIndex = 10;
            this.nom.Text = "Nom";
            this.nom.Click += new System.EventHandler(this.label2_Click);
            // 
            // identifiant
            // 
            this.identifiant.AutoSize = true;
            this.identifiant.Location = new System.Drawing.Point(12, 62);
            this.identifiant.Name = "identifiant";
            this.identifiant.Size = new System.Drawing.Size(69, 17);
            this.identifiant.TabIndex = 11;
            this.identifiant.Text = "Identifiant";
            // 
            // formTD4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 337);
            this.Controls.Add(this.identifiant);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.prenom);
            this.Controls.Add(this.effacer);
            this.Controls.Add(this.nomTextBox);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.prenomTextBox);
            this.Controls.Add(this.modifer);
            this.Controls.Add(this.supprime);
            this.Controls.Add(this.cherche);
            this.Controls.Add(this.ajoute);
            this.Name = "formTD4";
            this.Text = "formTD4";
            this.Load += new System.EventHandler(this.formTD4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ajoute;
        private System.Windows.Forms.Button cherche;
        private System.Windows.Forms.Button supprime;
        private System.Windows.Forms.Button modifer;
        private System.Windows.Forms.TextBox prenomTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox nomTextBox;
        private System.Windows.Forms.Button effacer;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.Label identifiant;
    }
}

