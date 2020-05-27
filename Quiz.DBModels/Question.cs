using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.DBModels
{
   public  class Question
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public IEnumerable<int> Options { get; set; }
        public IEnumerable<int> Answers { get; set; }
        public int Point { get; set; }
    }
}
