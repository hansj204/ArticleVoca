using Word_of_the_Day.Model;
using System.Data.Entity;

namespace Word_of_the_Day.Controller
{
    class mssqlDBContext : DbContext
    {
        public mssqlDBContext() : base("vocaDBEntities")
        {

        }

        public mssqlDBContext(string connectionString) : base(connectionString) {}

        public DbSet<userInfo> userInfo { get; set; }

        public DbSet<vocabulary> vocabulary { get; set; }

    }
}
