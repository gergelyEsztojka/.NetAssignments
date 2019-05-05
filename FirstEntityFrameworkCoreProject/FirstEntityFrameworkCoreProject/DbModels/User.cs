using System.Collections.Generic;

namespace FirstEntityFrameworkCoreProject.DbModels
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
