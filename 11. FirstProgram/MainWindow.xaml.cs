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

namespace _11._FirstProgram
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int cal1 = int.Parse(Cal_1.Text);
            int cal2 = int.Parse(Cal_2.Text);
            int cal3 = int.Parse(Cal_3.Text);
            int total = cal1 - cal2;
            int day = cal3 / total;
            string show = total.ToString (); 
            Cal_4.Text =show;

            if (cal1 < cal2)
            {
                MessageBox.Show(" Impossible ");
            }
            else
            {
                MessageBox.Show("คุณต้องเก็บเงินทั้งหมด "+total+" บาท "+" จำนวน "+day+"วัน");
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cal_1.Clear();
            Cal_2.Clear();
            Cal_3.Clear();
            Cal_4.Clear();
        }
    }
}
