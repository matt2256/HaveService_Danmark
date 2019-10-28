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
    /// Interaction logic for Renovation.xaml
    /// </summary>
    public partial class Renovation : Window
    {
        //Laver et object af HaveServiceDanmark og kalder det db
        Entities db = new Entities();

        //Laver et object at Renovation og kalder det renovation
        Renovation renovation = new Renovation();
        public Renovation()
        {
            InitializeComponent();
        }

        //Knap for at komme videre til vinduet for at ændre kundeinformation
        private void BtnCustumer_Click(object sender, RoutedEventArgs e)
        {
            //Laver et objekt af Custumer (custumer er et xaml windue)
            Custumer custumer = new Custumer();

            //Bruger custumer til at vise vinduet, når der bliver klikket på knappen
            custumer.Show();

            //Lukker det "gamle" vindue, efter man har trykket på knappen
            this.Close();
        }
        
        //Knap for at komme videre til vinduet for at kunne leje firma udstyr 
        private void BtnRent_Click(object sender, RoutedEventArgs e)
        {
            //Laver et objekt af Rent (custumer er et xaml windue)
            Rent rent = new Rent();

            //Bruger rent til at vise vinduet, når der bliver klikket på knappen
            rent.Show();

            //Lukker det "gamle" vindue, efter man har trykket på knappen
            this.Close();
        }

        //Knap for at kunne tilføje informtioner om en instandsættelse af en have
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            //Bruger enstandsen af renovation til at kunne ligge inputtet af textboxen over i databasen
            renovation.ClientAddress = tbClientAddress.Text;
            
            //Bruger enstandsen af renovation til at kunne ligge inputtet af textboxen over i databasen. Først skal inputtet parse datetime til string
            renovation.Startdate = DateTime.Parse(tbStartDate.Text);

            //Bruger enstandsen af renovation til at kunne ligge inputtet af textboxen over i databasen. Først skal inputtet parse datetime til string
            renovation.EndDate = DateTime.Parse(tbEndDate.Text);

            //Bruger endstadsen af renovation til at kunne ligge inputtet af textboxen over i databasen. Først skal inputtet parses fra int til string
            renovation.Price = Int16.Parse(tbPrice.Text);

            //Bruger enstanden af renovation til at kunne ligge inputtet af textboxen over i databasen. Først skal inputtet parses fra int til string
            renovation.Area = Int16.Parse(tbArea.Text);

            //Bruger enstandsen af renovation til at kunne ligge inputtet af textboxen over i databasen
            renovation.Decription = tbDecription.Text;


            //Gemmer de ændringer der er kommet i databasen
            db.SaveChanges();


        }

        //Knap for at kunne vise indholdet af det table, der indeholder information omkring instandsættelser af haver
        private void BtnShowDB_Click(object sender, RoutedEventArgs e)
        {
            dtgClientInfoShow.ItemsSource = db.Renovation.ToList();
        }

        
    }
}
