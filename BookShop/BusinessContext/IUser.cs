using BookShop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.BusinessContext
{
    /// <summary>
    /// Represents the abstract idea of a user.
    /// </summary>
    public interface IUser
    {
        /// <summary>
        /// Returns a list with all registered users.
        /// </summary>
        /// <returns>
        /// Returns a list with all registered users.
        /// </returns>
        List<user> GetAllUsers();

        /// <summary>
        /// Returns the current logged-in user.
        /// </summary>
        /// <returns>
        /// Returns the current logged-in user.
        /// </returns>
        /// <param name="name">The input username.</param>
        user GetUser(string name);

        /// <summary>
        /// Creates new user into the database.
        /// </summary>
        /// <param name="name">The username.</param>
        /// <param name="password">The user password.</param>
        void AddUser(string name, string password);

        /// <summary>
        /// Removes a user by input name.
        /// </summary>
        /// <param name="name">The input username.</param>
        void RemoveUser(string name);

        /// <summary>
        /// Gets old user with his password and checks if it exists and replaces it.
        /// </summary>
        /// <param name="user">Contains user information.</param>
        void UpdateUserPass(user user);
    }
}
