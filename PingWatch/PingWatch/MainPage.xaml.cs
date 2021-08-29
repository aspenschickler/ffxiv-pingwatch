using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PingWatch
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>

    public sealed partial class MainPage : Page
    {
        private String[] data_center_ip_arr;
        private TextBox tb;
        private ComboBox cb;

        public MainPage()
        {
            data_center_ip_arr = new string[8] { "204.2.229.10", "124.150.157.158", "124.150.157.157", "124.150.157.156", "204.2.229.9", "195.82.50.10", "195.82.50.9", "204.2.229.11" }; ;

            this.InitializeComponent();
            tb = this.FindName("textBox") as TextBox;
            cb = this.FindName("comboBox") as ComboBox;
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tb.Text = data_center_ip_arr[cb.SelectedIndex];
        }
    }
}
