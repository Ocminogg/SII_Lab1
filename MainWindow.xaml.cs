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

namespace WpfAppLaba1Frame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Repository data;

        public MainWindow()
        {
            InitializeComponent();
            data = Repository.CreateRepository();

            cbCountry.ItemsSource = data.CountryDb;
            cbCybject.ItemsSource = data.CybjectDb;
            cbCity.ItemsSource = data.CityDb;
        }

        private void btnRef(object sender, RoutedEventArgs e)
        {
            cbCountry.Items.Refresh();
            cbCybject.Items.Refresh();
            cbCity.Items.Refresh();
            lvZapros.Items.Refresh();
        }

        private void CbDepartment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvZapros.ItemsSource = data.ZaprosDb.Where(find);
        }

        private void CbCybject_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvZapros.ItemsSource = data.ZaprosDb.Where(findd);
        }

        private void CbCity_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lvZapros.ItemsSource = data.ZaprosDb.Where(finddd);
        }
        private bool find(Zapros arg)
        {
            return arg.CountryId == (cbCountry.SelectedItem as Country).CountryId;
        }
        private bool findd(Zapros arg)
        {
            return arg.CybjectId == (cbCybject.SelectedItem as Cybject).CybjectId;
        }
        private bool finddd(Zapros arg)
        {
            return arg.CityId == (cbCity.SelectedItem as City).CityId;
        }
    }
}
