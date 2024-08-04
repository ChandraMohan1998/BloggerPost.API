namespace BlogPost.API.Model.Domain
{
    public class BloggerPost
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string ShortDiscription { get; set; }
        public string MyProperty { get; set; }
        public string Content { get; set; }
        public string UrlHandle { get; set; }
        public string FeaturedImageUrl { get; set; }
        public DateTime DateCreated { get; set; }
        public string Author { get; set; }
        public bool IsVisible { get; set; }

    }
}
