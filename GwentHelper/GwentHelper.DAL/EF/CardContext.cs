using GwentHelper.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace GwentHelper.DAL.EF
{
    class CardContext: DbContext
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Keyword> Keywords { get; set; }
        public CardContext(DbContextOptions<CardContext> options)
            :base(options)
        {
        }
    }
}
