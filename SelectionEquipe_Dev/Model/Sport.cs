﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipe_Dev.Model
{
    public class Sport
    {
        [Key]
        public int SportId { get; set; }

        [@RequiredAttribute]
        [DisplayName("Nom Sport")]
        public string NomSport { get; set; }
        public ICollection<Poste> Postes { get; set; }
        public ICollection<Utilisateur> Utilisateurs { get; set; }

    }
}
