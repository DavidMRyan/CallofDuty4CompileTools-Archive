using System;
using System.Threading;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Guna.UI.WinForms;
using CallofDuty4CompileTools.src;

namespace CallofDuty4CompileTools
{
    public partial class Main : Form
    {
        public static ConsoleControl.ConsoleControl StaticConsoleInstance { get; set; }
        public static GunaComboBox StaticMapComboBoxInstance { get; set; }
        public static Thread Thread { get; } = Thread.CurrentThread;
        public static Process BinProcess { get; } = new Process();

        private static RootPathPopupMenu RootPathPopup { get; } = new RootPathPopupMenu();
        private static PopupMenu Popup { get; } = new PopupMenu();

        public Main()
        {
            InitializeComponent();
            // TODO: Create Thread-Safety rather than
            // disabling these checks for illegal cross thread calls.
            // 100% memory leak :ok_hand:
            CheckForIllegalCrossThreadCalls = false;
            StaticConsoleInstance = FormConsole;
            StaticMapComboBoxInstance = MapComboBox;
            MaximizeBox = false;
            Utility.GetMaps();
            

            foreach (GunaTextBox textBox in Utility.GetAll(this, typeof(GunaTextBox)))
                textBox.ScrollToCaret();
        }

        /// <summary>
        /// Saves all of the settings to a .CSV file each time this method is called.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        public void OnChange(object sender, EventArgs e)
        {
            if (MapComboBox.SelectedItem != null)
                SaveSettingsCSV(MapComboBox.SelectedItem.ToString());
        }

        /// <summary>
        /// Clears the console each time this method is called.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void ClearConsoleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            FormConsole.ClearOutput();

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            // TODO: Create Options/Preferences UserControl
            Popup.Show();
            RootPathPopup.Show();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Show About UserControlClass
            // Github
            // Version
        }

        private void HelpToolStripMenuItem_Click(object sender, EventArgs e) =>
            Process.Start("https://docs.raid-gaming.net/");

        private void RefreshMapsButton_Click(object sender, EventArgs e)
        {
            FormConsole.WriteOutputLn("Refreshing Map List\n--------------------------------------------------", Color.CornflowerBlue);
            Utility.GetMaps();
        }

