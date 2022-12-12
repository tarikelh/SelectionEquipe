using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipeWeb_Dev.Model;

namespace SelectionEquipeWeb_Dev.Repository
{
    public interface IUtilisateurRepository
    {
        void Insert(Utilisateur u);

        List<Utilisateur> GetAll();

        Utilisateur GetById(int id);

        void Update(Utilisateur u);

        void Delete(int id);

        Utilisateur FindByLogin(string login);
    }
}
