using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Models
{
     public class Pet
    {
        public string Type;
        public string Alias;
        public float Weight;

        public Pet (string Type, string Alias, float Weight)
        {
            this.Type = Type;
            this.Alias = Alias;
            this.Weight = Weight;
        }
        public override string ToString()
        {
            return "[" + Type + "," + Alias + "," + Weight + "]";
        }
    }



    
}
