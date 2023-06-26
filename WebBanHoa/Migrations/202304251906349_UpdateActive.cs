namespace WebBanHoa.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tb_Category", "IsAction", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_News", "IsAction", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Posts", "IsAction", c => c.Boolean(nullable: false));
            AddColumn("dbo.tb_Product", "IsAction", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tb_Product", "IsAction");
            DropColumn("dbo.tb_Posts", "IsAction");
            DropColumn("dbo.tb_News", "IsAction");
            DropColumn("dbo.tb_Category", "IsAction");
        }
    }
}
