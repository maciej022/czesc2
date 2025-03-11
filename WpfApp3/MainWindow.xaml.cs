using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
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
        private string MaleiDuzeLitery;
        private string znakiSpecjalne;
        private string cyfry;
        private string haslo;
        Random losuj = new Random();

        private void generuj_btn_Click(object sender, RoutedEventArgs e)
        {

            if (!int.TryParse(ileznaow_txt.Text, out int dlugoscHasla) || dlugoscHasla <= 0)
            {
                MessageBox.Show("Podaj poprawną liczbę znaków!");
                return;
            }

            string dozwoloneZnaki = "";

            if (malelitery_check.IsChecked == true)
                dozwoloneZnaki += MaleiDuzeLitery;

            if (cyfry_check.IsChecked == true)
                dozwoloneZnaki += cyfry;

            if (specjalne_check.IsChecked == true)
                dozwoloneZnaki += znakiSpecjalne;

           /* if (string.IsNullOrEmpty(dozwoloneZnaki))
            {
                MessageBox.Show("Wybierz co najmniej jeden typ znaków!");
                return;
            }
 */

            for (int i = 0; i < dlugoscHasla; i++)
            {
                int index = losuj.Next(dozwoloneZnaki.Length);
                
            }

            MessageBox.Show($"{haslo}");
        }

        private void Zatwierdź_btn_Click(object sender, RoutedEventArgs e)
        {
           // Stanowisko_combo.SelectedItem.ToString();
            MessageBox.Show($"Dane pracownika:Imię: {imie_txt.Text}Nazwisko: {nazwisko_txt.Text}Stanowisko: {Stanowisko_combo.SelectedItem.ToString()}");
        }
    }

}