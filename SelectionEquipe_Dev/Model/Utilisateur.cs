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

        public int Id { get; set; }

        public string Nom { get; set; }

        public string Prenom { get; set; }


        public string Login { get; set; }


        public string Password { get; set; }

        public virtual Sport Sport { get; set; }

        public int? SportId { get; set; }



    }
}
