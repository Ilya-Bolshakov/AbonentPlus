using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.ComponentModel;

namespace Practice1_MongoDB_With_On_WinForms.models
{
    // 17
    public class Request
    {
        [BsonId]
        [Browsable(false)]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("AccountCD")]
        [DisplayName("Account")]
        public string AccountCD { get; set; }

        [BsonElementAttribute("ExecutorCD")]
        [DisplayName("Executor")]
        public string ExecutorCD { get; set; }

        [BsonElementAttribute("FailureCD")]
        [DisplayName("Failure")]
        public string FailureCD { get; set; }

        [BsonElementAttribute("IncomingDate")]
        [DisplayName("Incoming Date")]
        public DateTime IncomingDate { get; set; }

        [BsonElementAttribute("ExecutionDate")]
        [DisplayName("Execution Date")]
        public DateTime ExecutionDate { get; set; }

        [BsonElementAttribute("Executed")]
        public bool Executed { get; set; }
    }
}
