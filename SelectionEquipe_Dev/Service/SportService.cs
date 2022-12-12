using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipeWeb_Dev.Model;
using SelectionEquipeWeb_Dev.Repository;

namespace SelectionEquipeWeb_Dev.Service
{
    public class SportService : ISportService
    {
        private ISportRepository _repo;

        public SportService(ISportRepository repo)
        {
            _repo = repo;
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }

        public Sport FindByName(string name)
        {
            return _repo.FindByName(name);
        }

        public List<Sport> GetAll()
        {
            return _repo.GetAll();
        }

        public Sport GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Insert(Sport s)
        {
            _repo.Insert(s);
        }
    }
}
