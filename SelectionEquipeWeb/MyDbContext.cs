using System.Data.Entity;
using SelectionEquipeWeb.Models;

namespace SelectionEquipeWeb
{
    public class MyDbContext : DbContext
    {
        // Votre contexte a été configuré pour utiliser une chaîne de connexion « MyDbContext » du fichier 
        // de configuration de votre application (App.config ou Web.config). Par défaut, cette chaîne de connexion cible 
        // la base de données « SelectionEquipeWeb.MyDbContext » sur votre instance LocalDb. 
        // 
        // Pour cibler une autre base de données et/ou un autre fournisseur de base de données, modifiez 
        // la chaîne de connexion « MyDbContext » dans le fichier de configuration de l'application.
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        // Ajoutez un DbSet pour chaque type d'entité à inclure dans votre modèle. Pour plus d'informations 
        // sur la configuration et l'utilisation du modèle Code First, consultez http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Coach> Coachs { get; set; }
        public virtual DbSet<Equipe> Equipes { get; set; }
        public virtual DbSet<Joueur> Joueurs { get; set; }
        public virtual DbSet<Poste> Postes { get; set; }
        public virtual DbSet<Sport> Sports { get; set; }
        public virtual DbSet<Utilisateur> Utilisateurs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Prop name(Course) : non nullable + taille 255
            modelBuilder.Entity<Utilisateur>()
                .Property(u => u.Nom)
                .IsRequired()
                .HasMaxLength(256);

            modelBuilder.Entity<Utilisateur>()
                .Property(u => u.Prenom)
                .IsRequired()
                .HasMaxLength(256);

            modelBuilder.Entity<Utilisateur>()
                .Property(u => u.Login)
                .IsRequired()
                .HasMaxLength(256);

            modelBuilder.Entity<Utilisateur>()
                .Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(256);

            modelBuilder.Entity<Equipe>()
                .Property(e => e.NomEquipe)
                .IsRequired()
                .HasMaxLength(256);

            modelBuilder.Entity<Poste>()
                .Property(p => p.NomPoste)
                .IsRequired()
                .HasMaxLength(256);

            modelBuilder.Entity<Sport>()
                .Property(s => s.NomSport)
                .IsRequired()
                .HasMaxLength(256);
            /*
             *Mapping  Association entre entités 
             *  
             *  On commence par identifier les propriétés de navigation qui composent la relation 
             *  HasRequired/HasOptionnel ou HasMany 
             *  
             *  On enchaine ensuite un appel à WithOne ou WithMany pour identifier la navigation inverse
             * 
             */

            //OneToMany
            modelBuilder.Entity<Utilisateur>()
                .HasOptional(u => u.Sport)
                .WithMany(s => s.Utilisateurs)
                .HasForeignKey(u => u.SportId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Poste>()
                .HasRequired(p => p.Sport)
                .WithMany(s => s.Postes)
                .HasForeignKey(p => p.SportId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Joueur>()
                .HasOptional(j => j.Equipe)
                .WithMany(e => e.Joueurs)
                .HasForeignKey(j => j.EquipeId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Joueur>()
                .HasOptional(j => j.Coach)
                .WithMany(e => e.Joueurs)
                .HasForeignKey(j => j.CoachId)
                .WillCascadeOnDelete(false);


            //OneToOne

            modelBuilder.Entity<Coach>()
                .HasOptional(c => c.Equipe)
                .WithRequired(e => e.Coach);


            //ManyToMany

            modelBuilder.Entity<Poste>()
                .HasMany(p => p.Joueurs)
                .WithMany(j => j.Postes)
                .Map(m => m.ToTable("PosteJoueur")
                .MapLeftKey("PosteId")
                .MapRightKey("JoueurId"));

            ////Clé etrangère vers la classe Author - OneToMany
            //modelBuilder.Entity<Course>()
            //    .HasRequired(c => c.Author)
            //    .WithMany(a => a.Courses)
            //    .HasForeignKey(c => c.AuthorId)
            //    .WillCascadeOnDelete(false);  //La suppression d'un cours n'implique pas la suppression d'un Author


            ////ManyToMany : Course - Utilisateur 
            //modelBuilder.Entity<Course>()
            //    .HasMany(c => c.Users)
            //    .WithMany(u => u.Courses)
            //    .Map(m => m.ToTable("CourseUser")
            //    .MapLeftKey("CourseId")
            //    .MapRightKey("UtilisateurId"));

            ////OneToOne : Utilisateur - Adresse 
            ////Préciser le parent (principal) et l'enfant (Dependant)
            //modelBuilder.Entity<Utilisateur>()
            //    .HasRequired(u => u.Adresse)
            //   .WithRequiredDependent();
        }

        //public class MyEntity
        //{
        //    public int Id { get; set; }
        //    public string Name { get; set; }
        //}
    }

}