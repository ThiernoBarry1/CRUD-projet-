namespace exempleBdD
{
    partial class FenetreRepertoire
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPren = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.btAjouter = new System.Windows.Forms.Button();
            this.groupInformations = new System.Windows.Forms.GroupBox();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnVoirContacts = new System.Windows.Forms.Button();
            this.groupInformations.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(193, 63);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(263, 30);
            this.txtNom.TabIndex = 2;
            // 
            // txtPren
            // 
            this.txtPren.Location = new System.Drawing.Point(193, 120);
            this.txtPren.Name = "txtPren";
            this.txtPren.Size = new System.Drawing.Size(263, 30);
            this.txtPren.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Téléphone :";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(193, 187);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(263, 30);
            this.txtTel.TabIndex = 6;
            // 
            // btAjouter
            // 
            this.btAjouter.BackColor = System.Drawing.Color.Turquoise;
            this.btAjouter.Location = new System.Drawing.Point(267, 434);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(108, 38);
            this.btAjouter.TabIndex = 8;
            this.btAjouter.Text = "Enregistrer";
            this.btAjouter.UseVisualStyleBackColor = false;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // groupInformations
            // 
            this.groupInformations.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupInformations.Controls.Add(this.label1);
            this.groupInformations.Controls.Add(this.txtNom);
            this.groupInformations.Controls.Add(this.label2);
            this.groupInformations.Controls.Add(this.label3);
            this.groupInformations.Controls.Add(this.txtTel);
            this.groupInformations.Controls.Add(this.txtPren);
            this.groupInformations.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupInformations.Location = new System.Drawing.Point(95, 103);
            this.groupInformations.Name = "groupInformations";
            this.groupInformations.Size = new System.Drawing.Size(530, 275);
            this.groupInformations.TabIndex = 12;
            this.groupInformations.TabStop = false;
            this.groupInformations.Text = "Enregistrement d\'un contact";
            this.groupInformations.Enter += new System.EventHandler(this.groupInformations_Enter);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnAnnuler.Location = new System.Drawing.Point(95, 434);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(108, 38);
            this.btnAnnuler.TabIndex = 13;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = false;
            this.btnAnnuler.Click += new System.EventHandler(this.btnAnnuler_Click);
            // 
            // btnVoirContacts
            // 
            this.btnVoirContacts.BackColor = System.Drawing.Color.PowderBlue;
            this.btnVoirContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoirContacts.Location = new System.Drawing.Point(408, 434);
            this.btnVoirContacts.Name = "btnVoirContacts";
            this.btnVoirContacts.Size = new System.Drawing.Size(217, 38);
            this.btnVoirContacts.TabIndex = 11;
            this.btnVoirContacts.Text = "Tous les contacts";
            this.btnVoirContacts.UseVisualStyleBackColor = false;
            this.btnVoirContacts.Click += new System.EventHandler(this.btnVoirContacts_Click);
            // 
            // FenetreRepertoire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 515);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.groupInformations);
            this.Controls.Add(this.btnVoirContacts);
            this.Controls.Add(this.btAjouter);
            this.MaximumSize = new System.Drawing.Size(769, 571);
            this.MinimumSize = new System.Drawing.Size(769, 571);
            this.Name = "FenetreRepertoire";
            this.Text = "Répertoire partagé";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupInformations.ResumeLayout(false);
            this.groupInformations.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPren;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.GroupBox groupInformations;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnVoirContacts;
    }
}

