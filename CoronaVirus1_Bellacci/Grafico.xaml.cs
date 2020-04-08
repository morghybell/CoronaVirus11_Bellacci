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

namespace CoronaVirus1_Bellacci
{
    /// <summary>
    /// Interaction logic for Grafico.xaml
    /// </summary>
    public partial class Grafico : Window
    {
        string NomeFile;

        public Grafico()
        {
            InitializeComponent();
        }

        private void Btn_Mostra_Click(object sender, RoutedEventArgs e)
        {
            NomeFile = "C:\\Users\\Morgana\\Desktop\\CoronaVirus1_Bellacci\\CorVirus.xlsx";
            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook xlWorkbook;
            xlWorkbook = xlApp.Workbooks.Open(NomeFile, 0, true, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", false, false, 0, true, 1, 0);
            xlApp.Visible = true;
        }
    }
}
