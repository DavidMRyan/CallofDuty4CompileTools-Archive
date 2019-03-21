using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CallofDuty4CompileTools.src;
using Microsoft.Win32;
using WindowsForm.Console;

namespace CallofDuty4CompileTools
{
    public partial class Main : Form
    {
        PopupMenu Popup = new PopupMenu();
        Process BinProcess = new Process();
        public static FConsole StaticConsoleInstance;
        public static ListBox StaticMapListBoxInstance;

        public Main()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; // This is important for async access to thread.
            StaticConsoleInstance = FormConsole;
            StaticMapListBoxInstance = MapsListBox;
            MaximizeBox = false;
        }

        /// <summary>
        /// Gets a registry value, containing the path of the user's Call of Duty 4 root directory.
        /// </summary>
        /// <returns>The value of the registry containing the game's path.</returns>
        public static string GetRootLocation() =>
            (string)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Call of Duty 4 Compile Tools", "RootPath", null);

        /// <summary>
        /// Gets all of the '.map' files located in the root directory's '/map_source/' sub directory.
        /// </summary>
        public void GetMaps()
        {
            string[] maps = Directory.GetFiles(GetRootLocation() + @"\map_source\", "*.map", SearchOption.TopDirectoryOnly);
            MapsListBox.Items.Clear();
            foreach (string map in maps)
            {
                FormConsole.WriteLine(map, Color.LightGreen);
                MapsListBox.Items.Add(Path.GetFileName(map));
            }
        }

        /// <summary>
        /// Saves all of the settings to a .CSV file each time this method is called.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        public void onChange(object sender, EventArgs e)
        {
            if (MapsListBox.SelectedItem != null) HandleSettingsCSV(MapsListBox.SelectedItem.ToString());
            else return;
        }

        /// <summary>
        /// Clears the console each time this method is called.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void ClearConsoleLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) =>
            FormConsole.Clear();

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            // Open the Options Menu
        }

        private void RootPathButton_Click(object sender, EventArgs e)
        {
            RootPathPopupMenu RootPathPopup = new RootPathPopupMenu();
            Popup.Show();
            RootPathPopup.Show();
        }

        private void RefreshMapsButton_Click(object sender, EventArgs e)
        {
            // FormConsole.Clear();
            FormConsole.WriteLine("Refreshing Map List...\n=================================================", Color.LightGreen);
            GetMaps();
        }

        /// <summary>
        /// Opens the Call of Duty 4 Radiant level editor.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void OpenRadiantButton_Click(object sender, EventArgs e)
        {
            BinProcess.StartInfo.FileName = GetRootLocation() + @"\bin\CoD4Radiant.exe";
            BinProcess.StartInfo.WorkingDirectory = GetRootLocation() + @"\bin\";
            BinProcess.StartInfo.UseShellExecute = true;
            BinProcess.Start();
        }

        /// <summary>
        /// Opens the Call of Duty 4 Asset Manager.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void OpenASMButton_Click(object sender, EventArgs e)
        {
            BinProcess.StartInfo.FileName = GetRootLocation() + @"\bin\asset_manager.exe";
            BinProcess.StartInfo.WorkingDirectory = GetRootLocation() + @"\bin\";
            BinProcess.StartInfo.UseShellExecute = true;
            BinProcess.Start();
        }

        /// <summary>
        /// Opens the Call of Duty 4 Effects Editor.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void OpenFXButton_Click(object sender, EventArgs e)
        {
            BinProcess.StartInfo.FileName = GetRootLocation() + @"\bin\CoD4EffectsEd.exe";
            BinProcess.StartInfo.WorkingDirectory = GetRootLocation() + @"\bin\";
            BinProcess.StartInfo.UseShellExecute = true;
            BinProcess.Start();
        }

        /// <summary>
        /// If a map is selected within the 'MapsListBox' List Box, this button will run the selected map.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void RunSelectedMapButton_Click(object sender, EventArgs e)
        {
            string Map = MapsListBox.SelectedIndex < 0 ? null : MapsListBox.SelectedItem.ToString(),
                   CustomArgs = CustomCommandLineCheckBox.Checked ? MapCustomCommandLineTextBox.Text : null,
                   isMpMap;

            if (MapsListBox.SelectedItem == null) { FormConsole.WriteLine("Warning: No Map was Selected. Please Select a Map!", Color.Yellow); return; }
            else isMpMap = MapsListBox.SelectedItem.ToString().Contains("mp_") ? "1" : "0";
            RunSelectedMap.Start(GetRootLocation(), Map, isMpMap, EnableDeveloperCheckBox.Checked, EnableDeveloperScriptCheckBox.Checked, EnableCheatsCheckBox.Checked, CustomArgs);
        }

