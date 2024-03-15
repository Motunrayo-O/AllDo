using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AllDo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Testmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("1f4da944-7fe6-4636-89d7-60acaa684410"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("69ee876a-2852-4c17-b5d4-1a680e09d32e"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("89657dc5-6ff1-43ce-844e-783e5cd9e94a"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("9319f7a3-a051-4af9-b295-e91c077bb0fa"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("afb3b228-5f6b-456f-abf2-600ce1a7ebf9"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("b9137577-6fc0-4847-8ad5-4f26c806cd2a"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("e5d34104-6a81-4e63-8859-4808e30f7b3b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("f5f362f6-4bb2-4671-bc42-0bdaceac1563"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("392731cb-8a70-4719-b63c-0a30951d7679"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("6ef8dd83-a5f5-4850-b32d-5fabe3b68d60"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9ef0e7ec-5336-4242-8a4b-64b081078ca3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "Todo",
                type: "TEXT",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"), "Paul Dyson" },
                    { new Guid("0eabde08-5118-4153-8b56-df78cd85a1d3"), "Jason Derulo" },
                    { new Guid("3b060441-bece-4d89-9291-19471e3b76e6"), "Tiwa Savage" },
                    { new Guid("406a7c7c-3173-4902-8d71-e8f4e0391edc"), "Mohbad " },
                    { new Guid("cbc116d6-926e-4eae-aa65-84af773f1080"), "Robyn Fenty" }
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AssignedToId", "Component", "CreatedById", "CreatedDate", "Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Priority", "Title" },
                values: new object[] { new Guid("12383f05-427d-4be1-ad51-d268b328626d"), new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"), "Component 2", new Guid("406a7c7c-3173-4902-8d71-e8f4e0391edc"), new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)), "Shortbread shortbread I love cake chocolate marzipan.. Tart marshmallow halvah powder jelly-o wafer macaroo", "Feature", new DateTimeOffset(new DateTime(2024, 4, 2, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4150), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Split Payments" });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AffectedUsers", "AffectedVersion", "Bug_AssignedToId", "CreatedById", "CreatedDate", "Bug_Description", "Discriminator", "DueDate", "ImageId", "IsCompleted", "IsDeleted", "ParentId", "Severity", "Title" },
                values: new object[,]
                {
                    { new Guid("55cb849a-d82b-47ed-949f-a6048a20f7be"), 5, "1.2", null, new Guid("0eabde08-5118-4153-8b56-df78cd85a1d3"), new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4050), new TimeSpan(0, 0, 0, 0, 0)), "Alignment on second wizard screen uneven", "Bug", new DateTimeOffset(new DateTime(2024, 3, 19, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4030), new TimeSpan(0, 0, 0, 0, 0)), null, false, false, null, 2, "Fix Alignment" },
                    { new Guid("720b2e86-0626-458b-8fab-0cf8381ef6cb"), 200, "1.2", null, new Guid("406a7c7c-3173-4902-8d71-e8f4e0391edc"), new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 0, 0, 0, 0)), "Incorrect Result calculated for Interest repayments", "Bug", new DateTimeOffset(new DateTime(2024, 4, 2, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4080), new TimeSpan(0, 0, 0, 0, 0)), null, false, false, null, 0, "Summary Calculations Wrong" }
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AssignedToId", "Component", "CreatedById", "CreatedDate", "Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Priority", "Title" },
                values: new object[] { new Guid("8bb33ab9-f8bc-4698-b302-29b8a1c661f1"), new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"), "Component 3", new Guid("406a7c7c-3173-4902-8d71-e8f4e0391edc"), new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)), "Marzipan candy croissant carrot cake sugar plum marzipan jujubes marshmallow sugar plum. Tart marshmallow halvah powder jelly-o wafer macaroo", "Feature", new DateTimeOffset(new DateTime(2024, 4, 2, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4130), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "User Preferences" });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AffectedUsers", "AffectedVersion", "Bug_AssignedToId", "CreatedById", "CreatedDate", "Bug_Description", "Discriminator", "DueDate", "ImageId", "IsCompleted", "IsDeleted", "ParentId", "Severity", "Title" },
                values: new object[] { new Guid("a1b39edd-92bd-49f8-9d0b-16f4c4ac36f8"), 450, "1.2", null, new Guid("cbc116d6-926e-4eae-aa65-84af773f1080"), new DateTimeOffset(new DateTime(2024, 3, 14, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 0, 0, 0, 0)), "Array Index out of bounds ecxeption", "Bug", new DateTimeOffset(new DateTime(2024, 3, 16, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4060), new TimeSpan(0, 0, 0, 0, 0)), null, false, false, null, 0, "Splash Screen Exception" });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AssignedToId", "Component", "CreatedById", "CreatedDate", "Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Priority", "Title" },
                values: new object[,]
                {
                    { new Guid("e2c875b6-61b8-4c23-9ea0-1716e7a58893"), new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"), "Component 2", new Guid("cbc116d6-926e-4eae-aa65-84af773f1080"), new DateTimeOffset(new DateTime(2024, 3, 14, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)), "Gingerbread cupcake carrot cake dragée chocolate bar chupa chups. Lemon drops cheesecake jelly-o I love dessert ice cream. Sugar plum cheesecake topping candy pie pastry. I love sugar plum bonbon dragée macaroon I love I love.", "Feature", new DateTimeOffset(new DateTime(2024, 3, 16, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4120), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Advisor Insights" },
                    { new Guid("eaf722ef-06c1-4861-92fd-f0977d4120da"), new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"), "Component 1", new Guid("0eabde08-5118-4153-8b56-df78cd85a1d3"), new DateTimeOffset(new DateTime(2024, 3, 5, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4110), new TimeSpan(0, 0, 0, 0, 0)), "Tart brownie macaroon wafer bear claw tiramisu apple pie. Cake soufflé cotton candy pudding cheesecake carrot cake cupcake. Danish ice cream chocolate bar sugar plum sugar plum lemon drops. Danish I love donut lemon drops chupa chups. Cake cake marzipan icing cake marzipan oat cake. Cotton candy liquorice toffee caramels wafer jelly beans fruitcake cotton candy. Toffee soufflé chupa chups powder candy gummi bears. Cookie dessert pudding I love gingerbread bear claw fruitcake candy.", "Feature", new DateTimeOffset(new DateTime(2024, 3, 19, 22, 16, 30, 590, DateTimeKind.Unspecified).AddTicks(4100), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Fractional Interest Rates" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("12383f05-427d-4be1-ad51-d268b328626d"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("55cb849a-d82b-47ed-949f-a6048a20f7be"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("720b2e86-0626-458b-8fab-0cf8381ef6cb"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("8bb33ab9-f8bc-4698-b302-29b8a1c661f1"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("a1b39edd-92bd-49f8-9d0b-16f4c4ac36f8"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("e2c875b6-61b8-4c23-9ea0-1716e7a58893"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("eaf722ef-06c1-4861-92fd-f0977d4120da"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b060441-bece-4d89-9291-19471e3b76e6"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0d4435d9-6e04-43fa-8da1-ba1c7588bc13"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0eabde08-5118-4153-8b56-df78cd85a1d3"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("406a7c7c-3173-4902-8d71-e8f4e0391edc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("cbc116d6-926e-4eae-aa65-84af773f1080"));

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Todo");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("392731cb-8a70-4719-b63c-0a30951d7679"), "Robyn Fenty" },
                    { new Guid("6ef8dd83-a5f5-4850-b32d-5fabe3b68d60"), "Mohbad " },
                    { new Guid("9ef0e7ec-5336-4242-8a4b-64b081078ca3"), "Jason Derulo" },
                    { new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"), "Paul Dyson" },
                    { new Guid("f5f362f6-4bb2-4671-bc42-0bdaceac1563"), "Tiwa Savage" }
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AffectedUsers", "AffectedVersion", "Bug_AssignedToId", "CreatedById", "CreatedDate", "Bug_Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Severity", "Title" },
                values: new object[,]
                {
                    { new Guid("1f4da944-7fe6-4636-89d7-60acaa684410"), 450, "1.2", null, new Guid("392731cb-8a70-4719-b63c-0a30951d7679"), new DateTimeOffset(new DateTime(2024, 3, 14, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6190), new TimeSpan(0, 0, 0, 0, 0)), "Array Index out of bounds ecxeption", "Bug", new DateTimeOffset(new DateTime(2024, 3, 16, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6190), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Splash Screen Exception" },
                    { new Guid("69ee876a-2852-4c17-b5d4-1a680e09d32e"), 200, "1.2", null, new Guid("6ef8dd83-a5f5-4850-b32d-5fabe3b68d60"), new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)), "Incorrect Result calculated for Interest repayments", "Bug", new DateTimeOffset(new DateTime(2024, 4, 2, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6210), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Summary Calculations Wrong" },
                    { new Guid("89657dc5-6ff1-43ce-844e-783e5cd9e94a"), 5, "1.2", null, new Guid("9ef0e7ec-5336-4242-8a4b-64b081078ca3"), new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6180), new TimeSpan(0, 0, 0, 0, 0)), "Alignment on second wizard screen uneven", "Bug", new DateTimeOffset(new DateTime(2024, 3, 19, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6160), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 2, "Fix Alignment!" }
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AssignedToId", "Component", "CreatedById", "CreatedDate", "Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Priority", "Title" },
                values: new object[,]
                {
                    { new Guid("9319f7a3-a051-4af9-b295-e91c077bb0fa"), new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"), "Component 1", new Guid("9ef0e7ec-5336-4242-8a4b-64b081078ca3"), new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, 0, 0, 0, 0)), "Tart brownie macaroon wafer bear claw tiramisu apple pie. Cake soufflé cotton candy pudding cheesecake carrot cake cupcake. Danish ice cream chocolate bar sugar plum sugar plum lemon drops. Danish I love donut lemon drops chupa chups. Cake cake marzipan icing cake marzipan oat cake. Cotton candy liquorice toffee caramels wafer jelly beans fruitcake cotton candy. Toffee soufflé chupa chups powder candy gummi bears. Cookie dessert pudding I love gingerbread bear claw fruitcake candy.", "Feature", new DateTimeOffset(new DateTime(2024, 3, 19, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6240), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Fractional Interest Rates" },
                    { new Guid("afb3b228-5f6b-456f-abf2-600ce1a7ebf9"), new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"), "Component 3", new Guid("6ef8dd83-a5f5-4850-b32d-5fabe3b68d60"), new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 0, 0, 0, 0)), "Marzipan candy croissant carrot cake sugar plum marzipan jujubes marshmallow sugar plum. Tart marshmallow halvah powder jelly-o wafer macaroo", "Feature", new DateTimeOffset(new DateTime(2024, 4, 2, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6270), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "User Preferences" },
                    { new Guid("b9137577-6fc0-4847-8ad5-4f26c806cd2a"), new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"), "Component 2", new Guid("392731cb-8a70-4719-b63c-0a30951d7679"), new DateTimeOffset(new DateTime(2024, 3, 14, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 0, 0, 0, 0)), "Gingerbread cupcake carrot cake dragée chocolate bar chupa chups. Lemon drops cheesecake jelly-o I love dessert ice cream. Sugar plum cheesecake topping candy pie pastry. I love sugar plum bonbon dragée macaroon I love I love.", "Feature", new DateTimeOffset(new DateTime(2024, 3, 16, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6250), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Advisor Insights" },
                    { new Guid("e5d34104-6a81-4e63-8859-4808e30f7b3b"), new Guid("ec0c4be6-6054-4cf4-a7f8-6c59e5f178ca"), "Component 2", new Guid("6ef8dd83-a5f5-4850-b32d-5fabe3b68d60"), new DateTimeOffset(new DateTime(2024, 3, 5, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)), "Shortbread shortbread I love cake chocolate marzipan.. Tart marshmallow halvah powder jelly-o wafer macaroo", "Feature", new DateTimeOffset(new DateTime(2024, 4, 2, 21, 10, 16, 622, DateTimeKind.Unspecified).AddTicks(6280), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Split Payments" }
                });
        }
    }
}
