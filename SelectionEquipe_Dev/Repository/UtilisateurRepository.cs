using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipe_Dev.Model;

namespace SelectionEquipe_Dev.Repository
{
    public class UtilisateurRepository : IUtilisateurRepository
    {
        private ApplicationSelection _dao = new ApplicationSelection();

        public void Delete(int id)
        {
            Utilisateur u = _dao.Utilisateurs.Find(id);
            if(u != null)
            {
                _dao.Utilisateurs.Remove(u);
                _dao.SaveChanges();
            }
            else
            {
                throw new Exception("Utilisateur Introuvable");
            }
        }

        public Utilisateur FindByLogin(string login)
        {
            return _dao.Utilisateurs.Where(x => x.Login.ToLower() == login.ToLower()).AsNoTracking().SingleOrDefault();
        }

        public List<Utilisateur> GetAll()
        {
            return _dao.Utilisateurs.Where(x => x.Login.ToLower() != "admin").AsNoTracking().ToList();
        }

        public Utilisateur GetById(int id)
        {
            return _dao.Utilisateurs.AsNoTracking().SingleOrDefault(x => x.Id == id);
        }

        public List<Coach> GetCoaches()
        {
            return _dao.Coachs.AsNoTracking().ToList();
        }

        public List<Joueur> GetJoueurs()
        {
            return _dao.Joueurs.AsNoTracking().ToList();
        }

        public List<Utilisateur> GetUtilisateursbySport(Sport s)
        {
            return _dao.Utilisateurs.Where(x => x.SportId == s.SportId).AsNoTracking().ToList();
        }

        public void Insert(Utilisateur u)
        {
            _dao.Utilisateurs.Add(u);
            _dao.SaveChanges();
        }

        public void Update(Utilisateur u)
        {
            _dao.Utilisateurs.Attach(u);
            _dao.Entry(u).State = EntityState.Modified;
            _dao.SaveChanges();
        }
    }
}
