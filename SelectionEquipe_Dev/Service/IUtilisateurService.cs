using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipe_Dev.Dtos;
using SelectionEquipe_Dev.Model;

namespace SelectionEquipe_Dev.Service
{
    public interface IUtilisateurService
    {
        void Insert(Utilisateur u);

        List<Utilisateur> GetAll();

        Utilisateur GetById(int id);

        void Update(Utilisateur u);

        void Delete(int id);
        Utilisateur CheckLogin(LoginDTO loginDto);

        Utilisateur FindByLogin(string login);
    }
}
