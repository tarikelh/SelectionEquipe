using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipeWeb_Dev.Model;

namespace SelectionEquipeWeb_Dev.Repository
{
    public class SportRepository : ISportRepository
    {

        private ApplicationSelection _dao = new ApplicationSelection();

        public void Delete(int id)
        {
            Sport s = _dao.Sports.Find(id);
            if (s != null)
            {
                _dao.Sports.Remove(s);
                _dao.SaveChanges();
            }
            else
            {
                throw new Exception("Sport Introuvable");
            }
        }

        public Sport FindByName(string name)
        {
            return _dao.Sports.Where(x => x.NomSport.ToLower() == name.ToLower()).AsNoTracking().SingleOrDefault();
        }

        public List<Sport> GetAll()
        {
            return _dao.Sports.AsNoTracking().ToList();
        }

        public Sport GetById(int id)
        {
            return _dao.Sports.AsNoTracking().SingleOrDefault(x => x.SportId == id);
        }

        public void Insert(Sport s)
        {
            _dao.Sports.Add(s);
            _dao.SaveChanges();
        }

    }
}
