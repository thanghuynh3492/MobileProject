namespace PhoneApp7
{
    public class DataClothing
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Translate { get; set; }
        public string Transliteration { get; set; }
        public string TranslateVietNam { get; set; }
        public string Exemple { get; set; }

        public DataClothing()
        {
        }

        public DataClothing(int idClothing, string nameClothing, string imageClothing, string translateClothing)
        {
            Id = idClothing;
            Name = nameClothing;
            Image = imageClothing;
            Translate = translateClothing;
        }
        public DataClothing(int idAnimals, string nameAnimals, string imageAnimals, string translateAnimals, string transliteration, string translateVietNam, string exemple)
        {
            Id = idAnimals;
            Name = nameAnimals;
            Image = imageAnimals;
            Translate = translateAnimals;
            Transliteration = transliteration;
            TranslateVietNam = translateVietNam;
            Exemple = exemple;
        }

    }
}
