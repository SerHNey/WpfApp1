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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomizer = new Random();
        private int _numValue_1 = 0;
        private int _numValue_2 = 0;
        private int _numValue_3 = 0;
        private int _numValue_4 = 0;
        private int added1;
        private int added2;

        private int minuend1;
        private int minuend2;

        private int multi1;
        private int multi2;


        private int delen1;
        private int delen2;


        public MainWindow()
        {
            InitializeComponent();
            StartTheQuiz();
            start.IsEnabled = false;

        }
        public void StartTheQuiz()
        {
            txtNum_1.Text = _numValue_1.ToString();
            txtNum_2.Text = _numValue_2.ToString();
            txtNum_3.Text = _numValue_3.ToString();
            txtNum_4.Text = _numValue_4.ToString();

            added1 = randomizer.Next(51);
            added2 = randomizer.Next(51);
            plusleftlabel.Content = added1.ToString();
            plusrightlabel.Content = added2.ToString();

            minuend1 = randomizer.Next(51);
            minuend2 = randomizer.Next(51);
            munleftlabel.Content = minuend1.ToString();
            munrightlabel.Content = minuend2.ToString();

            multi1 = randomizer.Next(51);
            multi2 = randomizer.Next(51);
            ymnleftlabel.Content = multi1.ToString();
            ymnrightlabel.Content = multi2.ToString();

            delen1 = randomizer.Next(51);
            delen2 = randomizer.Next(51);
            delenleftlabel.Content = delen1.ToString();
            delenrightlabel.Content = delen2.ToString();
    

        }
        public int NumValue_1
        {
            get { return _numValue_1; }
            set
            {
                _numValue_1 = value;
                txtNum_1.Text = value.ToString();
            }
        }
        public int NumValue_2
        {
            get { return _numValue_2; }
            set
            {
                _numValue_2 = value;
                txtNum_2.Text = value.ToString();
            }
        }
        public int NumValue_3
        {
            get { return _numValue_3; }
            set
            {
                _numValue_3 = value;
                txtNum_3.Text = value.ToString();
            }
        }
        public int NumValue_4
        {
            get { return _numValue_4; }
            set
            {
                _numValue_4 = value;
                txtNum_4.Text = value.ToString();
            }
        }


        private void start_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmdUp_1_Click(object sender, RoutedEventArgs e)
        {
            NumValue_1++;
        }

        private void cmdDown_1_Click(object sender, RoutedEventArgs e)
        {
            NumValue_1--;
        }

        private void cmdUp_2_Click(object sender, RoutedEventArgs e)
        {
            NumValue_2++;
        }

        private void cmdDown_2_Click(object sender, RoutedEventArgs e)
        {
            NumValue_2--;
        }

        private void cmdUp_3_Click(object sender, RoutedEventArgs e)
        {
            NumValue_3++;
        }

        private void cmdDown_3_Click(object sender, RoutedEventArgs e)
        {
            NumValue_3--;
        }

        private void cmdUp_4_Click(object sender, RoutedEventArgs e)
        {
            NumValue_4++;
        }

        private void cmdDown_4_Click(object sender, RoutedEventArgs e)
        {
            NumValue_4--;
        }

        private void txtNum_1_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum_1 == null)
            {
                return;
            }

            if (!int.TryParse(txtNum_1.Text, out _numValue_1))
                txtNum_1.Text = _numValue_1.ToString();
        }

        private void txtNum_2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum_2 == null)
            {
                return;
            }

            if (!int.TryParse(txtNum_2.Text, out _numValue_2))
                txtNum_2.Text = _numValue_2.ToString();
        }

        private void txtNum_3_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum_3 == null)
            {
                return;
            }

            if (!int.TryParse(txtNum_3.Text, out _numValue_3))
                txtNum_3.Text = _numValue_3.ToString();
        }

        private void txtNum_4_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtNum_4 == null)
            {
                return;
            }

            if (!int.TryParse(txtNum_4.Text, out _numValue_4))
                txtNum_4.Text = _numValue_4.ToString();
        }
    }
}
