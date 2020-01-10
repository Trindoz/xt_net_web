using System;
using System.Collections.Generic;
using System.Text;

namespace Users.Entities
{
    public class Award
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public override string ToString()
        {
            return $"{Id} {Title}";
        }
    }
}
