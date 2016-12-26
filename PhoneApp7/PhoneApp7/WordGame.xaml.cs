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
using System.Threading.Tasks;

namespace PhoneApp7
{
    public partial class WordGame : PhoneApplicationPage
    {
        public WordGame()
        {
            InitializeComponent();
        }
        public void GetDataColor()
        {

            colors.Add(new DataColor(1, "Black", "/Resources/Color/Black.png", "/Resources/TranslateColor/Black.mp3"));
            colors.Add(new DataColor(2, "Blue", "/Resources/Color/Blue.png", "/Resources/TranslateColor/Blue.mp3"));
            colors.Add(new DataColor(3, "Brown", "/Resources/Color/Brown.jpg", "/Resources/TranslateColor/Brown.mp3"));
            colors.Add(new DataColor(4, "Orange", "/Resources/Color/Orange.png", "/Resources/TranslateColor/Orange.mp3"));
            colors.Add(new DataColor(5, "Pink", "/Resources/Color/Pink.jpg", "/Resources/TranslateColor/Pink.mp3"));
            colors.Add(new DataColor(6, "Purple", "/Resources/Color/Purple.png", "/Resources/TranslateColor/Purple.mp3"));
            colors.Add(new DataColor(7, "Red", "/Resources/Color/Red.png", "/Resources/TranslateColor/Red.mp3"));
            colors.Add(new DataColor(8, "White", "/Resources/Color/White.png", "/Resources/TranslateColor/White.mp3"));
            colors.Add(new DataColor(9, "Yellow", "/Resources/Color/Yellow.png", "/Resources/TranslateColor/Yellow.mp3"));
            colors.Add(new DataColor(10, "Grey", "/Resources/Color/Grey.png", "/Resources/TranslateColor/Grey.mp3"));
        }

        public void GetDataClothing()
        {
            clothings.Add(new DataClothing(1, "BaseballCap", "/Resources/Clothing/BaseballCap.jpg", "/Resources/TranslateClothing/BaseballCap.mp3"));
            clothings.Add(new DataClothing(2, "Belt", "/Resources/Clothing/Belt.jpg", "/Resources/TranslateClothing/Belt.mp3"));
            clothings.Add(new DataClothing(3, "Blouse", "/Resources/Clothing/Blouse.jpg", "/Resources/TranslateClothing/Blouse.mp3"));
            clothings.Add(new DataClothing(4, "Boots", "/Resources/Clothing/Boots.jpg", "/Resources/TranslateClothing/Boots.mp3"));
            clothings.Add(new DataClothing(5, "Dress", "/Resources/Clothing/Dress.jpg", "/Resources/TranslateClothing/Dress.mp3"));
            clothings.Add(new DataClothing(6, "Gloves", "/Resources/Clothing/Gloves.jpg", "/Resources/TranslateClothing/Gloves.mp3"));
            clothings.Add(new DataClothing(7, "HighHeels", "/Resources/Clothing/HighHeels.jpg", "/Resources/TranslateClothing/HighHeels.mp3"));
            clothings.Add(new DataClothing(8, "Jeans", "/Resources/Clothing/Jeans.jpg", "/Resources/TranslateClothing/Jeans.mp3"));
            clothings.Add(new DataClothing(9, "Sweater", "/Resources/Clothing/Sweater.jpg", "/Resources/TranslateClothing/Sweater.mp3"));
            clothings.Add(new DataClothing(10, "Shirt", "/Resources/Clothing/Shirt.jpg", "/Resources/TranslateClothing/Shirt.mp3"));
        }

