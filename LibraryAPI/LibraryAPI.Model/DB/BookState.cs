namespace LibraryAPI.Model.DB
{

    // BookState
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public partial class BookState
    {
        public int BookStateId { get; set; } // BookStateId (Primary key)
        public string StateName { get; set; } // StateName (length: 100)
        public string StateDescription { get; set; } // StateDescription (length: 150)
        public System.DateTime? CreationDate { get; set; } // CreationDate

        // Reverse navigation

        /// <summary>
        /// Child Books where [Book].[BookStateId] point to this entity (FK__Book__BookStateI__29572725)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Book> Books { get; set; } // Book.FK__Book__BookStateI__29572725

        public BookState()
        {
            Books = new System.Collections.Generic.List<Book>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
 
