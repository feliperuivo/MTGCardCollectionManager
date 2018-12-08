using MTGCollection.Model;
using System.Configuration;
using System.Data.Entity;

namespace MTGCollection.DataSource
{
    public class EntDbConnection : DbContext
    {
        public EntDbConnection() : base(ConfigurationManager.ConnectionStrings["CardDatabase"].ConnectionString)
        {
        }

        public DbSet<Card> C { get; set; }
    }
}

