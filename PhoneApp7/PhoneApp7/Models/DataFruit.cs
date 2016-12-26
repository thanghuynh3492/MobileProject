namespace PhoneApp7
{
    public class DataFruit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Translate { get; set; }
        public string Transliteration { get; set; }
        public string TranslateVietNam { get; set; }
        public string Exemple { get; set; }
        public DataFruit()
        {
        }

        public DataFruit(int idFruit, string nameFruit, string imageFruit, string translateFruit)
        {
            Id = idFruit;
            Name = nameFruit;
            Image = imageFruit;
            Translate = translateFruit;
        }

        public DataFruit(int idAnimals, string nameAnimals, string imageAnimals, string translateAnimals, string transliteration, string translateVietNam, string exemple)
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
