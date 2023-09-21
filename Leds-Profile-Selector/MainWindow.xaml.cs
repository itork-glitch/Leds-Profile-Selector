using System.Windows;
using System.IO.Ports;
using System.Threading;

namespace Leds_Profile_Selector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private SerialPort serialPort;

        public MainWindow()
        {
            InitializeComponent();

            serialPort = new SerialPort("COM4", 9600);
            serialPort.Open();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
            }

            Application.Current.Shutdown();
        }

        private void ButtonReset_Click(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Close();
                Thread.Sleep(100);
                serialPort.Open();
                serialPort.Write("9");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("1");
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("2");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("3");
            }

        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("4");
            }
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            if (serialPort.IsOpen)
            {
                serialPort.Write("5");
            }
        }
    }
}
