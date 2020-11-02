using Microsoft.Win32;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using WindowsForm.Console;

namespace CallofDuty4CompileTools
{
    static class Utility
    {
        /// <summary>
        /// Gets a registry value containing the path of the user's Call of Duty 4 root directory.
        /// </summary>
        /// <returns>The string value of the registry entry containing the user's game root directory.</returns>
        public static string GetRootLocation() =>
            (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Call of Duty 4 Compile Tools", "RootPath", null);

        /// <summary>
        /// Initializes the process that is passed with the specified start information.
        /// Example of calling this method: exampleProcess.Initialize("application.exe", "path\to\working\directory\");
        /// </summary>
        /// <param name="proc">Process variable</param>
        /// <param name="fileName">Name of the file (Sets 'StartInfo.FileName')</param>
        /// <param name="workingDirectory">Path to the Working Directory (Sets StartInfo.WorkingDirectory)</param>
        /// <param name="arguments">Additional arguments to pass to the process' start info (Sets StartInfo.Arguments)</param>
        public static void Initialize(this Process proc, string fileName, string workingDirectory, string arguments = null)
        {
            if(Directory.Exists(workingDirectory))
            {
                proc.StartInfo.FileName = workingDirectory + fileName;
                proc.StartInfo.WorkingDirectory = workingDirectory;
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.Arguments = arguments;
            }
            else
                Main.StaticConsoleInstance.WriteLine(workingDirectory + "  not Found! Make sure you've specified your game's root path, and installed the Call of Duty 4 Mod Tools!", Color.Red);    
        }

        /// <summary>
        /// Gets all of the '.map' files located in the root directory's '/map_source/' sub directory.
        /// </summary>
        public static void GetMaps()
        {
            string workingDirectory = GetRootLocation() + @"map_source\";

            if (Directory.Exists(workingDirectory))
            {
                string[] maps = Directory.GetFiles(workingDirectory, "*.map",
                    SearchOption.TopDirectoryOnly);
                Main.StaticMapListBoxInstance.Items.Clear();

                foreach (string map in maps)
                {
                    Main.StaticConsoleInstance.WriteLine(map);
                    Main.StaticMapListBoxInstance.Items.Add(Path.GetFileName(map));
                }
            }
            else
                Main.StaticConsoleInstance.WriteLine(workingDirectory + " not Found! Make sure you've specified your game's root path, and installed the Call of Duty 4 Mod Tools!", Color.Red);
        }
    }
}
