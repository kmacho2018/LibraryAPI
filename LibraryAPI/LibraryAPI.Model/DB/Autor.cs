namespace LibraryAPI.Model.DB
{

    // Autor
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class Autor
    {
        public int AutorId { get; set; } // AutorId (Primary key)
        public string Name { get; set; } // Name (length: 100)

        public Autor()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
 
