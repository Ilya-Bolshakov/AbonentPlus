using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;


namespace Practice1_MongoDB_With_On_WinForms.models
{
    public class Abonent
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public string Id { get; set; }

        [BsonElementAttribute("StreetCD")]
        public string StreetCD { get; set; }

        [BsonElementAttribute("HouseNo")]
        public int HouseNo { get; set; }

        [BsonElementAttribute("FlatNo")]
        public int FlatNo { get; set; }

        [BsonElementAttribute("Fio")]
        public string Fio { get; set; }

        [BsonElementAttribute("Phone")]
        public string Phone { get; set; }
    }
}
