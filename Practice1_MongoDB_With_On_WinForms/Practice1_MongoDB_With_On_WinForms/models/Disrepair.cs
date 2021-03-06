using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel;

namespace Practice1_MongoDB_With_On_WinForms.models
{
    public class Disrepair
    {
        [BsonId]
        [Browsable(false)]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("FAILURENM")]
        [DisplayName("Failure")]
        public string FAILURENM { get; set; }

        public override string ToString()
        {
            return FAILURENM;
        }
    }
}
