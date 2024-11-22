using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookData.Migrations
{
    /// <inheritdoc />
    public partial class heeee : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("004be899-eeae-4d84-931f-30bd5bc9cab2"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("0467aa65-3e86-4e06-975f-4683371964ad"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("24f739f8-a14f-4882-a11c-d7da3508bf3d"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("27333652-16b9-47d1-bda1-389009338193"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("29205272-1f6a-41cf-8936-4d24ec716b16"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("7f7f26b0-46ac-49a9-9b77-07532f00e6be"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("9fa0df6c-a977-4b06-9fc5-c8f69143132e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("cc20bae7-3216-416e-abef-99d75d247eda"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("cc76633e-58dd-4494-8cf9-edcbec01eb7c"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("e5478055-6d08-474e-8048-0f1bc0599d2c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("34980fcc-3674-4b54-9794-9e58bd003ffa"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("50548792-b94c-4451-a1da-bbcd1a6febcd"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("6af4bcfe-f100-4558-bf0c-04f88ef57236"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("7be899d0-1685-4de9-98f8-cc0dcd4db5a8"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("850fc22d-be17-4921-bcec-62ef74b28b60"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("aee67c1d-1fe0-4d9d-ab92-9379c3a6ea9e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ce90b159-3d47-49c8-8fcf-d2d21b29d38a"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d32e9f36-baa7-4492-b0a2-683978225375"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("d456e618-7558-400e-a657-698b3e145c9c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fb3d734b-3665-4ebc-b783-153c3faa2e9f"));

            migrationBuilder.AlterColumn<string>(
                name: "Desciption",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CoverImage",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "BookQRCode",
                table: "Books",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorImage", "AuthorName", "Birth", "Desciption" },
                values: new object[,]
                {
                    { new Guid("158e0932-1920-4568-bdab-ae81a1158c76"), "path_to_mark_twain_image.jpg", "Mark Twain", new DateTime(1835, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark Twain was an American writer and humorist, famous for books like 'The Adventures of Tom Sawyer.'" },
                    { new Guid("251cba60-655a-49eb-897d-012abccf9333"), "path_to_garcia_marquez_image.jpg", "Gabriel García Márquez", new DateTime(1927, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel García Márquez was a Colombian author, famous for works like 'One Hundred Years of Solitude.'" },
                    { new Guid("481a8045-29ba-4483-9489-5c597387346b"), "path_to_virginia_woolf_image.jpg", "Virginia Woolf", new DateTime(1882, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virginia Woolf was an English writer, known for works like 'Mrs. Dalloway' and 'To the Lighthouse.'" },
                    { new Guid("668379fd-81e3-44e3-b60b-60683265742a"), "path_to_ho_chi_minh_image.jpg", "Ho Chi Minh", new DateTime(1890, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ho Chi Minh was a revolutionary leader and the founder of the Democratic Republic of Vietnam." },
                    { new Guid("74ef2711-fac6-4c28-8935-b7e6169a1e76"), "path_to_nguyen_du_image.jpg", "Nguyen Du", new DateTime(1765, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Du was a famous Vietnamese poet, the author of 'The Tale of Kieu.'" },
                    { new Guid("8cfa384e-414e-4076-b8e4-8f9a2ca739b3"), "path_to_kafka_image.jpg", "Franz Kafka", new DateTime(1883, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franz Kafka was a German-speaking Bohemian writer, known for works like 'The Trial' and 'The Metamorphosis.'" },
                    { new Guid("8fa70f1c-0fce-46bb-8f48-e53e73d0e256"), "path_to_tolstoy_image.jpg", "Leo Tolstoy", new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo Tolstoy was a Russian author, best known for novels such as 'War and Peace' and 'Anna Karenina.'" },
                    { new Guid("bedfb6fa-d6cf-4ba6-9e3d-8e92c4b034da"), "path_to_einstein_image.jpg", "Albert Einstein", new DateTime(1879, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert Einstein was a theoretical physicist, known for developing the theory of relativity." },
                    { new Guid("de59198d-f494-4530-9d88-9c31ccd4dd0e"), "path_to_tomaso_image.jpg", "Tomaso Marinetti", new DateTime(1876, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomaso Marinetti was an Italian poet and the founder of the Futurist movement." },
                    { new Guid("ea54fd0e-7ae0-4068-90d4-6aa102a6f496"), "path_to_jk_rowling_image.jpg", "J.K. Rowling", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "J.K. Rowling is a British author, best known for writing the 'Harry Potter' series." }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "AgeLimit", "GenreName" },
                values: new object[,]
                {
                    { new Guid("54be9672-c4b4-498d-880b-0052592fef30"), 15, "Science Fiction" },
                    { new Guid("9c6038cc-2e11-4bce-a0ca-1075378a3da5"), 16, "Romance" },
                    { new Guid("b2edbe3e-24ac-447f-88c5-b1d22ddcf1b2"), 16, "Thriller" },
                    { new Guid("cc608676-98ae-462d-bacd-2ed811e5524c"), 12, "Mystery" },
                    { new Guid("ce2b3c9e-4045-461d-bfa9-6702fad88f7e"), 12, "Fantasy" },
                    { new Guid("cf655fed-83af-46ba-a6d2-ef1c44f79c03"), 14, "Historical" },
                    { new Guid("cf787daf-55a6-4eb9-9da4-163c1532d989"), 6, "Children's Books" },
                    { new Guid("f058c5e7-e82d-4a33-8928-909a5a165ccc"), 18, "Fiction" },
                    { new Guid("f8990b35-da50-4006-bbf7-e10f2d7d50a1"), 18, "Biography" },
                    { new Guid("fcdda390-338e-4522-9655-99ea5cbda270"), 18, "Non-Fiction" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("158e0932-1920-4568-bdab-ae81a1158c76"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("251cba60-655a-49eb-897d-012abccf9333"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("481a8045-29ba-4483-9489-5c597387346b"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("668379fd-81e3-44e3-b60b-60683265742a"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("74ef2711-fac6-4c28-8935-b7e6169a1e76"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("8cfa384e-414e-4076-b8e4-8f9a2ca739b3"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("8fa70f1c-0fce-46bb-8f48-e53e73d0e256"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("bedfb6fa-d6cf-4ba6-9e3d-8e92c4b034da"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("de59198d-f494-4530-9d88-9c31ccd4dd0e"));

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "AuthorId",
                keyValue: new Guid("ea54fd0e-7ae0-4068-90d4-6aa102a6f496"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("54be9672-c4b4-498d-880b-0052592fef30"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("9c6038cc-2e11-4bce-a0ca-1075378a3da5"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("b2edbe3e-24ac-447f-88c5-b1d22ddcf1b2"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cc608676-98ae-462d-bacd-2ed811e5524c"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("ce2b3c9e-4045-461d-bfa9-6702fad88f7e"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cf655fed-83af-46ba-a6d2-ef1c44f79c03"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("cf787daf-55a6-4eb9-9da4-163c1532d989"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f058c5e7-e82d-4a33-8928-909a5a165ccc"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("f8990b35-da50-4006-bbf7-e10f2d7d50a1"));

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: new Guid("fcdda390-338e-4522-9655-99ea5cbda270"));

            migrationBuilder.AlterColumn<string>(
                name: "Desciption",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CoverImage",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "BookQRCode",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorImage", "AuthorName", "Birth", "Desciption" },
                values: new object[,]
                {
                    { new Guid("004be899-eeae-4d84-931f-30bd5bc9cab2"), "path_to_tolstoy_image.jpg", "Leo Tolstoy", new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leo Tolstoy was a Russian author, best known for novels such as 'War and Peace' and 'Anna Karenina.'" },
                    { new Guid("0467aa65-3e86-4e06-975f-4683371964ad"), "path_to_virginia_woolf_image.jpg", "Virginia Woolf", new DateTime(1882, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Virginia Woolf was an English writer, known for works like 'Mrs. Dalloway' and 'To the Lighthouse.'" },
                    { new Guid("24f739f8-a14f-4882-a11c-d7da3508bf3d"), "path_to_garcia_marquez_image.jpg", "Gabriel García Márquez", new DateTime(1927, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriel García Márquez was a Colombian author, famous for works like 'One Hundred Years of Solitude.'" },
                    { new Guid("27333652-16b9-47d1-bda1-389009338193"), "path_to_einstein_image.jpg", "Albert Einstein", new DateTime(1879, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Albert Einstein was a theoretical physicist, known for developing the theory of relativity." },
                    { new Guid("29205272-1f6a-41cf-8936-4d24ec716b16"), "path_to_jk_rowling_image.jpg", "J.K. Rowling", new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "J.K. Rowling is a British author, best known for writing the 'Harry Potter' series." },
                    { new Guid("7f7f26b0-46ac-49a9-9b77-07532f00e6be"), "path_to_kafka_image.jpg", "Franz Kafka", new DateTime(1883, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Franz Kafka was a German-speaking Bohemian writer, known for works like 'The Trial' and 'The Metamorphosis.'" },
                    { new Guid("9fa0df6c-a977-4b06-9fc5-c8f69143132e"), "path_to_nguyen_du_image.jpg", "Nguyen Du", new DateTime(1765, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nguyen Du was a famous Vietnamese poet, the author of 'The Tale of Kieu.'" },
                    { new Guid("cc20bae7-3216-416e-abef-99d75d247eda"), "path_to_mark_twain_image.jpg", "Mark Twain", new DateTime(1835, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark Twain was an American writer and humorist, famous for books like 'The Adventures of Tom Sawyer.'" },
                    { new Guid("cc76633e-58dd-4494-8cf9-edcbec01eb7c"), "path_to_tomaso_image.jpg", "Tomaso Marinetti", new DateTime(1876, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomaso Marinetti was an Italian poet and the founder of the Futurist movement." },
                    { new Guid("e5478055-6d08-474e-8048-0f1bc0599d2c"), "path_to_ho_chi_minh_image.jpg", "Ho Chi Minh", new DateTime(1890, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ho Chi Minh was a revolutionary leader and the founder of the Democratic Republic of Vietnam." }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "AgeLimit", "GenreName" },
                values: new object[,]
                {
                    { new Guid("34980fcc-3674-4b54-9794-9e58bd003ffa"), 16, "Thriller" },
                    { new Guid("50548792-b94c-4451-a1da-bbcd1a6febcd"), 6, "Children's Books" },
                    { new Guid("6af4bcfe-f100-4558-bf0c-04f88ef57236"), 18, "Biography" },
                    { new Guid("7be899d0-1685-4de9-98f8-cc0dcd4db5a8"), 18, "Non-Fiction" },
                    { new Guid("850fc22d-be17-4921-bcec-62ef74b28b60"), 14, "Historical" },
                    { new Guid("aee67c1d-1fe0-4d9d-ab92-9379c3a6ea9e"), 12, "Mystery" },
                    { new Guid("ce90b159-3d47-49c8-8fcf-d2d21b29d38a"), 12, "Fantasy" },
                    { new Guid("d32e9f36-baa7-4492-b0a2-683978225375"), 18, "Fiction" },
                    { new Guid("d456e618-7558-400e-a657-698b3e145c9c"), 16, "Romance" },
                    { new Guid("fb3d734b-3665-4ebc-b783-153c3faa2e9f"), 15, "Science Fiction" }
                });
        }
    }
}
