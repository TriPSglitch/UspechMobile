using SQLite;
using SQLiteNetExtensions.Attributes;
using System;

namespace UspechMobile.DBModels
{
    public class Schedule
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Courses))]
        public int IDCourse { get; set; }
        
        public DateTime Date { get; set; }
    }
}