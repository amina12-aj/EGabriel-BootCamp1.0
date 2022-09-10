

using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Book.data
{
    public class AuthorMap
    {
        public AuthorMap(EntityTypeBuilder<Author> entityBuilder)
        {
            entityBuilder.HasKey(a => a.Id);
            entityBuilder.Property(a => a.FirstName).IsRequired();
            entityBuilder.Property(a => a.LastName).IsRequired();
            entityBuilder.Property(a => a.Email).IsRequired();
        }
    }
}