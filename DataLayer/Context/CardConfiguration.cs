using Domain.Card;
using System.Data.Entity.ModelConfiguration;

namespace DataLayer.Context
{
    public class CardConfiguration : EntityTypeConfiguration<Card>
    {
        public CardConfiguration()
        {
            ToTable("Cards");
            Property(c => c.Name).IsRequired().HasMaxLength(50);
        }
    }
}
