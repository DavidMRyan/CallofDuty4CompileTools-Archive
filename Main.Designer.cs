namespace CallofDuty4CompileTools
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnableDeveloperScriptCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.CustomCommandLineCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.EnableCheatsCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.EnableDeveloperCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.MapCustomCommandLineTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.MapSelectionLabel = new System.Windows.Forms.Label();
            this.ClearConsoleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.RunSelectedMapButton = new System.Windows.Forms.Button();
            this.UpdateCSVButton = new System.Windows.Forms.Button();
            this.BuildFFButton = new System.Windows.Forms.Button();
            this.CompileReflectionsButton = new System.Windows.Forms.Button();
            this.CompileBSPButton = new System.Windows.Forms.Button();
            this.RefreshMapsButton = new System.Windows.Forms.Button();
            this.MapComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.MenuStrip = new DarkUI.Controls.DarkMenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenRadiantButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenASMButton = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenFXButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.OptionsButton = new System.Windows.Forms.ToolStripMenuItem();
            this.TabControl = new Manina.Windows.Forms.TabControl();
            this.BSPTab = new Manina.Windows.Forms.Tab();
            this.CompilePathsCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.CompileLightingCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.CompileBSPCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.SampleScaleTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.BlockSizeTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.CustomCommandLineTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaSeparator2 = new Guna.UI.WinForms.GunaSeparator();
            this.CustomCommandLineLabel = new System.Windows.Forms.Label();
            this.DebugLightmapsCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.SampleScaleCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.BlockSizeCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.OnlyEntsCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.LightingTab = new Manina.Windows.Forms.Tab();
            this.VerboseCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.ExtraCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.CustomLightOptionsTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaSeparator3 = new Guna.UI.WinForms.GunaSeparator();
            this.label2 = new System.Windows.Forms.Label();
            this.FastCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.RunTab = new Manina.Windows.Forms.Tab();
            this.gunaSeparator1 = new Guna.UI.WinForms.GunaSeparator();
            this.FormConsole = new ConsoleControl.ConsoleControl();
            this.ModelShadowCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.DumpOptionsCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.NoModelShadowCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.JitterCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.BounceFractionCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.TracesCheckBox = new Guna.UI.WinForms.GunaCheckBox();
            this.BounceFractionTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.TracesTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.JitterTextBox = new Guna.UI.WinForms.GunaTextBox();
            this.MenuStrip.SuspendLayout();
            this.TabControl.SuspendLayout();
            this.BSPTab.SuspendLayout();
            this.LightingTab.SuspendLayout();
            this.RunTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // EnableDeveloperScriptCheckBox
            // 
            this.EnableDeveloperScriptCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EnableDeveloperScriptCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EnableDeveloperScriptCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EnableDeveloperScriptCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.EnableDeveloperScriptCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.EnableDeveloperScriptCheckBox.Location = new System.Drawing.Point(3, 29);
            this.EnableDeveloperScriptCheckBox.Name = "EnableDeveloperScriptCheckBox";
            this.EnableDeveloperScriptCheckBox.Radius = 0;
            this.EnableDeveloperScriptCheckBox.Size = new System.Drawing.Size(152, 20);
            this.EnableDeveloperScriptCheckBox.TabIndex = 59;
            this.EnableDeveloperScriptCheckBox.Text = "Enable Developer Script";
            this.EnableDeveloperScriptCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // CustomCommandLineCheckBox
            // 
            this.CustomCommandLineCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CustomCommandLineCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CustomCommandLineCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CustomCommandLineCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CustomCommandLineCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CustomCommandLineCheckBox.Location = new System.Drawing.Point(3, 176);
            this.CustomCommandLineCheckBox.Name = "CustomCommandLineCheckBox";
            this.CustomCommandLineCheckBox.Radius = 0;
            this.CustomCommandLineCheckBox.Size = new System.Drawing.Size(229, 20);
            this.CustomCommandLineCheckBox.TabIndex = 58;
            this.CustomCommandLineCheckBox.Text = "Use Custom Command Line Arguments";
            this.CustomCommandLineCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // EnableCheatsCheckBox
            // 
            this.EnableCheatsCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EnableCheatsCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EnableCheatsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EnableCheatsCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.EnableCheatsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.EnableCheatsCheckBox.Location = new System.Drawing.Point(239, 7);
            this.EnableCheatsCheckBox.Name = "EnableCheatsCheckBox";
            this.EnableCheatsCheckBox.Radius = 0;
            this.EnableCheatsCheckBox.Size = new System.Drawing.Size(104, 20);
            this.EnableCheatsCheckBox.TabIndex = 57;
            this.EnableCheatsCheckBox.Text = "Enable Cheats";
            this.EnableCheatsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // EnableDeveloperCheckBox
            // 
            this.EnableDeveloperCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.EnableDeveloperCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EnableDeveloperCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.EnableDeveloperCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.EnableDeveloperCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.EnableDeveloperCheckBox.Location = new System.Drawing.Point(3, 6);
            this.EnableDeveloperCheckBox.Name = "EnableDeveloperCheckBox";
            this.EnableDeveloperCheckBox.Radius = 0;
            this.EnableDeveloperCheckBox.Size = new System.Drawing.Size(120, 20);
            this.EnableDeveloperCheckBox.TabIndex = 56;
            this.EnableDeveloperCheckBox.Text = "Enable Developer";
            this.EnableDeveloperCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // MapCustomCommandLineTextBox
            // 
            this.MapCustomCommandLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MapCustomCommandLineTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MapCustomCommandLineTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MapCustomCommandLineTextBox.BorderSize = 1;
            this.MapCustomCommandLineTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MapCustomCommandLineTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MapCustomCommandLineTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MapCustomCommandLineTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.MapCustomCommandLineTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MapCustomCommandLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.MapCustomCommandLineTextBox.Location = new System.Drawing.Point(3, 202);
            this.MapCustomCommandLineTextBox.Name = "MapCustomCommandLineTextBox";
            this.MapCustomCommandLineTextBox.PasswordChar = '\0';
            this.MapCustomCommandLineTextBox.Size = new System.Drawing.Size(340, 26);
            this.MapCustomCommandLineTextBox.TabIndex = 55;
            this.MapCustomCommandLineTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // MapSelectionLabel
            // 
            this.MapSelectionLabel.AutoSize = true;
            this.MapSelectionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MapSelectionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.MapSelectionLabel.Location = new System.Drawing.Point(11, 31);
            this.MapSelectionLabel.Name = "MapSelectionLabel";
            this.MapSelectionLabel.Size = new System.Drawing.Size(86, 15);
            this.MapSelectionLabel.TabIndex = 54;
            this.MapSelectionLabel.Text = "Selected Map:";
            // 
            // ClearConsoleLinkLabel
            // 
            this.ClearConsoleLinkLabel.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ClearConsoleLinkLabel.AutoSize = true;
            this.ClearConsoleLinkLabel.BackColor = System.Drawing.Color.Transparent;
            this.ClearConsoleLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ClearConsoleLinkLabel.LinkColor = System.Drawing.SystemColors.Window;
            this.ClearConsoleLinkLabel.Location = new System.Drawing.Point(768, 481);
            this.ClearConsoleLinkLabel.Name = "ClearConsoleLinkLabel";
            this.ClearConsoleLinkLabel.Size = new System.Drawing.Size(84, 15);
            this.ClearConsoleLinkLabel.TabIndex = 53;
            this.ClearConsoleLinkLabel.TabStop = true;
            this.ClearConsoleLinkLabel.Text = "Clear Console";
            this.ClearConsoleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearConsoleLinkLabel_LinkClicked);
            // 
            // RunSelectedMapButton
            // 
            this.RunSelectedMapButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RunSelectedMapButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RunSelectedMapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunSelectedMapButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunSelectedMapButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.RunSelectedMapButton.Location = new System.Drawing.Point(14, 439);
            this.RunSelectedMapButton.Name = "RunSelectedMapButton";
            this.RunSelectedMapButton.Size = new System.Drawing.Size(349, 38);
            this.RunSelectedMapButton.TabIndex = 52;
            this.RunSelectedMapButton.Text = "Run Selected Map";
            this.RunSelectedMapButton.UseVisualStyleBackColor = false;
            this.RunSelectedMapButton.Click += new System.EventHandler(this.RunSelectedMapButton_Click);
            // 
            // UpdateCSVButton
            // 
            this.UpdateCSVButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.UpdateCSVButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.UpdateCSVButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpdateCSVButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.UpdateCSVButton.Location = new System.Drawing.Point(14, 406);
            this.UpdateCSVButton.Name = "UpdateCSVButton";
            this.UpdateCSVButton.Size = new System.Drawing.Size(349, 23);
            this.UpdateCSVButton.TabIndex = 51;
            this.UpdateCSVButton.Text = "Update CSV";
            this.UpdateCSVButton.UseVisualStyleBackColor = false;
            // 
            // BuildFFButton
            // 
            this.BuildFFButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BuildFFButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BuildFFButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BuildFFButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BuildFFButton.Location = new System.Drawing.Point(14, 377);
            this.BuildFFButton.Name = "BuildFFButton";
            this.BuildFFButton.Size = new System.Drawing.Size(349, 23);
            this.BuildFFButton.TabIndex = 50;
            this.BuildFFButton.Text = "Build Fast File";
            this.BuildFFButton.UseVisualStyleBackColor = false;
            this.BuildFFButton.Click += new System.EventHandler(this.BuildFFButton_Click);
            // 
            // CompileReflectionsButton
            // 
            this.CompileReflectionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompileReflectionsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CompileReflectionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompileReflectionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CompileReflectionsButton.Location = new System.Drawing.Point(14, 348);
            this.CompileReflectionsButton.Name = "CompileReflectionsButton";
            this.CompileReflectionsButton.Size = new System.Drawing.Size(349, 23);
            this.CompileReflectionsButton.TabIndex = 49;
            this.CompileReflectionsButton.Text = "Compile Reflections";
            this.CompileReflectionsButton.UseVisualStyleBackColor = false;
            this.CompileReflectionsButton.Click += new System.EventHandler(this.CompileReflectionsButton_Click);
            // 
            // CompileBSPButton
            // 
            this.CompileBSPButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompileBSPButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CompileBSPButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CompileBSPButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CompileBSPButton.Location = new System.Drawing.Point(14, 319);
            this.CompileBSPButton.Name = "CompileBSPButton";
            this.CompileBSPButton.Size = new System.Drawing.Size(349, 23);
            this.CompileBSPButton.TabIndex = 48;
            this.CompileBSPButton.Text = "Compile BSP";
            this.CompileBSPButton.UseVisualStyleBackColor = false;
            this.CompileBSPButton.Click += new System.EventHandler(this.CompileBSPButton_Click);
            // 
            // RefreshMapsButton
            // 
            this.RefreshMapsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.RefreshMapsButton.BackgroundImage = global::CallofDuty4CompileTools.Properties.Resources.refresh;
            this.RefreshMapsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.RefreshMapsButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.RefreshMapsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshMapsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.RefreshMapsButton.Location = new System.Drawing.Point(291, 28);
            this.RefreshMapsButton.Name = "RefreshMapsButton";
            this.RefreshMapsButton.Size = new System.Drawing.Size(23, 22);
            this.RefreshMapsButton.TabIndex = 46;
            this.RefreshMapsButton.UseVisualStyleBackColor = false;
            this.RefreshMapsButton.Click += new System.EventHandler(this.RefreshMapsButton_Click);
            // 
            // MapComboBox
            // 
            this.MapComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MapComboBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MapComboBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MapComboBox.BorderSize = 1;
            this.MapComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.MapComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MapComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MapComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MapComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.MapComboBox.FormattingEnabled = true;
            this.MapComboBox.Location = new System.Drawing.Point(102, 28);
            this.MapComboBox.Name = "MapComboBox";
            this.MapComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MapComboBox.OnHoverItemForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.MapComboBox.Size = new System.Drawing.Size(183, 26);
            this.MapComboBox.TabIndex = 60;
            this.MapComboBox.SelectedIndexChanged += new System.EventHandler(this.MapComboBox_SelectedIndexChanged);
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.MenuStrip.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(3, 2, 0, 2);
            this.MenuStrip.Size = new System.Drawing.Size(855, 24);
            this.MenuStrip.TabIndex = 61;
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenRadiantButton,
            this.OpenASMButton,
            this.OpenFXButton,
            this.toolStripSeparator1,
            this.OptionsButton});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // OpenRadiantButton
            // 
            this.OpenRadiantButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.OpenRadiantButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OpenRadiantButton.Name = "OpenRadiantButton";
            this.OpenRadiantButton.Size = new System.Drawing.Size(180, 22);
            this.OpenRadiantButton.Text = "Radiant";
            this.OpenRadiantButton.Click += new System.EventHandler(this.OpenRadiantButton_Click);
            // 
            // OpenASMButton
            // 
            this.OpenASMButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.OpenASMButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OpenASMButton.Name = "OpenASMButton";
            this.OpenASMButton.Size = new System.Drawing.Size(180, 22);
            this.OpenASMButton.Text = "Asset Manager";
            this.OpenASMButton.Click += new System.EventHandler(this.OpenASMButton_Click);
            // 
            // OpenFXButton
            // 
            this.OpenFXButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.OpenFXButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.OpenFXButton.Name = "OpenFXButton";
            this.OpenFXButton.Size = new System.Drawing.Size(180, 22);
            this.OpenFXButton.Text = "Effects Editor";
            this.OpenFXButton.Click += new System.EventHandler(this.OpenFXButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.toolStripSeparator1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // OptionsButton
            // 
            this.OptionsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.OptionsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(180, 22);
            this.OptionsButton.Text = "Preferences";
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.BSPTab);
            this.TabControl.Controls.Add(this.LightingTab);
            this.TabControl.Controls.Add(this.RunTab);
            this.TabControl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.TabControl.Location = new System.Drawing.Point(14, 60);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 2;
            this.TabControl.Size = new System.Drawing.Size(348, 253);
            this.TabControl.TabIndex = 62;
            this.TabControl.Tabs.Add(this.BSPTab);
            this.TabControl.Tabs.Add(this.LightingTab);
            this.TabControl.Tabs.Add(this.RunTab);
            this.TabControl.TabSizing = Manina.Windows.Forms.TabSizing.Stretch;
            // 
            // BSPTab
            // 
            this.BSPTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BSPTab.Controls.Add(this.CompilePathsCheckBox);
            this.BSPTab.Controls.Add(this.CompileLightingCheckBox);
            this.BSPTab.Controls.Add(this.CompileBSPCheckBox);
            this.BSPTab.Controls.Add(this.SampleScaleTextBox);
            this.BSPTab.Controls.Add(this.BlockSizeTextBox);
            this.BSPTab.Controls.Add(this.CustomCommandLineTextBox);
            this.BSPTab.Controls.Add(this.gunaSeparator2);
            this.BSPTab.Controls.Add(this.CustomCommandLineLabel);
            this.BSPTab.Controls.Add(this.DebugLightmapsCheckBox);
            this.BSPTab.Controls.Add(this.SampleScaleCheckBox);
            this.BSPTab.Controls.Add(this.BlockSizeCheckBox);
            this.BSPTab.Controls.Add(this.OnlyEntsCheckBox);
            this.BSPTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BSPTab.Location = new System.Drawing.Point(1, 21);
            this.BSPTab.Name = "BSPTab";
            this.BSPTab.Size = new System.Drawing.Size(346, 231);
            this.BSPTab.Text = "BSP";
            // 
            // CompilePathsCheckBox
            // 
            this.CompilePathsCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompilePathsCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CompilePathsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CompilePathsCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CompilePathsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CompilePathsCheckBox.Location = new System.Drawing.Point(3, 55);
            this.CompilePathsCheckBox.Name = "CompilePathsCheckBox";
            this.CompilePathsCheckBox.Radius = 0;
            this.CompilePathsCheckBox.Size = new System.Drawing.Size(103, 20);
            this.CompilePathsCheckBox.TabIndex = 68;
            this.CompilePathsCheckBox.Text = "Compile Paths";
            this.CompilePathsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // CompileLightingCheckBox
            // 
            this.CompileLightingCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompileLightingCheckBox.Checked = true;
            this.CompileLightingCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CompileLightingCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CompileLightingCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CompileLightingCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CompileLightingCheckBox.Location = new System.Drawing.Point(3, 29);
            this.CompileLightingCheckBox.Name = "CompileLightingCheckBox";
            this.CompileLightingCheckBox.Radius = 0;
            this.CompileLightingCheckBox.Size = new System.Drawing.Size(114, 20);
            this.CompileLightingCheckBox.TabIndex = 67;
            this.CompileLightingCheckBox.Text = "Compile Lighting";
            this.CompileLightingCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // CompileBSPCheckBox
            // 
            this.CompileBSPCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CompileBSPCheckBox.Checked = true;
            this.CompileBSPCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CompileBSPCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CompileBSPCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CompileBSPCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CompileBSPCheckBox.Location = new System.Drawing.Point(3, 6);
            this.CompileBSPCheckBox.Name = "CompileBSPCheckBox";
            this.CompileBSPCheckBox.Radius = 0;
            this.CompileBSPCheckBox.Size = new System.Drawing.Size(97, 20);
            this.CompileBSPCheckBox.TabIndex = 66;
            this.CompileBSPCheckBox.Text = "Compile BSP";
            this.CompileBSPCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // SampleScaleTextBox
            // 
            this.SampleScaleTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SampleScaleTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SampleScaleTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SampleScaleTextBox.BorderSize = 1;
            this.SampleScaleTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SampleScaleTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SampleScaleTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SampleScaleTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.SampleScaleTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SampleScaleTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.SampleScaleTextBox.Location = new System.Drawing.Point(270, 60);
            this.SampleScaleTextBox.Name = "SampleScaleTextBox";
            this.SampleScaleTextBox.PasswordChar = '\0';
            this.SampleScaleTextBox.Size = new System.Drawing.Size(69, 26);
            this.SampleScaleTextBox.TabIndex = 65;
            this.SampleScaleTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // BlockSizeTextBox
            // 
            this.BlockSizeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BlockSizeTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BlockSizeTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BlockSizeTextBox.BorderSize = 1;
            this.BlockSizeTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BlockSizeTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BlockSizeTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BlockSizeTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BlockSizeTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BlockSizeTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BlockSizeTextBox.Location = new System.Drawing.Point(270, 29);
            this.BlockSizeTextBox.Name = "BlockSizeTextBox";
            this.BlockSizeTextBox.PasswordChar = '\0';
            this.BlockSizeTextBox.Size = new System.Drawing.Size(69, 26);
            this.BlockSizeTextBox.TabIndex = 64;
            this.BlockSizeTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // CustomCommandLineTextBox
            // 
            this.CustomCommandLineTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CustomCommandLineTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CustomCommandLineTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CustomCommandLineTextBox.BorderSize = 1;
            this.CustomCommandLineTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomCommandLineTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CustomCommandLineTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CustomCommandLineTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CustomCommandLineTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomCommandLineTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CustomCommandLineTextBox.Location = new System.Drawing.Point(3, 202);
            this.CustomCommandLineTextBox.Name = "CustomCommandLineTextBox";
            this.CustomCommandLineTextBox.PasswordChar = '\0';
            this.CustomCommandLineTextBox.Size = new System.Drawing.Size(340, 26);
            this.CustomCommandLineTextBox.TabIndex = 63;
            this.CustomCommandLineTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // gunaSeparator2
            // 
            this.gunaSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaSeparator2.Location = new System.Drawing.Point(13, 160);
            this.gunaSeparator2.Name = "gunaSeparator2";
            this.gunaSeparator2.Size = new System.Drawing.Size(319, 10);
            this.gunaSeparator2.TabIndex = 62;
            // 
            // CustomCommandLineLabel
            // 
            this.CustomCommandLineLabel.AutoSize = true;
            this.CustomCommandLineLabel.Location = new System.Drawing.Point(87, 186);
            this.CustomCommandLineLabel.Name = "CustomCommandLineLabel";
            this.CustomCommandLineLabel.Size = new System.Drawing.Size(174, 13);
            this.CustomCommandLineLabel.TabIndex = 61;
            this.CustomCommandLineLabel.Text = "Custom Command Line Arguements";
            // 
            // DebugLightmapsCheckBox
            // 
            this.DebugLightmapsCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DebugLightmapsCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DebugLightmapsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DebugLightmapsCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.DebugLightmapsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.DebugLightmapsCheckBox.Location = new System.Drawing.Point(148, 85);
            this.DebugLightmapsCheckBox.Name = "DebugLightmapsCheckBox";
            this.DebugLightmapsCheckBox.Radius = 0;
            this.DebugLightmapsCheckBox.Size = new System.Drawing.Size(118, 20);
            this.DebugLightmapsCheckBox.TabIndex = 60;
            this.DebugLightmapsCheckBox.Text = "Debug Lightmaps";
            this.DebugLightmapsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // SampleScaleCheckBox
            // 
            this.SampleScaleCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SampleScaleCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SampleScaleCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SampleScaleCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.SampleScaleCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.SampleScaleCheckBox.Location = new System.Drawing.Point(148, 59);
            this.SampleScaleCheckBox.Name = "SampleScaleCheckBox";
            this.SampleScaleCheckBox.Radius = 0;
            this.SampleScaleCheckBox.Size = new System.Drawing.Size(100, 20);
            this.SampleScaleCheckBox.TabIndex = 59;
            this.SampleScaleCheckBox.Text = "Sample Scale";
            this.SampleScaleCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // BlockSizeCheckBox
            // 
            this.BlockSizeCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BlockSizeCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BlockSizeCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BlockSizeCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BlockSizeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BlockSizeCheckBox.Location = new System.Drawing.Point(148, 33);
            this.BlockSizeCheckBox.Name = "BlockSizeCheckBox";
            this.BlockSizeCheckBox.Radius = 0;
            this.BlockSizeCheckBox.Size = new System.Drawing.Size(83, 20);
            this.BlockSizeCheckBox.TabIndex = 58;
            this.BlockSizeCheckBox.Text = "Block Size";
            this.BlockSizeCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // OnlyEntsCheckBox
            // 
            this.OnlyEntsCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OnlyEntsCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OnlyEntsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.OnlyEntsCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.OnlyEntsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.OnlyEntsCheckBox.Location = new System.Drawing.Point(148, 7);
            this.OnlyEntsCheckBox.Name = "OnlyEntsCheckBox";
            this.OnlyEntsCheckBox.Radius = 0;
            this.OnlyEntsCheckBox.Size = new System.Drawing.Size(93, 20);
            this.OnlyEntsCheckBox.TabIndex = 57;
            this.OnlyEntsCheckBox.Text = "Only Entities";
            this.OnlyEntsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // LightingTab
            // 
            this.LightingTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LightingTab.Controls.Add(this.JitterTextBox);
            this.LightingTab.Controls.Add(this.BounceFractionTextBox);
            this.LightingTab.Controls.Add(this.TracesTextBox);
            this.LightingTab.Controls.Add(this.JitterCheckBox);
            this.LightingTab.Controls.Add(this.BounceFractionCheckBox);
            this.LightingTab.Controls.Add(this.TracesCheckBox);
            this.LightingTab.Controls.Add(this.DumpOptionsCheckBox);
            this.LightingTab.Controls.Add(this.NoModelShadowCheckBox);
            this.LightingTab.Controls.Add(this.ModelShadowCheckBox);
            this.LightingTab.Controls.Add(this.VerboseCheckBox);
            this.LightingTab.Controls.Add(this.ExtraCheckBox);
            this.LightingTab.Controls.Add(this.CustomLightOptionsTextBox);
            this.LightingTab.Controls.Add(this.gunaSeparator3);
            this.LightingTab.Controls.Add(this.label2);
            this.LightingTab.Controls.Add(this.FastCheckBox);
            this.LightingTab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.LightingTab.Location = new System.Drawing.Point(1, 21);
            this.LightingTab.Name = "LightingTab";
            this.LightingTab.Size = new System.Drawing.Size(346, 231);
            this.LightingTab.Text = "Lighting";
            // 
            // VerboseCheckBox
            // 
            this.VerboseCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.VerboseCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.VerboseCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.VerboseCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.VerboseCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.VerboseCheckBox.Location = new System.Drawing.Point(3, 58);
            this.VerboseCheckBox.Name = "VerboseCheckBox";
            this.VerboseCheckBox.Radius = 0;
            this.VerboseCheckBox.Size = new System.Drawing.Size(72, 20);
            this.VerboseCheckBox.TabIndex = 72;
            this.VerboseCheckBox.Text = "Verbose";
            this.VerboseCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // ExtraCheckBox
            // 
            this.ExtraCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ExtraCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExtraCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ExtraCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ExtraCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ExtraCheckBox.Location = new System.Drawing.Point(3, 32);
            this.ExtraCheckBox.Name = "ExtraCheckBox";
            this.ExtraCheckBox.Radius = 0;
            this.ExtraCheckBox.Size = new System.Drawing.Size(56, 20);
            this.ExtraCheckBox.TabIndex = 71;
            this.ExtraCheckBox.Text = "Extra";
            this.ExtraCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // CustomLightOptionsTextBox
            // 
            this.CustomLightOptionsTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CustomLightOptionsTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CustomLightOptionsTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CustomLightOptionsTextBox.BorderSize = 1;
            this.CustomLightOptionsTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CustomLightOptionsTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CustomLightOptionsTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CustomLightOptionsTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CustomLightOptionsTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomLightOptionsTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.CustomLightOptionsTextBox.Location = new System.Drawing.Point(3, 202);
            this.CustomLightOptionsTextBox.Name = "CustomLightOptionsTextBox";
            this.CustomLightOptionsTextBox.PasswordChar = '\0';
            this.CustomLightOptionsTextBox.Size = new System.Drawing.Size(340, 26);
            this.CustomLightOptionsTextBox.TabIndex = 70;
            this.CustomLightOptionsTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // gunaSeparator3
            // 
            this.gunaSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaSeparator3.Location = new System.Drawing.Point(13, 160);
            this.gunaSeparator3.Name = "gunaSeparator3";
            this.gunaSeparator3.Size = new System.Drawing.Size(319, 10);
            this.gunaSeparator3.TabIndex = 69;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Custom Command Line Arguements";
            // 
            // FastCheckBox
            // 
            this.FastCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.FastCheckBox.Checked = true;
            this.FastCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FastCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FastCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.FastCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.FastCheckBox.Location = new System.Drawing.Point(3, 6);
            this.FastCheckBox.Name = "FastCheckBox";
            this.FastCheckBox.Radius = 0;
            this.FastCheckBox.Size = new System.Drawing.Size(52, 20);
            this.FastCheckBox.TabIndex = 67;
            this.FastCheckBox.Text = "Fast";
            this.FastCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // RunTab
            // 
            this.RunTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.RunTab.Controls.Add(this.gunaSeparator1);
            this.RunTab.Controls.Add(this.EnableDeveloperCheckBox);
            this.RunTab.Controls.Add(this.EnableCheatsCheckBox);
            this.RunTab.Controls.Add(this.CustomCommandLineCheckBox);
            this.RunTab.Controls.Add(this.MapCustomCommandLineTextBox);
            this.RunTab.Controls.Add(this.EnableDeveloperScriptCheckBox);
            this.RunTab.Location = new System.Drawing.Point(1, 21);
            this.RunTab.Name = "RunTab";
            this.RunTab.Size = new System.Drawing.Size(346, 231);
            this.RunTab.Text = "Run";
            // 
            // gunaSeparator1
            // 
            this.gunaSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.gunaSeparator1.Location = new System.Drawing.Point(13, 160);
            this.gunaSeparator1.Name = "gunaSeparator1";
            this.gunaSeparator1.Size = new System.Drawing.Size(319, 10);
            this.gunaSeparator1.TabIndex = 60;
            // 
            // FormConsole
            // 
            this.FormConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.FormConsole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FormConsole.Font = new System.Drawing.Font("Hack", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormConsole.IsInputEnabled = true;
            this.FormConsole.Location = new System.Drawing.Point(379, 28);
            this.FormConsole.Name = "FormConsole";
            this.FormConsole.SendKeyboardCommandsToProcess = false;
            this.FormConsole.ShowDiagnostics = false;
            this.FormConsole.Size = new System.Drawing.Size(473, 450);
            this.FormConsole.TabIndex = 64;
            // 
            // ModelShadowCheckBox
            // 
            this.ModelShadowCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ModelShadowCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ModelShadowCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ModelShadowCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ModelShadowCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.ModelShadowCheckBox.Location = new System.Drawing.Point(3, 84);
            this.ModelShadowCheckBox.Name = "ModelShadowCheckBox";
            this.ModelShadowCheckBox.Radius = 0;
            this.ModelShadowCheckBox.Size = new System.Drawing.Size(105, 20);
            this.ModelShadowCheckBox.TabIndex = 73;
            this.ModelShadowCheckBox.Text = "Model Shadow";
            this.ModelShadowCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // DumpOptionsCheckBox
            // 
            this.DumpOptionsCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.DumpOptionsCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DumpOptionsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.DumpOptionsCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.DumpOptionsCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.DumpOptionsCheckBox.Location = new System.Drawing.Point(3, 136);
            this.DumpOptionsCheckBox.Name = "DumpOptionsCheckBox";
            this.DumpOptionsCheckBox.Radius = 0;
            this.DumpOptionsCheckBox.Size = new System.Drawing.Size(102, 20);
            this.DumpOptionsCheckBox.TabIndex = 75;
            this.DumpOptionsCheckBox.Text = "Dump Options";
            this.DumpOptionsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // NoModelShadowCheckBox
            // 
            this.NoModelShadowCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.NoModelShadowCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NoModelShadowCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.NoModelShadowCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.NoModelShadowCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.NoModelShadowCheckBox.Location = new System.Drawing.Point(3, 110);
            this.NoModelShadowCheckBox.Name = "NoModelShadowCheckBox";
            this.NoModelShadowCheckBox.Radius = 0;
            this.NoModelShadowCheckBox.Size = new System.Drawing.Size(122, 20);
            this.NoModelShadowCheckBox.TabIndex = 74;
            this.NoModelShadowCheckBox.Text = "No Model Shadow";
            this.NoModelShadowCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // JitterCheckBox
            // 
            this.JitterCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.JitterCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.JitterCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.JitterCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.JitterCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.JitterCheckBox.Location = new System.Drawing.Point(167, 70);
            this.JitterCheckBox.Name = "JitterCheckBox";
            this.JitterCheckBox.Radius = 0;
            this.JitterCheckBox.Size = new System.Drawing.Size(54, 20);
            this.JitterCheckBox.TabIndex = 78;
            this.JitterCheckBox.Text = "Jitter";
            this.JitterCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // BounceFractionCheckBox
            // 
            this.BounceFractionCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BounceFractionCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BounceFractionCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BounceFractionCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BounceFractionCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BounceFractionCheckBox.Location = new System.Drawing.Point(167, 38);
            this.BounceFractionCheckBox.Name = "BounceFractionCheckBox";
            this.BounceFractionCheckBox.Radius = 0;
            this.BounceFractionCheckBox.Size = new System.Drawing.Size(112, 20);
            this.BounceFractionCheckBox.TabIndex = 77;
            this.BounceFractionCheckBox.Text = "Bounce Fraction";
            this.BounceFractionCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // TracesCheckBox
            // 
            this.TracesCheckBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TracesCheckBox.CheckedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TracesCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TracesCheckBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.TracesCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.TracesCheckBox.Location = new System.Drawing.Point(167, 6);
            this.TracesCheckBox.Name = "TracesCheckBox";
            this.TracesCheckBox.Radius = 0;
            this.TracesCheckBox.Size = new System.Drawing.Size(64, 20);
            this.TracesCheckBox.TabIndex = 76;
            this.TracesCheckBox.Text = "Traces";
            this.TracesCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // BounceFractionTextBox
            // 
            this.BounceFractionTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BounceFractionTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BounceFractionTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BounceFractionTextBox.BorderSize = 1;
            this.BounceFractionTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BounceFractionTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BounceFractionTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BounceFractionTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BounceFractionTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BounceFractionTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.BounceFractionTextBox.Location = new System.Drawing.Point(270, 35);
            this.BounceFractionTextBox.Name = "BounceFractionTextBox";
            this.BounceFractionTextBox.PasswordChar = '\0';
            this.BounceFractionTextBox.Size = new System.Drawing.Size(69, 26);
            this.BounceFractionTextBox.TabIndex = 80;
            this.BounceFractionTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // TracesTextBox
            // 
            this.TracesTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TracesTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TracesTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TracesTextBox.BorderSize = 1;
            this.TracesTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TracesTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TracesTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.TracesTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.TracesTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TracesTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.TracesTextBox.Location = new System.Drawing.Point(270, 3);
            this.TracesTextBox.Name = "TracesTextBox";
            this.TracesTextBox.PasswordChar = '\0';
            this.TracesTextBox.Size = new System.Drawing.Size(69, 26);
            this.TracesTextBox.TabIndex = 79;
            this.TracesTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // JitterTextBox
            // 
            this.JitterTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.JitterTextBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.JitterTextBox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.JitterTextBox.BorderSize = 1;
            this.JitterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.JitterTextBox.FocusedBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.JitterTextBox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.JitterTextBox.FocusedForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.JitterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.JitterTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.JitterTextBox.Location = new System.Drawing.Point(270, 67);
            this.JitterTextBox.Name = "JitterTextBox";
            this.JitterTextBox.PasswordChar = '\0';
            this.JitterTextBox.Size = new System.Drawing.Size(69, 26);
            this.JitterTextBox.TabIndex = 81;
            this.JitterTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(855, 500);
            this.Controls.Add(this.FormConsole);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.ClearConsoleLinkLabel);
            this.Controls.Add(this.MapComboBox);
            this.Controls.Add(this.MapSelectionLabel);
            this.Controls.Add(this.RunSelectedMapButton);
            this.Controls.Add(this.UpdateCSVButton);
            this.Controls.Add(this.BuildFFButton);
            this.Controls.Add(this.CompileReflectionsButton);
            this.Controls.Add(this.CompileBSPButton);
            this.Controls.Add(this.RefreshMapsButton);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.MenuStrip;
            this.Name = "Main";
            this.Text = "Call of Duty 4 Compile Tools";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.TabControl.ResumeLayout(false);
            this.BSPTab.ResumeLayout(false);
            this.BSPTab.PerformLayout();
            this.LightingTab.ResumeLayout(false);
            this.LightingTab.PerformLayout();
            this.RunTab.ResumeLayout(false);
            this.RunTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaCheckBox EnableDeveloperScriptCheckBox;
        private Guna.UI.WinForms.GunaCheckBox CustomCommandLineCheckBox;
        private Guna.UI.WinForms.GunaCheckBox EnableCheatsCheckBox;
        private Guna.UI.WinForms.GunaCheckBox EnableDeveloperCheckBox;
        private Guna.UI.WinForms.GunaTextBox MapCustomCommandLineTextBox;
        private System.Windows.Forms.Label MapSelectionLabel;
        private System.Windows.Forms.LinkLabel ClearConsoleLinkLabel;
        private System.Windows.Forms.Button RunSelectedMapButton;
        private System.Windows.Forms.Button UpdateCSVButton;
        private System.Windows.Forms.Button BuildFFButton;
        private System.Windows.Forms.Button CompileReflectionsButton;
        private System.Windows.Forms.Button CompileBSPButton;
        private System.Windows.Forms.Button RefreshMapsButton;
        private Guna.UI.WinForms.GunaComboBox MapComboBox;
        private DarkUI.Controls.DarkMenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenRadiantButton;
        private System.Windows.Forms.ToolStripMenuItem OpenASMButton;
        private System.Windows.Forms.ToolStripMenuItem OpenFXButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem OptionsButton;
        private Manina.Windows.Forms.TabControl TabControl;
        private Manina.Windows.Forms.Tab BSPTab;
        private Manina.Windows.Forms.Tab LightingTab;
        private Manina.Windows.Forms.Tab RunTab;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator1;
        private ConsoleControl.ConsoleControl FormConsole;
        private Guna.UI.WinForms.GunaCheckBox CompilePathsCheckBox;
        private Guna.UI.WinForms.GunaCheckBox CompileLightingCheckBox;
        private Guna.UI.WinForms.GunaCheckBox CompileBSPCheckBox;
        private Guna.UI.WinForms.GunaTextBox SampleScaleTextBox;
        private Guna.UI.WinForms.GunaTextBox BlockSizeTextBox;
        private Guna.UI.WinForms.GunaTextBox CustomCommandLineTextBox;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator2;
        private System.Windows.Forms.Label CustomCommandLineLabel;
        private Guna.UI.WinForms.GunaCheckBox DebugLightmapsCheckBox;
        private Guna.UI.WinForms.GunaCheckBox SampleScaleCheckBox;
        private Guna.UI.WinForms.GunaCheckBox BlockSizeCheckBox;
        private Guna.UI.WinForms.GunaCheckBox OnlyEntsCheckBox;
        private Guna.UI.WinForms.GunaTextBox CustomLightOptionsTextBox;
        private Guna.UI.WinForms.GunaSeparator gunaSeparator3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaCheckBox FastCheckBox;
        private Guna.UI.WinForms.GunaCheckBox VerboseCheckBox;
        private Guna.UI.WinForms.GunaCheckBox ExtraCheckBox;
        private Guna.UI.WinForms.GunaTextBox JitterTextBox;
        private Guna.UI.WinForms.GunaTextBox BounceFractionTextBox;
        private Guna.UI.WinForms.GunaTextBox TracesTextBox;
        private Guna.UI.WinForms.GunaCheckBox JitterCheckBox;
        private Guna.UI.WinForms.GunaCheckBox BounceFractionCheckBox;
        private Guna.UI.WinForms.GunaCheckBox TracesCheckBox;
        private Guna.UI.WinForms.GunaCheckBox DumpOptionsCheckBox;
        private Guna.UI.WinForms.GunaCheckBox NoModelShadowCheckBox;
        private Guna.UI.WinForms.GunaCheckBox ModelShadowCheckBox;
    }
}

