using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipe_Dev.Model
{
    public class Poste
    {
        [Key]
        public int PosteId { get; set; }

        [@RequiredAttribute]
        [DisplayName("Nom Poste")]
        public string NomPoste { get; set; }
        public Sport Sport { get; set; }
        public ICollection<Joueur> Joueurs { get; set; }
    }
}
