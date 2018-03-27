namespace SuperheroProjectv1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class WhatsInHere : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.UserModels", "Email", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.UserModels", "Email", c => c.String(nullable: false));
        }
    }
}
