using System;
using MongoDB.Bson;

namespace WebApplication1.Models
{
    public class Comments
    {
        public ObjectId UserId { get; set; }
        public ObjectId PosterId { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
   
        public Comments()
        {
            CreationDate = DateTime.Now;
        }
    }
}