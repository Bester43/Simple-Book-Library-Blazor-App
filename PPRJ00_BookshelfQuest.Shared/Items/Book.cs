using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PPRJ00_BookshelfQuest.Items
{
    // Model class representing a book
    public class Book
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; } = string.Empty;
        public string? Author { get; set; }
        public List<string>? Genres { get; set; }
        public DateOnly? PublicationYear { get; set; }
        public DateOnly? ReadDate { get; set; }
        public string? Status { get; set; }
    }
}
