using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookData.Migrations
{
    /// <inheritdoc />
    public partial class M1_new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AuthorImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    CoverImage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicationYear = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BookQRCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    Desciption = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AgeLimit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<double>(type: "float", nullable: false),
                    PurchaseTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Book_Author",
                columns: table => new
                {
                    AuthorsAuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BooksBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_Author", x => new { x.AuthorsAuthorId, x.BooksBookId });
                    table.ForeignKey(
                        name: "FK_Book_Author_Authors_AuthorsAuthorId",
                        column: x => x.AuthorsAuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Author_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Book_Genre",
                columns: table => new
                {
                    BooksBookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GenresId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Book_Genre", x => new { x.BooksBookId, x.GenresId });
                    table.ForeignKey(
                        name: "FK_Book_Genre_Books_BooksBookId",
                        column: x => x.BooksBookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Book_Genre_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetails",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => new { x.BookId, x.OrderId });
                    table.ForeignKey(
                        name: "FK_OrderDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Book_Author_BooksBookId",
                table: "Book_Author",
                column: "BooksBookId");

            migrationBuilder.CreateIndex(
                name: "IX_Book_Genre_GenresId",
                table: "Book_Genre",
                column: "GenresId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Book_Author");

            migrationBuilder.DropTable(
                name: "Book_Genre");

            migrationBuilder.DropTable(
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Orders");
        }
    }
}
