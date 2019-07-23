using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication1.Models
{
    public class User
    {
       
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public ObjectId Id { get; private set; }
            [BsonId]
            [BsonRepresentation(BsonType.ObjectId)]
            public ObjectId RoleId { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
            public int Sex { get; set; }
            public DateTime RegDate { get; set; }
   
            public User()
            {
                RegDate = DateTime.Now;
            }
    }
}