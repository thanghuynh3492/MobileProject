namespace PhoneApp7
{
    public class DataVegetables
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }       
        public string Translate { get; set; }
        public string Transliteration { get; set; }
        public string TranslateVietNam { get; set; }
        public string Exemple { get; set; }

        public DataVegetables()
        {
        }

        public DataVegetables(int idVegetables, string nameVegetables, string imageVegetables, string translateVegetables)
        {
            Id = idVegetables;
            Name = nameVegetables;
            Image = imageVegetables;
            Translate = translateVegetables;
        }

        public DataVegetables(int idAnimals, string nameAnimals, string imageAnimals, string translateAnimals, string transliteration, string translateVietNam, string exemple)
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
