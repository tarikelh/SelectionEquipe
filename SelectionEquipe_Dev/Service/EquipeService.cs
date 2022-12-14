using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipe_Dev.Model;
using SelectionEquipe_Dev.Repository;

namespace SelectionEquipe_Dev.Service
{
    public class EquipeService : IEquipeService
    {
        private IEquipeRepository _repo;

        public EquipeService(IEquipeRepository repo)
        {
            _repo = repo;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public Equipe FindByName(string name)
        {
            return _repo.FindByName(name);
        }

        public List<Equipe> GetAll()
        {
            return _repo.GetAll();
        }

        public Equipe GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Insert(Equipe e)
        {
            _repo.Insert(e);
        }
    }
}
