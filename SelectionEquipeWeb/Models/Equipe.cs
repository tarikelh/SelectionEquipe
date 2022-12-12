using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipeWeb.Models
{
    public class Equipe
    {

        public int EquipeId { get; set; }

        [DisplayName( "Nom Equipe")]
        public string NomEquipe { get; set; }
        
        public virtual Coach Coach { get; set; }
        public virtual ICollection<Joueur> Joueurs { get; set; }
    }
}
