using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using System.Collections.ObjectModel;
using System.Windows.Media.Imaging;

namespace PhoneApp7
{
    public partial class Details : PhoneApplicationPage
    {
        public Details()
        {
            InitializeComponent();
        }
        public void GetDataColor()
        {
            ObservableCollection<DataColor> colors = new ObservableCollection<DataColor>();
            colors.Add(new DataColor(1, "Black", "/Resources/Color/Black.png", "/Resources/TranslateColor/Black.mp3", "/bɪər/", "Màu đen", "She has a black hair"));
            colors.Add(new DataColor(2, "Blue", "/Resources/Color/Blue.png", "/Resources/TranslateColor/Blue.mp3", "/blu:/", "Màu xanh", "It's blue."));
            colors.Add(new DataColor(3, "Brown", "/Resources/Color/brown.png", "/Resources/TranslateColor/Brown.mp3", "/braun/", "Màu nâu", "Your pant is brown."));
            colors.Add(new DataColor(4, "Orange", "/Resources/Color/Orange.png", "/Resources/TranslateColor/Orange.mp3", "/ɒrɪndʒ/", "Màu cam", "The hat is orange."));
            colors.Add(new DataColor(5, "Pink", "/Resources/Color/pink.png", "/Resources/TranslateColor/Pink.mp3", "Pink", "Màu hồng", "He has a pink coat."));
            colors.Add(new DataColor(6, "Purple", "/Resources/Color/Puple.png", "/Resources/TranslateColor/Purple.mp3", "/ˈpɜrpəl/", "Màu tím", "Lavender is purple."));
            colors.Add(new DataColor(7, "Red", "/Resources/Color/Red.png", "/Resources/TranslateColor/Red.mp3", "/red/", "Màu đỏ", "T-Shirt is Red."));
            colors.Add(new DataColor(8, "White", "/Resources/Color/White.png", "/Resources/TranslateColor/White.mp3", "/wai:t/", "Màu trắng", "Wedding dress is white."));
            colors.Add(new DataColor(9, "Yellow", "/Resources/Color/Yellow.png", "/Resources/TranslateColor/Yellow.mp3", "/'jelou/", "Màu vàng", "Yello is my favorite color."));
            lstDetails.ItemsSource = colors;
        }

        public void GetDataClothing()
        {
            ObservableCollection<DataClothing> clothings = new ObservableCollection<DataClothing>();
            clothings.Add(new DataClothing(1, "Baseball Cap", "/Resources/Clothing/BaseballCap.jpg", "/Resources/TranslateClothing/BaseballCap.mp3", "['beisbɔ:l] [kæp]", "Mũ bóng chày", "I see baseball Cap on bookshelf"));
            clothings.Add(new DataClothing(2, "Belt", "/Resources/Clothing/Belt.jpg", "/Resources/TranslateClothing/Belt.mp3", "/Belt/", "Thắt lưng", "My belt is broken."));
            clothings.Add(new DataClothing(3, "Blouse", "/Resources/Clothing/Blouse.jpg", "/Resources/TranslateClothing/Blouse.mp3", "/blauz/", "Áo choàng", "Blouse is white."));
            clothings.Add(new DataClothing(4, "Boots", "/Resources/Clothing/Boots.jpg", "/Resources/TranslateClothing/Boots.mp3", "/bu:ts/", "Giày bốt", "I lose boots."));
            clothings.Add(new DataClothing(5, "Dress", "/Resources/Clothing/Dress.jpg", "/Resources/TranslateClothing/Dress.mp3", "/dres/", "Đầm", "My sister choosen the grey dress for her gradution party."));
            clothings.Add(new DataClothing(6, "Gloves", "/Resources/Clothing/Gloves.jpg", "/Resources/TranslateClothing/Gloves.mp3", "/glʌvz/", "Găng tay", "I bought the gloves for winter."));
            clothings.Add(new DataClothing(7, "HighHeels", "/Resources/Clothing/HighHeels.jpg", "/Resources/TranslateClothing/HighHeels.mp3", "", "Giày Cao Gót", "High heels are the ultimate trendsetter when it comes to women's fashion."));
            clothings.Add(new DataClothing(8, "Jeans", "/Resources/Clothing/Jeans.jpg", "/Resources/TranslateClothing/Jeans.mp3", "[dʒi:nz]", "Quần jean", "Hundreds of different jean styles, including skinny jeans, straight leg jeans, bootcut and coloured denim."));
            clothings.Add(new DataClothing(9, "Sweater", "/Resources/Clothing/Sweater.jpg", "/Resources/TranslateClothing/Sweater.mp3", "Áo len", "['swetə]", "We call it natural air conditioning while, for others, a sweater would be a good idea."));
            clothings.Add(new DataClothing(10, "Shirt", "/Resources/Clothing/Shirt.jpg", "/Resources/TranslateClothing/Shirt.mp3", "/ʃɜːt/", "Áo sơ mi", "An unicorn wear white shoes, and blue jersey shirts"));
            lstDetails.ItemsSource = clothings;
        }

