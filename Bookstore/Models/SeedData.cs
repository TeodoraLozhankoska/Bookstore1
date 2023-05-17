using Microsoft.EntityFrameworkCore;
using System.IO;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Data;

namespace Bookstore.Models
{
    public class SeedData
    {
        public static async Task CreateUserRoles(IServiceProvider serviceProvider)
        {
  
        }
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new BookstoreContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<BookstoreContext>>());

            // CreateUserRoles(serviceProvider).Wait();

           
            if (context.Author.Any() && context.Genre.Any() && context.BookGenre.Any())
            {
                return;  
            }

            context.Author.AddRange(
                new Author
                {
                    FirstName = "Dan",
                    LastName = "Brown",
                    Nationality = "American",
                    Gender = "Male",
                    BirthDate = DateTime.Parse("196-6-22"),
                    Books = new List<Book> {
                         new Book
                         {
                            
                             Title = "The Da Vinci Code",
                             YearPublished = 2003,
                             NumPages = 454,
                             Description = "Dan Brown's gripping thriller follows symbologist Robert Langdon as he unravels a complex mystery involving religious symbolism, secret societies, and a quest for a hidden artifact. It's a fast-paced and suspenseful adventure that intertwines art, history, and conspiracy.",
                             Publisher = "Doubleday",
                             FrontPage = "https://i.scdn.co/image/ab67616d0000b273ad2137d5ee5a7cae407dc073",
                             DownloadURL = "https://ia800404.us.archive.org/9/items/TheDaVinciCode_201308/The%20Da%20Vinci%20Code.pdf",
                             AuthorId = 1,

                             Reviews = new List<Review>
                             {
                                new Review { AppUser = "1@user.com", Comment = "Good", Rating = 8, BookId = 1},
                                new Review { AppUser = "2@user.com", Comment = "Good", Rating = 5, BookId = 1}
                             },


                             UserBooks = new List<UserBook>
                             {
                                new UserBook { AppUser = "1@user.com", BookId = 1 },
                                new UserBook { AppUser = "2@user.com", BookId = 1 }
                             }
                         }
                    }
                },
                new Author
                { 
                    FirstName = "Suzanne",
                    LastName = "Collins",
                    Nationality = "American",
                    Gender = "Female",
                    BirthDate = DateTime.Parse("1962-8-10"),
                    Books = new List<Book> {
                          new Book
                          {
                              
                                Title = "The Hunger Games",
                                YearPublished = 2008,
                                NumPages = 374,
                                Description = "Suzanne Collins' dystopian novel is set in a post-apocalyptic world where teenagers from different districts are forced to participate in a televised fight to the death known as the Hunger Games. It explores themes of survival, government oppression, and rebellion.",
                                Publisher = "Scholastic",
                                FrontPage = "https://upload.wikimedia.org/wikipedia/en/3/39/The_Hunger_Games_cover.jpg",
                                DownloadURL = "https://docs.google.com/viewer?a=v&pid=sites&srcid=c21jc3R1ZGVudHMuY2F8bXItbGFsb25kZS1zLWNsYXNzfGd4OmNiOWE1MjhlZDk5ZWEwYg",
                                AuthorId = 2,                  

                                Reviews = new List<Review>
                                {
                                    new Review { AppUser = "3@user.com", Comment = "Excellent!", Rating = 10, BookId = 2},
                                    new Review { AppUser = "4@user.com", Comment = "Bad!", Rating = 1, BookId = 2}
                                },

                                UserBooks = new List<UserBook>
                                {
                                    new UserBook { AppUser = "3@user.com", BookId = 2 },
                                    new UserBook { AppUser = "4@user.com", BookId = 2 }
                                 }
                         }
                    }
                },
                new Author
                { 
                    FirstName = "Paulo",
                    LastName = "Coelho",
                    Nationality = "Brazilian",
                    Gender = "Male",
                    BirthDate = DateTime.Parse("1747-8-24"),
                    Books = new List<Book> {
                     new Book
                     {
                       
                        Title = "The Alchemist",
                        YearPublished = 1988,
                        NumPages = 1988,
                        Description = "Paulo Coelho's allegorical novel follows the journey of a young Andalusian shepherd named Santiago as he searches for a hidden treasure in the Egyptian desert. It's a philosophical and inspiring tale about following one's dreams and finding one's true purpose.",
                        Publisher = "HarperOne",
                        FrontPage = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1654371463i/18144590.jpg",
                        DownloadURL = "https://ia601006.us.archive.org/13/items/OceanofPDF.comTheAlchemist/_OceanofPDF.com_The_Alchemist.pdf",
                        AuthorId = 3,

                        Reviews = new List<Review>
                        {
                             new Review { AppUser = "5@user.com", Comment = "Good!", Rating = 7, BookId = 3},
                               new Review { AppUser = "6@user.com", Comment = "Good!", Rating = 7, BookId = 3}
                        },

                        UserBooks = new List<UserBook>
                        {
                             new UserBook { AppUser = "5@user.com", BookId = 3 },
                             new UserBook { AppUser = "6@user.com", BookId = 3 }
                        }
                     }
                   }
                },
                new Author
                { 
                    FirstName = "J.K.",
                    LastName = "Rowling",
                    Nationality = "British",
                    Gender = "Female",
                    BirthDate = DateTime.Parse("1965-7-31"),
                    Books = new List<Book>
                    {
                        new Book
                        {
                           
                             Title = "Harry Potter and the Philosopher's Stone",
                             YearPublished = 1997,
                             NumPages =223,
                             Description = "J.K. Rowling's beloved novel introduces readers to the magical world of Harry Potter, an orphaned boy who discovers he's a wizard and enrolls at Hogwarts School of Witchcraft and Wizardry. It's a story of friendship, adventure, and the triumph of good over evil.",
                             Publisher = "Bloomsbury Publishing",
                             FrontPage = "https://upload.wikimedia.org/wikipedia/en/6/6b/Harry_Potter_and_the_Philosopher%27s_Stone_Book_Cover.jpg",
                             DownloadURL = "https://docenti.unimc.it/antonella.pascali/teaching/2018/19055/files/ultima-lezione/harry-potter-and-the-philosophers-stone",
                             AuthorId = 4,

                             Reviews = new List<Review>
                             {
                                new Review { AppUser = "7@user.com", Comment = "Great!", Rating = 9, BookId = 4},
                                new Review { AppUser = "8@user.com", Comment = "Not bad!.", Rating = 4, BookId = 4}
                             },

                             UserBooks = new List<UserBook>
                             {
                                new UserBook { AppUser = "7@user.com", BookId = 4 },
                                new UserBook { AppUser = "8@user.com", BookId = 4 }
                             }
                        }
                    }
                },
                new Author
                { 
                    FirstName = "George",
                    LastName = "Orwell",
                    Nationality = "British",
                    Gender = "Male",
                    BirthDate = DateTime.Parse("1903-6-25"),
                    Books = new List<Book>
                    {
                        new Book
                        {
                           
                             Title = "1984",
                             YearPublished = 1949,
                             NumPages = 328,
                             Description = "George Orwell's dystopian masterpiece envisions a totalitarian future where Big Brother monitors every move of the citizens. It explores themes of government control, surveillance, and the power of language.",
                             Publisher = " Secker & Warburg",
                             FrontPage = "https://m.media-amazon.com/images/I/519zR2oIlmL._SX305_BO1,204,203,200_.jpg",
                             DownloadURL = "https://rauterberg.employee.id.tue.nl/lecturenotes/DDM110%20CAS/Orwell-1949%201984.pdf",
                             AuthorId = 5,

                             Reviews = new List<Review>
                             {
                                new Review { AppUser = "9@user.com", Comment = "Excellent!", Rating = 9, BookId = 5},
                                 new Review { AppUser = "10@user.com", Comment = "Excellent!", Rating = 8, BookId = 5}
                             },

                             UserBooks = new List<UserBook>
                             {
                                new UserBook { AppUser = "9@user.com", BookId = 5 },
                                new UserBook { AppUser = "9@user.com", BookId = 5 }
                             }


                        }
                    }
                }
            );
            context.SaveChanges();

            context.Genre.AddRange(
                new Genre {GenreName = "Fantasy" },
                new Genre {GenreName = "Young Adult" },
                new Genre {GenreName = "Adventure" },
                new Genre {GenreName = "Allegory" },
                new Genre {GenreName = "Political Fiction" },
                new Genre {GenreName = "Mystery" },
                new Genre {GenreName = "Fiction" }
            );
            context.SaveChanges();


            context.BookGenre.AddRange(
                new BookGenre { GenreID = 1, BookId = 1 },
                new BookGenre { GenreID = 6, BookId = 1 },
                new BookGenre { GenreID = 7, BookId = 1 },
                new BookGenre { GenreID = 2, BookId = 2 },
                new BookGenre { GenreID = 7, BookId = 2 },
                new BookGenre { GenreID = 4, BookId = 3 },
                new BookGenre { GenreID = 7, BookId = 3 },
                new BookGenre { GenreID = 1, BookId = 4 },
                new BookGenre { GenreID = 2, BookId = 4 },
                new BookGenre { GenreID = 5, BookId = 5 }
                
            );
            context.SaveChanges();

        }

    }
}