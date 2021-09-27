using Microsoft.EntityFrameworkCore.Migrations;

namespace boilerplatetest.Migrations
{
    public partial class SmartQuick_Clients : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    client_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_document_type = table.Column<int>(type: "int", nullable: false),
                    client_document = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_phone_number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    city = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    hour = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    date = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    load_time = table.Column<int>(type: "int", nullable: false),
                    start_time_delivery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_time_delivery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_order = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    depot = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    delivery_address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    longitude = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    latitude = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CubingVariableService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cubing_variables_service = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CubingVariableService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CubingVariableService_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DynamicField",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dynamic_field = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DynamicField", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DynamicField_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    product_sku = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    product_weight = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    service_quantity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TimeWindow",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    start_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    end_time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeWindow", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TimeWindow_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TypeService",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type_service = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClientId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeService", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TypeService_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CubingVariableProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cubing_variable_product = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CubingVariableProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CubingVariableProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CubingVariableProduct_ProductId",
                table: "CubingVariableProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_CubingVariableService_ClientId",
                table: "CubingVariableService",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_DynamicField_ClientId",
                table: "DynamicField",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ClientId",
                table: "Product",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TimeWindow_ClientId",
                table: "TimeWindow",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeService_ClientId",
                table: "TypeService",
                column: "ClientId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CubingVariableProduct");

            migrationBuilder.DropTable(
                name: "CubingVariableService");

            migrationBuilder.DropTable(
                name: "DynamicField");

            migrationBuilder.DropTable(
                name: "TimeWindow");

            migrationBuilder.DropTable(
                name: "TypeService");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Clients");
        }
    }
}