        /// <summary>
        /// This method loads the settings from the MapName.settings file.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void MapsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapsListBox.SelectedIndex > -1) LoadSettings(MapsListBox.SelectedItem.ToString());
            else { FormConsole.WriteLine("Error: Couldn't load settings for " + MapsListBox.SelectedItem.ToString(), Color.Red); return; }
        }

        /// <summary>
        /// This method compiles the selected map's '.d3dbsp' file for use in game.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void CompileBSPButton_Click(object sender, EventArgs e)
        {
            string MapName = MapsListBox.SelectedIndex > -1 ? Path.GetFileNameWithoutExtension(MapsListBox.SelectedItem.ToString()) : null,
                   BSPPath = GetRootLocation() + @"\raw\maps\mp\" + MapName + ".d3dbsp",
                   MapLocation = GetRootLocation() + @"\map_source\" + MapName + ".map",
                   BSPArgs = CustomCommandLineTextBox == null ? null : CustomCommandLineTextBox.Text,
                   LightArgs = CustomLightOptionsTextBox == null ? null : CustomLightOptionsTextBox.Text;

            CompileBSP.Start(BSPPath, MapLocation, GetRootLocation(), MapName, BSPArgs, LightArgs, CompileBSPCheckBox.Checked, CompileLightingCheckBox.Checked, CompilePathsCheckBox.Checked);
        }

        /// <summary>
        /// This method compiles the selected map's reflections.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void CompileReflectionsButton_Click(object sender, EventArgs e)
        {
            string MapName = MapsListBox.SelectedIndex > 0 ? Path.GetFileNameWithoutExtension(MapsListBox.SelectedItem.ToString()) : null,
                   isMpMap;

            if (MapsListBox.SelectedItem == null) { FormConsole.WriteLine("Warning: No Map was Selected. Please Select a Map!", Color.Yellow); return; }
            else isMpMap = MapsListBox.SelectedItem.ToString().Contains("mp_") ? "1" : "0";
            CompileReflections.Start(GetRootLocation(), MapName, isMpMap);
        }

        /// <summary>
        /// This method builds the selected map's Fast File (.ff), and Load Fast File (*_load.ff).
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void BuildFFButton_Click(object sender, EventArgs e) =>
            BuildFF.Start(MapsListBox.SelectedIndex > -1 ? Path.GetFileNameWithoutExtension(MapsListBox.SelectedItem.ToString()) : null);

        /// <summary>
        /// This method saves the settings for the selected map to 'MapName.settings', which can be located in @'../Call of Duty 4/bin/CoD4CompileTools/'.
        /// </summary>
        /// <param name="MapName">The name of the map who's settings will be saved.</param>
        private void HandleSettingsCSV(string MapName)
        {
            string SettingsPath = GetRootLocation() + @"\bin\CoD4CompileTools",
                   SettingsFileName = MapName.Substring(0, MapName.Length - 4);

            File.WriteAllLines(SettingsPath + @"\" + SettingsFileName + ".settings",
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

        /// <summary>
        /// This method loads the settings for the selected map.
        /// </summary>
        /// <param name="MapName">The name of the map who's settings will be loaded.</param>
        public void LoadSettings(string MapName)
        {
            string SettingsPath = GetRootLocation() + @"\bin\CoD4CompileTools",
                   SettingsFileName = MapName.Substring(0, MapName.Length - 4);

            CheckBox[] CheckBoxes = new CheckBox[] 
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

            TextBox[] TextBoxes = new TextBox[]
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

            if (File.Exists(SettingsPath + @"\" + SettingsFileName + ".settings"))
            {
                string[] Settings = File.ReadAllLines(SettingsPath + @"\" + SettingsFileName + ".settings");
                int tickBoxIndex = 0,
                    textBoxIndex = 0;
                foreach (string Setting in Settings)
                {
                    string[] token = Setting.Split(',');
                    if (token.Length < 2) continue;
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

            else FormConsole.WriteLine("Error: Couldn't find file \'" + SettingsPath + @"\" + SettingsFileName + ".settings" + "\'", Color.Red);
        }
    }
}
