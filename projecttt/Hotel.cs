using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace projecttt
{
    [Serializable]
    class Hotel
    {
        private List<Client> listaClienti = new List<Client>();
        private List<Camera> listaCamere = new List<Camera>();
        private List<Rezervare> listaRezervari = new List<Rezervare>();

        public Hotel()
        {
            listaClienti = new List<Client>();
            listaRezervari = new List<Rezervare>();
            listaCamere = new List<Camera>();

        }



        public List<Client> ListaClienti
        {
            get { return listaClienti; }
            set { listaClienti = value; }
        }

        public List<Camera> ListaCamere
        {
            get { return listaCamere; }
            set { listaCamere = value; }
        }

        public Client CautaClient(string nume, string prenume)
        {
            foreach (Client client in listaClienti)
            {
                if (client.Nume == nume && client.Prenume == prenume)
                {
                    return client;
                }
            }

            return null;
        }

        public void AdaugaClient(Client client)
        {
            listaClienti.Add(client);

        }


        public void AdaugaCamera(Camera camera)
        {
            listaCamere.Add(camera);  
        }

        public void AdaugaRezervare(string nume, string camera)
        {
            // Creare obiect Rezervare
            Rezervare rezervare = new Rezervare(nume, camera);

            // Adăugare rezervare în lista de rezervări
            listaRezervari.Add(rezervare);
        }

        public void SalveazaRezervari(string numeFisier)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();

                XmlElement rootElement = xmlDoc.CreateElement("Hotel");
                xmlDoc.AppendChild(rootElement);

                XmlElement rezervariElement = xmlDoc.CreateElement("Rezervari");
                rootElement.AppendChild(rezervariElement);

                foreach (Rezervare rezervare in listaRezervari)
                {
                    XmlElement rezervareElement = xmlDoc.CreateElement("Rezervare");
                    rezervariElement.AppendChild(rezervareElement);

                    XmlElement numeElement = xmlDoc.CreateElement("Nume");
                    numeElement.InnerText = rezervare.Nume;
                    rezervareElement.AppendChild(numeElement);

                    XmlElement cameraElement = xmlDoc.CreateElement("Camera");
                    cameraElement.InnerText = rezervare.Camera;
                    rezervareElement.AppendChild(cameraElement);
                }

                xmlDoc.Save(numeFisier);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la salvarea datelor în fișierul {0}: {1}", numeFisier, ex.Message);
            }
        }

        public class Rezervare
        {
            public string Nume { get; set; }
            public string Camera { get; set; }
            public DateTime DataCheckIn { get; set; }
            public DateTime DataCheckOut { get; set; }

            public Rezervare() { }

            public Rezervare(string nume, string camera)
            {
                Nume = nume;
                Camera = camera;
            }

            public Rezervare(string nume, string camera, DateTime dataCheckIn, DateTime dataCheckOut)
            {
                Nume = nume;
                Camera = camera;
                DataCheckIn = dataCheckIn;
                DataCheckOut = dataCheckOut;
            }
        }


        public static Hotel IncarcaDate(string numeFisier)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Hotel));
                using (TextReader reader = new StreamReader(numeFisier))
                {
                    Hotel hotel = (Hotel)serializer.Deserialize(reader);
                    return hotel;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la incarcarea datelor din fisierul {0}: {1}", numeFisier, ex.Message);
                return null;
            }
        }

        public override string ToString()
        {
            string output = "Clienti:\n";
            foreach (Client client in listaClienti)
            {
                output += client.ToString() + "\n";
            }
            output += "\nCamere:\n";
            foreach (Camera camera in listaCamere)
            {
                output += camera.ToString() + "\n";
            }
            return output;
        }
       

    }
}
