using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipe_Dev.Model
{
    public abstract class Utilisateur
    {
        protected Utilisateur()
        {
        }

        protected Utilisateur(string nom, string prenom)
        {
            Nom = nom;
            Prenom = prenom;
        }

        public enum Role {
            Coach = 1,
            Joueur
        }
        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }


        public string Login { get; set; }


        public string Password { get; set; }

        public virtual Sport Sport { get; set; }

        public int? SportId { get; set; }

        public new string ToString() { return $"{Prenom} {Nom}"; }
    }
}
