using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaCategorias : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Terno + calça',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Terno',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Calça',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Smoke',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('colete',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Suspensorio',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Gravata Borboleta',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Gravata',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Vestido Festa',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Vestido Noiva',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Vestido Madrinha',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Calçado Masculino c/ cardaço',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Calçado Masculino c/ cardaço',1,true, now() ,now() )");
            mb.Sql("INSERT INTO producttype (ProductTypeName, StatusId, IsActive, dateCreated, dateUpdated) values ('Calçado feminino',1,true, now() ,now() )");

            
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from producttype");
        }
    }
}
