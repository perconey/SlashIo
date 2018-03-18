namespace SlashIo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chngednamesandaddeddetails : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.OgPropertySets",
                c => new
                    {
                        Ogsetid = c.Int(nullable: false, identity: true),
                        Ogurl = c.String(),
                        Ogtype = c.String(),
                        Ogtitle = c.String(),
                        OgDescription = c.String(),
                        OgImage = c.String(),
                    })
                .PrimaryKey(t => t.Ogsetid);
            
            CreateTable(
                "dbo.PageDetails",
                c => new
                    {
                        Pagedetailsid = c.Int(nullable: false, identity: true),
                        CurrentPrefix = c.String(),
                        ImagesAreUrlProvided = c.Boolean(nullable: false),
                        PropSet_Ogsetid = c.Int(),
                    })
                .PrimaryKey(t => t.Pagedetailsid)
                .ForeignKey("dbo.OgPropertySets", t => t.PropSet_Ogsetid)
                .Index(t => t.PropSet_Ogsetid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PageDetails", "PropSet_Ogsetid", "dbo.OgPropertySets");
            DropIndex("dbo.PageDetails", new[] { "PropSet_Ogsetid" });
            DropTable("dbo.PageDetails");
            DropTable("dbo.OgPropertySets");
        }
    }
}
