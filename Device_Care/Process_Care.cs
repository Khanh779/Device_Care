using Microsoft.SqlServer.Server;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Device_Care
{
    public partial class Process_Care
    {

        // History Browser
        //C:\Users\[Tên người dùng]\AppData\Local\[Tên trình duyệt]
        // Cookies
        //C:\Users\[Tên người dùng]\AppData\Local\[Tên trình duyệt]\User Data\Default\Cookies
        // Trash Files
        //C:\Users\[Tên người dùng]\AppData\Local\Temp
        //C:\$Recycle.Bin

        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        private static extern int SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, uint dwFlags);

        static string[] directories = {
                                            "C:\\Windows\\Temp",
                                            "C:\\Windows\\Prefetch",
                                            //"C:\\Users\\"+SystemInformation.UserName +"\\AppData\\Local\\"  ,
                                            Path.GetTempPath(),

                                      };

        public static int calcaulateFile(string path)
        {
            int size = 0;
            DirectoryInfo directory = new DirectoryInfo(path);
            size+= directory.GetFiles().Length;
            return size;
        }

        public static int calcaulateFileInDirectory(string[] paths)
        {
            int size = 0;
            foreach (string path in paths)
            {
                size += calcaulateFile(path);
            }
            return size;
        }

        
        static List<AppStartupInfo> ListStartupPrograms(RegistryKey rootKey, string subKeyPath)
        {
            List<AppStartupInfo> a = new List<AppStartupInfo>();
            using (var subKey = rootKey.OpenSubKey(subKeyPath))
            {
                if (subKey != null)
                {
                    var valueNames = subKey.GetValueNames();
                    foreach (var name in valueNames)
                    {
                        a.Add(new AppStartupInfo { Name = name, Path = subKey.GetValue(name).ToString(), AppStartupType= rootKey== Registry.CurrentUser? AppStartupType.CurrentUser:
                            AppStartupType.LocalMachine});
                        //Console.WriteLine($"{name}: {subKey.GetValue(name)}");
                    }
                }
                else
                {
                    Console.WriteLine("Không tìm thấy khóa khởi động.");
                }
            }
            return a;
        }

        public static List<AppStartupInfo> ListStartupApps()
        {
            List<AppStartupInfo> b = new List<AppStartupInfo>();

            // Kiểm tra Registry cho HKEY_CURRENT_USER
            b.AddRange(ListStartupPrograms(Registry.CurrentUser, @"Software\Microsoft\Windows\CurrentVersion\Run"));

            // Kiểm tra Registry cho HKEY_LOCAL_MACHINE
            b.AddRange(ListStartupPrograms(Registry.LocalMachine, @"Software\Microsoft\Windows\CurrentVersion\Run"));

            return b;
        }

        public static string ConvertEnumToString(AppStartupType appStartupType)
        {
            switch (appStartupType)
            {
                case AppStartupType.CurrentUser:
                    return "HKEY_CURRENT_USER";
                case AppStartupType.LocalMachine:
                    return "HKEY_LOCAL_MACHINE";
                default:
                    return "Unknown";
            }
        }


    }

    public struct AppStartupInfo
    {
        public string Name { get; set; }
        public string Path { get; set; }
        
        public AppStartupType AppStartupType { get; set; }

    }

    public enum AppStartupType
    {
        CurrentUser,
        LocalMachine,
        Unknown
    }
}
