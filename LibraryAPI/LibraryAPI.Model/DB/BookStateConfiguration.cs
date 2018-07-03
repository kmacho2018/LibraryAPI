namespace LibraryAPI.Model.DB
{

    // BookState
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class BookStateConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BookState>
    {
        public BookStateConfiguration()
            : this("dbo")
        {
        }

        public BookStateConfiguration(string schema)
        {
            ToTable("BookState", schema);
            HasKey(x => x.BookStateId);

            Property(x => x.BookStateId).HasColumnName(@"BookStateId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.StateName).HasColumnName(@"StateName").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.StateDescription).HasColumnName(@"StateDescription").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            Property(x => x.CreationDate).HasColumnName(@"CreationDate").HasColumnType("datetime").IsOptional();
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
 
