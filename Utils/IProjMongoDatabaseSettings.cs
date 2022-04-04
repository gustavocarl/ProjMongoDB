namespace ProjMongoDB.Utils
{
    public interface IProjMongoDatabaseSettings
    {
        string PersonCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
