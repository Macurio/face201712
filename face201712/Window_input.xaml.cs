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

namespace face201712
{
    /// <summary>
    /// Window_input.xaml 的交互逻辑
    /// </summary>
    public partial class Window_input : Window
    {
        public Window_input()
        {
            InitializeComponent();
        }

        
        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.uid = text_uid.Text;
            App.uinfo = text_uifo.Text;
            App.gid = text_gid.Text;
            this.Close();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