        public void GetDataVegetables()
        {
            vegetableses.Add(new DataVegetables(1, "Bell-pepper", "/Resources/Vegetables/Bell-pepper.jpg", "/Resources/TranslateVegetables/Bell-pepper.mp3"));
            vegetableses.Add(new DataVegetables(2, "Broccoli", "/Resources/Vegetables/Broccoli.jpg", "/Resources/TranslateVegetables/Broccoli.mp3"));
            vegetableses.Add(new DataVegetables(3, "Carrot", "/Resources/Vegetables/Carrot.jpg", "/Resources/TranslateVegetables/Carrot.mp3"));
            vegetableses.Add(new DataVegetables(4, "Cauliflower", "/Resources/Vegetables/Cauliflower.jpg", "/Resources/TranslateVegetables/Cauliflower.mp3"));
            vegetableses.Add(new DataVegetables(5, "Eggplant", "/Resources/Vegetables/Eggplant.jpg", "/Resources/TranslateVegetables/Eggplant.mp3"));
            vegetableses.Add(new DataVegetables(6, "Ginger", "/Resources/Vegetables/Ginger.jpg", "/Resources/TranslateVegetables/Ginger.mp3"));
            vegetableses.Add(new DataVegetables(7, "Ice-buerg-lettuce", "/Resources/Vegetables/Ice-buerg-lettuce.jpg", "/Resources/TranslateVegetables/Ice-buerg-lettuce.mp3"));
            vegetableses.Add(new DataVegetables(8, "Kohlrabi", "/Resources/Vegetables/Kohlrabi.jpg", "/Resources/TranslateVegetables/Kohlrabi.mp3"));
            vegetableses.Add(new DataVegetables(9, "Tomato", "/Resources/Vegetables/Tomato.jpg", "/Resources/TranslateVegetables/Tomato.mp3"));
            vegetableses.Add(new DataVegetables(10, "Yam", "/Resources/Vegetables/Yam.jpg", "/Resources/TranslateVegetables/Yam.mp3"));
        }

        public void GetDataFruit()
        {
            fruits.Add(new DataFruit(1, "Apple", "/Resources/Fruit/Apple.jpg", "/Resources/TranslateFruit/Apple.mp3"));
            fruits.Add(new DataFruit(2, "Apricot", "/Resources/Fruit/Apricot.jpg", "/Resources/TranslateFruit/Apricot.mp3"));
            fruits.Add(new DataFruit(3, "Banana", "/Resources/Fruit/Banana.jpg", "/Resources/TranslateFruit/Banana.mp3"));
            fruits.Add(new DataFruit(4, "Cherry", "/Resources/Fruit/Cherry.jpg", "/Resources/TranslateFruit/Cherry.mp3"));
            fruits.Add(new DataFruit(5, "Dragon-fruit", "/Resources/Fruit/Dragon-fruit.jpg", "/Resources/TranslateFruit/Dragon-fruit.mp3"));
            fruits.Add(new DataFruit(6, "Grape", "/Resources/Fruit/Grape.jpg", "/Resources/TranslateFruit/Grape.mp3"));
            fruits.Add(new DataFruit(7, "Lemon", "/Resources/Fruit/Lemon.jpg", "/Resources/TranslateFruit/Lemon.mp3"));
            fruits.Add(new DataFruit(8, "Lychee", "/Resources/Fruit/Lychee.jpg", "/Resources/TranslateFruit/Lychee.mp3"));
            fruits.Add(new DataFruit(9, "Mangosteen", "/Resources/Fruit/Mangosteen.jpg", "/Resources/TranslateFruit/Mangosteen.mp3"));
            fruits.Add(new DataFruit(10, "Passion-fruit", "/Resources/Fruit/Passion-fruit.jpg", "/Resources/TranslateFruit/Passion-fruit.mp3"));
        }

