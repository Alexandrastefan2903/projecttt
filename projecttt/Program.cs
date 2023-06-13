using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace projecttt
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            // Creare document XML
            XmlDocument xmlDoc = new XmlDocument();

            // Creare element radacina
            XmlElement rootElement = xmlDoc.CreateElement("Hotel");
            xmlDoc.AppendChild(rootElement);

            // Adăugare rezervări
            XmlElement rezervariElement = xmlDoc.CreateElement("Rezervari");
            rootElement.AppendChild(rezervariElement);

            // Adăugare rezervare 1
            XmlElement rezervareElement1 = xmlDoc.CreateElement("Rezervare");
            rezervariElement.AppendChild(rezervareElement1);

            XmlElement numeElement1 = xmlDoc.CreateElement("Nume");
            numeElement1.InnerText = "John Doe";
            rezervareElement1.AppendChild(numeElement1);

            XmlElement cameraElement1 = xmlDoc.CreateElement("Camera");
            cameraElement1.InnerText = "101";
            rezervareElement1.AppendChild(cameraElement1);

            // Adăugare rezervare 2
            XmlElement rezervareElement2 = xmlDoc.CreateElement("Rezervare");
            rezervariElement.AppendChild(rezervareElement2);

            XmlElement numeElement2 = xmlDoc.CreateElement("Nume");
            numeElement2.InnerText = "Jane Smith";
            rezervareElement2.AppendChild(numeElement2);

            XmlElement cameraElement2 = xmlDoc.CreateElement("Camera");
            cameraElement2.InnerText = "202";
            rezervareElement2.AppendChild(cameraElement2);

            // Salvare document XML în fișier
            xmlDoc.Save("rezervari.xml");

            Console.WriteLine("Fișierul XML a fost creat cu succes.");
        }
    }
}
