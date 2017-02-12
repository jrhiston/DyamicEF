using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace efexample
{
    public class DocumentEntityTypeConfiguration : IEntityTypeConfiguration<Document>
    {
        public DocumentEntityTypeConfiguration(IEnumerable<IDataElement> elements)
        {
            
        }

        public void Map(EntityTypeBuilder<Document> builder)
        {
            
        }
    }
}