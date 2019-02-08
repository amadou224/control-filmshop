using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FilmLibrairie;
using FilmLibrary;

namespace TestFilm
{


    // GESTION DES TEST UNITAIRE 

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            var personne = new Personne();
            Assert.ThrowsException<ArgumentException>()=>personne.PoidsPersonne > 200;
        }

        [TestMethod]
        public void LeNomEmployeNePeutPasEtreVide()
        {
            var personne = new Personne();
            Assert.ThrowsException<ArgumentException>(() => personne.NomPersonne = " ");
        }


        [TestMethod]
        public void LeNomEmployeNePeutPasCommencerParUnChiffre()
        {
            var personne = new Personne();
            Assert.ThrowsException<ArgumentException>(() => personne.PrenomPersonne = "1Test");
        }

        [TestMethod]
        public void LeNomDunePersonneNeDoitPasEtreSuperieurA50Caracteres()
        {
            var personne = new Personne();
            string message = "";
            for (int i = 0; i < 51; i++)
            {
                message = message + "a";
            }
            Assert.ThrowsException<ArgumentException>(()
                => Personne.nomPersonne = message);
        }

        [TestMethod]
        public void LeNomDunRealisateurNePeutPasCommencerParUnChiffre()
        {
            var film = new Film();
            Assert.ThrowsException<ArgumentException>(() => film.Realisateur = "1Test");
        }



    }
}






    


