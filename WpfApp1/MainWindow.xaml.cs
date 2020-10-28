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
        
    }
}
///////////////////////////////쉬는시간2//////////////////////////////////////////////////////////
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

//            // Create bindings.
//            CommandBinding binding;
//            binding = new CommandBinding(ApplicationCommands.New);
//            binding.Executed += NewCommand;
//            this.CommandBindings.Add(binding);

//            binding = new CommandBinding(ApplicationCommands.Open);
//            binding.Executed += OpenCommand;
//            this.CommandBindings.Add(binding);

//            binding = new CommandBinding(ApplicationCommands.Save);
//            binding.Executed += SaveCommand_Executed;
//            binding.CanExecute += SaveCommand_CanExecute;
//            this.CommandBindings.Add(binding);
//        }
//        private void NewCommand(object sender, ExecutedRoutedEventArgs e)
//        {
//            MessageBox.Show("New command triggered with " + e.Source.ToString());
//            isDirty = false;
//        }

//        private void OpenCommand(object sender, ExecutedRoutedEventArgs e)
//        {
//            isDirty = false;
//        }

//        private void SaveCommand_Executed(object sender, ExecutedRoutedEventArgs e)
//        {
//            MessageBox.Show("Save command triggered with " + e.Source.ToString());
//            isDirty = false;
//        }

//        private bool isDirty = false;
//        private void txt_TextChanged(object sender, TextChangedEventArgs e)
//        {
//            isDirty = true;
//        }
//        private void SaveCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
//        {
//            e.CanExecute = isDirty;
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

//        private void txt_TextChanged(object sender, TextChangedEventArgs e)
//        {

//        }
//    }
//}
//////////////////////////////쉬는시간1//////////////////////////////////////////////
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

//        private void cmd_SetSmall(object sender, RoutedEventArgs e)
//        {
//            sliderFontSize.Value = 2;
//        }

//        private void cmd_SetNormal(object sender, RoutedEventArgs e)
//        {
//            sliderFontSize.Value = this.FontSize;
//        }

//        private void cmd_SetLarge(object sender, RoutedEventArgs e)
//        {
//            lblSampleText.FontSize = 30;
//        }


//    }
//}

//using System; //onWayToSource
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

//        private void cmd_SetSmall(object sender, RoutedEventArgs e)
//        {
//            sliderFontSize.Value = 2;
//        }

//        private void cmd_SetNormal(object sender, RoutedEventArgs e)
//        {
//            sliderFontSize.Value = this.FontSize;
//        }

//        private void cmd_SetLarge(object sender, RoutedEventArgs e)
//        {
//            lblSampleText.FontSize = 30;
//        }


//    }
//}

//using System; //onWayToSource
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

//        private void cmd_SetSmall(object sender, RoutedEventArgs e)
//        {
//            sliderFontSize.Value = 2;
//        }

//        private void cmd_SetNormal(object sender, RoutedEventArgs e)
//        {
//            sliderFontSize.Value = this.FontSize;
//        }

//        private void cmd_SetLarge(object sender, RoutedEventArgs e)
//        {
//            lblSampleText.FontSize = 30;
//        }

//        private void cmd_ShowProperty(object sender, RoutedEventArgs e)
//        {
//            MyClass m = (MyClass)this.Resources["myclass"];
//            MessageBox.Show("" + m.Size);
//        }
//    }
//}

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
