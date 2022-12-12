using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipeWeb_Dev.Model
{
    public class Coach : Utilisateur
    {
        public Coach()
        {
        }

        public virtual Equipe Equipe { get; set; } = null;

        public virtual ICollection<Joueur> Joueurs { get; set; }
    }
}