        /// <summary>
        /// Opens the Call of Duty 4 Radiant level editor.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void OpenRadiantButton_Click(object sender, EventArgs e)
        {
            BinProcess.Initialize("CoD4Radiant.exe", Utility.GetRootLocation() + @"bin\");

            if (File.Exists(BinProcess.StartInfo.FileName))
                BinProcess.Start();
            else
                StaticConsoleInstance.WriteOutputLn("Error: " + BinProcess.StartInfo.FileName + " not found!", Color.Red);
            
        }

        /// <summary>
        /// Opens the Call of Duty 4 Asset Manager.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void OpenASMButton_Click(object sender, EventArgs e)
        {
            BinProcess.Initialize("asset_manager.exe", Utility.GetRootLocation() + @"bin\");

            if (File.Exists(BinProcess.StartInfo.FileName))
                BinProcess.Start();
            else
                StaticConsoleInstance.WriteOutputLn("Error: " + BinProcess.StartInfo.FileName + " not found!", Color.Red);
        }

        /// <summary>
        /// Opens the Call of Duty 4 Effects Editor.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void OpenFXButton_Click(object sender, EventArgs e)
        {
            BinProcess.Initialize("CoD4EffectsEd.exe", Utility.GetRootLocation() + @"bin\");

            if (File.Exists(BinProcess.StartInfo.FileName))
                BinProcess.Start();
            else
                StaticConsoleInstance.WriteOutputLn("Error: " + BinProcess.StartInfo.FileName + " not found!", Color.Red);
        }

        /// <summary>
        /// If a map is selected within the 'MapComboBox' List Box, this button will run the selected map.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void RunSelectedMapButton_Click(object sender, EventArgs e)
        {
            string Map = MapComboBox.SelectedIndex < 0 ? null : MapComboBox.SelectedItem.ToString();
            string CustomArgs = MapCustomCommandLineTextBox.Text;
            bool isMultiplayerMap;

            if (MapComboBox.SelectedItem == null)
            {
                FormConsole.WriteOutputLn("Warning: No Map was Selected. Please Select a Map!", Color.Yellow);
                return;
            }
            else
                isMultiplayerMap = MapComboBox.SelectedItem.ToString().Contains("mp_");

            RunSelectedMap.Start(Map, isMultiplayerMap, EnableDeveloperCheckBox.Checked,
                EnableDeveloperScriptCheckBox.Checked, EnableCheatsCheckBox.Checked, CustomArgs);
        }

        /// <summary>
        /// This method loads the settings from the MapName.settings file.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void MapComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapComboBox.SelectedIndex > -1)
                LoadSettings(MapComboBox.SelectedItem.ToString());
            else
                FormConsole.WriteOutputLn("Warning: Couldn't load settings for " + MapComboBox.SelectedItem.ToString(), Color.Yellow);
        }

        /// <summary>
        /// This method compiles the selected map's '.d3dbsp' file for use in game.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void CompileBSPButton_Click(object sender, EventArgs e)
        {
            string MapName = MapComboBox.SelectedIndex > -1 ? Path.GetFileNameWithoutExtension(MapComboBox.SelectedItem.ToString()) : null;
            string BSPPath = Utility.GetRootLocation() + @"raw\maps\mp\" + MapName + ".d3dbsp";
            string MapLocation = Utility.GetRootLocation() + @"map_source\" + MapName + ".map";
            string BSPArgs = CustomCommandLineTextBox.Text;
            string LightArgs = CustomLightOptionsTextBox.Text;

            if (MapComboBox.SelectedItem == null)
            {
                FormConsole.WriteOutputLn("Warning: No Map was Selected. Please Select a Map!", Color.Yellow);
                return;
            }

            CompileBSP.Thread = new Thread(() => CompileBSP.Start(BSPPath, MapLocation, Utility.GetRootLocation(), MapName,
                BSPArgs, LightArgs, CompileBSPCheckBox.Checked, CompileLightingCheckBox.Checked, CompilePathsCheckBox.Checked));
            CompileBSP.Thread.Start();
        }

        /// <summary>
        /// This method compiles the selected map's reflections.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void CompileReflectionsButton_Click(object sender, EventArgs e)
        {
            string MapName = MapComboBox.SelectedIndex > 0 ?
                Path.GetFileNameWithoutExtension(MapComboBox.SelectedItem.ToString()) : null;
            bool isMultiplayerMap;

            if (MapComboBox.SelectedItem == null)
            {
                FormConsole.WriteOutputLn("Warning: No Map was Selected. Please Select a Map!", Color.Yellow);
                return;
            }
            else
                isMultiplayerMap = MapComboBox.SelectedItem.ToString().Contains("mp_");

            CompileReflections.Thread = new Thread(() => CompileReflections.Start(
                Utility.GetRootLocation(), MapName, isMultiplayerMap));
            CompileReflections.Thread.Start();
        }

        /// <summary>
        /// This method builds the selected map's Fast File (.ff), and Load Fast File (*_load.ff).
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void BuildFFButton_Click(object sender, EventArgs e)
        {
            if (MapComboBox.SelectedItem == null)
            {
                FormConsole.WriteOutputLn("Warning: No Map was Selected. Please Select a Map!", Color.Yellow);
                return;
            }

            BuildFF.Thread = new Thread(() => BuildFF.Start(MapComboBox.SelectedIndex > -1 ?
                Path.GetFileNameWithoutExtension(MapComboBox.SelectedItem.ToString()) : null));
            BuildFF.Thread.Start();
        }

        private void UpdateCSVButton_Click(object sender, EventArgs e)
        {
            if (StaticMapComboBoxInstance.SelectedIndex > -1)
            {
                string mapName = StaticMapComboBoxInstance.SelectedItem.ToString();
                string path = Utility.GetRootLocation() + @"zone_source\" +
                    mapName.Substring(0, mapName.Length - 4) + ".csv";

                // TODO: Add a way for user to allow creation of zone files if they're not found.
                if (File.Exists(path))
                    Process.Start(path);
                else
                    StaticConsoleInstance.WriteOutputLn("Warning: Couldn't find file \'" + path + "\'", Color.Yellow);
            }
            else
                StaticConsoleInstance.WriteOutputLn("Warning: No map selected, please choose a map!\n", Color.Yellow);
        }

        /// <summary>
        /// This method saves the settings for the selected map to 'MapName.settings', which can be located in @'../Call of Duty 4/bin/CoD4CompileTools/'.
        /// </summary>
        /// <param name="MapName">The name of the map who's settings will be saved.</param>
        private void SaveSettingsCSV(string MapName)
        {
            string SettingsPath = Utility.GetRootLocation() + @"bin\CoD4CompileTools\";
            string SettingsFileName = MapName.Substring(0, MapName.Length - 4);

            File.WriteAllLines(SettingsPath + SettingsFileName + ".settings",
                new string[]
                {
                    "bsp," + CompileBSPCheckBox.Checked.ToString(),
                    "light," + CompileLightingCheckBox.Checked.ToString(),
                    "paths," + CompilePathsCheckBox.Checked.ToString(),
                    "onlyents," + OnlyEntsCheckBox.Checked.ToString(),
                    "blocksize," + BlockSizeCheckBox.Checked.ToString(),
                    "blocksize_value," + BlockSizeTextBox.Text,
                    "samplescale," + SampleScaleCheckBox.Checked.ToString(),
                    "samplescale_value," + SampleScaleTextBox.Text,
                    "debugLightmaps," + DebugLightmapsCheckBox.Checked.ToString(),
                    "bspoptions," + CustomCommandLineTextBox.Text,
                    "fast," + FastCheckBox.Checked.ToString(),
                    "extra," + ExtraCheckBox.Checked.ToString(),
                    "verbose," + VerboseCheckBox.Checked.ToString(),
                    "modelshadow," + ModelShadowCheckBox.Checked.ToString(),
                    "nomodelshadow," + NoModelShadowCheckBox.Checked.ToString(),
                    "dumpoptions," + DumpOptionsCheckBox.Checked.ToString(),
                    "traces," + TracesCheckBox.Checked.ToString(),
                    "traces_value," + TracesTextBox.Text,
                    "bouncefraction," + BounceFractionCheckBox.Checked.ToString(),
                    "bouncefraction_value," + BounceFractionTextBox.Text,
                    "jitter," + JitterCheckBox.Checked.ToString(),
                    "jitter_value," + JitterTextBox.Text,
                    "lightoptions," + CustomLightOptionsTextBox.Text,
                    "developer," + EnableDeveloperCheckBox.Checked.ToString(),
                    "developer_script," + EnableDeveloperScriptCheckBox.Checked.ToString(),
                    "command_args_chk," + CustomCommandLineCheckBox.Checked.ToString(),
                    "command_args," + MapCustomCommandLineTextBox.Text,
                    "cheats," + EnableCheatsCheckBox.Checked.ToString(),
                }
            );
        }

        // TODO: Use this on MapComboBox_SelectedIndexChanged event
        /// <summary>
        /// This method loads the settings for the selected map.
        /// </summary>
        /// <param name="MapName">The name of the map who's settings will be loaded.</param>
        public void LoadSettings(string MapName)
        {
            string SettingsPath = Utility.GetRootLocation() + @"bin\CoD4CompileTools\";
            string SettingsFileName = MapName.Substring(0, MapName.Length - 4);

            GunaCheckBox[] CheckBoxes = new GunaCheckBox[]
            {
                CompileBSPCheckBox,
                CompileLightingCheckBox,
                CompilePathsCheckBox,
                OnlyEntsCheckBox,
                BlockSizeCheckBox,
                SampleScaleCheckBox,
                DebugLightmapsCheckBox,
                FastCheckBox,
                ExtraCheckBox,
                VerboseCheckBox,
                ModelShadowCheckBox,
                NoModelShadowCheckBox,
                DumpOptionsCheckBox,
                TracesCheckBox,
                BounceFractionCheckBox,
                JitterCheckBox,
                EnableDeveloperCheckBox,
                EnableDeveloperScriptCheckBox,
                CustomCommandLineCheckBox,
                EnableCheatsCheckBox
            };

            GunaTextBox[] TextBoxes = new GunaTextBox[]
            {
                BlockSizeTextBox,
                SampleScaleTextBox,
                CustomCommandLineTextBox,
                TracesTextBox,
                BounceFractionTextBox,
                JitterTextBox,
                CustomLightOptionsTextBox,
                MapCustomCommandLineTextBox
            };

            if (File.Exists(SettingsPath + SettingsFileName + ".settings"))
            {
                string[] Settings = File.ReadAllLines(SettingsPath + SettingsFileName + ".settings");
                int tickBoxIndex = 0;
                int textBoxIndex = 0;

                foreach (string Setting in Settings)
                {
                    string[] token = Setting.Split(',');
                    if (token.Length < 2)
                        continue;

                    if (bool.TryParse(token[1], out bool isChecked))
                    {
                        CheckBoxes[tickBoxIndex].Checked = isChecked;
                        tickBoxIndex++;
                    }

                    else
                    {
                        TextBoxes[textBoxIndex].Text = token[1];
                        textBoxIndex++;
                    }
                }
            }

            else
                FormConsole.WriteOutputLn("Warning: Couldn't find file \'" + SettingsFileName + ".settings" + "\'", Color.Yellow);
        }
    }
}
