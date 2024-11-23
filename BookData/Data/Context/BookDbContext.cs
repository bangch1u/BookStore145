using BookData.Data.Configurations;
using BookData.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookData.Data.Context
{
    public class BookDbContext : DbContext
    {

        public BookDbContext(DbContextOptions options) : base(options)
        {
        }

        //protected BookDbContext()
        //{
        //}

        // Constructor không nhận DbContextOptions từ DI


        // Các DbSet tương ứng với các thực thể trong cơ sở dữ liệu
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        //public DbSet<Publisher> Publisher { get; set; }

        // Phương thức OnConfiguring để cấu hình chuỗi kết nối
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // Đảm bảo chuỗi kết nối đúng
        //    optionsBuilder.UseSqlServer("Data Source=BANGCH1U\\SQLEXPRESS;Initial Catalog=BookShop;Integrated Security=True;Trust Server Certificate=True");
        //}

        // Phương thức cấu hình các thực thể và các quan hệ giữa chúng
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookConfig())
                        .ApplyConfiguration(new OrderDetailConfig());

            // Seeding dữ liệu mẫu cho 10 tác giả
            modelBuilder.Entity<Author>().HasData(
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Nguyen Du",
                    Birth = new DateTime(1765, 1, 1),
                    AuthorImage = "path_to_nguyen_du_image.jpg",
                    Desciption = "Nguyen Du was a famous Vietnamese poet, the author of 'The Tale of Kieu.'"
                },
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Ho Chi Minh",
                    Birth = new DateTime(1890, 5, 19),
                    AuthorImage = "path_to_ho_chi_minh_image.jpg",
                    Desciption = "Ho Chi Minh was a revolutionary leader and the founder of the Democratic Republic of Vietnam."
                },
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Tomaso Marinetti",
                    Birth = new DateTime(1876, 12, 22),
                    AuthorImage = "path_to_tomaso_image.jpg",
                    Desciption = "Tomaso Marinetti was an Italian poet and the founder of the Futurist movement."
                },
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Albert Einstein",
                    Birth = new DateTime(1879, 3, 14),
                    AuthorImage = "path_to_einstein_image.jpg",
                    Desciption = "Albert Einstein was a theoretical physicist, known for developing the theory of relativity."
                },
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Virginia Woolf",
                    Birth = new DateTime(1882, 1, 25),
                    AuthorImage = "path_to_virginia_woolf_image.jpg",
                    Desciption = "Virginia Woolf was an English writer, known for works like 'Mrs. Dalloway' and 'To the Lighthouse.'"
                },
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Leo Tolstoy",
                    Birth = new DateTime(1828, 9, 9),
                    AuthorImage = "path_to_tolstoy_image.jpg",
                    Desciption = "Leo Tolstoy was a Russian author, best known for novels such as 'War and Peace' and 'Anna Karenina.'"
                },
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Mark Twain",
                    Birth = new DateTime(1835, 11, 30),
                    AuthorImage = "path_to_mark_twain_image.jpg",
                    Desciption = "Mark Twain was an American writer and humorist, famous for books like 'The Adventures of Tom Sawyer.'"
                },
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "J.K. Rowling",
                    Birth = new DateTime(1965, 7, 31),
                    AuthorImage = "path_to_jk_rowling_image.jpg",
                    Desciption = "J.K. Rowling is a British author, best known for writing the 'Harry Potter' series."
                },
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Gabriel García Márquez",
                    Birth = new DateTime(1927, 3, 6),
                    AuthorImage = "path_to_garcia_marquez_image.jpg",
                    Desciption = "Gabriel García Márquez was a Colombian author, famous for works like 'One Hundred Years of Solitude.'"
                },
                new Author
                {
                    AuthorId = Guid.NewGuid(),
                    AuthorName = "Franz Kafka",
                    Birth = new DateTime(1883, 7, 3),
                    AuthorImage = "path_to_kafka_image.jpg",
                    Desciption = "Franz Kafka was a German-speaking Bohemian writer, known for works like 'The Trial' and 'The Metamorphosis.'"
                }
            );

            // Seeding dữ liệu mẫu cho Genre
            modelBuilder.Entity<Genre>().HasData(
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Fiction",
                    AgeLimit = 18 // Thể loại này phù hợp cho người từ 18 tuổi trở lên
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Science Fiction",
                    AgeLimit = 15 // Thể loại này phù hợp cho người từ 15 tuổi trở lên
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Fantasy",
                    AgeLimit = 12 // Thể loại này phù hợp cho người từ 12 tuổi trở lên
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Biography",
                    AgeLimit = 18 // Thể loại này dành cho người trưởng thành
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Romance",
                    AgeLimit = 16 // Thể loại này dành cho người từ 16 tuổi trở lên
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Mystery",
                    AgeLimit = 12 // Thể loại này phù hợp cho người từ 12 tuổi trở lên
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Thriller",
                    AgeLimit = 16 // Thể loại này dành cho người từ 16 tuổi trở lên
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Non-Fiction",
                    AgeLimit = 18 // Thể loại này dành cho người trưởng thành
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Historical",
                    AgeLimit = 14 // Thể loại này phù hợp cho người từ 14 tuổi trở lên
                },
                new Genre
                {
                    Id = Guid.NewGuid(),
                    GenreName = "Children's Books",
                    AgeLimit = 6 // Thể loại này dành cho trẻ em từ 6 tuổi trở lên
                }
            );
        }

        
    }
}
