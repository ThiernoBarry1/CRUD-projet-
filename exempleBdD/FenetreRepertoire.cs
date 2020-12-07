using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exempleBdD
{
    public partial class FenetreRepertoire : Form
    {
        private List<int> lesId = new List<int>();
        private string nom;
        private string prenom;
        private string telephone;
        private int id;
        private bool estModification = false;
        public FenetreRepertoire() {
            InitializeComponent();
        }
        public FenetreRepertoire(int id,string nom,string prenom, string telephone)
        {
            InitializeComponent();
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
            this.estModification = true;
        }

        
        private void Form1_Load(object sender, EventArgs e) {
            if (this.estModification)
            {
                groupInformations.Text = "Modification d'un contact";
                txtNom.Text = this.nom;
                txtPren.Text = this.prenom;
                txtTel.Text = this.telephone;
            }
        }
        
        private void btAjouter_Click(object sender, EventArgs e) {
            string nom = txtNom.Text;
            string prenom = txtPren.Text;
            string telephone = txtTel.Text;
            int id = this.id;
            if (!AttributNullTropLong(nom,"nom", 30) && !AttributNullTropLong(prenom,"prenom", 30) && !AttributNullTropLong(telephone,"telephone", 20))
            {
               
                if (this.estModification)
                {
                    if(BdD.MettreAjour(id,nom, prenom, telephone))
                    {
                       
                      MessageBox.Show("Le contact a été mis-à-jour avec succès !","Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Impossible de mettre à jour  le contact d'identifiant " + id, "Operation a échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    BdD.ajouterContact(txtNom.Text, txtPren.Text, txtTel.Text); 
                   MessageBox.Show("Le contact a été enregistré avec succès !","Opération réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
               
            }
        }

        private void btnVoirContacts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListeContacts listeContacts = new ListeContacts();
            listeContacts.ShowDialog();
            listeContacts.Closed += (s, args) => this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public bool AttributNullTropLong(string Attribute, string nomAttribute, int longeur)
        {
            if ( nomAttribute == "nom" && Attribute.Length == 0)
            {
                MessageBox.Show("Merci de renseigner le Nom", "Echec de l'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            if (Attribute.Length > longeur)
            {
                MessageBox.Show("Le " + nomAttribute + " est trop long", "Echec de l'ajout", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;
        }
        private void groupInformations_Enter(object sender, EventArgs e)
        {

        }
    }
}
