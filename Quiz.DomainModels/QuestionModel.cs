using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.DomainModels
{
    public class QuestionModel
    {
        public List<OptionModel> Options { get; set; }
        public int ID { get; set; }
        public string Content { get; set; }
    }
}
