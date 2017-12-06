using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


namespace face201712
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        //静态和全局参数表 
        const string APP_ID = "10447843";
        const string API_KEY = "bHnKHuGkpQEaSU5k68F5MGen";
        const string SECRET_KEY = "EojiKc7KgHF6FySfgp9lZYPynjAonRp6 ";
        public static string filename1, filename2,filename;
        public static string uid, uinfo, gid;

        public static void FaceRegister()
        {
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var image1 = File.ReadAllBytes(App.filename);
            var result = client.User.Register(image1, App.uid, App.uinfo, new[] { App.gid })["log_id"];
            MessageBox.Show(result.ToString());
        }
        public static void FaceVerify()
        {
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var image1 = File.ReadAllBytes(App.filename);
            var result = client.User.Verify(image1, App.uid, new[] { App.gid }, 1)["result"][0];
            MessageBox.Show(result.ToString());
        }
        public static void FaceMatch()
        {
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var image1 = File.ReadAllBytes(filename1);
            var image2 = File.ReadAllBytes(filename2);
            var images = new byte[][] { image1, image2 };
            var result = client.FaceMatch(images);
            MessageBox.Show(result.ToString());
        }
        public static void FaceDetect()
        {
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var image = File.ReadAllBytes(App.filename);
            var options = new Dictionary<string, object>(){
                {"face_fields","beauty,age"}
            };
            var result = client.FaceDetect(image, options)["result"];
            MessageBox.Show(result.ToString());
        }
        public static void UserInfo()
        {
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var result = client.User.GetInfo(App.uid);
            MessageBox.Show(result.ToString());
        }
        public static void FaceDelete()
        {
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var result = client.User.Delete(App.uid, new[] { App.gid });
            MessageBox.Show(result.ToString());
        }
        public static void FaceUpdate()
        {
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var image1 = File.ReadAllBytes(App.filename);
            var result = client.User.Update(image1, App.uid, App.gid, App.uinfo);
            MessageBox.Show(result.ToString());
        }
        public static void GroupList()
        {
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var result = client.Group.GetAllGroups(0, 100);
            MessageBox.Show(result.ToString());
        }
        public static void GroupUsers()
        {
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var result = client.Group.GetUsers(App.gid, 0, 100);
            MessageBox.Show(result.ToString());
        }
    }
}
