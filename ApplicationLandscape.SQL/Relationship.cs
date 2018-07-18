using System;
using System.ComponentModel.DataAnnotations;

namespace ApplicationLandscape.SQL
{
    public class Relationship
    {
        public string Id { get; set; }
        public Entity PrimaryEntity { get; set; }
        public Entity SecondaryEntity { get; set; }
        public string RelationshipType { get; set; }
        public string RelationshipName { get; set; }
        public string RelationshipSubtype { get; set; }
        public DateTime LastUpdate { get; set; }
        public string LastUpdateBy { get; set; }
        public string Comments { get; set; }
    }
}