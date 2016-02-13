using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Less_11.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Pass { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public bool Pet { get; set; }
        public string Continent { get; set; }




        public override string ToString()
        {
            return Name + " " + Age + " " + Sex + " " + Pet + " " + Continent;
        }

    }
}