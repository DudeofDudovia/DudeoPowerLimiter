using System.IO;
using System.Collections.Generic;
using System.Text;

namespace DudeoPowerLimiter
{
    internal static class SaveHelper
    {
        public static string SaveFile = Path.Combine(Application.LocalUserAppDataPath,"LastSetting.dpl");
        public static string SaveSlider = Path.Combine(Application.LocalUserAppDataPath,"LastSlider.dpl");
        public static string SavePath = Application.LocalUserAppDataPath;
    }
}
