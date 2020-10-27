using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private void cmd_SetSmall(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 2;
        }

        private void cmd_SetNormal(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = this.FontSize;
        }

        private void cmd_SetLarge(object sender, RoutedEventArgs e)
        {
            lblSampleText.FontSize = 30;
        }
    }
}

//////////////////////////////////////////////////////////////////////////
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace WpfApp1
//{
//    /// <summary>
//    /// MainWindow.xaml에 대한 상호 작용 논리
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();

//        }
//        private void cmdCapture_Click(object sender, RoutedEventArgs e)
//        {
//            this.AddHandler(
//                   Mouse.LostMouseCaptureEvent,
//                   new RoutedEventHandler(this.LostCapture));
//            Mouse.Capture(rect);

//            cmdCapture.Content = "[ Mouse is now captured ... ]";
//        }

//        private void MouseMoved(object sender, MouseEventArgs e)
//        {
//            Point pt = e.GetPosition(this); //
//            lblInfo.Text =
//                String.Format("You are at ({0},{1}) in window coordinates",
//                pt.X, pt.Y);
//        }

//        private void LostCapture(object sender, RoutedEventArgs e)
//        {
//            MessageBox.Show("Lost capture");
//            cmdCapture.Content = "Capture the Mouse";
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace WpfApp1
//{
//    /// <summary>
//    /// MainWindow.xaml에 대한 상호 작용 논리
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();

//        }
//        private void pnl_PreviewTextInput(object sender, TextCompositionEventArgs e)
//        {
//            //short val;
//            //if (!Int16.TryParse(e.Text, out val))
//            //{
//            //    e.Handled = true;
//            //}

//            // 문자만
//            Regex regex = new Regex("[a-zA-Z]");
//            Match m = regex.Match(e.Text);
//            if (!m.Success)
//            {
//                e.Handled = true;
//            }

//        }

//        private void pnl_PreviewKeyDown(object sender, KeyEventArgs e)
//        {
//            if (e.Key == Key.Space)
//            {
//                e.Handled = true;
//            }
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace WpfApp1
//{
//    /// <summary>
//    /// MainWindow.xaml에 대한 상호 작용 논리
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();

//        }
//        private void KeyEvent(object sender, KeyEventArgs e)
//        {
//            if ((bool)chkIgnoreRepeat.IsChecked && e.IsRepeat) return;

//            string message = //"At: " + e.Timestamp.ToString() +
//                "Event: " + e.RoutedEvent + " " +
//                " Key: " + e.Key;
//            lstMessages.Items.Add(message);
//        }

//        private void TextInput(object sender, TextCompositionEventArgs e)
//        {
//            string message = //"At: " + e.Timestamp.ToString() +
//                "Event: " + e.RoutedEvent + " " +
//                " Text: " + e.Text;
//            lstMessages.Items.Add(message);
//        }

//        private void TextChanged(object sender, TextChangedEventArgs e)
//        {
//            string message =
//                "Event: " + e.RoutedEvent;
//            lstMessages.Items.Add(message);
//        }

//        private void cmdClear_Click(object sender, RoutedEventArgs e)
//        {
//            lstMessages.Items.Clear();
//        }
//    }
//}

///////////////////////////////////////////////////////////////////////////////////////
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace WpfApp1
//{
//    /// <summary>
//    /// MainWindow.xaml에 대한 상호 작용 논리
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();

//        }
//        protected int eventCounter = 0;

//        private void SomeKeyPressed(object sender, KeyEventArgs e)
//        {
//            eventCounter++;
//            string message = "#" + eventCounter.ToString() + ":\r\n" +
//                " Sender: " + sender.ToString() + "\r\n" +
//                " Source: " + e.Source + "\r\n" +
//                " Original Source: " + e.OriginalSource + "\r\n" +
//                " Event: " + e.RoutedEvent;
//            lstMessages.Items.Add(message);
//            e.Handled = (bool)chkHandle.IsChecked;
//        }

//        private void cmdClear_Click(object sender, RoutedEventArgs e)
//        {
//            eventCounter = 0;
//            lstMessages.Items.Clear();
//        }
//    }
//}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace WpfApp1
//{
//    /// <summary>
//    /// MainWindow.xaml에 대한 상호 작용 논리
//    /// </summary>
//    public partial class MainWindow : Window
//    {
//        public MainWindow()
//        {
//            InitializeComponent();

//        }
//        protected int eventCounter = 0;
//        private void SomethingClicked(object sender, MouseButtonEventArgs e)
//        {
//            eventCounter++;
//            string message = "#" + eventCounter.ToString() + ":\r\n" +
//                " Sender: " + sender.ToString() + "\r\n" +
//                " Source: " + e.Source + "\r\n" +
//                " Original Source: " + e.OriginalSource;
//            lstMessages.Items.Add(message);
//            e.Handled = (bool)chkHandle.IsChecked;
//        }

//        private void cmdClear_Click(object sender, RoutedEventArgs e)
//        {
//            eventCounter = 0;
//            lstMessages.Items.Clear();
//        }
//    }
//}
