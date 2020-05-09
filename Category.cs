namespace TestTask
{
    public class Category
    {
        public int ID { get; set; }
        public string CategoryName { get; set; }

        public Category(int id, string name)
        {
                ID = id;
                CategoryName = name;
        }
    }
}