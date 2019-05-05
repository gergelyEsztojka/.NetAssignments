using System.Collections.Generic;

namespace FirstEntityFrameworkCoreProject.DbModels
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }

        public IEnumerable<Post> Posts { get; set; }
    }
}
