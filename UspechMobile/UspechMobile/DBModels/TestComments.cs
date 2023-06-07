using SQLite;
using SQLiteNetExtensions.Attributes;
using System;

namespace UspechMobile.DBModels
{
    public class TestComments
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Tests))]
        public int IDTest { get; set; }

        public int IDUser { get; set; }
        public string Comment { get; set; }
        public DateTime Date { get; set; }
    }
}