namespace LibraryAPI.Model.DB
{

    // BookPage
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class BookPageConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BookPage>
    {
        public BookPageConfiguration()
            : this("dbo")
        {
        }

        public BookPageConfiguration(string schema)
        {
            ToTable("BookPage", schema);
            HasKey(x => x.BookPageId);

            Property(x => x.BookPageId).HasColumnName(@"BookPageId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.BookId).HasColumnName(@"BookId").HasColumnType("int").IsOptional();
            Property(x => x.PageNumber).HasColumnName(@"PageNumber").HasColumnType("int").IsOptional();
            Property(x => x.Content).HasColumnName(@"Content").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(1000);

            // Foreign keys
            HasOptional(a => a.Book).WithMany(b => b.BookPages).HasForeignKey(c => c.BookId).WillCascadeOnDelete(false); // FK__BookPage__BookId__2C3393D0
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
 
