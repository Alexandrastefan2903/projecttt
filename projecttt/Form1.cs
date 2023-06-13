using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Globalization;

using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Printing;
using static projecttt.Hotel;

namespace projecttt
{
    public partial class Form1 : Form
    {
        private Hotel hotel;
        private List<Camera> listaCamere;
        private List<Rezervare> listaRezervari;


        public Form1()
        {
            InitializeComponent();
            hotel = new Hotel();
            this.cbCamere.SelectedIndexChanged += new System.EventHandler(this.cbCamere_SelectedIndexChanged);

            listaCamere = new List<Camera>(); // Inițializarea listei de camere

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.rezervari_date_clientiTableAdapter.Fill(this.bazadedateDataSet._Rezervari_date_clienti);
            listaCamere.Add(new Camera(1));
            listaCamere.Add(new Camera(2));
            listaCamere.Add(new Camera(3));
            listaCamere.Add(new Camera(4));
            listaCamere.Add(new Camera(5));
            listaCamere.Add(new Camera(6));
            listaCamere.Add(new Camera(7));
            listaCamere.Add(new Camera(8));
            listaCamere.Add(new Camera(9));
            listaCamere.Add(new Camera(10));

            foreach (Camera camera in listaCamere)
            {
                cbCamere.Items.Add(camera.NumarCamera.ToString());
            }

            listaRezervari = new List<Rezervare>();

            stergeRezervareToolStripMenuItem.Click += StergeRezervareToolStripMenuItem_Click;
            listViewCamere.View = View.Details;
            listViewCamere.Columns.Add("Nume");
            listViewCamere.Columns.Add("Prenume");
            listViewCamere.Columns.Add("Numar Camera");
            listViewCamere.Columns.Add("Check-in");
            listViewCamere.Columns.Add("Check-out");

            listViewCamere.SelectedIndexChanged += listViewCamere_SelectedIndexChanged;


            foreach (Rezervare rezervare in listaRezervari)
            {
                ListViewItem item = new ListViewItem(rezervare.Client.Nume);
                item.SubItems.Add(rezervare.Client.Prenume);
                item.SubItems.Add(rezervare.Camera.NumarCamera.ToString());
                item.SubItems.Add(rezervare.DataCheckIn.ToShortDateString());
                listViewCamere.Items.Add(item);
            }
            //stergeRezervareToolStripMenuItem.Click += StergeRezervareToolStripMenuItem_Click;
            perioadeOcupateToolStripMenuItem.Click += perioadeOcupateToolStripMenuItem_Click;


        }


        private void cbCamere_SelectedIndexChanged(object sender, EventArgs e)
        {
            Camera cameraSelectata = listaCamere.FirstOrDefault(camera => camera.NumarCamera == cbCamere.SelectedIndex + 1);
            double pretPeNoapte;

            // Setăm prețul pe noapte în funcție de numărul camerei
            if (cameraSelectata != null)
            {
                if (cameraSelectata.NumarCamera <= 5)
                {
                    pretPeNoapte = 100;
                }
                else
                {
                    pretPeNoapte = 150;
                }

                // Afișăm prețul pe noapte în TextBox
                tbPretPeNoapte.Text = pretPeNoapte.ToString() + " RON";
            }
        }

        private void btnRezerva_Click(object sender, EventArgs e)
        {


            Camera cameraSelectata = listaCamere.FirstOrDefault(camera => camera.NumarCamera == cbCamere.SelectedIndex + 1);

            // Verificam daca au fost completate toate campurile necesare
            if (string.IsNullOrEmpty(tbNume.Text) || string.IsNullOrEmpty(tbPrenume.Text) || cbCamere.SelectedIndex < 0 || dtpInceput.Value >= dtpSfarsit.Value)
            {
                MessageBox.Show("Va rugam completati toate informatiile necesare si verificati perioada de sedere.");
                return;
            }

            // Cautam clientul dupa nume si prenume sau cream unul nou
            Client client = hotel.CautaClient(tbNume.Text, tbPrenume.Text);
            if (client == null)
            {
                client = new Client(tbNume.Text, tbPrenume.Text, tbTelefon.Text, tbEmail.Text);
                hotel.AdaugaClient(client);
            }

            // Obținem prețul camerei selectate și îl afișăm în interfață
            double pretPeNoapte = Convert.ToDouble(tbPretPeNoapte.Text.Replace(" RON", ""));
            tbPretPeNoapte.Text = pretPeNoapte.ToString() + " RON";

            // Calculăm numărul de nopți și prețul total
            int numarNopti = (dtpSfarsit.Value - dtpInceput.Value).Days;
            double pretTotal = numarNopti * pretPeNoapte;
            // Crează o nouă rezervare
            Rezervare rezervare = new Rezervare(client, cameraSelectata, dtpInceput.Value, dtpSfarsit.Value);

            // Adaugă rezervarea în lista de rezervări
            listaRezervari.Add(rezervare);

            // Actualizează listViewCamere cu rezervarea adăugată
            ListViewItem item = new ListViewItem(new[] {
    rezervare.Client.Nume,
    rezervare.Client.Prenume,
    rezervare.Camera.NumarCamera.ToString(),
    rezervare.DataCheckIn.ToShortDateString(),
    rezervare.DataCheckOut.ToShortDateString()
}); listViewCamere.Items.Add(item);



            listViewCamere.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listViewCamere.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            // Afișăm prețul total în text box
            tbPretFinal.Text = pretTotal.ToString() + " RON"; MessageBox.Show("Ati rezervat!");
        }



