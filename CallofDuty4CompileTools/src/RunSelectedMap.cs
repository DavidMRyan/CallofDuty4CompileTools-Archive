using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallofDuty4CompileTools
{
    class RunSelectedMap
    {
        public static Process GameClient = new Process();

        /// <summary>
        /// This method starts the selected map in the game client.
        /// </summary>
        /// <param name="RootPath">The root directory of the game's installation.</param>
        /// <param name="MapName">The name of the map (without file extension)</param>
        /// <param name="Multiplayer">String value of either "1" or "0" determining if the map is meant for Single Player, or Multiplayer.</param>
        /// <param name="Args">The arguments passed to the game client, if the 'CustomCommandLineCheckBox' is checked, which are defined by whatever string is inside the 'MapCustomCommandLineTextBox' Text Box.</param>
        public static void Start(string RootPath, string MapName, string Multiplayer, bool isDeveloperChecked, bool isDeveloperScriptChecked, bool isCheatsChecked, string Args)
        {
            bool MpMap = Multiplayer == "1" ? true : false;
            string Executable = MpMap == true ? "iw3mp.exe" : "iw3sp.exe",
                   Developer = isDeveloperChecked ? "+developer 1" : null, 
                   DeveloperScript = isDeveloperScriptChecked ? "+developer_script 1" : null, 
                   Cheats = isCheatsChecked ? "+set sv_cheats 1" : null;
            
            GameClient.StartInfo.FileName = RootPath + @"\" + Executable;
            GameClient.StartInfo.WorkingDirectory = RootPath;
            GameClient.StartInfo.UseShellExecute = true;
            GameClient.StartInfo.Arguments = string.Format("{0} {1} {2} {3} +devmap {4}", Developer, DeveloperScript, Cheats, Args, MapName.Substring(0, MapName.Length - 4));
            GameClient.StartInfo.CreateNoWindow = false;
            GameClient.Start();

            Main.StaticConsoleInstance.WriteLine(Executable + " " + GameClient.StartInfo.Arguments);
        }
    }
}
