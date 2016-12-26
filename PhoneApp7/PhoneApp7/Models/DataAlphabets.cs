namespace PhoneApp7
{
    public class DataAlphabets
    {
        public int Id{ get; set; }
        public string Name{ get; set; }
        public string Image{ get; set; }
        public string Translate { get; set; }
        public string Transliteration { get; set; }
        public string TranslateVietNam { get; set; }
        public string Exemple { get; set; }

        public DataAlphabets()
        {
        }

        public DataAlphabets(int idAlphabets, string nameAlphabets, string imageAlphabets, string translateAlphabets)
        {
            Id = idAlphabets;
            Name = nameAlphabets;
            Image = imageAlphabets;
            Translate = translateAlphabets;
        }

        public DataAlphabets(int idAnimals, string nameAnimals, string imageAnimals, string translateAnimals, string transliteration, string translateVietNam, string exemple)
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
