using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Categories
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<CourseCategories> CourseCategories { get; set; }
    }
}