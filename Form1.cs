using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ext_change_detect_settings
{
    public partial class ecd_settings : Form
    {
        public ecd_settings()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            path_textbox.Text = GetValueString("basic", "path", "data\\info.ini");
        }

        //---DLL関数の定義 START---//
        //GetPrivateProfileString関数の定義
        [DllImport("KERNEL32.DLL")]
        public static extern uint GetPrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpDefault,
            StringBuilder lpReturnedString,
            uint nSize,
            string lpFileName);

        //GetPrivateProfileInt関数の定義
        [DllImport("KERNEL32.DLL")]
        public static extern uint GetPrivateProfileInt(
            string lpAppName,
            string lpKeyName,
            int nDefault,
            string lpFileName);
        //WritePrivateProfileString関数の定義
        [DllImport("KERNEL32.DLL")]
        public static extern bool WritePrivateProfileString(
            string lpAppName,
            string lpKeyName,
            string lpString,
            string lpFileName);

        //---DLL関数の定義 END ---//


        // DLL関数をラップしたメソッドです。
        public string GetValueString(string section, string key, string fileName)
        {
            var sb = new StringBuilder(1024);
            GetPrivateProfileString(section, key, "", sb, Convert.ToUInt32(sb.Capacity), fileName);
            return sb.ToString();
        }

        public int GetValueInt(string section, string key, string fileName)
        {
            var sb = new StringBuilder(1024);
            return (int)GetPrivateProfileInt(section, key, 0, fileName);
        }

        // DLL関数をラップしたメソッドです。
        public bool SetValueString(string section, string key, string value, string fileName)
        {
            return WritePrivateProfileString(section, key, value, fileName);
        }

        public static void RegisterStartupApp(string appName, string appPath)
        {
            // レジストリのキーを開く
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // アプリケーション名と実行可能パスを値として設定する
            rkApp.SetValue(appName, appPath);
        }

        // アプリケーション名を引数にとり、レジストリからスタートアップアプリを解除する関数
        public static void UnregisterStartupApp(string appName)
        {
            // レジストリのキーを開く
            RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            // アプリケーション名に対応する値が存在するかチェックする
            if (rkApp.GetValue(appName) != null)
            {
                // 値が存在する場合は削除する
                rkApp.DeleteValue(appName, false);
            }
        }

        private void update_path_Click(object sender, EventArgs e)
        {
            SetValueString("basic", "path", path_textbox.Text, "data\\info.ini");
            MessageBox.Show("正常に更新しました。念のため再起動することをお勧めします。");
        }

        private void update_startup_true_Click(object sender, EventArgs e)
        {
            SetValueString("basic", "startup", "true", "data\\info.ini");
            RegisterStartupApp("Ext-Change-Detect", Path.GetDirectoryName(Application.ExecutablePath) + "\\ext-chg-detect.exe");
            MessageBox.Show("正常に有効化しました。念のため再起動することをお勧めします。");
        }

        private void update_startup_false_Click(object sender, EventArgs e)
        {
            SetValueString("basic", "startup", "false", "data\\info.ini");
            UnregisterStartupApp("Ext-Change-Detect");
            MessageBox.Show("正常に無効化しました。念のため再起動することをお勧めします。");
        }

        private void exe_start_Click(object sender, EventArgs e)
        {
            Process.Start(@"ext-chg-detect.exe");
        }
    }
}
