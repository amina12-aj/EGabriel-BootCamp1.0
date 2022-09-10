

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book.data
{
    public class BookMap
    {
        public BookMap(EntityTypeBuilder<Book> entityBuilder)
        {
            entityBuilder.HasKey(b => b.Id);
            entityBuilder.Property(b => b.Name).IsRequired();  
            entityBuilder.Property(b => b.ISBN).IsRequired();  
            entityBuilder.Property(b => b.Publisher).IsRequired();  
            entityBuilder.HasOne(b => b.Author).WithMany(a => a.Books).HasForeignKey(b => b.AuthorId);

        }
    }
}