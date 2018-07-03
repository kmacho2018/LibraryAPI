namespace LibraryAPI.Model.DB
{

    // Autor
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class AutorConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Autor>
    {
        public AutorConfiguration()
            : this("dbo")
        {
        }

        public AutorConfiguration(string schema)
        {
            ToTable("Autor", schema);
            HasKey(x => x.AutorId);

            Property(x => x.AutorId).HasColumnName(@"AutorId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            InitializePartial();
        }
        partial void InitializePartial();
    }

}
 
