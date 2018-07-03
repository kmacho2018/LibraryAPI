namespace LibraryAPI.Model.DB
{

    // Book
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class BookConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Book>
    {
        public BookConfiguration()
            : this("dbo")
        {
        }

        public BookConfiguration(string schema)
        {
            ToTable("Book", schema);
            HasKey(x => x.BookId);

            Property(x => x.BookId).HasColumnName(@"BookId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.BookStateId).HasColumnName(@"BookStateId").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.BookState).WithMany(b => b.Books).HasForeignKey(c => c.BookStateId).WillCascadeOnDelete(false); // FK__Book__BookStateI__29572725
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
 
