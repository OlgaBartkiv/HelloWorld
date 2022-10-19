using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    /// <summary>
    /// class Politician defines type of object
    /// </summary>
    public class Politician
    {
        public int Id;
        public string FirstName;
        public string LastName;
        public string Position;

        /// <summary>
        /// Costructor that takes arguments
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="FirstName"></param>
        /// <param name="LastName"></param>
        /// <param name="Position"></param>
        public Politician(int Id, string FirstName, string LastName, string Position)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
        }

        public void AddPolitician()
        {
            //new Politician object/instance is created based on Politician class
            Politician politician1 = new Politician(4, "Bill", "Clinton", "Ex-President");
        }
    }
}
