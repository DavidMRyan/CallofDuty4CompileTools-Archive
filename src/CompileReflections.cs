using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading;

namespace CallofDuty4CompileTools.src
{
    public static class CompileReflections
    {
        public static Thread Thread { get; set; }
        public static Process ToolProcess { get; } = new Process();

        /// <summary>
        /// This method starts the compile process for the selected map's reflection probes.
        /// </summary>
        /// <param name="RootPath">The root directory of the game's installation.</param>
        /// <param name="MapName">The name of the map (without file extension)</param>
        /// <param name="Multiplayer">String value of either "1" or "0" determining if the map is meant for Single Player, or Multiplayer.</param>
        public static void Start(string RootPath, string MapName, bool isMultiplayerMap)
        {
            string ExecutableFileName = isMultiplayerMap ? @"mp_tool.exe" : @"sp_tool.exe";
            
            ToolProcess.StartInfo.FileName = RootPath + @"\" + ExecutableFileName;
            ToolProcess.StartInfo.WorkingDirectory = RootPath;
            ToolProcess.StartInfo.CreateNoWindow = false;
            ToolProcess.StartInfo.Arguments = ExecutableFileName == "mp_tool.exe"
                ? string.Format("+set fs_gamemode war +set g_gametype war +set r_fullscreen 0 +set loc_warnings 0 +set +set developer 1 +set logfile 2 +set thereisacow 1337 +set sv_pure 0 +set com_introplayed 1 +set useFastFile 0 +set ui_autoContinue 1 +set r_reflectionProbeGenerateExit 1+set com_hunkMegs 512 +set r_reflectionProbeRegenerateAll 1 +set r_dof_enable 0 +set r_zFeather 1 +set sys_smp_allowed 0 +set r_reflectionProbeGenerate 1 +devmap {0}", MapName)
                : string.Format("+ set r_fullscreen 0 + set loc_warnings 0 + set + set developer 1 + set logfile 2 + set thereisacow 1337 + set com_introplayed 1 + set useFastFile 0 + set ui_autoContinue 1 + set r_reflectionProbeGenerateExit 1 + set com_hunkMegs 512 + set r_reflectionProbeRegenerateAll 1 + set r_dof_enable 0 + set r_zFeather 1 + set sys_smp_allowed 0 + set r_reflectionProbeGenerate 1 + devmap {0}", MapName);

            if (File.Exists(ToolProcess.StartInfo.FileName))
                ToolProcess.Start();
            else
                Main.StaticConsoleInstance.WriteOutputLn("Error: " + ToolProcess.StartInfo.FileName + " not found!", Color.Red);

            Thread.Abort();
        }
    }
}