        public void GetDataAlphabets()
        {
            alphabetses.Add(new DataAlphabets(1, "A", "/Resources/Alphabets/A.png", "/Resources/Translate/A.mp3"));
            alphabetses.Add(new DataAlphabets(2, "B", "/Resources/Alphabets/B.png", "/Resources/Translate/A.mp3"));
            alphabetses.Add(new DataAlphabets(3, "C", "/Resources/Alphabets/C.png", "/Resources/Translate/C.mp3"));
            alphabetses.Add(new DataAlphabets(4, "D", "/Resources/Alphabets/D.png", "/Resources/Translate/D.mp3"));
            alphabetses.Add(new DataAlphabets(5, "E", "/Resources/Alphabets/E.png", "/Resources/Translate/E.mp3"));
            alphabetses.Add(new DataAlphabets(6, "F", "/Resources/Alphabets/F.png", "/Resources/Translate/F.mp3"));
            alphabetses.Add(new DataAlphabets(7, "G", "/Resources/Alphabets/G.png", "/Resources/Translate/G.mp3"));
            alphabetses.Add(new DataAlphabets(8, "H", "/Resources/Alphabets/H.png", "/Resources/Translate/H.mp3"));
            alphabetses.Add(new DataAlphabets(9, "I", "/Resources/Alphabets/I.png", "/Resources/Translate/I.mp3"));
            alphabetses.Add(new DataAlphabets(10, "J", "/Resources/Alphabets/J.png", "/Resources/Translate/J.mp3"));
        }

        public void GetDataNumber()
        {
            numbers.Add(new DataNumber(1, "0", "/Resources/Number/0.png", "/Resources/TranslatenNumber/0.mp3"));
            numbers.Add(new DataNumber(2, "1", "/Resources/Number/1.png", "/Resources/TranslatenNumber/1.mp3"));
            numbers.Add(new DataNumber(3, "2", "/Resources/Number/2.png", "/Resources/TranslatenNumber/2.mp3"));
            numbers.Add(new DataNumber(4, "3", "/Resources/Number/3.png", "/Resources/TranslatenNumber/3.mp3"));
            numbers.Add(new DataNumber(5, "4", "/Resources/Number/4.png", "/Resources/TranslatenNumber/4.mp3"));
            numbers.Add(new DataNumber(6, "5", "/Resources/Number/5.png", "/Resources/TranslatenNumber/5.mp3"));
            numbers.Add(new DataNumber(7, "6", "/Resources/Number/6.png", "/Resources/TranslatenNumber/6.mp3"));
            numbers.Add(new DataNumber(8, "7", "/Resources/Number/7.png", "/Resources/TranslatenNumber/7.mp3"));
            numbers.Add(new DataNumber(9, "8", "/Resources/Number/8.png", "/Resources/TranslatenNumber/8.mp3"));
            numbers.Add(new DataNumber(10, "9", "/Resources/Number/9.png", "/Resources/TranslatenNumber/9.mp3"));
        }

        public void GetDataAnimal()
        {
            animals.Add(new DataAnimals(1, "Bear", "/Resources/Animal/Bear.jpg", "/Resources/TranslateAnimal/Bear.mp3"));
            animals.Add(new DataAnimals(2, "Buffalo", "/Resources/Animal/Buffalo.jpg", "/Resources/TranslateAnimal/Buffalo.mp3"));
            animals.Add(new DataAnimals(3, "Camel", "/Resources/Animal/Camel.jpg", "/Resources/TranslateAnimal/Camel.mp3"));
            animals.Add(new DataAnimals(4, "Cat", "/Resources/Animal/Cat.jpg", "/Resources/TranslateAnimal/Cat.mp3"));
            animals.Add(new DataAnimals(5, "Cow", "/Resources/Animal/Cow.jpg", "/Resources/TranslateAnimal/Cow.mp3"));
            animals.Add(new DataAnimals(6, "Deer", "/Resources/Animal/Deer.jpg", "/Resources/TranslateAnimal/Deer.mp3"));
            animals.Add(new DataAnimals(7, "Dog", "/Resources/Animal/Dog.jpg", "/Resources/TranslateAnimal/Dog.mp3"));
            animals.Add(new DataAnimals(8, "Dolphin", "/Resources/Animal/Dolphin.jpg", "/Resources/TranslateAnimal/Dolphin.mp3"));
            animals.Add(new DataAnimals(9, "Eagle", "/Resources/Animal/Eagle.jpg", "/Resources/TranslateAnimal/Eagle.mp3"));
            animals.Add(new DataAnimals(10, "Elephant", "/Resources/Animal/Elephant.jpg", "/Resources/TranslateAnimal/Elephant.mp3"));
        }

