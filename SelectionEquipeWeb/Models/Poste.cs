using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipeWeb.Models
{
    public class Poste
    {
        public int PosteId { get; set; }

        [DisplayName("Nom Poste")]
        public string NomPoste { get; set; }
        public virtual Sport Sport { get; set; }

        public int SportId { get; set; }

        public virtual ICollection<Joueur> Joueurs { get; set; }
    }
}
