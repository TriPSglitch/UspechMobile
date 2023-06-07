using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Types
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Questions> Questions { get; set; }
    }
}