        public void GetDataSchoolSupplie()
        {
            schoolSupplies.Add(new SchoolSupplie(1, "Bag", "/Resources/SchoolSupplies/Bag.jpg", "/Resources/TranslateSchoolSupplies/Bag.mp3"));
            schoolSupplies.Add(new SchoolSupplie(2, "BallPointPen", "/Resources/SchoolSupplies/BallPointPen.jpg", "/Resources/TranslateSchoolSupplies/BallPointPen.mp3"));
            schoolSupplies.Add(new SchoolSupplie(3, "Book", "/Resources/SchoolSupplies/Book.jpg", "/Resources/TranslateSchoolSupplies/Book.mp3"));
            schoolSupplies.Add(new SchoolSupplie(4, "Calculator", "/Resources/SchoolSupplies/Calculator.jpg", "/Resources/TranslateSchoolSupplies/Calculator.mp3"));
            schoolSupplies.Add(new SchoolSupplie(5, "Chalk", "/Resources/SchoolSupplies/Chalk.jpg", "/Resources/TranslateSchoolSupplies/Chalk.mp3"));
            schoolSupplies.Add(new SchoolSupplie(6, "Clip", "/Resources/SchoolSupplies/Clip.jpg", "/Resources/TranslateSchoolSupplies/Clip.mp3"));
            schoolSupplies.Add(new SchoolSupplie(7, "Compa", "/Resources/SchoolSupplies/Compa.jpg", "/Resources/TranslateSchoolSupplies/Compa.mp3"));
            schoolSupplies.Add(new SchoolSupplie(8, "Eraser1", "/Resources/SchoolSupplies/Eraser1.jpg", "/Resources/TranslateSchoolSupplies/Eraser1.mp3"));
            schoolSupplies.Add(new SchoolSupplie(9, "NoteBook", "/Resources/SchoolSupplies/NoteBook.jpg", "/Resources/TranslateSchoolSupplies/NoteBook.mp3"));
            schoolSupplies.Add(new SchoolSupplie(10, "Crayon", "/Resources/SchoolSupplies/Crayon.jpg", "/Resources/TranslateSchoolSupplies/Crayon.mp3"));
        }

        private string _name;
        private string _image;
        private string _translate;
        private string _sound;
        private int _id;
        public string checktick = "Collapsed";
        private int index = 0;

        ObservableCollection<DataClothing> clothings = new ObservableCollection<DataClothing>();
        ObservableCollection<DataColor> colors = new ObservableCollection<DataColor>();
        ObservableCollection<DataVegetables> vegetableses = new ObservableCollection<DataVegetables>();
        ObservableCollection<DataFruit> fruits = new ObservableCollection<DataFruit>();
        ObservableCollection<DataAlphabets> alphabetses = new ObservableCollection<DataAlphabets>();
        ObservableCollection<DataNumber> numbers = new ObservableCollection<DataNumber>();
        ObservableCollection<DataAnimals> animals = new ObservableCollection<DataAnimals>();
        ObservableCollection<SchoolSupplie> schoolSupplies = new ObservableCollection<SchoolSupplie>();

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            _id = Convert.ToInt32(NavigationContext.QueryString["id"]);
            switch (_id)
            {
                case 1:
                    GetDataColor();
                    DataColor dataColor = colors[index];
                    _name = dataColor.Name;
                    _image = dataColor.Image;
                    _translate = dataColor.Translate;
                    imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    break;
                case 2:
                    GetDataClothing();
                    DataClothing dataClothing = clothings[index];
                    _name = dataClothing.Name;
                    _image = dataClothing.Image;
                    _translate = dataClothing.Translate;
                    imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    break;
                case 3:
                    GetDataVegetables();
                    DataVegetables dataVegetables = vegetableses[index];
                    _name = dataVegetables.Name;
                    _image = dataVegetables.Image;
                    _translate = dataVegetables.Translate;
                    imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    break;
                case 4:
                    GetDataFruit();
                    DataFruit dataFruit = fruits[index];
                    _name = dataFruit.Name;
                    _image = dataFruit.Image;
                    _translate = dataFruit.Translate;
                    imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    break;
                case 5:
                    GetDataAlphabets();
                    DataAlphabets dataAlphabets = alphabetses[index];
                    _name = dataAlphabets.Name;
                    _image = dataAlphabets.Image;
                    _translate = dataAlphabets.Translate;
                    imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    break;
                case 6:
                    GetDataNumber();
                    DataNumber dataNumber = numbers[index];
                    _name = dataNumber.Name;
                    _image = dataNumber.Image;
                    _translate = dataNumber.Translate;
                    imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    break;
                case 7:
                    GetDataAnimal();
                    DataAnimals dataAnimals = animals[index];
                    _name = dataAnimals.Name;
                    _image = dataAnimals.Image;
                    _translate = dataAnimals.Translate;
                    imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    //imageButtonSound.Visibility = Visibility.Visible;
                    //imageButtonSound.Tap += ImageButtonSoundTap;
                    //tblSound.Visibility = Visibility.Visible;
                    //tblSound.Tap += TblSoundTap;
                    break;
                case 8:
                    GetDataSchoolSupplie();
                    SchoolSupplie schoolSupplie = schoolSupplies[index];
                    _name = schoolSupplie.Name;
                    _image = schoolSupplie.Image;
                    _translate = schoolSupplie.Translate;
                    imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    break;
            }
            mediaElement.Source = new Uri(_translate, UriKind.Relative);
            mediaElement.Play();
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

