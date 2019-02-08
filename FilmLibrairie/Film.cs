using System;
using System.Collections.Generic;
using System.Text;

namespace FilmLibrary
{
    public class Film
    {
        private string TitreFilm;
        private string RealisateurFilm;
        private string DateSortie;
        private string ResumeFilm;
        private string Genre;
        private int DureeMinFilm;
       



        public Film()
        {
        }

        public string TitreFilm1 { get => TitreFilm; set => TitreFilm = value; }
        public string RealisateurFilm1 { get => RealisateurFilm; set => RealisateurFilm = value; }
        public string DateSortie1 { get => DateSortie; set => DateSortie = value; }
        public string ResumeFilm1 { get => ResumeFilm; set => ResumeFilm = value; }
        public int DureeMinFilm1 { get => DureeMinFilm; set => DureeMinFilm = value; }
        public string Genre1 { get => Genre; set => Genre = value; }
    }



}
