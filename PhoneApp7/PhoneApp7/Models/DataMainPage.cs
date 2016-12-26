namespace PhoneApp7
{
    public class DataMainPage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        
        public DataMainPage()
        {
        }

        public DataMainPage(int id, string name, string image)
        {
            Id = id;
            Name = name;
            Image = image;
        }
    }
}
