namespace PhoneApp7
{
    public class DataAnimals
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Translate { get; set; }
        public string Transliteration { get; set; }
        public string TranslateVietNam { get; set; }
        public string Exemple { get; set; }
        public DataAnimals()
        {
        }

        public DataAnimals(int idAnimals, string nameAnimals, string imageAnimals, string translateAnimals)
        {
            Id = idAnimals;
            Name = nameAnimals;
            Image = imageAnimals;
            Translate = translateAnimals;
        }

        public DataAnimals(int idAnimals, string nameAnimals, string imageAnimals, string translateAnimals, string transliteration, string translateVietNam, string exemple)
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
