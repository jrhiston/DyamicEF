using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efexample
{
    public interface IEntityTypeConfiguration<TEntityType> where TEntityType : class
    {
        void Map(EntityTypeBuilder<TEntityType> builder);
    }
}