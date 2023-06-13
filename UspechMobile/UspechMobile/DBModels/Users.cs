using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Users
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        [ForeignKey(typeof(Roles))]
        public int IDRole { get; set; }

        [ForeignKey(typeof(Persons))]
        public int IDPerson { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<UserCourses> UserCourses { get; set; }
    }
}