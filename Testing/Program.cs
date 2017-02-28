using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Testing
{
    class Program
    {
        static void Main(string[] args)
        {
            using (DBContext DB = new DBContext())
            {
                bool exist = false;
                var result = DB.Users.Where(i => i.Name == "www" && i.Password == "qwerty");
                if (result.ToList().Count > 0)
                    exist = true;
                else
                    exist = false;
                Console.ReadKey();
            }
        }
        public class DBContext : DbContext
        {
            public DBContext() : base("name=DBContext") { }
            public DbSet<User> Users { get; set; }
        }
        public class User
        {
            [Key]
            public int UserId { get; set; }
            [Index(IsUnique = true)]
            [MinLength(3)]
            [Required]
            public string Name { get; set; }
            [MinLength(3)]
            [Required]
            public string Password { get; set; }
            public Nullable<int> LastLogin { get; set; }
        }
    }
}

