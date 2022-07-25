using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Terno Armani','terno de 3 botões',1,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Terno Colombo','terno de 3 botões',1,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Terno Dorinhos','terno de 3 botões',1,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Terno Rener','terno de 3 botões',1,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Vestido de Noiva','---------------',2,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Smoke','um botão',1,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Vestido de Madrinha','--------',3,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Vestido de Madrinha','--------',3,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Vestido de Madrinha','--------',3,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Vestido de Madrinha','--------',3,1,1,30.5,350.99,2,now(),now(), 1, true )");
            mb.Sql("INSERT INTO  product (ProductName , ProductDescription , ColorId , MaximumSizeId , MinimimSizeId , DailyValue , PurchasePrice , ProductTypeId ,DateCreated , DateUpdated , StatusId , IsActive ) VALUES ('Vestido de Madrinha','--------',3,1,1,30.5,350.99,2,now(),now(), 1, true )");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("delete from Product");
        }
    }
}
