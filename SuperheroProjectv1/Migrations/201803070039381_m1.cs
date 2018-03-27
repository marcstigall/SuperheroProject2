namespace SuperheroProjectv1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SuperheroModels",
                c => new
                    {
                        SuperheroModelId = c.Int(nullable: false, identity: true),
                        Power = c.String(nullable: false),
                        Backstory = c.String(),
                        Name = c.String(),
                        UserModel_UserModelId = c.Int(),
                    })
                .PrimaryKey(t => t.SuperheroModelId)
                .ForeignKey("dbo.UserModels", t => t.UserModel_UserModelId)
                .Index(t => t.UserModel_UserModelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SuperheroModels", "UserModel_UserModelId", "dbo.UserModels");
            DropIndex("dbo.SuperheroModels", new[] { "UserModel_UserModelId" });
            DropTable("dbo.SuperheroModels");
        }
    }
}
