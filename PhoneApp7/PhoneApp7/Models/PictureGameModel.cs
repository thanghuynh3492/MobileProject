namespace PhoneApp7
{
    public class PictureGameModel
    {
        public int Id { get; set; }
        public int Correct { get; set; }
        public string Name { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }

        public PictureGameModel()
        {
        }

        public PictureGameModel(int Id, string Name, string Image1, string Image2, string Image3, int Correct)
        {
            this.Id = Id;
            this.Image1 = Image1;
            this.Image2 = Image2;
            this.Image3 = Image3;
            this.Correct = Correct;
            this.Name = Name;
        }
    }
}
