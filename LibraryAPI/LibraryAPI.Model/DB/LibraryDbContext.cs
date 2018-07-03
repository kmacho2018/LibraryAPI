namespace LibraryAPI.Model.DB
{


    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class LibraryDbContext : System.Data.Entity.DbContext
    {
        public System.Data.Entity.DbSet<Autor> Autors { get; set; } // Autor
        public System.Data.Entity.DbSet<Book> Books { get; set; } // Book
        public System.Data.Entity.DbSet<BookFormat> BookFormats { get; set; } // BookFormat
        public System.Data.Entity.DbSet<BookPage> BookPages { get; set; } // BookPage
        public System.Data.Entity.DbSet<BookState> BookStates { get; set; } // BookState

        static LibraryDbContext()
        {
            System.Data.Entity.Database.SetInitializer<LibraryDbContext>(null);
        }

        public LibraryDbContext()
            : base("Name=LibraryDbContextCon")
        {
            InitializePartial();
        }

        public LibraryDbContext(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public LibraryDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public LibraryDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public LibraryDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            DisposePartial(disposing);
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new AutorConfiguration());
            modelBuilder.Configurations.Add(new BookConfiguration());
            modelBuilder.Configurations.Add(new BookFormatConfiguration());
            modelBuilder.Configurations.Add(new BookPageConfiguration());
            modelBuilder.Configurations.Add(new BookStateConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new AutorConfiguration(schema));
            modelBuilder.Configurations.Add(new BookConfiguration(schema));
            modelBuilder.Configurations.Add(new BookFormatConfiguration(schema));
            modelBuilder.Configurations.Add(new BookPageConfiguration(schema));
            modelBuilder.Configurations.Add(new BookStateConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void DisposePartial(bool disposing);
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);
    }
}
 
