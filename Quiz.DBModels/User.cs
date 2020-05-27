using System;

namespace Quiz.DBModels
{
    public class User
    {
        public int ID { get; set; }
        public string Account { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public int Level { get; set; }
    }
}
