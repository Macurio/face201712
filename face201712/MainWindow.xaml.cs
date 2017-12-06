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

namespace face201712
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        

        private void face_register_Click(object sender, RoutedEventArgs e)
        {
            new Window_select().ShowDialog();
            new Window_input().ShowDialog();
            App.FaceRegister();
        }

        private void face_verify_Click(object sender, RoutedEventArgs e)
        {
            new Window_select().ShowDialog();
            new Window_input().ShowDialog();
            App.FaceVerify();
        }

        private void face_match_Click(object sender, RoutedEventArgs e)
        {
            //调用两次选择窗口付给filename1 filename2
            //只有人脸比对需要两张人脸图片，其它都用filename参数
            new Window_select().ShowDialog();
            App.filename1 = App.filename;
            new Window_select().ShowDialog();
            App.filename2 = App.filename;
            App.FaceMatch();
        }

        private void face_detect_Click(object sender, RoutedEventArgs e)
        {
            new Window_select().ShowDialog();
            App.FaceDetect();
        }

        private void user_info_Click(object sender, RoutedEventArgs e)
        {
            new Window_input().ShowDialog();
            App.UserInfo();
        }

        private void face_delete_Click(object sender, RoutedEventArgs e)
        {
            new Window_input().ShowDialog();
            App.FaceDelete();
        }

        private void face_update_Click(object sender, RoutedEventArgs e)
        {
            new Window_select().ShowDialog();
            new Window_input().ShowDialog();
            App.FaceUpdate();
        }

        private void group_list_Click(object sender, RoutedEventArgs e)
        {
            App.GroupList();
        }

        private void group_users_Click(object sender, RoutedEventArgs e)
        {
            new Window_input().ShowDialog();
            App.GroupUsers();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
