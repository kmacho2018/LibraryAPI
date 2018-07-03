namespace LibraryAPI.Model.DB
{

    // BookFormat
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class BookFormat
    {
        public int BookFormatId { get; set; } // BookFormatId (Primary key)
        public string Name { get; set; } // Name (length: 100)
        public string Description { get; set; } // Description (length: 150)

        public BookFormat()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
 
