using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FilmShop
{
    class Program
    {
        private static string SqlConnectionString = "Server =.\SQLExpress;Database=Control8fev;Trusted_Connection=Yes";
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Ajouter un film ? Ajouter une personne");
                string choix = Console.ReadLine();
                Console.Clear();
                switch (choix)
                {
                    case "A":

                        AjouterUnePresonne();
                            break;
                    case "B":
                        AjouterUnFilm();
                        break;
                    case "X":
                        Console.WriteLine("Merci ");
                        Console.ReadKey();
                        return;
                }
                    
            }
        }

        private static void AjouterUnFilm()
        {
            throw new NotImplementedException();
        }

        private static void AjouterUnePresonne()
        {
            throw new NotImplementedException();
        }

        private static void AjouterUnePersonne()
        {

            Console.WriteLine("Renseigner les infomations de la personne son nom,prenom,date de naissance,ville ,codepostal,taille ,poids");

            Console.Write("Nom:");
            string Nom = Console.ReadLine();

            Console.Write("Prenom:");
            string Prenom = Console.ReadLine();

            Console.Write("date de naissane");
            string date = Console.ReadLine();

            Console.WriteLine("code postale");
            string cp = Console.ReadLine();

            Console.WriteLine("taille");
           string taille = Console.ReadLine();

            Console.WriteLine("poids");
            string poids = Console.ReadLine();

            AjouterUnePersonneEnBDD(Nom, Prenom, date, taille, poids);
        }
        // AJOUTER UNE PERSONNE  
        private static void AjouterUnePersonneEnBDD(string Nom, string Prenom, string date, string taille, string poids)
        {
            SqlConnection conex = new SqlConnection(SqlConnectionString);
            conex.Open();
            SqlCommand inserer = conex.CreateCommand();
            inserer.CommandText = ("INSERT INTO Personne(NomPersonne,PrenomPersonne,DateNaissance,AdressePersonne,CodePostal,TaillePersonne,PoidsPersonne) VALUES('" + Nom + "','" + Prenom + "','" + date + "','" + taille + "','" + poids + "')";
            inserer.EndExecuteNonQuery();
            conex.Close();
 
        }


        // AJOUTER UN FILM 



        private static void AjouterUneFilm()
        {

            Console.WriteLine("Renseigner les infomations du film ");

            Console.Write("Titre Film:");
            string titre = Console.ReadLine();

            Console.Write("Realisateur:");
            string realisateur = Console.ReadLine();

            Console.Write("date de sortie");
            string date = Console.ReadLine();

            Console.WriteLine("Resume film");
            string resume = Console.ReadLine();

            Console.WriteLine("Duree ");
            string duree = Console.ReadLine();

          

            AjouterUnFilmEnBDD(titre, realisateur, date, resume,duree);
        }
        // AJOUTER UNE PERSONNE  


        private static void AjouterUnFilmEnBDD(string titre, string realisateur, string date, string resume,string genre, string duree)
        {
            SqlConnection conex = new SqlConnection(SqlConnectionString);
            conex.Open();
            SqlCommand inserer = conex.CreateCommand();
            inserer.CommandText = ("INSERT INTO Film(TitreFilm,RealisateurFilm,DateSortie,ResumeFilm,DureeMinFilm) VALUES('" + titre + "','" + realisateur + "','" + date + "','" + resume + "','" +genre + "','" + duree + "')";
            inserer.EndExecuteNonQuery();
            conex.Close();

        }


        // OBTENIR DES FILMS PAR GENRE 

        private static void ObtenirFilmBDD (string titre, string realisateur, string date, string resume,string genre, string duree)
        {
            SqlConnection conex = new SqlConnection(SqlConnectionString);
            conex.Open();
            SqlCommand inserer = conex.CreateCommand();
            inserer.CommandText = ("SELECT Genre From Film") ;
            inserer.EndExecuteNonQuery();
            conex.Close();



        }





        // OBTENIR FILM PAR ANNEE 


        private static void ObtenirFilmParAnnee(string titre, string realisateur, string date, string resume,string genre, string duree)
        {
            SqlConnection conex = new SqlConnection(SqlConnectionString);
            conex.Open();
            SqlCommand inserer = conex.CreateCommand();
            inserer.CommandText = ("SELECT date From Film");
            inserer.EndExecuteNonQuery();
            conex.Close();



        }











    }



}




