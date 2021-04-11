using Mongo.Core.Abstract;

namespace Mongo.Core.Concrate
{
    public class MongoDBSettings : IMongoDBSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
