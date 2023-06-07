using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Courses
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int IDCreator { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<UserCourses> UserCourses { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Schedule> Schedule { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<CourseCategories> CourseCategories { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Lectures> Lectures { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Exercises> Exercises { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<Tests> Tests { get; set; }
    }
}