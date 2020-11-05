using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CallofDuty4CompileTools
{
    public static class Utility
    {
        /// <summary>
        /// Gets a registry value containing the path of the user's Call of Duty 4 root directory.
        /// </summary>
        /// <returns>The string value of the registry entry containing the user's game root directory.</returns>
        public static string GetRootLocation() =>
            (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Call of Duty 4 Compile Tools", "RootPath", null);

        public static void WriteOutputLn(this ConsoleControl.ConsoleControl console, string message) =>
            console.WriteOutput(message + Environment.NewLine, Color.White);

        public static void WriteOutputLn(this ConsoleControl.ConsoleControl console, string message, Color color) =>
            console.WriteOutput(message + Environment.NewLine, color);

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
                Main.StaticConsoleInstance.WriteOutputLn(workingDirectory + "  not Found! Make sure you've specified your game's root path, and installed the Call of Duty 4 Mod Tools!", Color.Red);    
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

                if(Main.StaticMapComboBoxInstance.Items.Count > 0)
                    Main.StaticMapComboBoxInstance.Items.Clear();

                foreach (string map in maps)
                {
                    Main.StaticConsoleInstance.WriteOutputLn(Path.GetFileName(map));
                    Main.StaticMapComboBoxInstance.Items.Add(Path.GetFileName(map));
                }
            }
            else
                Main.StaticConsoleInstance.WriteOutputLn(workingDirectory + " not Found! Make sure you've specified your game's root path, and installed the Call of Duty 4 Mod Tools!", Color.Red);
        }

        public static IEnumerable<Control> GetAll(Control control, Type type)
        {
            var controls = control.Controls.Cast<Control>();

            return controls.SelectMany(ctrl => GetAll(ctrl, type))
                .Concat(controls).Where(c => c.GetType() == type);
        }
    }
}
