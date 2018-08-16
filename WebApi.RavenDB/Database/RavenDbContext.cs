using Raven.Client.Documents;

namespace WebApi.RavenDB.Database
{
    public class RavenDbContext
    {
        public IDocumentStore DocumentStore { get; }
        public RavenDbContext()
        {
            DocumentStore = new DocumentStore
            {
                Urls = new[]
                {
                    "http://localhost:8080"
                },
                Database = "RavenDbExample",
                Conventions = { }
            };

            DocumentStore.Initialize();
        }
    }
}
