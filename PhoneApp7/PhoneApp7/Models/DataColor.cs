namespace PhoneApp7
{
    public class DataColor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Translate { get; set; }
        public string Transliteration { get; set; }
        public string TranslateVietNam { get; set; }
        public string Exemple { get; set; }

        public DataColor()
        {
        }

        public DataColor(int idColor, string nameColor, string imageColor, string translateColor)
        {
            Id = idColor;
            Name = nameColor;
            Image = imageColor;
            Translate = translateColor;
        }
        public DataColor(int idAnimals, string nameAnimals, string imageAnimals, string translateAnimals, string transliteration, string translateVietNam, string exemple)
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
