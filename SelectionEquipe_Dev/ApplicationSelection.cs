using System;
using System.Data.Entity;
using System.Linq;
using SelectionEquipe_Dev.Model;

namespace SelectionEquipe_Dev
{
    public class ApplicationSelection : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « ApplicationSelection » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « SelectionEquipe_Dev.ApplicationSelection » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « ApplicationSelection » dans le fichier de configuration de l'application.
        public ApplicationSelection()
            : base("name=ApplicationSelection")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Coach> Coachs { get; set; }
        public virtual DbSet<Equipe> Equipes { get; set; }
        public virtual DbSet<Joueur> Joueurs { get; set; }
        public virtual DbSet<Poste> Postes { get; set; }
        public virtual DbSet<Sport> Sport { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}