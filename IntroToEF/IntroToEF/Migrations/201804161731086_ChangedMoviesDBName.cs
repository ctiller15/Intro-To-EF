namespace IntroToEF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedMoviesDBName : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Movies", newName: "IntroToEfMovies");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.IntroToEfMovies", newName: "Movies");
        }
    }
}
