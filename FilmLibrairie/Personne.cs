using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary
{
    public class Personne
    {



        
        private String nomPersonne;
        private String prenomPersonne;
        private int dateNaissance;
        private string villePersonne;
        private string codePostal;
        private int taillePersonne;
        private int poidsPersonne;
    
        public Personne()
        {

        }

        public string NomPersonne { get => nomPersonne; set => nomPersonne = value; }
        public string PrenomPersonne { get => prenomPersonne; set => prenomPersonne = value; }
        public int DateNaissance { get => dateNaissance; set => dateNaissance = value; }
        public string VillePersonne { get => villePersonne; set => villePersonne = value; }
        public string CodePostal { get => codePostal; set => codePostal = value; }
        public int TaillePersonne { get => taillePersonne; set => taillePersonne = value; }
        public int PoidsPersonne { get => poidsPersonne; set => poidsPersonne = value; }
    }

    

}
