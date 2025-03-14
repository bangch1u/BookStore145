﻿// <auto-generated />
using System;
using BookData.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BookData.Migrations
{
    [DbContext(typeof(BookDbContext))]
    partial class BookDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.Property<Guid>("AuthorsAuthorId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("BooksBookId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("AuthorsAuthorId", "BooksBookId");

                    b.HasIndex("BooksBookId");

                    b.ToTable("Book_Author", (string)null);
                });

            modelBuilder.Entity("BookData.Data.Entities.Author", b =>
                {
                    b.Property<Guid>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AuthorImage")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Birth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desciption")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = new Guid("74ef2711-fac6-4c28-8935-b7e6169a1e76"),
                            AuthorImage = "path_to_nguyen_du_image.jpg",
                            AuthorName = "Nguyen Du",
                            Birth = new DateTime(1765, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "Nguyen Du was a famous Vietnamese poet, the author of 'The Tale of Kieu.'"
                        },
                        new
                        {
                            AuthorId = new Guid("668379fd-81e3-44e3-b60b-60683265742a"),
                            AuthorImage = "path_to_ho_chi_minh_image.jpg",
                            AuthorName = "Ho Chi Minh",
                            Birth = new DateTime(1890, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "Ho Chi Minh was a revolutionary leader and the founder of the Democratic Republic of Vietnam."
                        },
                        new
                        {
                            AuthorId = new Guid("de59198d-f494-4530-9d88-9c31ccd4dd0e"),
                            AuthorImage = "path_to_tomaso_image.jpg",
                            AuthorName = "Tomaso Marinetti",
                            Birth = new DateTime(1876, 12, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "Tomaso Marinetti was an Italian poet and the founder of the Futurist movement."
                        },
                        new
                        {
                            AuthorId = new Guid("bedfb6fa-d6cf-4ba6-9e3d-8e92c4b034da"),
                            AuthorImage = "path_to_einstein_image.jpg",
                            AuthorName = "Albert Einstein",
                            Birth = new DateTime(1879, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "Albert Einstein was a theoretical physicist, known for developing the theory of relativity."
                        },
                        new
                        {
                            AuthorId = new Guid("481a8045-29ba-4483-9489-5c597387346b"),
                            AuthorImage = "path_to_virginia_woolf_image.jpg",
                            AuthorName = "Virginia Woolf",
                            Birth = new DateTime(1882, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "Virginia Woolf was an English writer, known for works like 'Mrs. Dalloway' and 'To the Lighthouse.'"
                        },
                        new
                        {
                            AuthorId = new Guid("8fa70f1c-0fce-46bb-8f48-e53e73d0e256"),
                            AuthorImage = "path_to_tolstoy_image.jpg",
                            AuthorName = "Leo Tolstoy",
                            Birth = new DateTime(1828, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "Leo Tolstoy was a Russian author, best known for novels such as 'War and Peace' and 'Anna Karenina.'"
                        },
                        new
                        {
                            AuthorId = new Guid("158e0932-1920-4568-bdab-ae81a1158c76"),
                            AuthorImage = "path_to_mark_twain_image.jpg",
                            AuthorName = "Mark Twain",
                            Birth = new DateTime(1835, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "Mark Twain was an American writer and humorist, famous for books like 'The Adventures of Tom Sawyer.'"
                        },
                        new
                        {
                            AuthorId = new Guid("ea54fd0e-7ae0-4068-90d4-6aa102a6f496"),
                            AuthorImage = "path_to_jk_rowling_image.jpg",
                            AuthorName = "J.K. Rowling",
                            Birth = new DateTime(1965, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "J.K. Rowling is a British author, best known for writing the 'Harry Potter' series."
                        },
                        new
                        {
                            AuthorId = new Guid("251cba60-655a-49eb-897d-012abccf9333"),
                            AuthorImage = "path_to_garcia_marquez_image.jpg",
                            AuthorName = "Gabriel García Márquez",
                            Birth = new DateTime(1927, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "Gabriel García Márquez was a Colombian author, famous for works like 'One Hundred Years of Solitude.'"
                        },
                        new
                        {
                            AuthorId = new Guid("8cfa384e-414e-4076-b8e4-8f9a2ca739b3"),
                            AuthorImage = "path_to_kafka_image.jpg",
                            AuthorName = "Franz Kafka",
                            Birth = new DateTime(1883, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Desciption = "Franz Kafka was a German-speaking Bohemian writer, known for works like 'The Trial' and 'The Metamorphosis.'"
                        });
                });

            modelBuilder.Entity("BookData.Data.Entities.Book", b =>
                {
                    b.Property<Guid>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("BookQRCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CoverImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Desciption")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<DateTime>("PublicationYear")
                        .HasColumnType("datetime2");

                    b.Property<int>("StockQuantity")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.ToTable("Books");
                });

            modelBuilder.Entity("BookData.Data.Entities.Genre", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("AgeLimit")
                        .HasColumnType("int");

                    b.Property<string>("GenreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = new Guid("f058c5e7-e82d-4a33-8928-909a5a165ccc"),
                            AgeLimit = 18,
                            GenreName = "Fiction"
                        },
                        new
                        {
                            Id = new Guid("54be9672-c4b4-498d-880b-0052592fef30"),
                            AgeLimit = 15,
                            GenreName = "Science Fiction"
                        },
                        new
                        {
                            Id = new Guid("ce2b3c9e-4045-461d-bfa9-6702fad88f7e"),
                            AgeLimit = 12,
                            GenreName = "Fantasy"
                        },
                        new
                        {
                            Id = new Guid("f8990b35-da50-4006-bbf7-e10f2d7d50a1"),
                            AgeLimit = 18,
                            GenreName = "Biography"
                        },
                        new
                        {
                            Id = new Guid("9c6038cc-2e11-4bce-a0ca-1075378a3da5"),
                            AgeLimit = 16,
                            GenreName = "Romance"
                        },
                        new
                        {
                            Id = new Guid("cc608676-98ae-462d-bacd-2ed811e5524c"),
                            AgeLimit = 12,
                            GenreName = "Mystery"
                        },
                        new
                        {
                            Id = new Guid("b2edbe3e-24ac-447f-88c5-b1d22ddcf1b2"),
                            AgeLimit = 16,
                            GenreName = "Thriller"
                        },
                        new
                        {
                            Id = new Guid("fcdda390-338e-4522-9655-99ea5cbda270"),
                            AgeLimit = 18,
                            GenreName = "Non-Fiction"
                        },
                        new
                        {
                            Id = new Guid("cf655fed-83af-46ba-a6d2-ef1c44f79c03"),
                            AgeLimit = 14,
                            GenreName = "Historical"
                        },
                        new
                        {
                            Id = new Guid("cf787daf-55a6-4eb9-9da4-163c1532d989"),
                            AgeLimit = 6,
                            GenreName = "Children's Books"
                        });
                });

            modelBuilder.Entity("BookData.Data.Entities.Order", b =>
                {
                    b.Property<Guid>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("PurchaseTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.Property<int>("TotalQuantity")
                        .HasColumnType("int");

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("BookData.Data.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("BookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("BookId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.Property<Guid>("BooksBookId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("GenresId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("BooksBookId", "GenresId");

                    b.HasIndex("GenresId");

                    b.ToTable("Book_Genre", (string)null);
                });

            modelBuilder.Entity("AuthorBook", b =>
                {
                    b.HasOne("BookData.Data.Entities.Author", null)
                        .WithMany()
                        .HasForeignKey("AuthorsAuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookData.Data.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookData.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("BookData.Data.Entities.Book", "Book")
                        .WithMany("OrderDetails")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookData.Data.Entities.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("BookGenre", b =>
                {
                    b.HasOne("BookData.Data.Entities.Book", null)
                        .WithMany()
                        .HasForeignKey("BooksBookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BookData.Data.Entities.Genre", null)
                        .WithMany()
                        .HasForeignKey("GenresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BookData.Data.Entities.Book", b =>
                {
                    b.Navigation("OrderDetails");
                });

            modelBuilder.Entity("BookData.Data.Entities.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
