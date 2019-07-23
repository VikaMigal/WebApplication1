using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication1.Models
{
    public class Poster
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; private set; }
        public ObjectId UserId { get; set; }
        public ObjectId RubricId { get; set; }
        public GeographyPoster Geography { get; set; }
        public string Address { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
        public byte Active { get; set; }
        public DateTime CreationDate { get; set; }
   
        public Poster()
        {
            CreationDate = DateTime.Now;
        }
        
        
        
    }

    public class GeographyPoster
    {
        public string Region { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        
    }
}