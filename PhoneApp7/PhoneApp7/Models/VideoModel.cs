namespace PhoneApp7
{
    public class VideoModel
    {
        public string image { get; set; }
        public string name { get; set; }
        public string video { get; set; }

        public VideoModel()
        {
        }

        public VideoModel(string image, string name, string video)
        {
            this.image = image;
            this.name = name;
            this.video = video;
        }
    }
}
