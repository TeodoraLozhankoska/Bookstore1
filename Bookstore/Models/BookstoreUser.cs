enum UserRole
{
    Admin,
    User
}

namespace Bookstore.Models
{
    public class BookstoreUser
    {
        public int Id { get; set; }
        public String Email {  get; set; }

        public String UserName { get; set; }

        public String password { get; set; }

        public String role { get; set; }
    }
}
