using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsCars2
{
    public partial class Form1 : Form
    {

        List<Car> Cars;
        public Form1()
        {
            InitializeComponent();

            Cars = new List<Car>();

            //All available cars
            Cars.Add(new Car() { Id = 1, Make = "Volvo", Model = "V70", Color = "White", Km = 1292, Price = 3465, Year = 1998 });
            Cars.Add(new Car() { Id = 31, Make = "Skoda", Model = "Fabia", Color = "Red", Km = 1292, Price = 76556, Year = 2001 });
            Cars.Add(new Car() { Id = 14, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 432, Price = 32001, Year = 2003 });
            Cars.Add(new Car() { Id = 4, Make = "Volvo", Model = "V70", Color = "Red", Km = 1223492, Price = 24512, Year = 1998 });
            Cars.Add(new Car() { Id = 23, Make = "BMW", Model = "735", Color = "Black", Km = 435, Price = 234512, Year = 1999 });
            Cars.Add(new Car() { Id = 234, Make = "Audi", Model = "Q3", Color = "Blue", Km = 345, Price = 334552, Year = 2010 });
            Cars.Add(new Car() { Id = 451, Make = "Volvo", Model = "V40", Color = "Grey", Km = 235235, Price = 535512, Year = 2008 });
            Cars.Add(new Car() { Id = 651, Make = "Volvo", Model = "XC90", Color = "White", Km = 345345, Price = 34510, Year = 2011 });
            Cars.Add(new Car() { Id = 91, Make = "Volvo", Model = "V70", Color = "Red", Km = 345, Price = 4512, Year = 1997 });
            Cars.Add(new Car() { Id = 8001, Make = "Audi", Model = "A3", Color = "White", Km = 123492, Price = 87500, Year = 2001 });
            Cars.Add(new Car() { Id = 631, Make = "Audi", Model = "A8", Color = "Blue", Km = 55342, Price = 55400, Year = 2010 });
            Cars.Add(new Car() { Id = 51, Make = "Volvo", Model = "V40", Color = "Red", Km = 1692, Price = 3465, Year = 1999 });
            Cars.Add(new Car() { Id = 781, Make = "Skoda", Model = "Fabia", Color = "Blue", Km = 1792, Price = 56556, Year = 2000 });
            Cars.Add(new Car() { Id = 144, Make = "Volvo", Model = "XC90", Color = "Blue", Km = 4382, Price = 25001, Year = 2004 });
            Cars.Add(new Car() { Id = 48, Make = "Volvo", Model = "V70", Color = "Red", Km = 12292, Price = 26512, Year = 1997 });
            Cars.Add(new Car() { Id = 912, Make = "BMW", Model = "735", Color = "Black", Km = 4395, Price = 134512, Year = 1960 });
            Cars.Add(new Car() { Id = 2344, Make = "Audi", Model = "Q3", Color = "Grey", Km = 3425, Price = 434552, Year = 2011 });
            Cars.Add(new Car() { Id = 4501, Make = "Volvo", Model = "V40", Color = "Grey", Km = 215235, Price = 435512, Year = 2007 });
            Cars.Add(new Car() { Id = 6051, Make = "Volvo", Model = "XC90", Color = "White", Km = 47345, Price = 134510, Year = 2012 });
            Cars.Add(new Car() { Id = 991, Make = "Volvo", Model = "V70", Color = "Red", Km = 3475, Price = 14512, Year = 1998 });
            Cars.Add(new Car() { Id = 801, Make = "Audi", Model = "A7", Color = "White", Km = 492, Price = 187500, Year = 2002 });
            Cars.Add(new Car() { Id = 6031, Make = "Audi", Model = "A6", Color = "Blue", Km = 553, Price = 55400, Year = 2011 });

            //Sorts all available cars and shows them in alphabetical order.
            foreach (Car item in Cars.OrderBy(x => x.Make))
            {
                allcars.Items.Add(item);
            }

            //Goes through all seperate colors that the cars have and puts them in a list in the ComboBox.
            foreach (var SeperateColor in Cars.Select(x => x.Color).Distinct())
            {
                menu.Items.Add(SeperateColor);
            }

        }

        //When user clicks on a car all attributes are shown in the box to the right of the original list.
        private void allcars_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ListofCars = sender as ListBox;
            Car SelectedCar = ListofCars.SelectedItem as Car;

            //Clears the ListBox from the previous attributes.
            carattributes.Items.Clear();

            //Puts in all of the attributes of SelectedCar.
            carattributes.Items.Add("####################################");
            carattributes.Items.Add($"Id: {SelectedCar.Id}");
            carattributes.Items.Add($"Manufacturer: {SelectedCar.Make}");
            carattributes.Items.Add($"Model: {SelectedCar.Model}");
            carattributes.Items.Add($"Color: {SelectedCar.Color}");
            carattributes.Items.Add($"Km: {SelectedCar.Km}");
            carattributes.Items.Add($"Price: {SelectedCar.Price}");
            carattributes.Items.Add($"Year: {SelectedCar.Year}");
            carattributes.Items.Add("####################################");
        }

        //When user clicks on color in ComboBox menu the cars of chosen color pops up in ListBox below.
        private void menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Clears the ListBox so it isn't continously stacked with more and more cars of every color.
            CarsOfColor.Items.Clear();

            //Goes through all the Cars and finds all the ones for the chosen color, f.e "Red".
            var ListOfColors = Cars.FindAll(x => x.Color == (sender as ComboBox).SelectedItem as String);

            //Prints out all cars of chosen color in ListBox.
            foreach (Car item in ListOfColors)
            {
                CarsOfColor.Items.Add(item);
            }
         
        }

        //When user clicks on car the attributes come up in the middle box.
        private void CarsOfColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox ListofCars = sender as ListBox;
            Car SelectedCar = ListofCars.SelectedItem as Car;

            //Clears the ListBox from the previous attributes.
            carattributes.Items.Clear();

            //Puts in all of the attributes of SelectedCar.
            carattributes.Items.Add("####################################");
            carattributes.Items.Add($"Id: {SelectedCar.Id}");
            carattributes.Items.Add($"Manufacturer: {SelectedCar.Make}");
            carattributes.Items.Add($"Model: {SelectedCar.Model}");
            carattributes.Items.Add($"Color: {SelectedCar.Color}");
            carattributes.Items.Add($"Km: {SelectedCar.Km}");
            carattributes.Items.Add($"Price: {SelectedCar.Price}");
            carattributes.Items.Add($"Year: {SelectedCar.Year}");
            carattributes.Items.Add("####################################");
        }
    }

    //Public class for all of the cars attributes. Also a string override for ListBox.
    public class Car
    {
        //Types of attributes of the cars and are sourced from the list in beggining of code.
        public int Id { get; set; }
        public int Km { get; set; }
        public int Price { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        //Overrides the ListBox and prints out the attributes of the car.
        public override string ToString()
        {
            return $"{Make} {Model}";
        }

    }
}
