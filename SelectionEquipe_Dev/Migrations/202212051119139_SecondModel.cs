namespace SelectionEquipe_Dev.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondModel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Utilisateurs", "CoachId", c => c.Int());
            CreateIndex("dbo.Utilisateurs", "CoachId");
            AddForeignKey("dbo.Utilisateurs", "CoachId", "dbo.Utilisateurs", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Utilisateurs", "CoachId", "dbo.Utilisateurs");
            DropIndex("dbo.Utilisateurs", new[] { "CoachId" });
            DropColumn("dbo.Utilisateurs", "CoachId");
        }
    }
}
