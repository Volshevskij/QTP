namespace QTProj.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class customer_address : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "Address", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "Address");
        }
    }
}
