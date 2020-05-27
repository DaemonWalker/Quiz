using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.DBModels
{
    public class Exam
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public IEnumerable<int> QuestionIDs { get; set; }
        public IEnumerable<int> UserIDs { get; set; }
        public int PassScore { get; set; }
    }
}
