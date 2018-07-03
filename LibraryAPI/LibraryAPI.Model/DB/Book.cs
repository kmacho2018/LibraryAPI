namespace LibraryAPI.Model.DB
{

    // Book
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class Book
    {
        public int BookId { get; set; } // BookId (Primary key)
        public string Name { get; set; } // Name (length: 100)
        public int? BookStateId { get; set; } // BookStateId

        // Reverse navigation

        /// <summary>
        /// Child BookPages where [BookPage].[BookId] point to this entity (FK__BookPage__BookId__2C3393D0)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<BookPage> BookPages { get; set; } // BookPage.FK__BookPage__BookId__2C3393D0

        // Foreign keys

        /// <summary>
        /// Parent BookState pointed by [Book].([BookStateId]) (FK__Book__BookStateI__29572725)
        /// </summary>
        public virtual BookState BookState { get; set; } // FK__Book__BookStateI__29572725

        public Book()
        {
            BookPages = new System.Collections.Generic.List<BookPage>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
 
