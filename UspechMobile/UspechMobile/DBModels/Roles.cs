using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Roles
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Users> Users { get; set; }
    }
}