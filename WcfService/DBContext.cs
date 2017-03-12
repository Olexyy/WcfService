using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ServiceModel;
using System.Data.Entity;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatLibrary
{
    public class DBContext : DbContext
    {
        public DBContext() : base ("name=DbContext") { }
        public DbSet<User> Users { get; set; }
    }
    [DataContract]
    public class User
    {
        [Key]
        [DataMember]
        public int UserId { get; set; }
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        [Index(IsUnique = true)]
        [MinLength(3)]
        [Required]
        [DataMember]
        public string Name { get; set; }
        [MinLength(3)]
        [Required]
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public Nullable<DateTime> LastLogin { get; set; }
        [DataMember]
        [Column(TypeName = "NVARCHAR")]
        [StringLength(50)]
        public string Group { get; set; }
    }
}