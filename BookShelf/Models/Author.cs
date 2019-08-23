using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Author
    {
        [Required]
        public int? Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }

        }

        public string PenName { get; set; }
        public string PreferredGenre { get; set; }
        public List<Book> Books { get; set; }
        [Required]
        public int ApplicationUserId { get; set; }
    }
}