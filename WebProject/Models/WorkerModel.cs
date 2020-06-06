using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebProject.Models
{
    public class Worker
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Position { get; set; }
        public string Work_Phone_Number { get; set; }
        public string Work_Email { get; set; }
        public string Name { get; set; }
        public string Sirname { get; set; }
        public string PESEL { get; set; }
        public string Date_of_Birth { get; set; }
        public string Date_of_Employment { get; set; }
        public bool Valid { get; set; }
    }
}
