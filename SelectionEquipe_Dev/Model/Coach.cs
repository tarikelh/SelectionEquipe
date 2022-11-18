using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionEquipe_Dev.Model
{
    public abstract class Coach : Utilisateur
    {
        public Equipe Equipe { get; set; } = null;
    }
}
