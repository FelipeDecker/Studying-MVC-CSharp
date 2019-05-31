namespace VendaProdutos.Infraestrutura.Dados.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PrimeiraVersao : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Produto", "ItemVenda_Id", c => c.Int());
            CreateIndex("dbo.Produto", "ItemVenda_Id");
            AddForeignKey("dbo.Produto", "ItemVenda_Id", "dbo.ItemVenda", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produto", "ItemVenda_Id", "dbo.ItemVenda");
            DropIndex("dbo.Produto", new[] { "ItemVenda_Id" });
            DropColumn("dbo.Produto", "ItemVenda_Id");
        }
    }
}
