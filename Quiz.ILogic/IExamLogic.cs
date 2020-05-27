using Quiz.DomainModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Quiz.ILogic
{
    public interface IExamLogic
    {
        Task<ExamModel> GetExamByIDAsync(int id);

        Task<ResultModel> SubmitExamAsync(ExamModel examModel);

        Task<List<ExamModel>> GetExamsByUserID(int userID);
    }
}
