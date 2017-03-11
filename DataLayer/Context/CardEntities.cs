using Domain.Card;
using Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Context
{
    public class CardEntities : DbContext
    {
        public CardEntities() : base("CardEntities")
        {
        }

        public DbSet<Card> Cards { get; set; }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CardConfiguration());
        }
    }
}
