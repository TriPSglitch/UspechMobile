using SQLite;
using SQLiteNetExtensions.Attributes;
using System.Collections.Generic;

namespace UspechMobile.DBModels
{
    public class Chats
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Title { get; set; }
        public byte[] Image { get; set; }
        public int IDCreator { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<UserChats> UserChats { get; set; }

        [OneToMany(CascadeOperations = CascadeOperation.All)]
        public List<ChatMessages> ChatMessages { get; set; }
    }
}