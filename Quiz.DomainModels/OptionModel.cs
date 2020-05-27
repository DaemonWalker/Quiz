using System;
using System.Collections.Generic;
using System.Text;

namespace Quiz.DomainModels
{
    public class OptionModel
    {
        public string Content { get; set; }
        public int ID { get; set; }
        public bool IsChecked { get; set; }
        public bool IsMuiltySelection { get; set; }
        public string GroupName { get; set; }
    }
}
