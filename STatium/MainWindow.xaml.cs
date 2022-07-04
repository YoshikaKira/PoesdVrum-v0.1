using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace STatium
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Train train;
        Timer timer;
        public MainWindow()
        {
            InitializeComponent();
            train = new Train("E578 Novosib - Nur-sultan", GreenTrain);
            timer = new Timer(50);
            timer.Elapsed += Timer_Elepsed;
            timer.Start();
        }
        private void Timer_Elepsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(new Action(() =>
            {
                train.TrainImage.Margin = new Thickness(
                    train.TrainImage.Margin.Left - 5,
                    train.TrainImage.Margin.Top,
                    train.TrainImage.Margin.Right + 5,
                    train.TrainImage.Margin.Bottom);
                if (train.TrainImage.Margin.Left < -100) train.TrainImage.Margin = new Thickness(900, train.TrainImage.Margin.Top, -500, train.TrainImage.Margin.Bottom);

            }));
            
        }
    }
}
