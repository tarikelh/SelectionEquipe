using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipe_Dev.Model;

namespace SelectionEquipe_Dev.Repository
{
    public class EquipeRepository : IEquipeRepository
    {
        private ApplicationSelection _dao = new ApplicationSelection();
        public void Delete(int id)
        {
            Equipe e = _dao.Equipes.Find(id);
            if(e != null)
            {
                _dao.Equipes.Remove(e);
                _dao.SaveChanges();
            }
            else
            {
                throw new Exception("Equipe Introuvable");
            }
        }

        public Equipe FindByName(string name)
        {
            return _dao.Equipes.Where(x => x.NomEquipe.ToLower() == name.ToLower()).AsNoTracking().SingleOrDefault();
        }

        public List<Equipe> GetAll()
        {
            return _dao.Equipes.AsNoTracking().ToList();
        }

        public Equipe GetById(int id)
        {
            return _dao.Equipes.AsNoTracking().SingleOrDefault(x => x.EquipeId == id);
        }

        public void Insert(Equipe e)
        {
            _dao.Equipes.Add(e);
            _dao.SaveChanges();
        }
    }
}
