using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
    public class Politician
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public int Age;
        public string Position;

        public Politician (int Id, string FirstName, string LastName, int Age, string Position)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Age = Age;
            this.Position = Position;
        }
    }
}
