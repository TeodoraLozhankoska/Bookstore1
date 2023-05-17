using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class UserBook
    {
        public int Id { get; set; }  //UserBooks
        [Required]
        [StringLength(450)]
        public string AppUser { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
