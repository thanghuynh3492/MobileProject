namespace PhoneApp7
{
    public class SchoolSupplie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Translate { get; set; }
        public string Transliteration { get; set; }
        public string TranslateVietNam { get; set; }
        public string Exemple { get; set; }

        public SchoolSupplie()
        {
        }

        public SchoolSupplie(int idSchoolSupplie, string nameSchoolSupplie, string imageSchoolSupplie, string translateSchoolSupplie)
        {
            Id = idSchoolSupplie;
            Name = nameSchoolSupplie;
            Image = imageSchoolSupplie;
            Translate = translateSchoolSupplie;
        }

        public SchoolSupplie(int idAnimals, string nameAnimals, string imageAnimals, string translateAnimals, string transliteration, string translateVietNam, string exemple)
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