        //private void ImgImageTap(object sender, System.Windows.Input.GestureEventArgs e)
        //{
        //    switch (_id)
        //    {
        //        case 1:
        //            DataColor color = (DataColor)lstDetails.SelectedItem;
        //            _name = color.Name;
        //            _image = color.Image;
        //            _translate = color.Translate;
        //            break;
        //        case 2:
        //            DataClothing clothing = (DataClothing)lstDetails.SelectedItem;
        //            _name = clothing.Name;
        //            _image = clothing.Image;
        //            _translate = clothing.Translate;
        //            break;
        //        case 3:
        //            DataVegetables vegetables = (DataVegetables)lstDetails.SelectedItem;
        //            _name = vegetables.Name;
        //            _image = vegetables.Image;
        //            _translate = vegetables.Translate;
        //            break;
        //        case 4:
        //            DataFruit fruit = (DataFruit)lstDetails.SelectedItem;
        //            _name = fruit.Name;
        //            _image = fruit.Image;
        //            _translate = fruit.Translate;
        //            break;
        //        case 5:
        //            DataAlphabets alphabets = (DataAlphabets)lstDetails.SelectedItem;
        //            _name = alphabets.Name;
        //            _image = alphabets.Image;
        //            _translate = alphabets.Translate;
        //            break;
        //        case 6:
        //            DataNumber number = (DataNumber)lstDetails.SelectedItem;
        //            _name = number.Name;
        //            _image = number.Image;
        //            _translate = number.Translate;
        //            break;
        //        case 7:
        //            DataAnimals animals = (DataAnimals)lstDetails.SelectedItem;
        //            _name = animals.Name;
        //            _image = animals.Image;
        //            _sound = animals.Sound;
        //            _translate = animals.Translate;
        //            imageButtonSound.Visibility = Visibility.Visible;
        //            tblSound.Visibility = Visibility.Visible;
        //            imageButtonSound.Tap += ImageButtonSoundTap;
        //            tblSound.Tap += TblSoundTap;
        //            break;
        //        case 8:
        //            SchoolSupplie schoolSupplie = (SchoolSupplie)lstDetails.SelectedItem;
        //            _name = schoolSupplie.Name;
        //            _image = schoolSupplie.Image;
        //            _translate = schoolSupplie.Translate;
        //            break;
        //    }

