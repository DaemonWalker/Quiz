using Quiz.DomainModels;
using System;

namespace Quiz.ILogic
{
    public interface IUserLogic
    {
        LoginModel Login(LoginModel login);
        IEquatable<RecordModel> GetExamRecords(int userID);
    }
}
