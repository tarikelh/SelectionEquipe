namespace SelectionEquipeWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Utilisateurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(nullable: false, maxLength: 256),
                        Prenom = c.String(nullable: false, maxLength: 256),
                        Login = c.String(nullable: false, maxLength: 256),
                        Password = c.String(nullable: false, maxLength: 256),
                        SportId = c.Int(),
                        Note = c.Int(),
                        Commentaire = c.String(),
                        EquipeId = c.Int(),
                        CoachId = c.Int(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Utilisateurs", t => t.CoachId)
                .ForeignKey("dbo.Equipes", t => t.EquipeId)
                .ForeignKey("dbo.Sports", t => t.SportId)
                .Index(t => t.SportId)
                .Index(t => t.EquipeId)
                .Index(t => t.CoachId);
            
            CreateTable(
                "dbo.Sports",
                c => new
                    {
                        SportId = c.Int(nullable: false, identity: true),
                        NomSport = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.SportId);
            
            CreateTable(
                "dbo.Postes",
                c => new
                    {
                        PosteId = c.Int(nullable: false, identity: true),
                        NomPoste = c.String(nullable: false, maxLength: 256),
                        SportId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PosteId)
                .ForeignKey("dbo.Sports", t => t.SportId)
                .Index(t => t.SportId);
            
            CreateTable(
                "dbo.Equipes",
                c => new
                    {
                        EquipeId = c.Int(nullable: false),
                        NomEquipe = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.EquipeId)
                .ForeignKey("dbo.Utilisateurs", t => t.EquipeId)
                .Index(t => t.EquipeId);
            
            CreateTable(
                "dbo.PosteJoueur",
                c => new
                    {
                        PosteId = c.Int(nullable: false),
                        JoueurId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.PosteId, t.JoueurId })
                .ForeignKey("dbo.Postes", t => t.PosteId, cascadeDelete: true)
                .ForeignKey("dbo.Utilisateurs", t => t.JoueurId, cascadeDelete: true)
                .Index(t => t.PosteId)
                .Index(t => t.JoueurId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Utilisateurs", "SportId", "dbo.Sports");
            DropForeignKey("dbo.Postes", "SportId", "dbo.Sports");
            DropForeignKey("dbo.PosteJoueur", "JoueurId", "dbo.Utilisateurs");
            DropForeignKey("dbo.PosteJoueur", "PosteId", "dbo.Postes");
            DropForeignKey("dbo.Utilisateurs", "EquipeId", "dbo.Equipes");
            DropForeignKey("dbo.Utilisateurs", "CoachId", "dbo.Utilisateurs");
            DropForeignKey("dbo.Equipes", "EquipeId", "dbo.Utilisateurs");
            DropIndex("dbo.PosteJoueur", new[] { "JoueurId" });
            DropIndex("dbo.PosteJoueur", new[] { "PosteId" });
            DropIndex("dbo.Equipes", new[] { "EquipeId" });
            DropIndex("dbo.Postes", new[] { "SportId" });
            DropIndex("dbo.Utilisateurs", new[] { "CoachId" });
            DropIndex("dbo.Utilisateurs", new[] { "EquipeId" });
            DropIndex("dbo.Utilisateurs", new[] { "SportId" });
            DropTable("dbo.PosteJoueur");
            DropTable("dbo.Equipes");
            DropTable("dbo.Postes");
            DropTable("dbo.Sports");
            DropTable("dbo.Utilisateurs");
        }
    }
}