        private void cmsCheckIn_Opening_1(object sender, CancelEventArgs e)
        {
            // Ora specifică pentru check-in
            TimeSpan oraCheckIn = new TimeSpan(13, 0, 0);

            // Creează un obiect DateTime cu data curentă și ora specifică pentru check-in
            DateTime dataSiOraCheckIn = DateTime.Today.Add(oraCheckIn);

            // Creează un element de meniu cu ora check-in-ului
            ToolStripMenuItem itemOra = new ToolStripMenuItem(dataSiOraCheckIn.ToString("HH:mm"));

            // Adaugă elementul de meniu în context menu strip
            cmsCheckIn.Items.Add(itemOra);
        }

        private void cmsCheckOut_Opening(object sender, CancelEventArgs e)
        {
            // Ora specifică pentru check-in
            TimeSpan oraCheckOut = new TimeSpan(11, 0, 0);

            // Creează un obiect DateTime cu data curentă și ora specifică pentru check-in
            DateTime dataSiOraCheckOut = DateTime.Today.Add(oraCheckOut);


            // Creează un element de meniu cu ora check-in-ului
            ToolStripMenuItem itemOra = new ToolStripMenuItem(dataSiOraCheckOut.ToString("HH:mm"));

            // Adaugă elementul de meniu în context menu strip
            cmsCheckOut.Items.Add(itemOra);
        }








        private void listViewCamere_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifică dacă există un element selectat în listă
            if (listViewCamere.SelectedItems.Count > 0)
            {
                // Activează meniul "Stergere rezervare"
                stergeRezervareToolStripMenuItem.Enabled = true;
            }
            else
            {
                // Dezactivează meniul "Stergere rezervare"
                stergeRezervareToolStripMenuItem.Enabled = false;
            }
        }




