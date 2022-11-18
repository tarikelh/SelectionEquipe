using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipe_Dev.Model
{
    public class Equipe
    {
        [Key]
        public int EquipeId { get; set; }

        [@RequiredAttribute]
        [DisplayName( "Nom Equipe")]
        public string NomEquipe { get; set; }
        
        public Coach Coach { get; set; }
        public ICollection<Joueur> joueurs { get; set; }
    }
}
