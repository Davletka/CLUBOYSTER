namespace CLUBOYSTER.Data
{
    public class UserService
    {
        public User? user { get; set; }

        public List<User>? users = new List<User>();

        public User? Get()
        {
            return user;
        }

        public User Set(User mem)
        {
            this.user = mem;
            return user;
        }

        public User Remove()
        {
            this.user = null;
            return user;
        }

        public List<User>? GetUsers()
        {
            return users;
        }

        public List<User>? SetUsers()
        {
            users = MongoDb.FindUsers();
            return users;
        }
    }
}
