﻿using Microsoft.Extensions.Logging;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
using System.Xml;
using zad1.Interfaces;
using zad1.Models;
using zad1.Share;

namespace zad1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly IXmlWorker _worker;
        private readonly ILogger _logger;
        public bool IsFileOpened = false;
        private string _xmlFilePath;

        public MainWindow()
        {

            InitializeComponent();
            _logger = LoggerFactory.Create(builder =>  builder
                                            .SetMinimumLevel(LogLevel.Information))
                                            .CreateLogger<MainWindow>();

            _worker = new XmlDocumentWorker(_logger);
        }

        private void buttonFindDestinationName_Click(object sender, RoutedEventArgs e)
        {
            var flight = _worker.FindBy(textBoxDestinationName.Text);
            PrintFlight(flight);
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            AddFlightForm addFlightForm = new AddFlightForm();
            addFlightForm.ShowDialog();

            PrintFlights(_worker.GetAll());
        }

        private void buttonExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrEmpty(textBoxDeleteDestinationName.Text)
                || !string.IsNullOrWhiteSpace(textBoxDeleteDestinationName.Text))
            {
                _worker.Delete(textBoxDeleteDestinationName.Text);
                PrintFlights(_worker.GetAll());
            }
        }

        private void PrintFlight(Flight flight)
        {
            textBlockXMLFileContent.Text = "=======Flight======="
                + Environment.NewLine;
            textBlockXMLFileContent.Text += flight?.ToString() ?? "flight not found";

        }

        public void PrintFlights(List<Flight> flights)
        {
            textBlockXMLFileContent.Text = "=======Flights======="
                + Environment.NewLine;
            foreach(var flight in flights) 
            {
                textBlockXMLFileContent.Text += flight.ToString();
            }
        }

        private void textBoxDestinationName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxDestinationName.Text))
            {
                PrintFlights(_worker.GetAll());
            }
        }

        private void buttonOpenFile_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();

            dialog.InitialDirectory = Directory.GetParent(AppContext.BaseDirectory)
                .Parent
                .Parent
                .FullName;
            dialog.DefaultExt = ".xml";
            dialog.Filter = "Xml documents (.xml)|*.xml";
            var result = dialog.ShowDialog();
            if(result.HasValue && result.Value) 
            {
                _xmlFilePath = dialog.FileName;
                textBlockXMLPathFile.Text = _xmlFilePath;
                _worker.Load(_xmlFilePath);
                PrintFlights(_worker.GetAll());
            }
        }
    }
}
