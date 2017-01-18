using Microsoft.Win32;
using System.IO;
using System.Reflection;

namespace Wallpaper
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            var archivos = Directory.GetFiles(path, "*.jpg");
            if(archivos.Length > 0)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System", "Wallpaper", archivos[0]);
            }
        }
    }
}
