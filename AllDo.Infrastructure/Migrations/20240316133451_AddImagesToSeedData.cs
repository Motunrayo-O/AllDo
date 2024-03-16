using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AllDo.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddImagesToSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Todo_BugId",
                table: "Images");

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

            migrationBuilder.AlterColumn<Guid>(
                name: "BugId",
                table: "Images",
                type: "TEXT",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("61c091a8-534a-4330-b468-43223dd79f0c"), "Robyn Fenty" },
                    { new Guid("644d7218-42f9-479c-8436-ebe5224af97e"), "Jason Derulo" },
                    { new Guid("72e1d4c7-ceff-44db-b9b6-d177813941ff"), "Mohbad " },
                    { new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"), "Paul Dyson" },
                    { new Guid("8e04647a-8ce1-413d-a6b1-c3623cb74e95"), "Tiwa Savage" }
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AssignedToId", "Component", "CreatedById", "CreatedDate", "Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Priority", "Title" },
                values: new object[] { new Guid("336bdb86-29c7-4a45-91ae-404886969a36"), new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"), "Component 1", new Guid("644d7218-42f9-479c-8436-ebe5224af97e"), new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7860), new TimeSpan(0, 0, 0, 0, 0)), "Tart brownie macaroon wafer bear claw tiramisu apple pie. Cake soufflé cotton candy pudding cheesecake carrot cake cupcake. Danish ice cream chocolate bar sugar plum sugar plum lemon drops. Danish I love donut lemon drops chupa chups. Cake cake marzipan icing cake marzipan oat cake. Cotton candy liquorice toffee caramels wafer jelly beans fruitcake cotton candy. Toffee soufflé chupa chups powder candy gummi bears. Cookie dessert pudding I love gingerbread bear claw fruitcake candy.", "Feature", new DateTimeOffset(new DateTime(2024, 3, 20, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7850), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Fractional Interest Rates" });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AffectedUsers", "AffectedVersion", "Bug_AssignedToId", "CreatedById", "CreatedDate", "Bug_Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Severity", "Title" },
                values: new object[] { new Guid("3e8d5d50-6727-40c1-b9fc-4817b27aedcc"), 5, "1.2", null, new Guid("644d7218-42f9-479c-8436-ebe5224af97e"), new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7680), new TimeSpan(0, 0, 0, 0, 0)), "Alignment on second wizard screen uneven", "Bug", new DateTimeOffset(new DateTime(2024, 3, 20, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7660), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 2, "Fix Alignment" });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AssignedToId", "Component", "CreatedById", "CreatedDate", "Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Priority", "Title" },
                values: new object[,]
                {
                    { new Guid("5708c5aa-4430-4f79-bd2a-fd23bab7f640"), new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"), "Component 2", new Guid("61c091a8-534a-4330-b468-43223dd79f0c"), new DateTimeOffset(new DateTime(2024, 3, 15, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 0, 0, 0, 0)), "Gingerbread cupcake carrot cake dragée chocolate bar chupa chups. Lemon drops cheesecake jelly-o I love dessert ice cream. Sugar plum cheesecake topping candy pie pastry. I love sugar plum bonbon dragée macaroon I love I love.", "Feature", new DateTimeOffset(new DateTime(2024, 3, 17, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7870), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Advisor Insights" },
                    { new Guid("5e2cef00-7800-4d0c-abf4-2ff25d060076"), new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"), "Component 3", new Guid("72e1d4c7-ceff-44db-b9b6-d177813941ff"), new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7890), new TimeSpan(0, 0, 0, 0, 0)), "Marzipan candy croissant carrot cake sugar plum marzipan jujubes marshmallow sugar plum. Tart marshmallow halvah powder jelly-o wafer macaroo", "Feature", new DateTimeOffset(new DateTime(2024, 4, 3, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7890), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "User Preferences" }
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AffectedUsers", "AffectedVersion", "Bug_AssignedToId", "CreatedById", "CreatedDate", "Bug_Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Severity", "Title" },
                values: new object[,]
                {
                    { new Guid("9f2a863d-c7af-4b61-9bff-765d6f26dca2"), 450, "1.2", null, new Guid("61c091a8-534a-4330-b468-43223dd79f0c"), new DateTimeOffset(new DateTime(2024, 3, 15, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), "Array Index out of bounds ecxeption", "Bug", new DateTimeOffset(new DateTime(2024, 3, 17, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7700), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Splash Screen Exception" },
                    { new Guid("cdc8bcbb-a2da-4818-8c0f-c729269c00eb"), 200, "1.2", null, new Guid("72e1d4c7-ceff-44db-b9b6-d177813941ff"), new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), "Incorrect Result calculated for Interest repayments", "Bug", new DateTimeOffset(new DateTime(2024, 4, 3, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7710), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Summary Calculations Wrong" }
                });

            migrationBuilder.InsertData(
                table: "Todo",
                columns: new[] { "Id", "AssignedToId", "Component", "CreatedById", "CreatedDate", "Description", "Discriminator", "DueDate", "IsCompleted", "IsDeleted", "ParentId", "Priority", "Title" },
                values: new object[] { new Guid("fc553fdb-1f79-48cc-b360-3d824a408283"), new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"), "Component 2", new Guid("72e1d4c7-ceff-44db-b9b6-d177813941ff"), new DateTimeOffset(new DateTime(2024, 3, 6, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 0, 0, 0, 0)), "Shortbread shortbread I love cake chocolate marzipan.. Tart marshmallow halvah powder jelly-o wafer macaroo", "Feature", new DateTimeOffset(new DateTime(2024, 4, 3, 13, 34, 51, 800, DateTimeKind.Unspecified).AddTicks(7900), new TimeSpan(0, 0, 0, 0, 0)), false, false, null, 0, "Split Payments" });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "Id", "BugId", "ImageData" },
                values: new object[] { new Guid("4f894d7b-bb3b-47da-b220-2762420c8f70"), new Guid("3e8d5d50-6727-40c1-b9fc-4817b27aedcc"), "iVBORw0KGgoAAAANSUhEUgAAAQAAAAEACAIAAADTED8xAAADMElEQVR4nOzVwQnAIBQFQYXff81RUkQCOyDj1YOPnbXWPmeTRef+/3O/OyBjzh3CD95BfqICMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMK0CMO0TAAD//2Anhf4QtqobAAAAAElFTkSuQmCC" });

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Todo_BugId",
                table: "Images",
                column: "BugId",
                principalTable: "Todo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Images_Todo_BugId",
                table: "Images");

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "Id",
                keyValue: new Guid("4f894d7b-bb3b-47da-b220-2762420c8f70"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("336bdb86-29c7-4a45-91ae-404886969a36"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("5708c5aa-4430-4f79-bd2a-fd23bab7f640"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("5e2cef00-7800-4d0c-abf4-2ff25d060076"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("9f2a863d-c7af-4b61-9bff-765d6f26dca2"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("cdc8bcbb-a2da-4818-8c0f-c729269c00eb"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("fc553fdb-1f79-48cc-b360-3d824a408283"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("8e04647a-8ce1-413d-a6b1-c3623cb74e95"));

            migrationBuilder.DeleteData(
                table: "Todo",
                keyColumn: "Id",
                keyValue: new Guid("3e8d5d50-6727-40c1-b9fc-4817b27aedcc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("61c091a8-534a-4330-b468-43223dd79f0c"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("72e1d4c7-ceff-44db-b9b6-d177813941ff"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("898e833d-6519-420a-8792-061c5d3d4e1e"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("644d7218-42f9-479c-8436-ebe5224af97e"));

            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "Todo",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "BugId",
                table: "Images",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "TEXT");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Images_Todo_BugId",
                table: "Images",
                column: "BugId",
                principalTable: "Todo",
                principalColumn: "Id");
        }
    }
}
