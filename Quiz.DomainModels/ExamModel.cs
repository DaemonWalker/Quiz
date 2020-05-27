using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.DomainModels
{
    public class ExamModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int PassScore { get; set; }
        public int HighestScore { get; set; }
        public bool IsPassed { get; set; }
        public List<QuestionModel> Questions { get; set; }
    }
}
