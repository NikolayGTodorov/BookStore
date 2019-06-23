using System.Data.Entity.Migrations;
using BookShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BusinessContext
{
    /// <summary>
    /// Contains the database and the methods for books and users processing.
    /// </summary>
    public class Business : IUser, IBook
    {
        /// <value>Contains the database context.</value>
        public bookshopEntities1 bookstoreDBcontext;

        /// <summary>
        /// Returns a list with all registered users.
        /// </summary>
        /// <returns>
        /// Returns a list with all registered users.
        /// </returns>
        public List<user> GetAllUsers()
        {
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                return bookstoreDBcontext.users.ToList();
            }
        }

        /// <summary>
        /// Returns the current logged-in user.
        /// </summary>
        /// <returns>
        /// Returns the current logged-in user.
        /// </returns>
        /// <param name="name">The input username.</param>
        public user GetUser(string name)
        {
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                return bookstoreDBcontext.users.Where(a => a.Username == name).FirstOrDefault();
            }
        }

        /// <summary>
        /// Creates new user into the database.
        /// </summary>
        /// <param name="name">The input username.</param>
        /// <param name="password">The input password.</param>
        public void AddUser(string name, string password)
        {
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                user user = new user();
                user.Username = name;
                user.Password = password;
                bookstoreDBcontext.users.Add(user);
                bookstoreDBcontext.SaveChanges();
            }
        }

        /// <summary>
        /// Removes a user by input name.
        /// </summary>
        /// <param name="name">The input username.</param>
        public void RemoveUser(string name)
        {
            user user = GetUser(name);
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                bookstoreDBcontext.users.Attach(user);
                bookstoreDBcontext.users.Remove(user);
                bookstoreDBcontext.SaveChanges();
            }
        }

        /// <summary>
        /// Gets old user with his password and checks if it exists and replaces it.
        /// </summary>
        /// <param name="user">Contains user information.</param>
        public void UpdateUserPass(user user)
        {
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                var pass = bookstoreDBcontext.users.Where(a => a.Username == user.Username).FirstOrDefault();

                if (pass != null)
                {
                    user.Id = pass.Id;
                    bookstoreDBcontext.Entry(pass).CurrentValues.SetValues(user);
                    bookstoreDBcontext.SaveChanges();
                }
            }
        }

        /// <summary>
        /// Adds a book by input name, author, publisher, quantity, costPrice, 
        /// sellingPrice and identifier for the book type.
        /// </summary>
        /// <param name="name">The name of the book.</param>
        /// <param name="author">The author of the book.</param>
        /// <param name="publisher">The publisher of the book.</param>
        /// <param name="quantity">The quantity of the book.</param>
        /// <param name="costPrice">The cost of the book.</param>
        /// <param name="sellingPrice">The sell price of the book.</param>
        /// <param name="bookTypeId">The identifier's type of the book.</param>
        public void AddBook(string name, string author, string publisher, int quantity, float costPrice, double sellingPrice, int bookTypeId)
        {
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                book book = new book();
                book.Author = author;
                book.Number = quantity;
                book.Price = costPrice;
                book.Publisher = publisher;
                book.Book1 = name;
                sellingPrice = costPrice + 7; // + 7leva
                book.BookTypeId = bookTypeId;

                bookstoreDBcontext.books.Add(book);
                bookstoreDBcontext.SaveChanges();
            }
        }

        /// <summary>
        /// Returns the count of the books.
        /// </summary>
        /// <returns>
        /// Returns the count of the books.
        /// </returns>
        public int GetAllBarcodesCount()
        {
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                return bookstoreDBcontext.books.ToList().Count();
            }
        }

        /// <summary>
        /// Returns all books from the database.
        /// </summary>
        /// <returns>
        /// Returns all books from the database.
        /// </returns>
        public List<book> GetAllBooks()
        {
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                return bookstoreDBcontext.books.ToList();
            }
        }

        /// <summary>
        /// Returns book by input barcode.
        /// </summary>
        /// <returns>
        /// Returns book by input barcode.
        /// </returns>
        /// <param name="barcode]">The barcode of the book.</param>
        public book GetBookByBarcode(int barcode)
        {
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                return bookstoreDBcontext.books.Where(a => a.barcodeId == barcode).FirstOrDefault();
            }
        }

        /// <summary>
        /// Returns the type of the input book.
        /// </summary>
        /// <returns>
        /// Returns the type of the input book.
        /// </returns>
        /// <param name="book]">The input book.</param>
        public booktype GetBookType(book book)
        {
            using (bookstoreDBcontext = new bookshopEntities1())
            {
                return bookstoreDBcontext.booktypes.Where(a => a.Id == book.BookTypeId).FirstOrDefault();
            }
        }

        /// <summary>
        /// Decreases the amount of books when purchased.
        /// </summary>
        /// <param name="book]">The book purchased.</param>
        /// <param name="quantity]">The book's quantity purchased.</param>
        public void UpdateBook(book book, int quantity)
        {
            book book1 = book;
            book1.Number -= quantity;

            using (bookstoreDBcontext = new bookshopEntities1())
            {
                bookstoreDBcontext.books.AddOrUpdate(book1);
                bookstoreDBcontext.SaveChanges();
            }
        }

        /// <summary>
        /// Restocks the amount of the input book.
        /// </summary>
        /// <param name="book]">The book to be restocked.</param>
        /// <param name="quantity]">The amount to be added into the current.</param>
        public void UpdateBookQuantity(book book, int quantity)
        {
            book book1 = book;
            book1.Number = quantity;

            using (bookstoreDBcontext = new bookshopEntities1())
            {
                bookstoreDBcontext.books.AddOrUpdate(book1);
                bookstoreDBcontext.SaveChanges();
            }
        }
    }
}
