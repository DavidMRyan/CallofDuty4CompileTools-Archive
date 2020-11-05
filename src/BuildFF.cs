using System.Diagnostics;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Threading;

namespace CallofDuty4CompileTools.src
{
    public static class BuildFF
    {
        public static Thread Thread { get; set; }
        public static Process LinkerPC { get; } = new Process();
        
        /// <summary>
        /// This method starts the build process for the selected map's Fast File (.ff), and Load Fast File (*_load.ff).
        /// </summary>
        public static void Start(string MapName)
        {
            Main.StaticConsoleInstance.WriteOutputLn("\nBuilding Fast Files\n--------------------------------------------------", Color.Green);

            LinkerPC.StartInfo.FileName = Utility.GetRootLocation() + @"bin\linker_pc.exe";
            LinkerPC.StartInfo.WorkingDirectory = Utility.GetRootLocation() + @"bin";
            LinkerPC.StartInfo.CreateNoWindow = true;
            LinkerPC.StartInfo.UseShellExecute = false;
            LinkerPC.StartInfo.Arguments = string.Format("{0} {1}", MapName, MapName + "_load");
            LinkerPC.StartInfo.RedirectStandardOutput = true;

            if (File.Exists(LinkerPC.StartInfo.FileName))
            {
                LinkerPC.Start();

                StreamReader Reader = LinkerPC.StandardOutput;
                while (!Reader.EndOfStream)
                    Main.StaticConsoleInstance.WriteOutputLn(Reader.ReadLine());

                Reader.Close();
                Reader.Dispose();
                LinkerPC.Close();
            }
            else
                Main.StaticConsoleInstance.WriteOutputLn("Error: " + LinkerPC.StartInfo.FileName + " not found!", Color.Red);

            Main.StaticConsoleInstance.WriteOutputLn("\nFinished\n--------------------------------------------------\n", Color.Green);
            Thread.Abort();
        }
    }
}
