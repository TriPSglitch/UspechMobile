using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class Persons
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        [OneToOne(CascadeOperations = CascadeOperation.All)]
        public Users User { get; set; }
    }
}