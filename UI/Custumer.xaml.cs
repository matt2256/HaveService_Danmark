using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.Entity.Validation;


namespace UI
{
    /// <summary>
    /// Interaction logic for Custumer.xaml
    /// </summary>
    public partial class Custumer : Window
    {
        //Laver et object af HaveServiceDanmark, der kan bruges til at få adgang til databasen der er tilknyttet
        Entities db = new Entities();

        //Laver et object af Customer og kalder det kunder
        Customer Kunder = new Customer();
        public Custumer()
        {
            InitializeComponent();

            
        }

        //Knap for at komme videre til vinduet for at kunne vælge en istandsætelse af have 
        private void BtnRenovation_Click(object sender, RoutedEventArgs e)
        {
            //Laver et objekt af Renovation (custumer er et xaml windue)
            Renovation renovation = new Renovation();

            //Bruger renovation til at vise vinduet, når der bliver klikket på knappen
            renovation.Show();

            //Lukker det "gamle" vindue, efter man har trykket på knappen
            this.Close();
        }

        //knap for at komme videre til vinduet for at kunne vælge at leje maskiner 
        private void BtnRent_Click(object sender, RoutedEventArgs e)
        {
            //Laver et objekt af Rent (custumer er et xaml windue)
            Rent rent = new Rent();

            //Bruger rent til at vise vinduet, når der bliver klikket på knappen
            rent.Show();

            //Lukker det "gamle" vindue, efter man har trykket på knappen
            this.Close();
        }

        //Knap for at tilføje en ny kunde
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Bruger enstandsen af Kunde og ligger inputtet af textboxen over i databasen
            Kunder.Name = tbName.Text;

            //Bruger enstandsen af Kunder og ligger inputett af textboxen over i databasen
            Kunder.Address = tbAddress.Text;

            //Bruger enstandsen af Kunder og ligger inputtet af textboxen over i databasen. Først skal det parses fra int til string
            Kunder.Phone_Number = Int32.Parse(tbPhoneNumber.Text);

            //Bruger enstandsen af Kunder og ligger inputtet af textboxen over i databasen. Først skal det parses fra int til string
            Kunder.Zipcode = Int16.Parse(tbZipcode.Text);

            //Adder Kunde objeket til Customer table i databasen 
            db.Customer.Add(Kunder);

            //Gemmer de ændringer der er lavet i databasen 
            db.SaveChanges();

        }

        //Knap for at vise indholdet af databasen
        private void BtnShowDB_Click(object sender, RoutedEventArgs e)
        {
            
            dtgClientInfoShow.ItemsSource = db.Customer.ToList();
        }

        
    }
}

