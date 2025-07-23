namespace BookManagementSystemAPI.Data
{
    public class MongoDbSettings
    {
        public string DatabaseName { get; set; }
        public string ConnectionString { get; set; }
        public string BookEventCollectionName { get; set; }
    }
}
