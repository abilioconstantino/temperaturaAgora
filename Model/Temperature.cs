using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace temperaturaAgora.Model
{
    public class Temperature
    {
        public Guid Id { get; set; }

        [BsonElement("Coord")]
        public List<Coord> coord { get; set; }
        [BsonElement("Weather")]
        public List<Weather> weather { get; set; }
        [BsonElement("Main")]
        public List<Main> main { get; set; }
        public int visibility { get; set; }
        [BsonElement("Wind")]
        public List<Wind> wind { get; set; }
        [BsonElement("Clouds")]
        public List<Clouds> clouds { get; set; }
        public int dt { get; set; }
        [BsonElement("Sys")]
        public List<Sys> sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
}