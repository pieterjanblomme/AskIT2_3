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

namespace ASKITbyBDK_v2
{
    /// <summary>
    /// Interaction logic for S5_Bevestiging.xaml
    /// </summary>
    public partial class S5_Bevestiging : Window
    {
        public S5_Bevestiging()
        {
            InitializeComponent();
        }

        private void Btn_s5_opnieuw_Click(object sender, RoutedEventArgs e)
        {
            S2_personalia keuze = new S2_personalia();
            keuze.Show();
            this.Close();
        }

        private void Btn_s5_afsluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