        //    imageButtonTranslate.Visibility = Visibility.Visible;
        //    tblSpeak.Visibility = Visibility.Visible;
        //    imageButtonTranslate.Tap += ImageButtonTranslateTap;
        //    tblSpeak.Tap += TblSpeakTap;
        //    imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
        //    imageBackground.Tap += ImageBackgroundTap;
        //}

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

        private void nextButton_Click_1(object sender, RoutedEventArgs e)
        {
            tblName.Text = "";
            imtick.Visibility = Visibility.Collapsed;
            nextButton.Visibility = Visibility.Collapsed;

            switch (_id)
            {
                case 1:
                    if (colors.Count >= (index + 2))
                    {
                        index++;
                        DataColor dataColor = colors[index];
                        _name = dataColor.Name;
                        _image = dataColor.Image;
                        _translate = dataColor.Translate;
                        imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    }
                    break;
                case 2:
                    if (clothings.Count >= (index + 2))
                    {
                        index++;
                        DataClothing dataClothing = clothings[index];
                        _name = dataClothing.Name;
                        _image = dataClothing.Image;
                        _translate = dataClothing.Translate;
                        imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    }
                    break;
                case 3:
                    if (vegetableses.Count >= (index + 2))
                    {
                        index++;
                        DataVegetables dataVegetables = vegetableses[index];
                        _name = dataVegetables.Name;
                        _image = dataVegetables.Image;
                        _translate = dataVegetables.Translate;
                        imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    }
                    break;
                case 4:
                    if (fruits.Count >= (index + 2))
                    {
                        index++;
                        DataFruit dataFruit = fruits[index];
                        _name = dataFruit.Name;
                        _image = dataFruit.Image;
                        _translate = dataFruit.Translate;
                        imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    }
                    break;
                case 5:
                    if (alphabetses.Count >= (index + 2))
                    {
                        index++;
                        DataAlphabets dataAlphabets = alphabetses[index];
                        _name = dataAlphabets.Name;
                        _image = dataAlphabets.Image;
                        _translate = dataAlphabets.Translate;
                        imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    }
                    break;
                case 6:
                    if (numbers.Count >= (index + 2))
                    {
                        index++;
                        DataNumber dataNumber = numbers[index];
                        _name = dataNumber.Name;
                        _image = dataNumber.Image;
                        _translate = dataNumber.Translate;
                        imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    }
                    break;
                case 7:
                    if (animals.Count >= (index + 2))
                    {
                        index++;
                        DataAnimals dataAnimals = animals[index];
                        _name = dataAnimals.Name;
                        _image = dataAnimals.Image;
                        _translate = dataAnimals.Translate;
                        imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    }
                    //imageButtonSound.Visibility = Visibility.Visible;
                    //imageButtonSound.Tap += ImageButtonSoundTap;
                    //tblSound.Visibility = Visibility.Visible;
                    //tblSound.Tap += TblSoundTap;
                    break;
                case 8:
                    if (schoolSupplies.Count >= (index + 2))
                    {
                        index++;
                        SchoolSupplie schoolSupplie = schoolSupplies[index];
                        _name = schoolSupplie.Name;
                        _image = schoolSupplie.Image;
                        _translate = schoolSupplie.Translate;
                        imageBackground.Source = new BitmapImage(new Uri(_image, UriKind.Relative));
                    }
                    break;

               
            }
            mediaElement.Source = new Uri(_translate, UriKind.Relative);
            mediaElement.Play();
        }

        private async void imtick_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            if (tblName.Text.ToUpper().Equals(_name.ToUpper()))
            {
                nextButton.Visibility = Visibility.Visible;
                GridTrue.Visibility = Visibility.Visible;
                Uri urimedia = new Uri("/Resources/All/Exactly.mp3", UriKind.RelativeOrAbsolute);
                MediaStudy1.Source = urimedia;
                await Task.Delay(1000);
                GridTrue.Visibility = Visibility.Collapsed;
            }
            else
            {
                nextButton.Visibility = Visibility.Collapsed;
            }
        }

        private void image_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            mediaElement.Play();
        }
    }
}