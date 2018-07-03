namespace LibraryAPI.Model.DB
{

    // BookPage
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class BookPage
    {
        public int BookPageId { get; set; } // BookPageId (Primary key)
        public int? BookId { get; set; } // BookId
        public int? PageNumber { get; set; } // PageNumber
        public string Content { get; set; } // Content (length: 1000)

        // Foreign keys

        /// <summary>
        /// Parent Book pointed by [BookPage].([BookId]) (FK__BookPage__BookId__2C3393D0)
        /// </summary>
        public virtual Book Book { get; set; } // FK__BookPage__BookId__2C3393D0

        public BookPage()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
 
