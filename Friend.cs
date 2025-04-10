using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект
{
    public class Friend
    {
        public int Id { get; set; }
        public string PhotoPath { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public string FullDescription { get; set; }
        public string PhoneNumber { get; set; }
        public string LFS {  get; set; }

        public override string ToString()
        {
            string s = $"{FirstName} {LastName} {SurName}";

            return s;
        }
    }

}