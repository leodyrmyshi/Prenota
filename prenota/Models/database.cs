 using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;


public class dbContext : DbContext
    {
        
        private readonly DbContextOptions? _options;
        public dbContext(){}

        protected override void 
                OnConfiguring(DbContextOptionsBuilder options)
                => options.UseSqlite("Data Source=database.db");
    }




