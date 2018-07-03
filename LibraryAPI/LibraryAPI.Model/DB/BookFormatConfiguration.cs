namespace LibraryAPI.Model.DB
{

    // BookFormat
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class BookFormatConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<BookFormat>
    {
        public BookFormatConfiguration()
            : this("dbo")
        {
        }

        public BookFormatConfiguration(string schema)
        {
            ToTable("BookFormat", schema);
            HasKey(x => x.BookFormatId);

            Property(x => x.BookFormatId).HasColumnName(@"BookFormatId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(150);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}