        public void GetDataVegetables()
        {
            ObservableCollection<DataVegetables> vegetableses = new ObservableCollection<DataVegetables>();
            vegetableses.Add(new DataVegetables(1, "Bell-pepper", "/Resources/Vegetables/Bell-pepper.jpg", "/Resources/TranslateVegetables/Bell-pepper.mp3", "[bel 'pepə(r)]", "ớt chuông", "Bell 	 is very good for health"));
            vegetableses.Add(new DataVegetables(2, "Broccoli", "/Resources/Vegetables/Broccoli.jpg", "/Resources/TranslateVegetables/Broccoli.mp3", "['brɒkəli]", "Bông cải xanh", "Broccoli soup is my favorite food"));
            vegetableses.Add(new DataVegetables(3, "Carrot", "/Resources/Vegetables/Carrot.jpg", "/Resources/TranslateVegetables/Carrot.mp3", "['kærət]", "Cà rốt", "Carrots have health benefits like reduced cholesterol, prevention of heart attacks, preventing cancers. "));
            vegetableses.Add(new DataVegetables(4, "Cauliflower", "/Resources/Vegetables/Cauliflower.jpg", "/Resources/TranslateVegetables/Cauliflower.mp3", "['kɔliflauə]", "Cải súp lơ", "Cauliflower rice is a healthy protein and fiber-packed alternative to white rice."));
            vegetableses.Add(new DataVegetables(5, "Eggplant", "/Resources/Vegetables/Eggplant.jpg", "/Resources/TranslateVegetables/Eggplant.mp3", "", "Cà tím", "Eggplant has been cultivated in India for at least 4,000 years."));
            vegetableses.Add(new DataVegetables(6, "Ginger", "/Resources/Vegetables/Ginger.jpg", "/Resources/TranslateVegetables/Ginger.mp3", "['dʒindʒə]", "Củ Gừng", "Give me some ginger beer, a pie and some hot chips"));
            vegetableses.Add(new DataVegetables(7, "Ice-buerg-lettuce", "/Resources/Vegetables/Ice-buerg-lettuce.jpg", "/Resources/TranslateVegetables/Ice-buerg-lettuce.mp3", "", "Rau diếp", ""));
            vegetableses.Add(new DataVegetables(8, "Kohlrabi", "/Resources/Vegetables/Kohlrabi.jpg", "/Resources/TranslateVegetables/Kohlrabi.mp3", "['koul'rɑ:bi]", "Củ Cải", "Kohlrabi's crisp, mild and sweet white flesh is suitable for fresh eating or light cooking."));
            vegetableses.Add(new DataVegetables(9, "Tomato", "/Resources/Vegetables/Tomato.jpg", "/Resources/TranslateVegetables/Tomato.mp3", "[tə'mɑ:tou]", "Cà Chua", "The English called it tomate and later tomato, but the term “love apple” also became fashionable."));
            vegetableses.Add(new DataVegetables(10, "Yam", "/Resources/Vegetables/Yam.jpg", "/Resources/TranslateVegetables/Yam.mp3", "[jæm]", "Khoai Mỡ", "Do you know the difference between a yam and a sweet potato?"));
            lstDetails.ItemsSource = vegetableses;
        }

