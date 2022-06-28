using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System.ComponentModel;

namespace Practice1_MongoDB_With_On_WinForms.models
{
    public class Abonent
    {
        [BsonId]
        [Browsable(false)]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        [DisplayName("ID")]
        public string Id { get; set; }

        [BsonElementAttribute("StreetCD")]
        [DisplayName("Street")]
        public string StreetCD { get; set; }

        [BsonElementAttribute("HouseNo")]
        [DisplayName("House Number")]
        public int HouseNo { get; set; }

        [BsonElementAttribute("FlatNo")]
        [DisplayName("Flat Number")]
        public int FlatNo { get; set; }

        [BsonElementAttribute("Fio")]
        public string Fio { get; set; }

        [BsonElementAttribute("Phone")]
        public string Phone { get; set; }
    }
}
