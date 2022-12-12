using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipeWeb_Dev.Model;

namespace SelectionEquipeWeb_Dev.Repository
{
    public interface ISportRepository
    {
        void Insert(Sport s);

        List<Sport> GetAll();

        Sport GetById(int id);

        Sport FindByName(string name);
        void Delete(int id);
    }
}
