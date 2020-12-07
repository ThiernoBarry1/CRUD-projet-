
namespace exempleBdD
{
    partial class ListeContacts
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
            this.lstIdentite = new System.Windows.Forms.ListBox();
            this.btnMetteAjour = new System.Windows.Forms.Button();
            this.labelTousContacts = new System.Windows.Forms.Label();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.annuler = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstIdentite
            // 
            this.lstIdentite.FormattingEnabled = true;
            this.lstIdentite.ItemHeight = 20;
            this.lstIdentite.Location = new System.Drawing.Point(94, 99);
            this.lstIdentite.Name = "lstIdentite";
            this.lstIdentite.Size = new System.Drawing.Size(425, 364);
            this.lstIdentite.TabIndex = 0;
            // 
            // btnMetteAjour
            // 
            this.btnMetteAjour.BackColor = System.Drawing.Color.White;
            this.btnMetteAjour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMetteAjour.ForeColor = System.Drawing.Color.OliveDrab;
            this.btnMetteAjour.Location = new System.Drawing.Point(593, 230);
            this.btnMetteAjour.Name = "btnMetteAjour";
            this.btnMetteAjour.Size = new System.Drawing.Size(141, 41);
            this.btnMetteAjour.TabIndex = 1;
            this.btnMetteAjour.Text = "Mettre à jour";
            this.btnMetteAjour.UseVisualStyleBackColor = false;
            this.btnMetteAjour.Click += new System.EventHandler(this.btnMetteAjour_Click);
            // 
            // labelTousContacts
            // 
            this.labelTousContacts.AutoSize = true;
            this.labelTousContacts.BackColor = System.Drawing.Color.PowderBlue;
            this.labelTousContacts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTousContacts.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTousContacts.Location = new System.Drawing.Point(190, 41);
            this.labelTousContacts.Name = "labelTousContacts";
            this.labelTousContacts.Size = new System.Drawing.Size(258, 27);
            this.labelTousContacts.TabIndex = 2;
            this.labelTousContacts.Text = "Tous les contact enregistrés";
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupprimer.ForeColor = System.Drawing.Color.Red;
            this.btnSupprimer.Location = new System.Drawing.Point(593, 305);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(141, 41);
            this.btnSupprimer.TabIndex = 3;
            this.btnSupprimer.Text = "Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = false;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // annuler
            // 
            this.annuler.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.annuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.annuler.ForeColor = System.Drawing.SystemColors.Desktop;
            this.annuler.Location = new System.Drawing.Point(24, 488);
            this.annuler.Name = "annuler";
            this.annuler.Size = new System.Drawing.Size(141, 41);
            this.annuler.TabIndex = 4;
            this.annuler.Text = "Annuler";
            this.annuler.UseVisualStyleBackColor = false;
            this.annuler.Click += new System.EventHandler(this.annuler_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetail.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.btnDetail.Location = new System.Drawing.Point(593, 372);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(141, 41);
            this.btnDetail.TabIndex = 5;
            this.btnDetail.Text = "Détail";
            this.btnDetail.UseVisualStyleBackColor = false;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // ListeContacts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 541);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.annuler);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.labelTousContacts);
            this.Controls.Add(this.btnMetteAjour);
            this.Controls.Add(this.lstIdentite);
            this.MaximumSize = new System.Drawing.Size(822, 597);
            this.MinimumSize = new System.Drawing.Size(822, 597);
            this.Name = "ListeContacts";
            this.Text = "ListeContacts";
            this.Load += new System.EventHandler(this.ListeContacts_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstIdentite;
        private System.Windows.Forms.Button btnMetteAjour;
        private System.Windows.Forms.Label labelTousContacts;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button annuler;
        private System.Windows.Forms.Button btnDetail;
    }
}