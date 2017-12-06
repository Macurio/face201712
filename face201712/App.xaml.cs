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
        public App()
        {
            DispatcherUnhandledException += App_DispatcherUnhandledException;
        }
        void App_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("Error encountered! Please contact support." + Environment.NewLine + e.Exception.Message);
            //Shutdown(1);
            e.Handled = true;
        }
        //静态和全局参数表 
        const string APP_ID = "10447843";
        const string API_KEY = "bHnKHuGkpQEaSU5k68F5MGen";
        const string SECRET_KEY = "EojiKc7KgHF6FySfgp9lZYPynjAonRp6 ";
        public static string filename1, filename2,filename;
        public static string uid, uinfo, gid;
        public static string toGroupId, fromGroupId;
        public static string prompting_message;
        public static string str1, str2, str3;

        public static void FaceRegister()
        {
            uid = str1;
            gid = str2;
            uinfo = str3;
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var image1 = File.ReadAllBytes(filename);
            var result = client.User.Register(image1, uid, uinfo, new[] { gid })["log_id"];
            MessageBox.Show(result.ToString());
        }
        public static void FaceVerify()
        {
            uid = str1;
            gid = str2;
            //MessageBox.Show(uid);
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var image1 = File.ReadAllBytes(filename);
            var result = client.User.Verify(image1, uid, new[] { gid }, 1)["result"][0];
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
            var image = File.ReadAllBytes(filename);
            var options = new Dictionary<string, object>(){
                {"face_fields","beauty,age"}
            };
            var result = client.FaceDetect(image, options)["result"];
            MessageBox.Show(result.ToString());
        }
        public static void UserInfo()
        {
            uid = str1;
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var result = client.User.GetInfo(uid);
            MessageBox.Show(result.ToString());
        }
        public static void FaceDelete()
        {
            uid = str1;
            gid = str2;
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var result = client.User.Delete(uid, new[] { gid });
            MessageBox.Show(result.ToString());
        }
        public static void FaceUpdate()
        {
            uid = str1;
            gid = str2;
            uinfo = str3;
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var image1 = File.ReadAllBytes(filename);
            var result = client.User.Update(image1, uid, gid, uinfo);
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
            gid = str1;
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var result = client.Group.GetUsers(gid, 0, 100);
            MessageBox.Show(result.ToString());
        }
        public static void FaceIdentify()
        {
            gid = str1;
            //MessageBox.Show(gid);
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var image1 = File.ReadAllBytes(filename);
            var result = client.User.Identify(image1, new[] { gid }, 1, 1);
            MessageBox.Show(result.ToString());
        }
        public static void GroupAddUser()
        {
            toGroupId = str1;
            uid = str2;
            fromGroupId = str3;
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var result = client.Group.AddUser(new[] { toGroupId }, uid, fromGroupId);
            MessageBox.Show(result.ToString());
        }
        public static void GroupDeleteUser()
        {
            uid = str1;
            gid = str2;
            var client = new Baidu.Aip.Face.Face(API_KEY, SECRET_KEY);
            var result = client.Group.DeleteUser(new[] { gid }, uid);
            MessageBox.Show(result.ToString());
        }
    }
}
//未实现的功能：
//连接数据库保存结果，批量注册图片  