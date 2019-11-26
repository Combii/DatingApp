using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using DatingApp.Models;

namespace DatingApp.Data
{
    public interface IDatingRepository
    {
        void Add<T>(T enitity) where T: class;
        void Delete<T>(T enitity) where T: class;
        Task<bool> SaveAll();
        Task<IEnumerable<User>> GetUsers();
        Task<User> GetUser(int id);
    }
}