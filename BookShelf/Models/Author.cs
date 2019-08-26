using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookShelf.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }

        }

        public string Penname { get; set; }
        public string PreferredGenre { get; set; }
        // virtual allows the framework to not automatically pull in Books on a join
        // unless asked for
        public virtual ICollection<Book> Books { get; set; }

        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}