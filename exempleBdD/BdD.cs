using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace exempleBdD
{
    class BdD
    {
        private static SqlConnection connexion;
        public static bool seConnecterALaBase()
        {
            try
            {
                connexion = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\BARRY-05046\\Documents\\Cours\\csharp\\exemple.mdf;Integrated Security=True;Connect Timeout=30");
                connexion.Open();
            }
            catch (Exception)
            {
                connexion = null;
            }
            return connexion != null;
        }
        public static void seDeconnecterDeLaBase()
        {
            connexion.Close();
            connexion = null;
        }
        public static SqlCommand commandePour(String ordreSQL)
        {
            return new SqlCommand(ordreSQL, BdD.connexion);
        }
        public static List<Contact> lireContacts()
        {
            List<Contact> lc = new List<Contact>();
            SqlCommand commande = commandePour("select id, nom, [prénom], [téléphone] from contact order by nom, [prénom]");
  
            SqlDataReader curseur = commande.ExecuteReader();
            while (curseur.Read())
                if(curseur.GetString(1) != "")
                   lc.Add(new Contact(curseur.GetInt32(0), curseur.GetString(1), curseur.GetString(2), curseur.GetString(3)));
            curseur.Close();
            commande.Dispose();
            return lc;
        }
        public static Contact lireContact(int id)
        {
            SqlCommand commande = commandePour("select nom, [prénom], [téléphone] from contact where id = " + id);
            SqlDataReader curseur = commande.ExecuteReader();
            Contact c = null;
            if (curseur.Read())
                c = new Contact(id, curseur.GetString(0), curseur.GetString(1), curseur.GetString(2));
            curseur.Close();
            commande.Dispose();
            return c;
        }
        public static bool supprimerContact(int id)
        {
            SqlCommand commande = commandePour("delete from contact where id = " + id);
            bool operationReussie = commande.ExecuteNonQuery() == 1;
            commande.Dispose();
            return operationReussie;
        }
        public static bool ajouterContact(String nom, String prenom, String telephone)
        {
            SqlParameter nParam = new SqlParameter("@n", System.Data.SqlDbType.VarChar, 30);
            SqlParameter pParam = new SqlParameter("@p", System.Data.SqlDbType.VarChar, 30);
            SqlParameter tParam = new SqlParameter("@t", System.Data.SqlDbType.VarChar, 20);
            nParam.Value = nom;
            pParam.Value = prenom;
            tParam.Value = telephone;
            SqlCommand commande = commandePour("insert into contact (nom, [prénom], [téléphone]) values (@n, @p, @t)");
            commande.Parameters.Add(nParam);
            commande.Parameters.Add(pParam);
            commande.Parameters.Add(tParam);
            bool operationReussie = commande.ExecuteNonQuery() == 1;
            commande.Dispose();
            return operationReussie;
        }

        public static bool MettreAjour(int id, string nom, string prenom, string telephone)
        {
            SqlParameter nParam = new SqlParameter("@nom", System.Data.SqlDbType.VarChar, 30);
            SqlParameter pParam = new SqlParameter("@prenom", System.Data.SqlDbType.VarChar, 30);
            SqlParameter tParam = new SqlParameter("@telephone", System.Data.SqlDbType.VarChar, 20);
            SqlParameter idParam = new SqlParameter("@id", System.Data.SqlDbType.Int);
            nParam.Value = nom;
            nParam.Value = nom;
            pParam.Value = prenom;
            tParam.Value = telephone;
            idParam.Value = id;
            SqlCommand commande = commandePour("UPDATE contact SET nom = @nom, [prénom]=@prenom,[téléphone]=@telephone  WHERE id = @id");
            commande.Parameters.Add(nParam);
            commande.Parameters.Add(pParam);
            commande.Parameters.Add(tParam);
            commande.Parameters.Add(idParam);
            bool operationReussie = commande.ExecuteNonQuery() == 1;
            commande.Dispose();
            return operationReussie;
        }
    }
}
