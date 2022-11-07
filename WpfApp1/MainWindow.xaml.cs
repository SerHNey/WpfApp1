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
using System.Windows.Threading;
using System.Threading;


namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random randomizer = new Random();
        double result_pll = 0;
        double result_minn = 0;
        double result_ymnn = 0;
        double result_dell = 0;

        private int time = 30;
        DispatcherTimer timer = new DispatcherTimer();
        bool ok_answer = false;
        public MainWindow()
        {
            InitializeComponent();
           // StartTheQuiz();
           // start.IsEnabled = false;

            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = new TimeSpan(0, 0, 1);

        }


        private bool CheckTheAnswer()
        {



            return false;
        }
        public void StartTheQuiz()
        {
           
        }

        private void start_Click(object sender, RoutedEventArgs e)
        {
             tileLabel.Text = "30";
            Random random = new Random();
            var blocks = plus_panel.Children.OfType<TextBlock>().ToList().
                Concat(minus_panel.Children.OfType<TextBlock>().ToList()).
                Concat(mult_panel.Children.OfType<TextBlock>().ToList()).
                Concat(divide_panel.Children.OfType<TextBlock>().ToList());

            var blocks1 = mult_panel.Children.OfType<TextBlock>().ToList();

            foreach (TextBlock item in blocks)
            {
                item.Text = random.Next(51).ToString();

            }
            foreach (TextBlock item in blocks1)
            {
                item.Text = random.Next(10).ToString();
            }
            var block = plus_panel.Children.OfType<TextBlock>().ToList();
            result_pll = double.Parse(block[0].Text) + double.Parse(block[1].Text);
            block = minus_panel.Children.OfType<TextBlock>().ToList();
            result_minn = double.Parse(block[0].Text) + double.Parse(block[1].Text);
            block = mult_panel.Children.OfType<TextBlock>().ToList();
            result_ymnn = double.Parse(block[0].Text) * double.Parse(block[1].Text);
            block = divide_panel.Children.OfType<TextBlock>().ToList();
            result_dell = double.Parse(block[0].Text) / double.Parse(block[1].Text);

            timer.Start();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            if (result_del.Text == result_dell.ToString() && result_raz.Text == result_minn.ToString() && result_ymn.Text == result_ymnn.ToString() && result_plus.Text == result_pll.ToString())
            {
                timer.Stop();
                MessageBox.Show("ТЫ не ЛЕРУА МЕРЛЕН");
            }
            tileLabel.Text = (double.Parse(tileLabel.Text) - 1).ToString();
            if (tileLabel.Text == "0")
            {
                MessageBox.Show("ТЫ ЛЕРУА МЕРЛЕН");
                timer.Stop();
            }
        }

    }
}
