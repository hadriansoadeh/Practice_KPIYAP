using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using zad1.Interfaces;
using zad1.Models;

namespace zad1.Share
{
    public class XmlDocumentWorker : IXmlWorker
    {
        private readonly XmlDocument _document;
        private readonly ILogger _logger;
        private string _xmlFilePath;

        public XmlDocumentWorker(ILogger logger)
        {
            _logger = logger;
            _document = new XmlDocument();
        }
        public void Add(Flight flight)
        {
            var xRoot = _document.DocumentElement;

            XmlElement flightElem = _document.CreateElement("flight");

            XmlAttribute destinationNameAttribute = _document.CreateAttribute("destinationname");
            XmlText destinationNameText = _document.CreateTextNode(flight.DestinationName);
            destinationNameAttribute.AppendChild(destinationNameText);

            XmlElement flightNumberElem = _document.CreateElement("flightNumber");
            XmlText flightNumberInnerText = _document.CreateTextNode(flight.FlightNumber.ToString());
            flightNumberElem.AppendChild(flightNumberInnerText);

            flightElem.AppendChild(flightNumberElem);

            XmlElement departureTimeElem = _document.CreateElement("departureTime");
            XmlText departureTimeInnerText = _document.CreateTextNode(flight.DepartureTime.ToString()); 
            departureTimeElem.AppendChild(departureTimeInnerText);

            flightElem.AppendChild(departureTimeElem);

            xRoot.AppendChild(flightElem);
            _document.Save(_xmlFilePath);

        }

        public void Delete(string destinationName)
        {
            var xRoot = _document.DocumentElement;
            foreach (XmlNode xNode in xRoot)
            {
                if (xNode.Attributes.Count > 0)
                {
                    var attributeName = xNode.Attributes.GetNamedItem(destinationName);
                    try 
                    {
                        var attributeNameText = attributeName?.InnerText;
                        if (attributeNameText.Equals(destinationName))
                        {
                            xRoot.RemoveChild(xNode);
                        }
                    }
                    catch (Exception ex) when (ex is XmlException || ex is NullReferenceException)
                    {
                        _logger.LogWarning(ex.Message, nameof(attributeName));
                    }
                }
            }
        }

        public Flight FindBy(string destinationName)
        {
            Flight flight = null;
            var xRoot = _document.DocumentElement;
            foreach(XmlNode xmlNode in xRoot)
            {
                flight = GetFlight(xmlNode);
                if (flight.DestinationName.Equals(destinationName))
                {
                    return flight;
                }
            }

            return flight;
        }

        private Flight GetFlight(XmlNode node)
        {
            var flight = new Flight();
            if (node.Attributes.Count > 0)
            {
                var attributeName = node.Attributes.GetNamedItem("destinationName");
                flight.DestinationName = attributeName?.Value;
            }

            foreach (XmlNode childNode in node.ChildNodes)
            {
                try
                {
                    if (childNode.Name.Equals("destinationName"))
                    {
                        flight.DestinationName = (childNode.InnerText).ToString();
                    }
                    if(childNode.Name.Equals("flightNumber"))
                    {
                        flight.FlightNumber = Int32.Parse(childNode.InnerText);
                    }
                    if(childNode.Name.Equals("departureTime"))
                    {
                        flight.DepartureTime = (childNode.InnerText).ToString();
                    }

                }
                catch (Exception ex) when (ex is FormatException
                    || ex is NullReferenceException)
                {
                    _logger.LogError(ex.Message, ex.StackTrace, nameof(childNode.InnerText));   
                }
            }
            return flight;
        }

        public List<Flight> GetAll()
        {
            List<Flight> flights = new List<Flight>();
            var xRoot = _document.DocumentElement;
            foreach(XmlNode node in xRoot)
            {
                var flight = GetFlight(node);
                flights.Add(flight);      
            }
            return flights;
        }

        public void Load(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            _document.Load(xmlFilePath);
        }
    }
}
