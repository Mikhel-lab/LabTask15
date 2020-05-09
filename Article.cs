namespace TestTask
{
    public class Article
    {
        public int ID { get; set; }
        public int categoryID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }

        public Article(int id, int cat, string title, string body)
        {
            ID = id;
            categoryID = cat;
            Title = title;
            Body = body;
        }

        // public class Category
        // {
           
        // }
        
    }
}