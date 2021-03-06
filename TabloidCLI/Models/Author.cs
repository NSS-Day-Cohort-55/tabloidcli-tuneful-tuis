using System;
using System.Collections.Generic;

namespace TabloidCLI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
        public List<Tag> Tags { get; set; } = new List<Tag>();

        public int PostCount { get; set; }

        public int BlogCount { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public override string ToString()
        {
            return FullName;
        }
    }
}