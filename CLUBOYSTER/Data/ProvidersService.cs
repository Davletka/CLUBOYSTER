namespace CLUBOYSTER.Data
{
    public class ProvidersService
    {

        public List<Providers>? users = new List<Providers>();

        public List<Providers>? GetUsers()
        {
            return users;
        }

        public List<Providers>? SetUsers()
        {
            users = MongoDb.FindProviders();
            return users;
        }
    }
}
