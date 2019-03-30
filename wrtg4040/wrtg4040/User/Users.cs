using wrtg4040;

namespace Entities
{
    /// <summary>
    /// Contains Structure involved with storing the Users that have been pulled into the Database.
    /// </summary>
    public class Users
    {
        public User[] users;

        public class User : IUser
        {
            public string name { get; set; }
            public string surname { get; set; }
            public string gender { get; set; }
            public string region { get; set; }
            public int age { get; set; }
            public string title { get; set; }
            public string phone { get; set; }
            public object birthday { get; set; }
            public string email { get; set; }
            public string password { get; set; }
            public object credit_card { get; set; }
            public string photo { get; set; }
        }
    }
}