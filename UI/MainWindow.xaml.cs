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
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class   MainWindow : Window
    {
        //creating a object of entity (need it to use entity framework)
        Entities db = new Entities();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void BtnCustumer_Click(object sender, RoutedEventArgs e)
        {
            //Laver et objekt af Custumer (custumer er et xaml windue)
            Custumer custumer = new Custumer();

            //Bruger custumer til at vise vinduet, når der bliver klikket på knappen
            custumer.Show();

            //Lukker det "gamle" vindue, efter man har trykket på knappen
            this.Close(); 

            
        }

        private void BtnRent_Click(object sender, RoutedEventArgs e)
        {
            //Laver et objekt af Rent (custumer er et xaml windue)
            Rent rent = new Rent();

            //Bruger rent til at vise vinduet, når der bliver klikket på knappen
            rent.Show();

            //Lukker det "gamle" vindue, efter man har trykket på knappen
            this.Close();
        }

        private void BtnRenovation_Click(object sender, RoutedEventArgs e)
        {
            //Laver et objekt af Renovation (custumer er et xaml windue)
            Renovation renovation = new Renovation();

            //Bruger renovation til at vise vinduet, når der bliver klikket på knappen
            renovation.Show();

            //Lukker det "gamle" vindue, efter man har trykket på knappen
            this.Close();
        }

        //Knap for at vise indholdet af Customer table
        private void BtnCustumerDB_Click(object sender, RoutedEventArgs e)
        {
            //Tager al indholdet fra Customer tablet i databasen og ligger det i en liste. Derefter bruger datagridet listen til at vise indholdet
            dtgClientInfo.ItemsSource = db.Customer.ToList<Customer>();
        }

        //Knap for at vise indholdet af EquipmentRent table
        private void BtnRentDB_Click(object sender, RoutedEventArgs e)
        {
            //Tager al indholdet fra EquipmentRent tabel i databasen og ligger det i en liste. Derefter bruger datagridet listen til at vise indholdet
            dtgClientInfo.ItemsSource = db.EquipmentRent.ToList<EquipmentRent>();
        }

        //Knap for at vise indholdet af Renovation table
        private void BtnRenovationDB_Click(object sender, RoutedEventArgs e)
        {
            //Tager al indholdet fra Renovation table i databasen og ligger det i en liste. Derefter bruger datagridet listen ti vise indholdet
            dtgClientInfo.ItemsSource = db.Renovation.ToList<Renovation>();
        }
    }
}