        public void GetDataFruit()
        {
            ObservableCollection<DataFruit> fruits = new ObservableCollection<DataFruit>();
            fruits.Add(new DataFruit(1, "Apple", "/Resources/Fruit/Apple.jpg", "/Resources/TranslateFruit/Apple.mp3", "['æpl]", "Quả Táo", "Can you give me this apple?"));
            fruits.Add(new DataFruit(2, "Apricot", "/Resources/Fruit/Apricot.jpg", "/Resources/TranslateFruit/Apricot.mp3", "['eiprikɔt]", "Quả Mơ", "Method for processing plums and apricots"));
            fruits.Add(new DataFruit(3, "Banana", "/Resources/Fruit/Banana.jpg", "/Resources/TranslateFruit/Banana.mp3", "[bə'nɑ:nə]", "Quả chuối", "Banana leaves for tet cakes"));
            fruits.Add(new DataFruit(4, "Cherry", "/Resources/Fruit/Cherry.jpg", "/Resources/TranslateFruit/Cherry.mp3", "['t∫eri]", "Anh đào", "The two major kinds of cherries are sweet and sour ."));
            fruits.Add(new DataFruit(5, "Dragon-fruit", "/Resources/Fruit/Dragon-fruit.jpg", "/Resources/TranslateFruit/Dragon-fruit.mp3", "", "Thanh long", "The other name of dragon fruit is pitaya"));
            fruits.Add(new DataFruit(6, "Grape", "/Resources/Fruit/Grape.jpg", "/Resources/TranslateFruit/Grape.mp3", "[greip]", "Quả nho", "You can almost detect the rich French soil and the history that went into the grape"));
            fruits.Add(new DataFruit(7, "Lemon", "/Resources/Fruit/Lemon.jpg", "/Resources/TranslateFruit/Lemon.mp3", "['lemən]", "Quả chanh", "Why are you putting in lemon squares?"));
            fruits.Add(new DataFruit(8, "Lychee", "/Resources/Fruit/Lychee.jpg", "/Resources/TranslateFruit/Lychee.mp3", "[lai't∫e:]", "Vải Thiều", "Lychee fruit is rich in antioxidant vitamin C and other beneficial plant compounds that can be a healthy and tasty addition to your diet."));
            fruits.Add(new DataFruit(9, "Mangosteen", "/Resources/Fruit/Mangosteen.jpg", "/Resources/TranslateFruit/Mangosteen.mp3", "['mæηgousti:n]", "Cây măng cụt", "Mangosteen is a tropical fruit that has great nutritional value to it."));
            fruits.Add(new DataFruit(10, "Passion-fruit", "/Resources/Fruit/Passion-fruit.jpg", "/Resources/TranslateFruit/Passion-fruit.mp3", "['pæ∫ən frut]", "Chanh dây", "Passion fruit is a very refreshing, tropical-fruit, full of phyto-nutrients such as carotenes, vitamin A, and vitamin C."));
            lstDetails.ItemsSource = fruits;
        }

        public void GetDataAlphabets()
        {
            ObservableCollection<DataAlphabets> alphabetses = new ObservableCollection<DataAlphabets>();
            alphabetses.Add(new DataAlphabets(1, "A", "/Resources/Alphabets/A.png", "/Resources/Translate/A.mp3", "[,ei'wʌn]", "A", ""));
            alphabetses.Add(new DataAlphabets(2, "B", "/Resources/Alphabets/B.png", "/Resources/Translate/A.mp3", "[bi:]", "B", ""));
            alphabetses.Add(new DataAlphabets(3, "C", "/Resources/Alphabets/C.png", "/Resources/Translate/C.mp3", "[si:]", "C", ""));
            alphabetses.Add(new DataAlphabets(4, "D", "/Resources/Alphabets/D.png", "/Resources/Translate/D.mp3", "[di:]", "D", ""));
            alphabetses.Add(new DataAlphabets(5, "E", "/Resources/Alphabets/E.png", "/Resources/Translate/E.mp3", "[i:]", "E", ""));
            alphabetses.Add(new DataAlphabets(6, "F", "/Resources/Alphabets/F.png", "/Resources/Translate/F.mp3", "[ef]", "", "F"));
            alphabetses.Add(new DataAlphabets(7, "G", "/Resources/Alphabets/G.png", "/Resources/Translate/G.mp3", "[dʒi: - dʒi:z]", "G", ""));
            alphabetses.Add(new DataAlphabets(8, "H", "/Resources/Alphabets/H.png", "/Resources/Translate/H.mp3", "['eit∫iz]", "H", ""));
            alphabetses.Add(new DataAlphabets(9, "I", "/Resources/Alphabets/I.png", "/Resources/Translate/I.mp3", "[ai]", "I", ""));
            alphabetses.Add(new DataAlphabets(10, "J", "/Resources/Alphabets/J.png", "/Resources/Translate/J.mp3", "[dzei]", "J", ""));
            lstDetails.ItemsSource = alphabetses;
        }

