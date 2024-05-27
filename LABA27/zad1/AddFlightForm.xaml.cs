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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;
using System.Xml.Linq;
using zad1.Interfaces;
using zad1.Models;

namespace zad1
{
    /// <summary>
    /// Логика взаимодействия для AddFlightForm.xaml
    /// </summary>
    public partial class AddFlightForm : Window
    {
        private readonly IXmlWorker _worker;
        public AddFlightForm()
        {
            InitializeComponent();
        }

        private void buttonAddNewFlight_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();

            Flight newFlight = new Flight
            {
                DestinationName = textBoxDestinationName.Text,
                FlightNumber = int.Parse(textBoxFlightNumber.Text),
                DepartureTime = textBoxDepartureTime.Text
            };

            // Загружаем XML файл
            XDocument doc = XDocument.Load("D:\\Practic_KPIAP\\Dylyk_26\\zad1\\Files/Flights.xml");

            // Создаем новый элемент <flight>
            XElement flightElem = new XElement("flight",
                new XElement("destinationName", newFlight.DestinationName),
                new XElement("flightNumber", newFlight.FlightNumber),
                new XElement("departureTime", newFlight.DepartureTime)
            );

            // Добавляем элемент в корневой элемент
            doc.Root.Add(flightElem);

            // Сохраняем изменения
            doc.Save("D:\\Practic_KPIAP\\Dylyk_26\\zad1\\Files/Flights.xml");
            //main.PrintFlights(_worker.GetAll());

            this.Close();
        }
    }
}
