using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstEntityFrameworkCoreProject.DbModels
{
    public class Blog
    {
        public string Id { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public string Name { get; set; }
    }
}
