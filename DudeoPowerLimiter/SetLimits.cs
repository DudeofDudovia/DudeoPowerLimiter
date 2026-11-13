using System;
using System.Collections.Generic;
using System.Text;

namespace DudeoPowerLimiter
{
    internal static class SetLimits
    {
        public static void SetLimit(int Limit)
        {
            // Source - https://stackoverflow.com/a/1469790
            // Posted by RameshVel, modified by community. See post 'Timeline' for change history
            // Retrieved 2026-11-13, License - CC BY-SA 4.0
            string cmd = "";
            cmd = "/C powercfg /setdcvalueindex SCHEME_CURRENT SUB_PROCESSOR PROCTHROTTLEMAX " + Limit;
            System.Diagnostics.Process.Start("CMD.exe", cmd);
            string cmd2 = "";
            cmd2 = "/C powercfg /setactive SCHEME_CURRENT";
            System.Diagnostics.Process.Start("CMD.exe", cmd2);

        }
    }
}
