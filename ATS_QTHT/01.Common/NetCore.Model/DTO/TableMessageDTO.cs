using System;

namespace NetCore.Models.DTO
{
    public class TableMessageDTO
    {
        public Guid? id;
        public Guid tableId;
        public string message;
        public DateTime dateCreated;
        public object data;
        public string type;
        public string from;
        public string note;
    }
}