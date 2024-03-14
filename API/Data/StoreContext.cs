using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
        //Derive from an Entity Framework class DBContext (represents a session with the db it can be used to query and save instances of our entities : Create , Save , Delete)
    public class StoreContext : DbContext
    {
        //Create a constrctor to pass in some values
        public StoreContext(DbContextOptions options) : base(options)
        {
        }

        //Represents a table in our DB
        public DbSet<Product>Products { get; set; }
    }
}