using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BookShop.Data;
using BC = BookShop.BusinessContext;
using System.Linq;

namespace BookShop.UnitTests
{
    [TestClass]
    public class BusinessTests
    {
        private BC.Business business = new BC.Business();
        private bookshopEntities1 dbContext;

        [TestMethod]
        public void AddUserTest()
        {
            this.business.AddUser("wegwegwe", "wgewegwgwgewwe");
            bool dbContainsTheNewUser = false;

            using (this.business.bookstoreDBcontext = new bookshopEntities1())
            {
                dbContainsTheNewUser = business.bookstoreDBcontext.users.Any(u => u.Username == "wegwegwe");
            }

            this.business.RemoveUser("wegwegwe");
            Assert.AreEqual(dbContainsTheNewUser, true, "Database do not add new users");
        }

        [TestMethod]
        public void AddBookTest()
        {
            this.business.AddBook("Kniga na legendite", "Avtor na legendite", "ivangeww", 10, 12.5F, 17.5, 112);
            bool dbContainsTheNewBook = false;

            using (this.business.bookstoreDBcontext = new bookshopEntities1())
            {
                dbContainsTheNewBook = this.business.bookstoreDBcontext.books.Any(b => b.Book1 == "Kniga na legendite");
            }

            //Removing the book.
            using (this.business.bookstoreDBcontext = new bookshopEntities1())
            {
                book newBook = this.business.bookstoreDBcontext.books.Where(b => b.Book1 == "Kniga na legendite").First();
                this.business.bookstoreDBcontext.books.Remove(newBook);
            }

            Assert.AreEqual(dbContainsTheNewBook, true, "Database do not add new books");
        }

        [TestMethod]
        public void AssertThatDatabaseContainsCertainUser()
        {
            List<user> usersFromDB = new List<user>();

            using (dbContext = new bookshopEntities1())
            {
                usersFromDB = this.dbContext.users.ToList();
            }

            bool containsTheUser = usersFromDB.Select(x => x).Where(x => x.Username == "user").Count() > 0;
            Assert.AreEqual(containsTheUser, true, "Business dbContext differs from the original context.");
        }

        [TestMethod]
        public void AssertThatDatabaseContainsCertainBook()
        {
            List<book> booksFromDB = new List<book>();

            using (dbContext = new bookshopEntities1())
            {
                booksFromDB = this.dbContext.books.ToList();
            }

            bool containsTheBook = booksFromDB.Select(x => x).Where(x => x.barcodeId == 105).Count() > 0;
            Assert.AreEqual(containsTheBook, true, "Business dbContext differs from the original context.");
        }

        [TestMethod]
        public void RemoveUserTest()
        {
            this.business.AddUser("Aivan Kamaha", "kamahaPassword");
            bool isContained = false;
            bool userIsRemovedFromDB = false;

            using (this.business.bookstoreDBcontext = new bookshopEntities1())
            {
                if (this.business.bookstoreDBcontext.users.Any(u => u.Username == "Aivan Kamaha"))
                {
                    isContained = true;
                    this.business.RemoveUser("Aivan Kamaha");
                }
            }

            if (isContained)
            {
                using (this.business.bookstoreDBcontext = new bookshopEntities1())
                {
                    userIsRemovedFromDB = !this.business.bookstoreDBcontext.users.Any(u => u.Username == "Aivan Kamaha");
                }
            }

            Assert.AreEqual(userIsRemovedFromDB, true, "The user for delete still exists.");
        }

        [TestMethod]
        public void UpdateBookQuantityAfterPurchaseTestOne()
        {
            using (dbContext = new bookshopEntities1())
            {
                book firstBook = dbContext.books.Where(b => b.barcodeId == 101).First();
                int originalQuantity = firstBook.Number;
                int quantity = 4;

                business.UpdateBook(firstBook, quantity);
                firstBook = dbContext.books.Where(b => b.barcodeId == 101).First();
                Assert.AreEqual(originalQuantity, quantity + firstBook.Number, "Book quantity do not change after purchase.");
            }
        }

        [TestMethod]
        public void UpdateUserPasswordTest()
        {
            business.AddUser("Ivan Ivanov", "httrersgsa");
            string userPassword = null;
            string newPassword = "gosko_parola";

            using (dbContext = new bookshopEntities1())
            {
                user ivan = dbContext.users.Where(u => u.Username == "Ivan Ivanov").First();
                ivan.Password = newPassword;
                business.UpdateUserPass(ivan);
                userPassword = dbContext.users.Where(u => u.Username == "Ivan Ivanov").First().Password;
            }

            business.RemoveUser("Ivan Ivanov");
            Assert.AreEqual(userPassword, newPassword, "The user password do not change.");
        }
    }
}
