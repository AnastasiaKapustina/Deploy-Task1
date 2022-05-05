using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Task1.Migrations
{
    public partial class SeedDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MultiplicationResults",
                columns: new[] { "Id", "Result" },
                values: new object[,]
                {
                    { new Guid("48e2fd15-c89c-45d5-a3b6-86c5ace54f90"), 4 },
                    { new Guid("367572b0-7767-4611-bd15-0b34f02eefc9"), 5 },
                    { new Guid("fd4a43d5-5b98-484c-9b6c-7a5924815b1d"), 7 },
                    { new Guid("01f4b2a9-6314-4b57-84f9-02ec154f5dba"), 12 },
                    { new Guid("5ac3f5e6-8c3a-4635-a59d-7e80d41493fe"), 21 },
                    { new Guid("b825264d-f263-4589-9072-5fa98bd63e2d"), 24 },
                    { new Guid("7eb83242-297d-4ee3-85fd-f47c422d91fa"), 25 },
                    { new Guid("fc461dcb-f09d-419f-8c56-c8f8a7e485b2"), 32 },
                    { new Guid("9ca6d09b-684e-4479-a9d2-e89c82888a00"), 33 },
                    { new Guid("16a0cecc-0f80-48dc-9476-e1d76a783da2"), 36 },
                    { new Guid("51c1366b-d2e7-4af3-879c-9e6ce410c609"), 39 },
                    { new Guid("6af4dd1b-b9ed-47d6-afed-753cc2bcf92c"), 40 },
                    { new Guid("c3140917-5621-4560-80f7-130bab1b25a8"), 42 },
                    { new Guid("716b6c9b-e84b-4cfd-ad53-e144ff887786"), 44 },
                    { new Guid("6bdac941-7180-4894-bad1-543354f67128"), 45 },
                    { new Guid("a358c338-7e83-4fb6-929b-22dfaefe28e2"), 46 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("01f4b2a9-6314-4b57-84f9-02ec154f5dba"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("16a0cecc-0f80-48dc-9476-e1d76a783da2"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("367572b0-7767-4611-bd15-0b34f02eefc9"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("48e2fd15-c89c-45d5-a3b6-86c5ace54f90"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("51c1366b-d2e7-4af3-879c-9e6ce410c609"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("5ac3f5e6-8c3a-4635-a59d-7e80d41493fe"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("6af4dd1b-b9ed-47d6-afed-753cc2bcf92c"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("6bdac941-7180-4894-bad1-543354f67128"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("716b6c9b-e84b-4cfd-ad53-e144ff887786"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("7eb83242-297d-4ee3-85fd-f47c422d91fa"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("9ca6d09b-684e-4479-a9d2-e89c82888a00"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("a358c338-7e83-4fb6-929b-22dfaefe28e2"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("b825264d-f263-4589-9072-5fa98bd63e2d"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("c3140917-5621-4560-80f7-130bab1b25a8"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("fc461dcb-f09d-419f-8c56-c8f8a7e485b2"));

            migrationBuilder.DeleteData(
                table: "MultiplicationResults",
                keyColumn: "Id",
                keyValue: new Guid("fd4a43d5-5b98-484c-9b6c-7a5924815b1d"));
        }
    }
}
