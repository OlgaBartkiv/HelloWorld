using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    /// <summary>
    /// class Politician defines type of object
    /// </summary>
    public class PoliticianPerson
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
        public PoliticianPerson(int Id, string FirstName, string LastName, string Position)
        {
            this.Id = Id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Position = Position;
        }

        public void AddPolitician()
        {
            //new Politician object/instance is created based on Politician class
            PoliticianPerson politician1 = new PoliticianPerson(4, "Bill", "Clinton", "Ex-President");
        }
    }
}
