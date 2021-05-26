using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appli_Cinema
{
    public class Film
    {
        private char _titre;
        private char _genre;
        private int _anneeSortie;
        private char _nationalite;


        public char Titre
        {
            get { return _titre; }
            set { _titre = value; }
        }

        public char Genre
        {
            get { return _genre; }
            set { _genre = value; }
        }

        public int AnneeSortie
        {
            get { return _anneeSortie; }
            set { _anneeSortie = value; }
        }

        public char Nationalite
        {
            get { return _nationalite; }
            set { _nationalite = value; }
        }

    }
}
