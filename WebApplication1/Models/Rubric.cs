using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace WebApplication1.Models
{
    public class Rubric
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; private set; }
        public string Name { get; set; }
        public RubricParams RubricParams { get; set; }
    }

    public class RubricParams
    {
        public int Type { get; set; }
        public int Rooms { get; set; }
        public string Material { get; set; }
        public decimal Square { get; set; }
        public int Floor { get; set; }
        public DateTime DateConstruction { get; set; }
        public decimal Prise { get; set; }
        public string PropositionFrom { get; set; }
        public string Description { get; set; }
        public List<string> Photo { get; set; }
    }
}