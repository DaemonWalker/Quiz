using Quiz.DBModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.IRepository
{
    public interface IQuestionRepo
    {
        IEnumerable<Question> GetByExamID(int examID);
    }
}
