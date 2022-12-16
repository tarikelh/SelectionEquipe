﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SelectionEquipe_Dev.Model;

namespace SelectionEquipe_Dev.Service
{
    public interface IEquipeService
    {
        void Insert(Equipe e);

        List<Equipe> GetAll();

        Equipe GetById(int id);

        Equipe FindByName(string name);
        void Delete(int id);
    }
}