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
    public partial class Detail : Form
    {
        private int id;
        private string nom;
        private string prenom;
        private string telephone;
        public Detail()
        {
            InitializeComponent();
        }
        public Detail(int id,string nom, string prenom, string telephone)
        {
            InitializeComponent();
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.telephone = telephone;
        }
        private void Detail_Load(object sender, EventArgs e)
        {
            txtId.Text = this.id.ToString();
            txtNom.Text = this.nom;
            txtPrenom.Text = this.prenom;
            txtTelephone.Text = this.telephone;
        }

        private void btnRetour_Click(object sender, EventArgs e)
        {
            this.Hide();
            ListeContacts listeContacts = new ListeContacts();
            listeContacts.ShowDialog();
            listeContacts.Closed += (s, args) => this.Close(); 
        }
    }
}
