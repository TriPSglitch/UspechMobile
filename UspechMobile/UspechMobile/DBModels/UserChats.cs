using SQLite;
using SQLiteNetExtensions.Attributes;

namespace UspechMobile.DBModels
{
    public class UserChats
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Users))]
        public int IDUser { get; set; }

        [ForeignKey(typeof(Chats))]
        public int IDChat { get; set; }
    }
}