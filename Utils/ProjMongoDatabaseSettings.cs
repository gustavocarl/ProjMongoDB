namespace ProjMongoDB.Utils
{
    public class ProjMongoDatabaseSettings : IProjMongoDatabaseSettings
    {
        public string PersonCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
