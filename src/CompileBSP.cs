using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CallofDuty4CompileTools.src
{
    class CompileBSP
    {
        public static Process CoD4Map = new Process();
        public static Process CoD4Rad = new Process();
        public static Process SPTool = new Process();

        /// <summary>
        /// This method starts the compile process for the selected map's '.d3dbsp' file, for use in game.
        /// </summary>
        /// <param name="BSPPath">The path of the map's '.d3dbsp' file.</param>
        /// <param name="MapSourcePath">The path of the map's '.map' file.</param>
        /// <param name="RootPath">The root directory of the game's installation.</param>
        /// <param name="MapName">The name of the map (without file extension)</param>
        /// <param name="BSPArgs">Any additional arguments to pass the compiler, in terms of the BSP.</param>
        /// <param name="LightArgs">Any additional arguments to pass the compiler, in terms of the Lighting.</param>
        /// <param name="isCompileBSPChecked">Boolean checking if the 'CompileBSPCheckBox' is checked.</param>
        /// <param name="isCompileLightChecked">Boolean checking if the 'CompileLightsCheckBox' is checked</param>
        /// <param name="isCompilePathsChecked">Boolean checking if the 'CompilePathsCheckBox' is checked</param>
        public static void Start(string BSPPath, string MapSourcePath, string RootPath, string MapName, /*string Multiplayer,*/ string BSPArgs, string LightArgs, bool isCompileBSPChecked, bool isCompileLightChecked, bool isCompilePathsChecked)
        {
            // Handle BSP Compilation
            if (isCompileBSPChecked)
            {
                if(Main.StaticMapListBoxInstance.SelectedItem != null)
                {
                    Main.StaticConsoleInstance.WriteLine("\nCompiling BSP\n--------------------------------------------------\n");
                    if (!File.Exists(Utility.GetRootLocation() + @"raw\maps\mp\" + MapName + ".map"))
                        File.Copy(MapSourcePath, Utility.GetRootLocation() + @"raw\maps\mp\" + MapName + ".map");

                    CoD4Map.StartInfo.FileName = Utility.GetRootLocation() + @"bin\cod4map.exe";
                    CoD4Map.StartInfo.WorkingDirectory = Utility.GetRootLocation() + @"raw\maps\mp";
                    CoD4Map.StartInfo.CreateNoWindow = true;
                    CoD4Map.StartInfo.UseShellExecute = false;
                    CoD4Map.StartInfo.RedirectStandardOutput = true;
                    CoD4Map.StartInfo.Arguments = string.Format("-platform pc -loadFrom \"{0}\" {1} \"{2}\"", 
                        MapSourcePath, BSPArgs, Path.GetFileNameWithoutExtension(BSPPath));
                    CoD4Map.Start();

                    StreamReader Reader = CoD4Map.StandardOutput;
                    while(!Reader.EndOfStream)
                        Main.StaticConsoleInstance.WriteLine(Reader.ReadLine());
                        
                    Reader.Close();
                    Reader.Dispose();
                    CoD4Map.Close();
                }
                else
                {
                    Main.StaticConsoleInstance.WriteLine("Warning: No Map was Selected. Please Select a Map!", Color.Yellow);
                    return;
                }
            }

            // Handle Light Compilation
            if (isCompileLightChecked)
            {
                Main.StaticConsoleInstance.WriteLine("\nCompiling Lighting\n--------------------------------------------------\n");
                if (File.Exists(Path.GetFileNameWithoutExtension(MapSourcePath) + ".grid"))
                {
                    File.Copy(Path.GetFileNameWithoutExtension(MapSourcePath) + ".grid",
                        Path.GetFileNameWithoutExtension(BSPPath) + ".grid");
                }

                CoD4Rad.StartInfo.FileName = Utility.GetRootLocation() + @"bin\cod4rad.exe";
                CoD4Rad.StartInfo.WorkingDirectory = Utility.GetRootLocation() + @"raw\maps\mp";
                CoD4Rad.StartInfo.CreateNoWindow = true;
                CoD4Rad.StartInfo.UseShellExecute = false;
                CoD4Rad.StartInfo.RedirectStandardOutput = true;
                CoD4Rad.StartInfo.Arguments = string.Format("-platform pc {0} \"{1}\"",
                    LightArgs, Path.GetFileNameWithoutExtension(BSPPath));
                CoD4Rad.Start();

                StreamReader Reader = CoD4Rad.StandardOutput;
                while(!Reader.EndOfStream)
                    Main.StaticConsoleInstance.WriteLine(Reader.ReadLine());

                Reader.Close();
                Reader.Dispose();
                CoD4Rad.Close();
            }

            string[] DelSearchPatterns = new string[] { ".map", ".d3dprt", ".d3dpoly", ".vclog", ".grid"};
            List<string> FilesToDelete = Directory.GetFiles(Utility.GetRootLocation() + @"raw\maps\mp\", "*.*")
                    .Where(item => DelSearchPatterns.Any(format => Regex.IsMatch(item, format + "$"))).ToList();

            foreach (string file in FilesToDelete ?? Enumerable.Empty<string>())
            {
                if (File.Exists(file))
                    File.Delete(file);
            }

            if (File.Exists(Path.GetFileNameWithoutExtension(BSPPath) + ".lin"))
            {
                File.Move(Path.GetFileNameWithoutExtension(BSPPath) + ".lin",
                    Path.GetFileNameWithoutExtension(MapSourcePath) + ".lin");
            }

            // Handle Path Compiliation
            if(isCompilePathsChecked)
            {
                Main.StaticConsoleInstance.WriteLine("\nCompiling Paths\n--------------------------------------------------\n");
                
                SPTool.StartInfo.FileName = Utility.GetRootLocation() + @"bin\sp_tool.exe";
                SPTool.StartInfo.WorkingDirectory = Utility.GetRootLocation();
                SPTool.StartInfo.CreateNoWindow = true;
                SPTool.StartInfo.UseShellExecute = false;
                SPTool.StartInfo.RedirectStandardOutput = true;
                SPTool.StartInfo.Arguments = string.Format("+set r_fullscreen 0 +set logfile 2 +set monkeytoy 0 " +
                    "+set com_introplayed 1 +set usefastfile 0 +set g_connectpaths 2 +devmap {0}", MapName);
                SPTool.Start();

                StreamReader Reader = SPTool.StandardOutput;
                while(!Reader.EndOfStream)
                    Main.StaticConsoleInstance.WriteLine(Reader.ReadLine());

                Reader.Close();
                Reader.Dispose();
                SPTool.Close();
            }

            Main.StaticConsoleInstance.WriteLine("\nFinished\n--------------------------------------------------\n");
        }
    }
}