        public void GetDataNumber()
        {
            ObservableCollection<DataNumber> numbers = new ObservableCollection<DataNumber>();
            numbers.Add(new DataNumber(1, "Zero", "/Resources/Number/0.png", "/Resources/TranslatenNumber/0.mp3", "['ziərou]", "Số Không", "Make zero, a little behind the center"));
            numbers.Add(new DataNumber(2, "One", "/Resources/Number/1.png", "/Resources/TranslatenNumber/1.mp3", "[wʌn]", "Một", "Say one more time, please."));
            numbers.Add(new DataNumber(3, "Two", "/Resources/Number/2.png", "/Resources/TranslatenNumber/2.mp3", "[tu:]", "Hai", "Two years after... his parents died and she was adopted by the Strodes"));
            numbers.Add(new DataNumber(4, "Three", "/Resources/Number/3.png", "/Resources/TranslatenNumber/3.mp3", "[θri:]", "Ba", "Three moons have passed since her sweet face...... brightened the balcony of that lonely room"));
            numbers.Add(new DataNumber(5, "Four", "/Resources/Number/4.png", "/Resources/TranslatenNumber/4.mp3", "[fɔ:]", "Bốn", "Four trips a day will kill your donkey"));
            numbers.Add(new DataNumber(6, "Five", "/Resources/Number/5.png", "/Resources/TranslatenNumber/5.mp3", "[faiv]", "Năm", "These five units correlate with rocks in the Alexander Terrane in southeastern Alaska."));
            numbers.Add(new DataNumber(7, "Six", "/Resources/Number/6.png", "/Resources/TranslatenNumber/6.mp3", "[siks]", "Sáu", "One hour of meeting time with interpretation in six languages and support services"));
            numbers.Add(new DataNumber(8, "Seven", "/Resources/Number/7.png", "/Resources/TranslatenNumber/7.mp3", "['sevn]", "Bảy", "Seven bucks should be enough to feed the both of us"));
            numbers.Add(new DataNumber(9, "Eight", "/Resources/Number/8.png", "/Resources/TranslatenNumber/8.mp3", "[eit]", "Tám", "There' d be eight others left"));
            numbers.Add(new DataNumber(10, "Nine", "/Resources/Number/9.png", "/Resources/TranslatenNumber/9.mp3", "[nain]", "Chín", "Nine percent increase in the total number of housing units on reserve "));
            lstDetails.ItemsSource = numbers;
        }

        public void GetDataAnimal()
        {
            ObservableCollection<DataAnimals> animals = new ObservableCollection<DataAnimals>();
            animals.Add(new DataAnimals(1, "Bear", "/Resources/Animal/Bear.jpg", "/Resources/TranslateAnimal/Bear.mp3", "/bɪər/", "Con gấu", "Introduction Bears and people have shared this landscape for thousands of years."));
            animals.Add(new DataAnimals(2, "Buffalo", "/Resources/Animal/Buffalo.jpg", "/Resources/TranslateAnimal/Buffalo.mp3", "/´bʌfəlou/", "Con trâu", "There is a buffalo on the field."));
            animals.Add(new DataAnimals(3, "Camel", "/Resources/Animal/Camel.jpg", "/Resources/SoundAnimal/Camel.mp3", "/´kæml/", "Con lạc đà", "When the terrorists are at the mines and the camels start to run"));
            animals.Add(new DataAnimals(4, "Cat", "/Resources/Animal/Cat.jpg", "/Resources/TranslateAnimal/Cat.mp3", "/kæt/", "Con mèo", "That's not a cat. That's a dog."));
            animals.Add(new DataAnimals(5, "Cow", "/Resources/Animal/Cow.jpg", "/Resources/TranslateAnimal/Cow.mp3", "tim giúp", "Con bò", "Don' t hit me with the big cow eyes there stretch?Ok? I could always take care of myself"));
            animals.Add(new DataAnimals(6, "Deer", "/Resources/Animal/Deer.jpg", "/Resources/TranslateAnimal/Deer.mp3", "/diə/", "Con nai", "For example, white-tailed deer living in northwestern Costa Rica host six species of tick."));
            animals.Add(new DataAnimals(7, "Dog", "/Resources/Animal/Dog.jpg", "/Resources/TranslateAnimal/Dog.mp3", "/dɔg/", "Con chó", "Right between the dog boy and the two- headed rattlesnake"));
            animals.Add(new DataAnimals(8, "Dolphin", "/Resources/Animal/Dolphin.jpg", "/Resources/TranslateAnimal/Dolphin.mp3", "/´dɔlfin/", "Cá heo", "When I started training dolphins, there was no manual"));
            animals.Add(new DataAnimals(9, "Eagle", "/Resources/Animal/Eagle.jpg", "/Resources/TranslateAnimal/Eagle.mp3", "/'iːgl/", "Chim đại bàng", "Here the dancers used eagle whistles to awaken the fallen soldiers and guide them home."));
            animals.Add(new DataAnimals(10, "Elephant", "/Resources/Animal/Elephant.jpg", "/Resources/TranslateAnimal/Elephant.mp3", "/´elif(ə)nt/", "Con voi", "Just a playful little elephant, with no idea of the heart- rending drama that lies ahead of her"));
            lstDetails.ItemsSource = animals;
        }

