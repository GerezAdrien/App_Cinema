using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appli_Cinema
{
    public abstract class Personne
    {
        private char _nom;
        private char _prenom;
        private char _nationalite;
        private DateTime _dateNaissance;

        public char nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public char MyProperty
        {
            get { return _prenom; }
            set { _prenom = value; }
        }


        public DateTime DateNaissance
        {
            get { return DateNaissance; }
            set { DateNaissance = value; }
        }

        public char Nationalite
        {
            get { return _nationalite; }
            set { _nationalite = value; }
        }
    }
}
