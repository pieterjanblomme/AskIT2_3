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
    /// Interaction logic for S4_1_FV.xaml
    /// </summary>
    public partial class S4_1_FV : Window
    {
        public S4_1_FV()
        {
            InitializeComponent();
        }

        private void Btn_s4_1_doorgaan_Click(object sender, RoutedEventArgs e)
        {
            S5_Bevestiging BV = new S5_Bevestiging();
            BV.Show();
            this.Close();
        }
    }
}
