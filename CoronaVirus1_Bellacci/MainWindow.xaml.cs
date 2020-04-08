using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Xml.Linq;

namespace CoronaVirus1_Bellacci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Btn_Visualizza_Click(object sender, RoutedEventArgs e)
        {
            //faccio partire la task
            Task.Factory.StartNew(() => CaricaDati());
        }

        private void CaricaDati()
        {
            string path = @"CoronaVirus.xml";
            XDocument xmlDoc = XDocument.Load(path);
            //andiamo a leggere l'elemento atleti
            XElement xmlcorona = xmlDoc.Element("CoronaVirus");
            //andiamo a leggere l'elemento atleta presente dentro atleti
            var xmlcovid = xmlcorona.Elements("Covid-19");
            //rallento il caricamento dei dati
            Thread.Sleep(1000);

            foreach (var item in xmlcovid)
            {
                //leggo tutte le proprietà
                XElement xmlData = item.Element("data");
                XElement xmlStato = item.Element("stato");
                XElement xmlRicoverati = item.Element("ricoverati_con_sintomi");
                XElement xmlTerapia = item.Element("terapia_intensiva");
                XElement xmlOspedalizzati = item.Element("totale_ospedalizzati");
                XElement xmlIsolamento = item.Element("isolamento_domiciliare");
                XElement xmlPositivi = item.Element("totale_positivi");
                XElement xmlVarPositivi = item.Element("variazione_totale_positivi");
                XElement xmlNuoviPositivi = item.Element("nuovi_positivi");
                XElement xmlDimessi = item.Element("dimessi_guariti");
                XElement xmlDeceduti = item.Element("deceduti");
                XElement xmlTotCasi = item.Element("totale_casi");
                XElement xmlTamponi = item.Element("tamponi");

                //creo l'oggetto atleta
                Giorno g = new Giorno(Convert.ToDateTime(xmlData.Value.Substring(0, 10)), xmlStato.Value,
                    Convert.ToInt32(xmlRicoverati.Value),
                    Convert.ToInt32(xmlTerapia.Value),
                    Convert.ToInt32(xmlOspedalizzati.Value),
                    Convert.ToInt32(xmlIsolamento.Value),
                    Convert.ToInt32(xmlPositivi.Value),
                    Convert.ToInt32(xmlVarPositivi.Value),
                    Convert.ToInt32(xmlNuoviPositivi.Value),
                    Convert.ToInt32(xmlDimessi.Value),
                    Convert.ToInt32(xmlDeceduti.Value),
                    Convert.ToInt32(xmlTotCasi.Value),
                    Convert.ToInt32(xmlTamponi.Value));

                //popolo la lista
                Dispatcher.Invoke(() => Lst_Visualizza.Items.Add(g));
                Thread.Sleep(1000);
            }
        }

        private void Btn_Grafico_Click(object sender, RoutedEventArgs e)
        {
            Grafico window = new Grafico();
            window.Show();
        }

        private void Btn_Sito_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://opendatadpc.maps.arcgis.com/apps/opsdashboard/index.html#/b0c68bce2cce478eaac82fe38d4138b1");
        }

        private void Btn_Sito1_Click(object sender, RoutedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.salute.gov.it/portale/malattieInfettive/dettaglioFaqMalattieInfettive.jsp?lingua=italiano&id=228");
        }
    }
}
