using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace serverside.Migrations
{
    public partial class TestXtramile : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "country",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    uuid = table.Column<string>(type: "varchar(255)", nullable: true),
                    name = table.Column<string>(type: "longtext", nullable: true),
                    longtitude = table.Column<int>(type: "int", nullable: false),
                    latitude = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_country", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "cities",
                columns: table => new
                {
                    ID = table.Column<long>(type: "bigint(20)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    uuid = table.Column<string>(type: "varchar(255)", nullable: true),
                    name = table.Column<string>(type: "longtext", nullable: true),
                    location = table.Column<int>(type: "int", nullable: false),
                    time = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    wind = table.Column<int>(type: "int", nullable: false),
                    visibility = table.Column<int>(type: "int", nullable: false),
                    sky_condition = table.Column<string>(type: "longtext", nullable: true),
                    temp_celcius = table.Column<int>(type: "int", nullable: false),
                    temp_fahrenheit = table.Column<int>(type: "int", nullable: false),
                    dew_point = table.Column<int>(type: "int", nullable: false),
                    relative_humidility = table.Column<int>(type: "int", nullable: false),
                    pressure = table.Column<int>(type: "int", nullable: false),
                    countryID = table.Column<long>(type: "bigint(20)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    UpdateDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.ComputedColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cities", x => x.ID);
                    table.ForeignKey(
                        name: "FK_cities_country_countryID",
                        column: x => x.countryID,
                        principalTable: "country",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "country",
                columns: new[] { "ID", "latitude", "longtitude", "name", "uuid" },
                values: new object[] { 1L, 20, 203, "Indonesia", "dcb78c2c-208d-4c39-8b49-c3b70318eadb" });

            migrationBuilder.InsertData(
                table: "country",
                columns: new[] { "ID", "latitude", "longtitude", "name", "uuid" },
                values: new object[] { 2L, 30, 303, "America", "9a7164f8-b683-4117-aae1-904cb777e718" });

            migrationBuilder.InsertData(
                table: "country",
                columns: new[] { "ID", "latitude", "longtitude", "name", "uuid" },
                values: new object[] { 3L, 40, 403, "China", "1a4583de-c1b4-4f5b-a44f-bde2ea86b98e" });

            migrationBuilder.InsertData(
                table: "cities",
                columns: new[] { "ID", "countryID", "dew_point", "location", "name", "pressure", "relative_humidility", "sky_condition", "temp_celcius", "temp_fahrenheit", "time", "uuid", "visibility", "wind" },
                values: new object[,]
                {
                    { 1L, 1L, 2, 222, "Bandung", 203, 232, "rain", 20, 30, new DateTime(2023, 3, 26, 20, 4, 44, 921, DateTimeKind.Local).AddTicks(6596), "d19382ee-0e8a-432f-9bda-a6f2f3a78221", 7002, 222 },
                    { 2L, 1L, 2, 232, "Jakarta", 431, 522, "rain", 10, 5, new DateTime(2023, 3, 26, 20, 4, 44, 923, DateTimeKind.Local).AddTicks(8042), "3c676289-ffbc-4e77-a0ed-09f5b435bdbc", 7003, 2222 },
                    { 3L, 2L, 3, 231, "New York", 455, 123, "rain", 15, 19, new DateTime(2023, 3, 27, 1, 4, 44, 923, DateTimeKind.Local).AddTicks(8122), "4f088bc8-5a61-4aae-aff8-a5a1ed8ae844", 703, 222 },
                    { 4L, 2L, 3, 456, "Washington", 123, 789, "rain", 9, 7, new DateTime(2023, 3, 27, 1, 4, 44, 923, DateTimeKind.Local).AddTicks(8128), "d3e713d2-b7c4-46a8-96e9-d24bc66eb02f", 7023, 333 },
                    { 5L, 3L, 4, 555, "Maoming", 444, 666, "rain", 13, 44, new DateTime(2023, 3, 26, 22, 4, 44, 923, DateTimeKind.Local).AddTicks(8131), "ce149021-bbe7-4fec-ba14-bc9205834525", 7233, 456 },
                    { 6L, 3L, 5, 666, "Beijing", 555, 777, "rain", 14, 22, new DateTime(2023, 3, 26, 22, 4, 44, 923, DateTimeKind.Local).AddTicks(8135), "5f54d93d-05e1-4964-be49-60b860d824b5", 7233, 657 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_cities_countryID",
                table: "cities",
                column: "countryID");

            migrationBuilder.CreateIndex(
                name: "IX_cities_uuid",
                table: "cities",
                column: "uuid",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_country_uuid",
                table: "country",
                column: "uuid",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cities");

            migrationBuilder.DropTable(
                name: "country");
        }
    }
}
