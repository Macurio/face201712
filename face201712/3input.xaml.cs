﻿using System;
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
    /// _3input.xaml 的交互逻辑
    /// </summary>
    public partial class _3input : Window
    {
        public _3input()
        {
            InitializeComponent();
        }

        private void load(object sender, RoutedEventArgs e)
        {
            prompting_message_text.Text = "请输入：" + App.prompting_message;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            App.str1 = str1.Text;
            App.str2 = str2.Text;
            App.str3 = str3.Text;
            this.Close();
        }

    }
}
