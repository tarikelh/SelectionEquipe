using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipe_Dev.Model;

namespace SelectionEquipe_Dev.Repository
{
    public interface IUtilisateurRepository
    {
        void Insert(Utilisateur u);

        List<Utilisateur> GetAll();

        Utilisateur GetById(int id);

        void Update(Utilisateur u);

        void Delete(int id);

        Utilisateur FindByLogin(string login);

        List<Utilisateur> GetUtilisateursbySport(Sport s);
        List<Coach> GetCoaches();
        List<Joueur> GetJoueurs();
    }
}