        public void GetDataSchoolSupplie()
        {
            ObservableCollection<SchoolSupplie> schoolSupplies = new ObservableCollection<SchoolSupplie>();
            schoolSupplies.Add(new SchoolSupplie(1, "Bag", "/Resources/SchoolSupplies/Bag.jpg", "/Resources/TranslateSchoolSupplies/Bag.mp3", "[bæg]", "Cái túi", "I want that bag."));
            schoolSupplies.Add(new SchoolSupplie(2, "BallPointPen", "/Resources/SchoolSupplies/BallPointPen.jpg", "/Resources/TranslateSchoolSupplies/BallPointPen.mp3", "", "Bút Bi", "Fascinating facts about the invention of the Ballpoint Pen by Ladislas Biro and his brother, Georg in 1935."));
            schoolSupplies.Add(new SchoolSupplie(3, "Book", "/Resources/SchoolSupplies/Book.jpg", "/Resources/TranslateSchoolSupplies/Book.mp3", "[buk]", "Sách", "I could pin murder one on you for possession of those books"));
            schoolSupplies.Add(new SchoolSupplie(4, "Calculator", "/Resources/SchoolSupplies/Calculator.jpg", "/Resources/TranslateSchoolSupplies/Calculator.mp3", "['kælkjuleitə]", "Máy tính bỏ túi", "The cost factors are calculated from the perspective of the employer."));
            schoolSupplies.Add(new SchoolSupplie(5, "Chalk", "/Resources/SchoolSupplies/Chalk.jpg", "/Resources/TranslateSchoolSupplies/Chalk.mp3", "[t∫ɔ:k]", "Phấn", ""));
            schoolSupplies.Add(new SchoolSupplie(6, "Clip", "/Resources/SchoolSupplies/Clip.jpg", "/Resources/TranslateSchoolSupplies/Clip.mp3", "[klip]", "Kẹp giấy", ""));
            schoolSupplies.Add(new SchoolSupplie(7, "Compa", "/Resources/SchoolSupplies/Compa.jpg", "/Resources/TranslateSchoolSupplies/Compa.mp3", "", "Compa", ""));
            schoolSupplies.Add(new SchoolSupplie(8, "Eraser1", "/Resources/SchoolSupplies/Eraser1.jpg", "/Resources/TranslateSchoolSupplies/Eraser1.mp3", "[i'reizə]", "Cục Tẩy", "Eraser is available in a few flavours, the stable, the beta as well as the nightly builds."));
            schoolSupplies.Add(new SchoolSupplie(9, "NoteBook", "/Resources/SchoolSupplies/NoteBook.jpg", "/Resources/TranslateSchoolSupplies/NoteBook.mp3", "['noutbuk]", "Sổ ghi chú", ""));
            schoolSupplies.Add(new SchoolSupplie(10, "Crayon", "/Resources/SchoolSupplies/Crayon.jpg", "/Resources/TranslateSchoolSupplies/Crayon.mp3", "['kreiən]", "Bút sáp màu", "The candles are cylindrical, wavy or shaped like a crayon."));
            lstDetails.ItemsSource = schoolSupplies;
        }

        private string _name;
        private string _image;
        private string _translate;
        private string _sound;
        private int _id;
        private string _transliteration;
        private string _translateVietNam;
        private string _Exemple;

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _id = Convert.ToInt32(NavigationContext.QueryString["id"]);
            switch (_id)
            {
                case 1:
                    GetDataColor();
                    break;
                case 2:
                    GetDataClothing();
                    break;
                case 3:
                    GetDataVegetables();
                    break;
                case 4:
                    GetDataFruit();
                    break;
                case 5:
                    GetDataAlphabets();
                    break;
                case 6:
                    GetDataNumber();
                    break;
                case 7:
                    GetDataAnimal();
                    break;
                case 8:
                    GetDataSchoolSupplie();
                    break;
            }
        }

