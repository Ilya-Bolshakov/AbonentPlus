using System;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using MongoDB.Bson;
using Practice1_MongoDB_With_On_WinForms.models;

namespace Practice1_MongoDB_With_On_WinForms
{

    #region OldClasses
    public class Class_Street
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("STREETNM")]
        public string STREETNM { get; set; }

        public override string ToString()
        {
            return STREETNM;
        }
    }
    public class Class_Executor
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("Fio")]
        public string Fio { get; set; }

        public override string ToString()
        {
            return Fio;
        }
    }

    public class Class_NachislSumma
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("AccountCD")]
        public string AccountCD { get; set; }

        [BsonElementAttribute("ServiceCD")]
        public string ServiceCD { get; set; }

        [BsonElementAttribute("NachislSum")]
        public double NachislSum { get; set; }

        [BsonElementAttribute("NachislMonth")]
        public string NachislMonth { get; set; }

        [BsonElementAttribute("NachislYear")]
        public int NachislYear { get; set; }
    }

    public class Class_PaySumma
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("AccountCD")]
        public string AccountCD { get; set; }

        [BsonElementAttribute("ServiceCD")]
        public string ServiceCD { get; set; }

        [BsonElementAttribute("PaySum")]
        public double PaySum { get; set; }

        [BsonElementAttribute("PayDate")]
        public DateTime PayDate { get; set; }

        [BsonElementAttribute("PayMonth")]
        public string PayMonth { get; set; }

        [BsonElementAttribute("PayYear")]
        public int PayYear { get; set; }
    }

    public class Class_Services
    {
        [BsonId]
        public ObjectId _id { get; set; }

        [BsonElementAttribute("Id")]
        public int Id { get; set; }

        [BsonElementAttribute("SERVICENM")]
        public string SERVICENM { get; set; }

        public override string ToString()
        {
            return SERVICENM;
        }
    }
    #endregion


    public class MongoDBContext
    {
        MongoServerSettings Settings_;
        MongoServer server;
        MongoDatabase Database_;
        private static MongoDBContext _Obj;
        public static MongoDBContext GetObject()
        {
            if (_Obj == null)
            {
                _Obj = new MongoDBContext();
            }
            return _Obj;
        }

        private MongoDBContext()
        {
            Settings_ = new MongoServerSettings();
            Settings_.Server = new MongoServerAddress("localhost", 27017);
            server = new MongoServer(Settings_);
            Database_ = server.GetDatabase("test");
        }

        public SBindingList<Class_Street> Load_DataStreet()
        {
            var collection = Database_.GetCollection<Class_Street>("Street");
            SBindingList<Class_Street> doclist = new SBindingList<Class_Street>();
            foreach (Class_Street stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }

        public void Delete_Street_Infromation(Class_Street _Obj)
        {
            MongoCollection<Class_Street> Collection_ = Database_.GetCollection<Class_Street>("Street");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Filter_Street_Infromation(Class_Street _Obj)
        {
            MongoCollection<Class_Street> Collection_ = Database_.GetCollection<Class_Street>("Street");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Find(Marker);
        }

        public void Insert_Street_Information(Class_Street _Obj)
        {
            MongoCollection<Class_Street> Collection_ = Database_.GetCollection<Class_Street>("Street");
            BsonDocument Stu_Doc = new BsonDocument {  
                {  
                    "Id", _Obj.Id
                }, 
                {  
                    "STREETNM", _Obj.STREETNM  
                }
  
            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_Street_Information(Class_Street _Obj)
        {
            MongoCollection<Class_Street> Collection_ = Database_.GetCollection<Class_Street>("Street");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update.Set("STREETNM", _Obj.STREETNM);
            Collection_.Update(Marker, Update_);
        }

        public void Save_Street_Information(Class_Street _Obj)
        {
            MongoCollection<Class_Street> Collection_ = Database_.GetCollection<Class_Street>("Street");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("STREETNM", _Obj.STREETNM);
            Collection_.Save(Stu_Doc);
        }

        public SBindingList<Abonent> Load_Abonent()
        {
            var collection = Database_.GetCollection<Abonent>("Abonent");
            SBindingList<Abonent> doclist = new SBindingList<Abonent>();
            foreach (Abonent stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }

        public void Delete_Abonent_Infromation(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Insert_Abonent_Information(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            BsonDocument Stu_Doc = new BsonDocument {  
                {  
                    "Id", _Obj.Id
                },
                {  
                    "StreetCD", _Obj.StreetCD 
                },
                 {  
                    "HouseNo", _Obj.HouseNo
                },
                 {  
                    "FlatNo", _Obj.FlatNo
                },
                 {  
                    "Fio", _Obj.Fio
                },
                 {  
                    "Phone", _Obj.Phone
                }
  
            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_Abonent_Information(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update
                .Set("StreetCD", _Obj.StreetCD)
                .Set("HouseNo", _Obj.HouseNo)
                .Set("FlatNo", _Obj.FlatNo)
                .Set("Fio", _Obj.Fio)
                .Set("Phone", _Obj.Phone);
            Collection_.Update(Marker, Update_);
        }

        public void Save_Abonent_Information(Abonent _Obj)
        {
            MongoCollection<Abonent> Collection_ = Database_.GetCollection<Abonent>("Abonent");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("StreetCD", _Obj.StreetCD)
                .Add("HouseNo", _Obj.HouseNo)
                .Add("FlatNo", _Obj.FlatNo)
                .Add("Fio", _Obj.Fio)
                .Add("Phone", _Obj.Phone); ;
            Collection_.Save(Stu_Doc);
        }

        public SBindingList<Request> Load_DataRequest()
        {
            var collection = Database_.GetCollection<Request>("Request");
            SBindingList<Request> doclist = new SBindingList<Request>();
            foreach (Request stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }

        public void Delete_Request_Infromation(Request _Obj)
        {
            MongoCollection<Request> Collection_ = Database_.GetCollection<Request>("Request");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Insert_Request_Information(Request _Obj)
        {
            MongoCollection<Request> Collection_ = Database_.GetCollection<Request>("Request");
            BsonDocument Stu_Doc = new BsonDocument {  
                {  
                    "Id", _Obj.Id
                },
                {  
                    "AccountCD", _Obj.AccountCD 
                },
                 {  
                    "ExecutorCD", _Obj.ExecutorCD
                },
                 {  
                    "FailureCD", _Obj.FailureCD
                },
                 {  
                    "ExecutionDate", _Obj.ExecutionDate
                },
                 {  
                    "IncomingDate", _Obj.IncomingDate
                },
                 {  
                    "Executed", _Obj.Executed
                }
  
            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_Request_Information(Request _Obj)
        {
            MongoCollection<Request> Collection_ = Database_.GetCollection<Request>("Request");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);

            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update
                .Set("ExecutorCD", _Obj.ExecutorCD)
                .Set("FailureCD", _Obj.FailureCD)
                .Set("ExecutionDate", _Obj.ExecutionDate)
                .Set("IncomingDate", _Obj.IncomingDate)
                .Set("Executed", _Obj.Executed);
            Collection_.Update(Marker, Update_);
        }

        public void Save_Request_Information(Request _Obj)
        {
            MongoCollection<Request> Collection_ = Database_.GetCollection<Request>("Request");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("ExecutorCD", _Obj.ExecutorCD)
                .Add("FailureCD", _Obj.FailureCD)
                .Add("ExecutionDate", _Obj.ExecutionDate)
                .Add("IncomingDate", _Obj.IncomingDate)
                .Add("Executed", _Obj.Executed);
            Collection_.Save(Stu_Doc);
        }

        public SBindingList<Class_NachislSumma> Load_DataNachislSumma()
        {
            var collection = Database_.GetCollection<Class_NachislSumma>("NachislSumma");
            SBindingList<Class_NachislSumma> doclist = new SBindingList<Class_NachislSumma>();
            foreach (Class_NachislSumma stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }

        public void Delete_NachislSumma_Infromation(Class_NachislSumma _Obj)
        {
            MongoCollection<Class_NachislSumma> Collection_ = Database_.GetCollection<Class_NachislSumma>("NachislSumma");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Insert_NachislSumma_Information(Class_NachislSumma _Obj)
        {
            MongoCollection<Class_NachislSumma> Collection_ = Database_.GetCollection<Class_NachislSumma>("NachislSumma");
            BsonDocument Stu_Doc = new BsonDocument {  
                {  
                    "Id", _Obj.Id
                },
                {  
                    "AccountCD", _Obj.AccountCD 
                },
                 {  
                    "ServiceCD", _Obj.ServiceCD
                },
                 {  
                    "NachislSum", _Obj.NachislSum
                },
                 {  
                    "NachislMonth", _Obj.NachislMonth
                },
                 {  
                    "NachislYear", _Obj.NachislYear
                }
            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_NachislSumma_Information(Class_NachislSumma _Obj)
        {
            MongoCollection<Class_NachislSumma> Collection_ = Database_.GetCollection<Class_NachislSumma>("NachislSumma");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update
                .Set("AccountCD", _Obj.AccountCD)
                .Set("ServiceCD", _Obj.ServiceCD)
                .Set("NachislSum", _Obj.NachislSum)
                .Set("NachislMonth", _Obj.NachislMonth)
                .Set("NachislYear", _Obj.NachislYear);
            Collection_.Update(Marker, Update_);
        }

        public void Save_NachislSumma_Information(Class_NachislSumma _Obj)
        {
            MongoCollection<Class_NachislSumma> Collection_ = Database_.GetCollection<Class_NachislSumma>("NachislSumma");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("AccountCD", _Obj.AccountCD)
                .Add("ServiceCD", _Obj.ServiceCD)
                .Add("NachislSum", _Obj.NachislSum)
                .Add("NachislMonth", _Obj.NachislMonth)
                .Add("NachislYear", _Obj.NachislYear);
            Collection_.Save(Stu_Doc);
        }

        public SBindingList<Class_PaySumma> Load_DataPaySumma()
        {
            var collection = Database_.GetCollection<Class_PaySumma>("PaySumma");
            SBindingList<Class_PaySumma> doclist = new SBindingList<Class_PaySumma>();
            foreach (Class_PaySumma stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }

        public void Delete_PaySumma_Infromation(Class_PaySumma _Obj)
        {
            MongoCollection<Class_PaySumma> Collection_ = Database_.GetCollection<Class_PaySumma>("PaySumma");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Insert_PaySumma_Information(Class_PaySumma _Obj)
        {
            MongoCollection<Class_PaySumma> Collection_ = Database_.GetCollection<Class_PaySumma>("PaySumma");
            BsonDocument Stu_Doc = new BsonDocument {  
                {  
                    "Id", _Obj.Id
                },
                {  
                    "AccountCD", _Obj.AccountCD 
                },
                 {  
                    "ServiceCD", _Obj.ServiceCD
                },
                 {  
                    "PaySum", _Obj.PaySum
                },
                {  
                    "PayDate", _Obj.PayDate
                },
                 {  
                    "PayMonth", _Obj.PayMonth
                },
                 {  
                    "PayYear", _Obj.PayYear
                }
  
            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_PaySumma_Information(Class_PaySumma _Obj)
        {
            MongoCollection<Class_PaySumma> Collection_ = Database_.GetCollection<Class_PaySumma>("PaySumma");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update
                .Set("AccountCD", _Obj.AccountCD)
                .Set("ServiceCD", _Obj.ServiceCD)
                .Set("PaySum", _Obj.PaySum)
                .Set("PayDate", _Obj.PayDate)
                .Set("PayMonth", _Obj.PayMonth)
                .Set("PayYear", _Obj.PayYear);
            Collection_.Update(Marker, Update_);
        }

        public void Save_PaySumma_Information(Class_PaySumma _Obj)
        {
            MongoCollection<Class_PaySumma> Collection_ = Database_.GetCollection<Class_PaySumma>("PaySumma");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("AccountCD", _Obj.AccountCD)
                .Add("ServiceCD", _Obj.ServiceCD)
                .Add("PaySum", _Obj.PaySum)
                .Add("PayDate", _Obj.PayDate)
                .Add("PayMonth", _Obj.PayMonth)
                .Add("PayYear", _Obj.PayYear);
            Collection_.Save(Stu_Doc);
        }

        public SBindingList<Class_Executor> Load_DataExecutor()
        {
            var collection = Database_.GetCollection<Class_Executor>("Executor");
            SBindingList<Class_Executor> doclist = new SBindingList<Class_Executor>();
            foreach (Class_Executor stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }

        public void Delete_Executor_Infromation(Class_Executor _Obj)
        {
            MongoCollection<Class_Executor> Collection_ = Database_.GetCollection<Class_Executor>("Executor");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Insert_Executor_Information(Class_Executor _Obj)
        {
            MongoCollection<Class_Executor> Collection_ = Database_.GetCollection<Class_Executor>("Executor");
            BsonDocument Stu_Doc = new BsonDocument {  
                {  
                    "Id", _Obj.Id
                },
                {  
                    "Fio", _Obj.Fio
                }
  
            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_Executor_Information(Class_Executor _Obj)
        {
            MongoCollection<Class_Executor> Collection_ = Database_.GetCollection<Class_Executor>("Executor");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update
                .Set("Fio", _Obj.Fio);
            Collection_.Update(Marker, Update_);
        }

        public void Save_Executor_Information(Class_Executor _Obj)
        {
            MongoCollection<Class_Executor> Collection_ = Database_.GetCollection<Class_Executor>("Executor");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("Fio", _Obj.Fio);
            Collection_.Save(Stu_Doc);
        }

        public SBindingList<Class_Services> Load_DataServices()
        {
            var collection = Database_.GetCollection<Class_Services>("Services");
            SBindingList<Class_Services> doclist = new SBindingList<Class_Services>();
            foreach (Class_Services stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }

        public void Delete_Services_Infromation(Class_Services _Obj)
        {
            MongoCollection<Class_Services> Collection_ = Database_.GetCollection<Class_Services>("Services");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Insert_Services_Information(Class_Services _Obj)
        {
            MongoCollection<Class_Services> Collection_ = Database_.GetCollection<Class_Services>("Services");
            BsonDocument Stu_Doc = new BsonDocument {  
                {  
                    "Id", _Obj.Id
                },
                {  
                    "SERVICENM", _Obj.SERVICENM
                }
            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_Services_Information(Class_Services _Obj)
        {
            MongoCollection<Class_Services> Collection_ = Database_.GetCollection<Class_Services>("Services");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update
                .Set("SERVICENM", _Obj.SERVICENM);
            Collection_.Update(Marker, Update_);
        }

        public void Save_Services_Information(Class_Services _Obj)
        {
            MongoCollection<Class_Services> Collection_ = Database_.GetCollection<Class_Services>("Services");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("SERVICENM", _Obj.SERVICENM);
            Collection_.Save(Stu_Doc);
        }

        public SBindingList<Disrepair> Load_DataDisrepair()
        {
            var collection = Database_.GetCollection<Disrepair>("Disrepair");
            SBindingList<Disrepair> doclist = new SBindingList<Disrepair>();
            foreach (Disrepair stat in collection.FindAll())
            {
                doclist.Add(stat);
            }
            return doclist;
        }

        public void Delete_Disrepair_Infromation(Disrepair _Obj)
        {
            MongoCollection<Disrepair> Collection_ = Database_.GetCollection<Disrepair>("Disrepair");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            Collection_.Remove(Marker);
        }

        public void Insert_Disrepair_Information(Disrepair _Obj)
        {
            MongoCollection<Disrepair> Collection_ = Database_.GetCollection<Disrepair>("Disrepair");
            BsonDocument Stu_Doc = new BsonDocument {  
                {  
                    "Id", _Obj.Id
                },
                {  
                    "FAILURENM", _Obj.FAILURENM
                }
  
            };
            Collection_.Insert(Stu_Doc);
        }

        public void Update_Disrepair_Information(Disrepair _Obj)
        {
            MongoCollection<Disrepair> Collection_ = Database_.GetCollection<Disrepair>("Disrepair");
            IMongoQuery Marker = Query.EQ("Id", _Obj.Id);
            IMongoUpdate Update_ = MongoDB.Driver.Builders.Update
                .Set("FAILURENM", _Obj.FAILURENM);
            Collection_.Update(Marker, Update_);
        }

        public void Save_Disrepair_Information(Disrepair _Obj)
        {
            MongoCollection<Disrepair> Collection_ = Database_.GetCollection<Disrepair>("Disrepair");
            BsonDocument Stu_Doc = new BsonDocument()
                .Add("_id", _Obj._id)
                .Add("FAILURENM", _Obj.FAILURENM);
            Collection_.Save(Stu_Doc);
        }
    }
}

