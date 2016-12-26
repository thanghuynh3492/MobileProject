namespace PhoneApp7
{
    public class DataNumber
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Translate { get; set; }
        public string Transliteration { get; set; }
        public string TranslateVietNam { get; set; }
        public string Exemple { get; set; }

        public DataNumber()
        {
        }

        public DataNumber(int idNumber, string nameNumber, string imageNumber, string translateNumber)
        {
            Id = idNumber;
            Name = nameNumber;
            Image = imageNumber;
            Translate = translateNumber;
        }

        public DataNumber(int idAnimals, string nameAnimals, string imageAnimals, string translateAnimals, string transliteration, string translateVietNam, string exemple)
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
