using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipeWeb_Dev.Dtos;
using SelectionEquipeWeb_Dev.Model;
using SelectionEquipeWeb_Dev.Repository;

namespace SelectionEquipeWeb_Dev.Service
{
    public class UtilisateurService : IUtilisateurService
    {
        private IUtilisateurRepository _repo;

        public UtilisateurService(IUtilisateurRepository repo)
        {
            _repo = repo;
        }

        public Utilisateur CheckLogin(LoginDTO loginDto)
        {
            Utilisateur userDB = _repo.FindByLogin(loginDto.Login);
            if (userDB != null && userDB.Password.Equals(loginDto.Password))
            {
                return userDB;
            }

            return null;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public Utilisateur FindByLogin(string login)
        {
            return _repo.FindByLogin(login);
        }

        public List<Utilisateur> GetAll()
        {
            return _repo.GetAll();
        }

        public Utilisateur GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Insert(Utilisateur u)
        {
            _repo.Insert(u);
        }

        public void Update(Utilisateur u)
        {
            _repo.Update(u);
        }
    }
}
