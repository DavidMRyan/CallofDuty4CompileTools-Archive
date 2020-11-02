using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsForm.Console;

using CallofDuty4CompileTools.src;

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
            CheckForIllegalCrossThreadCalls = false;
            StaticConsoleInstance = FormConsole;
            StaticMapListBoxInstance = MapsListBox;
            MaximizeBox = false;
        }

        /// <summary>
        /// Saves all of the settings to a .CSV file each time this method is called.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        public void onChange(object sender, EventArgs e)
        {
            if (MapsListBox.SelectedItem != null)
                SaveSettingsCSV(MapsListBox.SelectedItem.ToString());
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
            FormConsole.WriteLine("Refreshing Map List...\n=================================================");
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
            BinProcess.Start();
        }

        /// <summary>
        /// Opens the Call of Duty 4 Asset Manager.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void OpenASMButton_Click(object sender, EventArgs e)
        {
            BinProcess.Initialize("asset_manager.exe", Utility.GetRootLocation() + @"bin\");
            BinProcess.Start();
        }

        /// <summary>
        /// Opens the Call of Duty 4 Effects Editor.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void OpenFXButton_Click(object sender, EventArgs e)
        {
            BinProcess.Initialize("CoD4EffectsEd.exe", Utility.GetRootLocation() + @"bin\");
            BinProcess.Start();
        }

        /// <summary>
        /// If a map is selected within the 'MapsListBox' List Box, this button will run the selected map.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void RunSelectedMapButton_Click(object sender, EventArgs e)
        {
            string Map = MapsListBox.SelectedIndex < 0 ? null : MapsListBox.SelectedItem.ToString();
            string CustomArgs = MapCustomCommandLineTextBox.Text;
            bool isMultiplayerMap;

            if (MapsListBox.SelectedItem == null)
            {
                FormConsole.WriteLine("Warning: No Map was Selected. Please Select a Map!", Color.Yellow);
                return;
            }
            else
                isMultiplayerMap = MapsListBox.SelectedItem.ToString().Contains("mp_");

            RunSelectedMap.Start(Map, isMultiplayerMap, EnableDeveloperCheckBox.Checked,
                EnableDeveloperScriptCheckBox.Checked, EnableCheatsCheckBox.Checked, CustomArgs);
        }

        /// <summary>
        /// This method loads the settings from the MapName.settings file.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void MapsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MapsListBox.SelectedIndex > -1)
                LoadSettings(MapsListBox.SelectedItem.ToString());
            else
                FormConsole.WriteLine("Warning: Couldn't load settings for " + MapsListBox.SelectedItem.ToString(), Color.Yellow);
        }

        /// <summary>
        /// This method compiles the selected map's '.d3dbsp' file for use in game.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void CompileBSPButton_Click(object sender, EventArgs e)
        {
            string MapName = MapsListBox.SelectedIndex > -1 ? Path.GetFileNameWithoutExtension(MapsListBox.SelectedItem.ToString()) : null;
            string BSPPath = Utility.GetRootLocation() + @"raw\maps\mp\" + MapName + ".d3dbsp";
            string MapLocation = Utility.GetRootLocation() + @"map_source\" + MapName + ".map";
            string BSPArgs = CustomCommandLineTextBox.Text;
            string LightArgs = CustomLightOptionsTextBox.Text;

            if (MapsListBox.SelectedItem == null)
            {
                FormConsole.WriteLine("Warning: No Map was Selected. Please Select a Map!", Color.Yellow);
                return;
            }

            CompileBSP.Start(BSPPath, MapLocation, Utility.GetRootLocation(), MapName, BSPArgs,
                LightArgs, CompileBSPCheckBox.Checked, CompileLightingCheckBox.Checked, CompilePathsCheckBox.Checked);
        }

        /// <summary>
        /// This method compiles the selected map's reflections.
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void CompileReflectionsButton_Click(object sender, EventArgs e)
        {
            string MapName = MapsListBox.SelectedIndex > 0 ?
                Path.GetFileNameWithoutExtension(MapsListBox.SelectedItem.ToString()) : null;
            bool isMultiplayerMap;

            if (MapsListBox.SelectedItem == null)
            {
                FormConsole.WriteLine("Warning: No Map was Selected. Please Select a Map!", Color.Yellow);
                return;
            }
            else
                isMultiplayerMap = MapsListBox.SelectedItem.ToString().Contains("mp_");

            CompileReflections.Start(Utility.GetRootLocation(), MapName, isMultiplayerMap);
        }

        /// <summary>
        /// This method builds the selected map's Fast File (.ff), and Load Fast File (*_load.ff).
        /// </summary>
        /// <param name="sender">The Object which triggered the event.</param>
        /// <param name="e">The event which has been triggered.</param>
        private void BuildFFButton_Click(object sender, EventArgs e)
        {
            if (MapsListBox.SelectedItem == null)
            {
                FormConsole.WriteLine("Warning: No Map was Selected. Please Select a Map!", Color.Yellow);
                return;
            }

            BuildFF.Start(MapsListBox.SelectedIndex > -1 ?
                Path.GetFileNameWithoutExtension(MapsListBox.SelectedItem.ToString()) : null);
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

        /// <summary>
        /// This method loads the settings for the selected map.
        /// </summary>
        /// <param name="MapName">The name of the map who's settings will be loaded.</param>
        public void LoadSettings(string MapName)
        {
            string SettingsPath = Utility.GetRootLocation() + @"bin\CoD4CompileTools\";
            string SettingsFileName = MapName.Substring(0, MapName.Length - 4);

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
                FormConsole.WriteLine("Warning: Couldn't find file \'" + SettingsPath + SettingsFileName + ".settings" + "\'", Color.Yellow);
        }
    }
}
