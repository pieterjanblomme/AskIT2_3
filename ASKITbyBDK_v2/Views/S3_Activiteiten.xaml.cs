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
    /// Interaction logic for S3_Activiteiten.xaml
    /// </summary>
    public partial class S3_Activiteiten : Window
    {
        public S3_Activiteiten()
        {
            InitializeComponent();
        }

        private void Btn_s3_fiets_Click(object sender, RoutedEventArgs e)
        {
            S4_1_FV FV = new S4_1_FV();
            FV.Show();
            this.Close();
        }
    }
}
