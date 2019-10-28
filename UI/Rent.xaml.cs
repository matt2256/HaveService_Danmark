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

namespace UI
{
    /// <summary>
    /// Interaction logic for Rent.xaml
    /// </summary>
    public partial class Rent : Window
    {
        //Laver et obejct af HaveServiceDanmark og kalder det db
        Entities db = new Entities();

        //Laver et object af EquipmentRent og kalder det rent
        EquipmentRent rent = new EquipmentRent();

        
        public Rent()
        {
            InitializeComponent();
        }

        //knap for at komme videre til vinduet for at ændre kunde information
        private void BtnCustumer_Click(object sender, RoutedEventArgs e)
        {
            //Laver et objekt af Custumer (custumer er et xaml windue)
            Custumer custumer = new Custumer();

            //Bruger custumer til at vise vinduet, når der bliver klikket på knappen
            custumer.Show();

            //Lukker det "gamle" vindue, efter man har trykket på knappen
            this.Close();
        }

        //Knap for at komme videre til vinduet for at kunne vælge instandsættelse af have
        private void BtnRenovation_Click(object sender, RoutedEventArgs e)
        {
            //Laver et objekt af Renovation (custumer er et xaml windue)
            Renovation renovation = new Renovation();

            //Bruger renovation til at vise vinduet, når der bliver klikket på knappen
            renovation.Show();

            //Lukker det "gamle" vindue, efter man har trykket på knappen
            this.Close();
        }

        //Knap for at oprette et firma i databasen
        private void BtnComp_Click(object sender, RoutedEventArgs e)
        {
            //bruger enstandsen af rent til at kunne ligge inputet af textboxen over i databasen
            rent.Company_Name = tbCompName.Text;

            //bruger enstandsen af rent til at kunne ligge inputet af textboxen over i databasen
            rent.Company_Address = tbCompAddress.Text;

            //bruger enstandsen af rent til at kunne ligge inputet af textboxen over i databasen, men først bliver det paraset da inputtet er en int og skal derfor parases til at være en string
            rent.Company_Phone_Number = Int32.Parse(tbCompPhoneNumber.Text);

            //bruger enstandsen af rent til at kunne ligge inputet af textboxen over i databasen
            rent.Others = tbCompOthers.Text;

            //Adder rent navnet til EquipmentRent tablet i databasen
            db.EquipmentRent.Add(rent);

            //Gemmer de ændringer der er kommet i databasen
            db.SaveChanges();

        }


        //Knap for at vise hvad der er indhold i databasen 
        private void BtnShowDB_Click(object sender, RoutedEventArgs e)
        {
            dtgClientInfoShow.ItemsSource = db.EquipmentRent.ToList<EquipmentRent>();
        }

        
    }
}
