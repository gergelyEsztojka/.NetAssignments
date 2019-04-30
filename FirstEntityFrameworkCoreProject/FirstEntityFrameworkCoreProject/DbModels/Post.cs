namespace FirstEntityFrameworkCoreProject.DbModels
{
    public class Post
    {
        public string Id { get; set; }
        public string UserId { get; set; }
        public string BlogId { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
    }
}