using BookShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BusinessContext
{
    /// <summary>
    /// Represents the abstract idea of a book.
    /// </summary>
    public interface IBook
    {
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
        void AddBook(string name, string author, string publisher, int quantity, float costprice, double sellingPrice, int bookTypeId);

        /// <summary>
        /// Returns the count of the books.
        /// </summary>
        /// <returns>
        /// Returns the count of the books.
        /// </returns>
        int GetAllBarcodesCount();

        /// <summary>
        /// Returns all books from the database.
        /// </summary>
        /// <returns>
        /// Returns all books from the database.
        /// </returns>
        List<book> GetAllBooks();

        /// <summary>
        /// Returns book by input barcode.
        /// </summary>
        /// <returns>
        /// Returns book by input barcode.
        /// </returns>
        /// <param name="barcode]">The barcode of the book.</param>
        book GetBookByBarcode(int barcode);

        /// <summary>
        /// Returns the type of the input book.
        /// </summary>
        /// <returns>
        /// Returns the type of the input book.
        /// </returns>
        /// <param name="book]">The input book.</param>
        booktype GetBookType(book book);
    }
}
