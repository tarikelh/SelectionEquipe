using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipeWeb_Dev.Model
{
    public class Joueur : Utilisateur
    {
        public Joueur()
        {
        }

        public int Note { get; set; }

        public string Commentaire { get; set; }

        public virtual Equipe Equipe { get; set; }

        public int? EquipeId { get; set; }

        public virtual Coach Coach { get; set; }

        public int? CoachId { get; set; }

        public virtual ICollection<Poste> Postes { get; set; }
    }
}
