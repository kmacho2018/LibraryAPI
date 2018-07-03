namespace LibraryAPI.Model.DB
{

    public interface ILibraryDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<Autor> Autors { get; set; } // Autor
        System.Data.Entity.DbSet<Book> Books { get; set; } // Book
        System.Data.Entity.DbSet<BookFormat> BookFormats { get; set; } // BookFormat
        System.Data.Entity.DbSet<BookPage> BookPages { get; set; } // BookPage
        System.Data.Entity.DbSet<BookState> BookStates { get; set; } // BookState

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();
    }

}
 
