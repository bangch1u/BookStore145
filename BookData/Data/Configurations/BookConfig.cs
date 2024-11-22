using BookData.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookData.Data.Configurations
{
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasMany(s => s.Genres)
                .WithMany(s => s.Books)
                .UsingEntity(tb => tb.ToTable("Book_Genre"));

            builder.HasMany(b => b.Authors)
                .WithMany(b => b.Books)
                .UsingEntity(tb => tb.ToTable("Book_Author"));
                

        }
    }
}
