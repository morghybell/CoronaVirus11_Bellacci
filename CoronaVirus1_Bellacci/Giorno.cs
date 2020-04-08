using System;

namespace CoronaVirus1_Bellacci
{
    internal class Giorno
    {
        public DateTime Data { get; set; }
        public string Stato { get; set; }
        public int Ricoverati_con_sintomi { get; set; }
        public int Terapia_intensiva { get; set; }
        public int Totale_ospedalizzati { get; set; }
        public int Isolamento_domiciliare { get; set; }
        public int Totale_positivi { get; set; }
        public int Variazione_totale_positivi { get; set; }
        public int Nuovi_positivi { get; set; }
        public int Dimessi_guariti { get; set; }
        public int Deceduti { get; set; }
        public int Totale_casi { get; set; }
        public int Tamponi { get; set; }

        public Giorno(DateTime data, string stato, int ricoverati, int terapia, int ospedalizzati, int isolamento, int totpositivi, int varpositivi, int nuovipositivi, int guariti, int deceduti, int totcasi, int tamponi)
        {
            this.Data = data;
            this.Stato = stato;
            this.Ricoverati_con_sintomi = ricoverati;
            this.Terapia_intensiva = terapia;
            this.Totale_ospedalizzati = ospedalizzati;
            this.Isolamento_domiciliare = isolamento;
            this.Totale_positivi = totpositivi;
            this.Variazione_totale_positivi = varpositivi;
            this.Nuovi_positivi = nuovipositivi;
            this.Dimessi_guariti = guariti;
            this.Deceduti = deceduti;
            this.Totale_casi = totcasi;
            this.Tamponi = tamponi;
        }

        public override string ToString()
        {
            return $"{Stato}, {Data.Day}/{Data.Month}/{Data.Year}:\nRicoverati con sintomi = {Ricoverati_con_sintomi}" +
                $"\nTerapia intensiva = {Terapia_intensiva}" +
                $"\nTotale ospedalizzati = {Totale_ospedalizzati}" +
                $"\nIsolamento domiciliare = {Isolamento_domiciliare}" +
                $"\nTotale positivi = {Totale_positivi}" +
                $"\nVariazione totale positivi = {Variazione_totale_positivi}" +
                $"\nNuovi positivi = {Nuovi_positivi}" +
                $"\nDimessi guariti = {Dimessi_guariti}" +
                $"\nDeceduti = {Deceduti}" +
                $"\nTotale casi = {Totale_casi}" +
                $"\nTamponi = {Tamponi}" +
                $"\n";
        }
    }
}