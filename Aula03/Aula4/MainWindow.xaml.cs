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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Aula4
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Botãocalulcar_Click(object sender, RoutedEventArgs e)
        {
            Abastecimento obj = new Abastecimento();
            obj.SetKmRodados(double.Parse(txt_1.Text));
            obj.SetValorPago(double.Parse(txt_2.Text));
            obj.SetValorLitro(double.Parse(txt_3.Text));
            txt_4.Text = obj.MediaKmLitro().ToString();
            txt_5.Text = obj.MediaReaisKm().ToString();
        }
    }
    class Abastecimento
    {
        private double valorLitro;
        private double valorPago;
        private double KmRodados;
        public void SetValorLitro(double valorLitro)
        {
            if (valorLitro > 0) this.valorLitro = valorLitro;
        }
        public void SetValorPago(double valorPago)
        {
            if (valorPago > 0) this.valorPago = valorPago;
        }
        public void SetKmRodados(double kmRodados)
        {
            if (kmRodados > 0) this.KmRodados = kmRodados;
        }
        public double MediaKmLitro()
        {
            double numLitros = valorPago / valorLitro;
            return KmRodados / numLitros;
        }
        public double MediaReaisKm()
        {
            return valorPago / KmRodados;
        }
    }
}
