using Quiz.DBModels;
using System;

namespace Quiz.IRepository
{
    public interface IUserRepo
    {
        User GetByAccountAndPassword(string account, string password);
        User GetByLevel(int level);
        User GetByUnderLevel(int level);
    }
}
