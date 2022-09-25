using GR.Data.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GR.Data.Maps
{
    public class BookMap
    {
        public BookMap (EntityTypeBuilder <Book> entityBuilder)
        {
            entityBuilder.HasKey(b => b.Id);
            entityBuilder.Property(b => b.Name).IsRequired();
            entityBuilder.Property(b => b.Category).IsRequired();
            entityBuilder.Property(b => b.ISBN).IsRequired();
            entityBuilder.Property(b => b.Publisher).IsRequired();
            entityBuilder.HasOne(e => e.Author).WithMany(e => e.Books).HasForeignKey(e => e.AuthorId);
        }
    }
}