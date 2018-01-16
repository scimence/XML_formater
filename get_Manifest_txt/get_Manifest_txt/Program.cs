using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace get_Manifest_txt
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            if (args.Length > 0)
            {
                //MessageBox.Show("参数0：" + args[0]);
                getManifest_txt(args[0]);
            }
        }

        // 提取Manifest.xml文件中的数据，转化为指定的格式
        private static void getManifest_txt(String filePath)
        {
            Manifest manifesetFile = new Manifest(filePath);
            manifesetFile.save();

            //// 以下为转化为特定的格式示例
            ////return;
            //xmlNode manifest = manifesetFile.manifest;
            //xmlNode application = manifesetFile.application;
            //xmlNode LauncherActivity = manifesetFile.LauncherActivity;

            //application.Remove(LauncherActivity);   // 移除入口Activity
            //manifest.Remove(application);           // 移除manifest中的application
            //manifest.Add(application.childs);       // 添加application下的所有子节点到manifest

            //string xml = ToString(manifest.childs); // 转化为特定的格式
            //FileProcess.SaveProcess(xml, filePath); // 输出处理结果
        }

        ///// <summary>
        ///// 转化list为特定的字符串形式
        ///// </summary>
        //public static string ToString(List<xmlNode> list)
        //{
        //    string Str = "";

        //    foreach (xmlNode node in list)
        //    {
        //        Str += (Str.Equals("") ? "" : "\r\n") + node.ToString() + "||";
        //    }

        //    return Str;
        //}
    }
}
