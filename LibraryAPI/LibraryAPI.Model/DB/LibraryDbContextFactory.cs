namespace LibraryAPI.Model.DB
{

    public partial class LibraryDbContextFactory : System.Data.Entity.Infrastructure.IDbContextFactory<LibraryDbContext>
    {
        public LibraryDbContext Create()
        {
            return new LibraryDbContext();
        }
    }
}
 
