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
using System.IO;
using Microsoft.Win32;

namespace face201712
{
    /// <summary>
    /// Window_select.xaml 的交互逻辑
    /// </summary>
    public partial class Window_select : Window
    {
        public Window_select()
        {
            InitializeComponent();
        }

        
        public static void read_filename()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "png files (*.png)|*.png|All files (*.*)|*.*";
            openFileDialog.RestoreDirectory = false;
            if (openFileDialog.ShowDialog() == false)
            {
                return;
            }
            App.filename = openFileDialog.FileName;
        }
        private void openfile_Click(object sender, RoutedEventArgs e)
        {
            read_filename();
            this.Close();
        }

        private void camera_Click(object sender, RoutedEventArgs e)
        {
            new Window_camera().ShowDialog();
            this.Close();
        }
    }
}