        private void StergeRezervareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewCamere.SelectedItems.Count == 0)
            {
                MessageBox.Show("Nu ați selectat o rezervare.");
                return;
            }

            ListViewItem selectedItem = listViewCamere.SelectedItems[0];
            string nume = selectedItem.SubItems[0].Text;
            string prenume = selectedItem.SubItems[1].Text;
            string numarCamera = selectedItem.SubItems[2].Text;
            string dataCheckIn = selectedItem.SubItems[3].Text;
            string dataCheckOut = selectedItem.SubItems[4].Text;
            listViewCamere.Items.Remove(selectedItem);


            Rezervare rezervare = listaRezervari.FirstOrDefault(r =>
                r.Client.Nume == nume &&
                r.Client.Prenume == prenume &&
                r.Camera.NumarCamera.ToString() == numarCamera &&
                r.DataCheckIn.ToShortDateString() == dataCheckIn &&
                r.DataCheckOut.ToShortDateString() == dataCheckOut);


            if (rezervare != null)
            {
                listaRezervari.Remove(rezervare);
                listViewCamere.Items.Remove(selectedItem);
                MessageBox.Show("Rezervarea a fost ștearsă.");
            }
            else
            {
                MessageBox.Show("Nu s-a găsit rezervarea selectată.");
            }
        }



        private void perioadeOcupateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Afișează perioadele ocupate într-o fereastră modală sau în alt mod dorit
            // Poți utiliza listaRezervari pentru a accesa perioadele ocupate
            // Exemplu:
            StringBuilder ocupateBuilder = new StringBuilder();
            foreach (Rezervare rezervare in listaRezervari)
            {
                ocupateBuilder.AppendLine($"Camera {rezervare.Camera.NumarCamera}: {rezervare.DataCheckIn.ToShortDateString()} - {rezervare.DataCheckOut.ToShortDateString()}");
            }
            MessageBox.Show(ocupateBuilder.ToString(), "Perioade Ocupate");
        }
        private void FormClosingHandler(object sender, FormClosingEventArgs e)
        {
            // Salvare rezervări înainte de închiderea aplicației
            hotel.SalveazaRezervari("rezervari.xml");
        }


        private void btnCreateDb_Click(object sender, EventArgs e)
        { // Creare document XML
            XmlDocument xmlDoc = new XmlDocument();

            // Creare element radacina
            XmlElement rootElement = xmlDoc.CreateElement("Database");
            xmlDoc.AppendChild(rootElement);

            // Adauga date in baza de date
            XmlElement recordElement1 = xmlDoc.CreateElement("Record");
            rootElement.AppendChild(recordElement1);

            XmlElement fieldElement1 = xmlDoc.CreateElement("Field");
            fieldElement1.InnerText = "Value 1";
            recordElement1.AppendChild(fieldElement1);

            XmlElement recordElement2 = xmlDoc.CreateElement("Record");
            rootElement.AppendChild(recordElement2);

            XmlElement fieldElement2 = xmlDoc.CreateElement("Field");
            fieldElement2.InnerText = "Value 2";
            recordElement2.AppendChild(fieldElement2);

            // Salvare document XML in fisier
            string fileName = "database.xml";
            xmlDoc.Save(fileName);

            MessageBox.Show("Baza de date XML a fost creata cu succes. Fisierul " + fileName + " a fost creat.");


        }



        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Clear chart data
            chart1.Series.Clear();

            // Create a new series
            Series series = new Series("Preț total pe lună", (int)SeriesChartType.Column);

            // Calculate the total price for each month and add the points to the series
            for (int i = 1; i <= 12; i++)
            {
                double totalPrice = 0;

                // Calculate the total price for the reservations that fall within the selected period
                foreach (Rezervare rezervare in listaRezervari)
                {
                    if (rezervare.DataCheckIn.Month <= i && rezervare.DataCheckOut.Month >= i)
                    {
                        // Calculate the number of overlapping days between the reservation and the selected month
                        DateTime startOfMonth = new DateTime(dtpInceput.Value.Year, i, 1);
                        DateTime endOfMonth = new DateTime(dtpInceput.Value.Year, i, DateTime.DaysInMonth(dtpInceput.Value.Year, i));
                        DateTime checkIn = rezervare.DataCheckIn < startOfMonth ? startOfMonth : rezervare.DataCheckIn;
                        DateTime checkOut = rezervare.DataCheckOut > endOfMonth ? endOfMonth : rezervare.DataCheckOut;
                        int numarZileSuprapuse = (checkOut - checkIn).Days + 1;

                        // Add the price for the overlapping days to the total price
                        totalPrice += numarZileSuprapuse * rezervare.Camera.PretPeNoapte;
                    }
                }

                // Add the point to the series
                series.Points.AddXY(CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i), totalPrice);

            }

            // Add the series to the chart
            chart1.Series.Add(series);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Obțineți obiectul Graphics pentru a desena pe pagină
            Graphics g = e.Graphics;

            // Definiți fonturi pentru text
            Font fontTitlu = new Font("Arial", 16, FontStyle.Bold);
            Font fontNormal = new Font("Arial", 12);

            // Desenați un titlu
            string titlu = "Raport rezervări hotel";
            g.DrawString(titlu, fontTitlu, Brushes.Black, new PointF(50, 50));

            int startX = 50;
            int startY = 100;
            int cellPadding = 5;

            g.DrawString("Nume", fontNormal, Brushes.Black, new PointF(startX , startY));
            g.DrawString("Prenume", fontNormal, Brushes.Black, new PointF(startX+100, startY));
            g.DrawString("Telefon", fontNormal, Brushes.Black, new PointF(startX + 200, startY));
            g.DrawString("Email", fontNormal, Brushes.Black, new PointF(startX + 300, startY));

            g.DrawString("Check-in", fontNormal, Brushes.Black, new PointF(startX + 500, startY));
            g.DrawString("Check-out", fontNormal, Brushes.Black, new PointF(startX + 600, startY));

            // Desenați linia de subliniere pentru antetele coloanelor
            g.DrawLine(Pens.Black, startX, startY + 30, startX + 800, startY + 30);

            // Iterați prin rezervări și desenați informațiile pentru fiecare rezervare
            startY += 40;
            foreach (Rezervare rezervare in listaRezervari)
            {
                g.DrawString(rezervare.Client.Nume, fontNormal, Brushes.Black, new PointF(startX, startY));
                g.DrawString(rezervare.Client.Prenume, fontNormal, Brushes.Black, new PointF(startX+100, startY));
                g.DrawString(rezervare.Client.Telefon, fontNormal, Brushes.Black, new PointF(startX+200, startY));
                g.DrawString(rezervare.Client.Email, fontNormal, Brushes.Black, new PointF(startX+300, startY));

                g.DrawString(rezervare.DataCheckIn.ToShortDateString(), fontNormal, Brushes.Black, new PointF(startX + 500, startY));
                g.DrawString(rezervare.DataCheckOut.ToShortDateString(), fontNormal, Brushes.Black, new PointF(startX + 600, startY));

                startY += 20;
            }

            
            e.HasMorePages = false;
        }


        private void btnPrint_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument1;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


    }

}