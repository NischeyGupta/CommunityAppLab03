using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CommunityApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "Cities",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "Population",
                value: 675218);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Victoria", 85792 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Kelowna", 144576 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                columns: new[] { "CityName", "Population", "ProvinceCode" },
                values: new object[] { "Surrey", 568322, "BC" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Toronto", 2930000 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Ottawa", 1010000 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7,
                columns: new[] { "CityName", "Population", "ProvinceCode" },
                values: new object[] { "Mississauga", 721599, "ON" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8,
                columns: new[] { "CityName", "Population", "ProvinceCode" },
                values: new object[] { "Hamilton", 569353, "ON" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Edmonton", 981280 });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode" },
                values: new object[,]
                {
                    { 10, "Calgary", 1239000, "AB" },
                    { 11, "Red Deer", 103588, "AB" }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "MB", "Manitoba" },
                    { "NB", "New Brunswick" },
                    { "NL", "Newfoundland and Labrador" },
                    { "NS", "Nova Scotia" },
                    { "NT", "Northwest Territories" },
                    { "NU", "Nunavut" },
                    { "PE", "Prince Edward Island" },
                    { "QC", "Quebec" },
                    { "SK", "Saskatchewan" },
                    { "YT", "Yukon" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "ProvinceCode" },
                values: new object[,]
                {
                    { 12, "Montreal", 1780000, "QC" },
                    { 13, "Quebec City", 531902, "QC" },
                    { 14, "Laval", 422993, "QC" },
                    { 15, "Winnipeg", 749607, "MB" },
                    { 16, "Brandon", 48859, "MB" },
                    { 17, "Saskatoon", 273010, "SK" },
                    { 18, "Regina", 236481, "SK" },
                    { 19, "Halifax", 448544, "NS" },
                    { 20, "Moncton", 79470, "NB" },
                    { 21, "Fredericton", 63116, "NB" },
                    { 22, "St. John's", 110525, "NL" },
                    { 23, "Charlottetown", 36094, "PE" },
                    { 24, "Yellowknife", 20100, "NT" },
                    { 25, "Whitehorse", 25136, "YT" },
                    { 26, "Iqaluit", 7740, "NU" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "MB");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "NB");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "NL");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "NS");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "NT");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "NU");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "PE");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "QC");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "SK");

            migrationBuilder.DeleteData(
                table: "Provinces",
                keyColumn: "ProvinceCode",
                keyValue: "YT");

            migrationBuilder.AlterColumn<string>(
                name: "CityName",
                table: "Cities",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "Population",
                value: 706012);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Surrey", 633234 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Richmond", 222954 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 4,
                columns: new[] { "CityName", "Population", "ProvinceCode" },
                values: new object[] { "Toronto", 3026000, "ON" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 5,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Ottawa", 1072000 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 6,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "London", 448051 });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 7,
                columns: new[] { "CityName", "Population", "ProvinceCode" },
                values: new object[] { "Calgary", 1414000, "AB" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 8,
                columns: new[] { "CityName", "Population", "ProvinceCode" },
                values: new object[] { "Edmonton", 1087000, "AB" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 9,
                columns: new[] { "CityName", "Population" },
                values: new object[] { "Banff", 8305 });
        }
    }
}
