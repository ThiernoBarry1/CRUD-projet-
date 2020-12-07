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
    public partial class ListeContacts : Form
    {
        private List<int> lesId = new List<int>();
        public ListeContacts()
        {
            InitializeComponent();
        }

        private void ListeContacts_Load(object sender, EventArgs e)
        {
            MettreAJourListe();
        }
        private void MettreAJourListe()
        {
            List<Contact> lc = BdD.lireContacts(); //appel du modèle
            RemplirListeContacts(lc); // appel de la vue
            lc.Clear();
        }
        private void RemplirListeContacts(List<Contact> lc)
        {
            lstIdentite.Items.Clear();
            lesId.Clear();
            foreach (Contact c in lc)
            {
                lstIdentite.Items.Add(c);
                lesId.Add(c.Id);
            }
        }

        private void btnMetteAjour_Click(object sender, EventArgs e)
        {
            int numero = SiPossible("modifier");
            if (numero >= 0)
            {
                int id = lesId[numero];
                Contact c = BdD.lireContact(id);
                if (c != null)
                {
                    this.Hide();
                    FenetreRepertoire fenetreRepertoire = new FenetreRepertoire(c.Id, c.Nom, c.Prenom, c.Telephone);
                    fenetreRepertoire.ShowDialog();
                    fenetreRepertoire.Closed += (s, args) => this.Close();
                }
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            bool possibleSupprimer = true;
            if (lstIdentite.SelectedItems.Count == 0)
            {
                MessageBox.Show("Merci de sélectionner un élément à supprimer", "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                possibleSupprimer = false;
            }


            if (possibleSupprimer && DialogResult.Yes == MessageBox.Show("êtes vous sûr de vouloir supprimer ce contact ?", "suppression", MessageBoxButtons.YesNo))
            {
                int id = lesId[lstIdentite.SelectedIndex];
                if (BdD.supprimerContact(id))
                {
                    MettreAJourListe();
                    lesId.Clear();
                    MessageBox.Show("Contact d'identifiant " + id + " a été supprimer avec succès ! ", "Operation réussie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Impossible de supprimer le contact d'identifiant " + id, "Operation a échouée", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }


            }
        }
        private int SiPossible(string action)
        {

            if (lstIdentite.SelectedItems.Count == 0)
            {
                MessageBox.Show("Merci de sélectionner un élément à " + action, "Aucune sélection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return lstIdentite.SelectedIndex;
        }

        private void annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            int numero = SiPossible("afficher les détails");
            if (numero >= 0)
            {
                int id = lesId[numero];
                Contact c = BdD.lireContact(id);
                if (c != null)
                {
                    this.Hide();
                    Detail detail = new Detail(c.Id, c.Nom, c.Prenom, c.Telephone);
                    detail.ShowDialog();
                    detail.Closed += (s, args) => this.Close();
                }
            }
        }
    }
}
