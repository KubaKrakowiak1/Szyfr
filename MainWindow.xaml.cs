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

namespace szyfrDesktop
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void zaszyfrujButton_Click(object sender, RoutedEventArgs e)
        {
            
                string haslo = hasloTextBox.Text;
                int key = int.Parse(DlugoscKlucza.Text);
                char[] alfabet = "abcdefghijklmnopqrstuwxyz".ToCharArray();

                char[] wynik = new char[haslo.Length];

                for (int i = 0; i < haslo.Length; i++)
                {

                    int index = haslo[i] - 'a';
                    int newIndex = (index + key) % 26;
                    wynik[i] = alfabet[newIndex];
                }
                string zaszyfrowaneHaslo = new string(wynik);

            hasloLabel.Content = zaszyfrowaneHaslo;
        }
    }
}
    
