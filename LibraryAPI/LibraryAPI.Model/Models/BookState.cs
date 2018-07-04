using System;

namespace LibraryAPI.Model.Models
{
    public class BookState
    {
        public int BookStateId { get; set; }
        public string StateName { get; set; }
        public string StateDescription { get; set; }
    }
}