        void ImageBackgroundTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mediaElement.Source = new Uri(_translate, UriKind.Relative);
            mediaElement.Play();
        }

        void TblSpeakTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mediaElement.Source = new Uri(_translate, UriKind.Relative);
            mediaElement.Play();
        }

        void ImageButtonTranslateTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mediaElement.Source = new Uri(_translate, UriKind.Relative);
            mediaElement.Play();
        }

        private void ImgImageTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            switch (_id)
            {
                case 1:
                    DataColor color = (DataColor)lstDetails.SelectedItem;
                    _name = color.Name;
                    _image = color.Image;
                    _translate = color.Translate;
                    _transliteration = color.Transliteration;
                    _translateVietNam = color.TranslateVietNam;
                    _Exemple = color.Exemple;
                    break;
                case 2:
                    DataClothing clothing = (DataClothing)lstDetails.SelectedItem;
                    _name = clothing.Name;
                    _image = clothing.Image;
                    _translate = clothing.Translate;
                    _transliteration = clothing.Transliteration;
                    _translateVietNam = clothing.TranslateVietNam;
                    _Exemple = clothing.Exemple;
                    break;
                case 3:
                    DataVegetables vegetables = (DataVegetables)lstDetails.SelectedItem;
                    _name = vegetables.Name;
                    _image = vegetables.Image;
                    _translate = vegetables.Translate;
                    _transliteration = vegetables.Transliteration;
                    _translateVietNam = vegetables.TranslateVietNam;
                    _Exemple = vegetables.Exemple;
                    break;
                case 4:
                    DataFruit fruit = (DataFruit)lstDetails.SelectedItem;
                    _name = fruit.Name;
                    _image = fruit.Image;
                    _translate = fruit.Translate;
                    _transliteration = fruit.Transliteration;
                    _translateVietNam = fruit.TranslateVietNam;
                    _Exemple = fruit.Exemple;
                    break;
                case 5:
                    DataAlphabets alphabets = (DataAlphabets)lstDetails.SelectedItem;
                    _name = alphabets.Name;
                    _image = alphabets.Image;
                    _translate = alphabets.Translate;
                    _transliteration = alphabets.Transliteration;
                    _translateVietNam = alphabets.TranslateVietNam;
                    _Exemple = alphabets.Exemple;
                    break;
                case 6:
                    DataNumber number = (DataNumber)lstDetails.SelectedItem;
                    _name = number.Name;
                    _image = number.Image;
                    _translate = number.Translate;
                    _transliteration = number.Transliteration;
                    _translateVietNam = number.TranslateVietNam;
                    _Exemple = number.Exemple;
                    break;
                case 7:
                    DataAnimals animals = (DataAnimals)lstDetails.SelectedItem;
                    _name = animals.Name;
                    _image = animals.Image;
                    _transliteration = animals.Transliteration;
                    _translateVietNam = animals.TranslateVietNam;
                    _translate = animals.Translate;
                    _Exemple = animals.Exemple;
                    tblSound.Visibility = Visibility.Visible;
                    tblSound.Tap += TblSoundTap;
                    break;
                case 8:
                    SchoolSupplie schoolSupplie = (SchoolSupplie)lstDetails.SelectedItem;
                    _name = schoolSupplie.Name;
                    _image = schoolSupplie.Image;
                    _translate = schoolSupplie.Translate;
                    _transliteration = schoolSupplie.Transliteration;
                    _translateVietNam = schoolSupplie.TranslateVietNam;
                    _Exemple = schoolSupplie.Exemple;
                    break;
            }

            imageButtonTranslate.Visibility = Visibility.Visible;
            tblSpeak.Visibility = Visibility.Visible;
            imgTextPhiemAm.Visibility = Visibility.Visible;
            ExempleText.Visibility = Visibility.Visible;
            TextTranslate.Visibility = Visibility.Visible;
            imageButtonTranslate.Tap += ImageButtonTranslateTap;
            tblSpeak.Tap += TblSpeakTap;
            tblName.Text = _name;
            imgtrans.Text = _transliteration;
            Translate.Text = _translateVietNam;
            Exemple.Text = _Exemple;
            imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
            imageBackground.Tap += ImageBackgroundTap;
        }

        void TblSoundTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mediaElement.Source = new Uri(_sound, UriKind.Relative);
            mediaElement.Play();
        }

        void ImageButtonSoundTap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mediaElement.Source = new Uri(_sound, UriKind.Relative);
            mediaElement.Play();
        }
    }
}