using Quiz.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.IRepository
{
    public interface IOptionRepo
    {
        IEnumerable<Option> GetOptionByQuestionID(int questionID);
        IEnumerable<Option> GetAnswerByQuestionID(int questionID);
    }
}
