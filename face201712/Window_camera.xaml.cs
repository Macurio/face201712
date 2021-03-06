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
using WPFMediaKit.DirectShow.Controls;

namespace face201712
{
    /// <summary>
    /// Window_camera.xaml 的交互逻辑
    /// </summary>
    public partial class Window_camera : Window
    {
        public Window_camera()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (MultimediaUtil.VideoInputNames.Length > 0){
                vce.VideoCaptureSource = MultimediaUtil.VideoInputNames[0];
                //vce.Play();
            }
                
                
            else
                MessageBox.Show("没有检测到任何摄像头");
            //vce.Play();
        }
        public static void SaveControlImage(FrameworkElement ui, string fileName)
        {
            System.IO.FileStream fs = new System.IO.FileStream(fileName, System.IO.FileMode.Create);
            RenderTargetBitmap bmp = new RenderTargetBitmap(200, 150, 0, 0, PixelFormats.Pbgra32);
            bmp.Render(ui);
            BitmapEncoder encoder = new PngBitmapEncoder();
            encoder.Frames.Add(BitmapFrame.Create(bmp));
            encoder.Save(fs);
            fs.Close();
        }

        private void btnCapture_Click(object sender, RoutedEventArgs e)
        {
            vce.Play();
            SaveControlImage(b, "b.png");
            vce.Stop();
            App.filename = "b.png";
            this.Close();
        }
    }
}
