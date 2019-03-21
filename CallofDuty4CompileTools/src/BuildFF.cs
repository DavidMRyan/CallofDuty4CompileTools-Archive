using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallofDuty4CompileTools.src
{
    class BuildFF
    {
        public static Process LinkerPC = new Process();
        
        /// <summary>
        /// This method starts the build process for the selected map's Fast File (.ff), and Load Fast File (*_load.ff).
        /// </summary>
        public static void Start(string MapName)
        {
            Main.StaticConsoleInstance.WriteLine(".\n.\n###########################################\n\t\tBUILDING FAST FILES\n###########################################\n.\n.", Color.Beige);

            LinkerPC.StartInfo.FileName = Main.GetRootLocation() + @"\bin\linker_pc.exe";
            LinkerPC.StartInfo.WorkingDirectory = Main.GetRootLocation() + @"\bin";
            LinkerPC.StartInfo.CreateNoWindow = true;
            LinkerPC.StartInfo.UseShellExecute = false;
            LinkerPC.StartInfo.RedirectStandardOutput = true;
            LinkerPC.StartInfo.Arguments = string.Format("{0} {1}", MapName, MapName + "_load");
            LinkerPC.Start();

            StreamReader Reader = LinkerPC.StandardOutput;
            while (!Reader.EndOfStream)
                Main.StaticConsoleInstance.WriteLine(Reader.ReadLine());

            Reader.Close();
            Reader.Dispose();
            LinkerPC.Close();

            Main.StaticConsoleInstance.WriteLine(".\n.\n###########################################\n\t\t\tDONE\n###########################################\n.\n.", Color.Beige);
        }
    }
}
