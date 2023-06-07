using SQLite;
using SQLiteNetExtensions.Attributes;
using System;

namespace UspechMobile.DBModels
{
    public class ChatMessages
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }

        [ForeignKey(typeof(Chats))]
        public int IDChat { get; set; }

        public int IDUser { get; set; }
        public string Message { get; set; }
        public byte[] File { get; set; }
        public string FileName { get; set; }
        public byte[] Image { get; set; }
        public DateTime Date { get; set; }
    }
}