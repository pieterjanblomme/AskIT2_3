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
using ASKITbyBDK_v2.ModelViews;

namespace ASKITbyBDK_v2
{
    /// <summary>
    /// Interaction logic for S2_personalia.xaml
    /// </summary>
    public partial class S2_personalia : Window
    {
        GebruikersViewModel ViewModel;
        public S2_personalia()
        {
            InitializeComponent();
            ViewModel = new GebruikersViewModel();
            this.DataContext = ViewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            S3_Activiteiten keuze = new S3_Activiteiten();
            keuze.Show();
            this.Close();
        }

    }
}
