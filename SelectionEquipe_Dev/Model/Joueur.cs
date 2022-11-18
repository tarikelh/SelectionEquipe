using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipe_Dev.Model
{
    public abstract class Joueur : Utilisateur
    {
        public int Note { get; set; }

        public string Commentaire { get; set; }

        public Equipe Equipe { get; set; }=null;

        public ICollection<Poste> Postes { get; set; }
    }
}
