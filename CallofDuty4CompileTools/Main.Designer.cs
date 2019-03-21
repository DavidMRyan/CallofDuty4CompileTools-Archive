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
            this.RefreshMapsButton = new System.Windows.Forms.Button();
            this.MapsListBox = new System.Windows.Forms.ListBox();
            this.OpenRadiantButton = new System.Windows.Forms.Button();
            this.OpenASMButton = new System.Windows.Forms.Button();
            this.OpenFXButton = new System.Windows.Forms.Button();
            this.CreditsLabel = new System.Windows.Forms.LinkLabel();
            this.CompileOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.LightingOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.JitterTextBox = new System.Windows.Forms.TextBox();
            this.BounceFractionTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TracesTextBox = new System.Windows.Forms.TextBox();
            this.BounceFractionCheckBox = new System.Windows.Forms.CheckBox();
            this.CustomLightOptionsTextBox = new System.Windows.Forms.TextBox();
            this.TracesCheckBox = new System.Windows.Forms.CheckBox();
            this.JitterCheckBox = new System.Windows.Forms.CheckBox();
            this.DumpOptionsCheckBox = new System.Windows.Forms.CheckBox();
            this.NoModelShadowCheckBox = new System.Windows.Forms.CheckBox();
            this.ModelShadowCheckBox = new System.Windows.Forms.CheckBox();
            this.VerboseCheckBox = new System.Windows.Forms.CheckBox();
            this.ExtraCheckBox = new System.Windows.Forms.CheckBox();
            this.FastCheckBox = new System.Windows.Forms.CheckBox();
            this.BSPOptionsGroupBox = new System.Windows.Forms.GroupBox();
            this.SampleScaleTextBox = new System.Windows.Forms.TextBox();
            this.BlockSizeTextBox = new System.Windows.Forms.TextBox();
            this.CustomCommandLineLabel = new System.Windows.Forms.Label();
            this.CustomCommandLineTextBox = new System.Windows.Forms.TextBox();
            this.DebugLightmapsCheckBox = new System.Windows.Forms.CheckBox();
            this.SampleScaleCheckBox = new System.Windows.Forms.CheckBox();
            this.BlockSizeCheckBox = new System.Windows.Forms.CheckBox();
            this.OnlyEntsCheckBox = new System.Windows.Forms.CheckBox();
            this.CompilePathsCheckBox = new System.Windows.Forms.CheckBox();
            this.CompileLightingCheckBox = new System.Windows.Forms.CheckBox();
            this.CompileBSPCheckBox = new System.Windows.Forms.CheckBox();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.FormConsole = new WindowsForm.Console.FConsole();
            this.RootPathButton = new System.Windows.Forms.Button();
            this.CompileBSPButton = new System.Windows.Forms.Button();
            this.CompileReflectionsButton = new System.Windows.Forms.Button();
            this.BuildFFButton = new System.Windows.Forms.Button();
            this.UpdateCSVButton = new System.Windows.Forms.Button();
            this.MapCustomCommandLineTextBox = new System.Windows.Forms.TextBox();
            this.CustomCommandLineCheckBox = new System.Windows.Forms.CheckBox();
            this.EnableDeveloperScriptCheckBox = new System.Windows.Forms.CheckBox();
            this.EnableDeveloperCheckBox = new System.Windows.Forms.CheckBox();
            this.EnableCheatsCheckBox = new System.Windows.Forms.CheckBox();
            this.RunSelectedMapButton = new System.Windows.Forms.Button();
            this.ClearConsoleLinkLabel = new System.Windows.Forms.LinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CompileOptionsGroupBox.SuspendLayout();
            this.LightingOptionsGroupBox.SuspendLayout();
            this.BSPOptionsGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // RefreshMapsButton
            // 
            this.RefreshMapsButton.BackColor = System.Drawing.Color.White;
            this.RefreshMapsButton.FlatAppearance.BorderSize = 0;
            this.RefreshMapsButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RefreshMapsButton.Location = new System.Drawing.Point(12, 274);
            this.RefreshMapsButton.Name = "RefreshMapsButton";
            this.RefreshMapsButton.Size = new System.Drawing.Size(300, 23);
            this.RefreshMapsButton.TabIndex = 1;
            this.RefreshMapsButton.Text = "Refresh Maps List";
            this.RefreshMapsButton.UseVisualStyleBackColor = false;
            this.RefreshMapsButton.Click += new System.EventHandler(this.RefreshMapsButton_Click);
            // 
            // MapsListBox
            // 
            this.MapsListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.MapsListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MapsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.MapsListBox.ForeColor = System.Drawing.SystemColors.Window;
            this.MapsListBox.FormattingEnabled = true;
            this.MapsListBox.ItemHeight = 20;
            this.MapsListBox.Location = new System.Drawing.Point(12, 303);
            this.MapsListBox.Name = "MapsListBox";
            this.MapsListBox.Size = new System.Drawing.Size(300, 362);
            this.MapsListBox.TabIndex = 0;
            this.MapsListBox.SelectedIndexChanged += new System.EventHandler(this.MapsListBox_SelectedIndexChanged);
            // 
            // OpenRadiantButton
            // 
            this.OpenRadiantButton.Location = new System.Drawing.Point(1106, 18);
            this.OpenRadiantButton.Name = "OpenRadiantButton";
            this.OpenRadiantButton.Size = new System.Drawing.Size(146, 23);
            this.OpenRadiantButton.TabIndex = 4;
            this.OpenRadiantButton.Text = "Launch Radiant";
            this.OpenRadiantButton.UseVisualStyleBackColor = true;
            this.OpenRadiantButton.Click += new System.EventHandler(this.OpenRadiantButton_Click);
            // 
            // OpenASMButton
            // 
            this.OpenASMButton.Location = new System.Drawing.Point(1106, 47);
            this.OpenASMButton.Name = "OpenASMButton";
            this.OpenASMButton.Size = new System.Drawing.Size(146, 23);
            this.OpenASMButton.TabIndex = 5;
            this.OpenASMButton.Text = "Launch Asset Manager";
            this.OpenASMButton.UseVisualStyleBackColor = true;
            this.OpenASMButton.Click += new System.EventHandler(this.OpenASMButton_Click);
            // 
            // OpenFXButton
            // 
            this.OpenFXButton.Location = new System.Drawing.Point(1106, 76);
            this.OpenFXButton.Name = "OpenFXButton";
            this.OpenFXButton.Size = new System.Drawing.Size(146, 23);
            this.OpenFXButton.TabIndex = 6;
            this.OpenFXButton.Text = "Launch FX Editor";
            this.OpenFXButton.UseVisualStyleBackColor = true;
            this.OpenFXButton.Click += new System.EventHandler(this.OpenFXButton_Click);
            // 
            // CreditsLabel
            // 
            this.CreditsLabel.AutoSize = true;
            this.CreditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.CreditsLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.CreditsLabel.LinkColor = System.Drawing.SystemColors.Window;
            this.CreditsLabel.Location = new System.Drawing.Point(1106, 276);
            this.CreditsLabel.Name = "CreditsLabel";
            this.CreditsLabel.Size = new System.Drawing.Size(52, 20);
            this.CreditsLabel.TabIndex = 7;
            this.CreditsLabel.TabStop = true;
            this.CreditsLabel.Text = "About";
            // 
            // CompileOptionsGroupBox
            // 
            this.CompileOptionsGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.CompileOptionsGroupBox.Controls.Add(this.LightingOptionsGroupBox);
            this.CompileOptionsGroupBox.Controls.Add(this.BSPOptionsGroupBox);
            this.CompileOptionsGroupBox.Controls.Add(this.CompilePathsCheckBox);
            this.CompileOptionsGroupBox.Controls.Add(this.CompileLightingCheckBox);
            this.CompileOptionsGroupBox.Controls.Add(this.CompileBSPCheckBox);
            this.CompileOptionsGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.CompileOptionsGroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CompileOptionsGroupBox.Location = new System.Drawing.Point(318, 12);
            this.CompileOptionsGroupBox.Name = "CompileOptionsGroupBox";
            this.CompileOptionsGroupBox.Size = new System.Drawing.Size(782, 285);
            this.CompileOptionsGroupBox.TabIndex = 2;
            this.CompileOptionsGroupBox.TabStop = false;
            this.CompileOptionsGroupBox.Text = "Compile Options";
            // 
            // LightingOptionsGroupBox
            // 
            this.LightingOptionsGroupBox.Controls.Add(this.JitterTextBox);
            this.LightingOptionsGroupBox.Controls.Add(this.BounceFractionTextBox);
            this.LightingOptionsGroupBox.Controls.Add(this.label1);
            this.LightingOptionsGroupBox.Controls.Add(this.TracesTextBox);
            this.LightingOptionsGroupBox.Controls.Add(this.BounceFractionCheckBox);
            this.LightingOptionsGroupBox.Controls.Add(this.CustomLightOptionsTextBox);
            this.LightingOptionsGroupBox.Controls.Add(this.TracesCheckBox);
            this.LightingOptionsGroupBox.Controls.Add(this.JitterCheckBox);
            this.LightingOptionsGroupBox.Controls.Add(this.DumpOptionsCheckBox);
            this.LightingOptionsGroupBox.Controls.Add(this.NoModelShadowCheckBox);
            this.LightingOptionsGroupBox.Controls.Add(this.ModelShadowCheckBox);
            this.LightingOptionsGroupBox.Controls.Add(this.VerboseCheckBox);
            this.LightingOptionsGroupBox.Controls.Add(this.ExtraCheckBox);
            this.LightingOptionsGroupBox.Controls.Add(this.FastCheckBox);
            this.LightingOptionsGroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.LightingOptionsGroupBox.Location = new System.Drawing.Point(465, 20);
            this.LightingOptionsGroupBox.Name = "LightingOptionsGroupBox";
            this.LightingOptionsGroupBox.Size = new System.Drawing.Size(311, 259);
            this.LightingOptionsGroupBox.TabIndex = 4;
            this.LightingOptionsGroupBox.TabStop = false;
            this.LightingOptionsGroupBox.Text = "Lighting Options";
            // 
            // JitterTextBox
            // 
            this.JitterTextBox.Location = new System.Drawing.Point(232, 96);
            this.JitterTextBox.Name = "JitterTextBox";
            this.JitterTextBox.Size = new System.Drawing.Size(73, 21);
            this.JitterTextBox.TabIndex = 15;
            this.JitterTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // BounceFractionTextBox
            // 
            this.BounceFractionTextBox.Location = new System.Drawing.Point(232, 69);
            this.BounceFractionTextBox.Name = "BounceFractionTextBox";
            this.BounceFractionTextBox.Size = new System.Drawing.Size(73, 21);
            this.BounceFractionTextBox.TabIndex = 9;
            this.BounceFractionTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Custom Command Line Arguements";
            // 
            // TracesTextBox
            // 
            this.TracesTextBox.Location = new System.Drawing.Point(232, 42);
            this.TracesTextBox.Name = "TracesTextBox";
            this.TracesTextBox.Size = new System.Drawing.Size(73, 21);
            this.TracesTextBox.TabIndex = 8;
            this.TracesTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // BounceFractionCheckBox
            // 
            this.BounceFractionCheckBox.AutoSize = true;
            this.BounceFractionCheckBox.Location = new System.Drawing.Point(117, 69);
            this.BounceFractionCheckBox.Name = "BounceFractionCheckBox";
            this.BounceFractionCheckBox.Size = new System.Drawing.Size(115, 19);
            this.BounceFractionCheckBox.TabIndex = 14;
            this.BounceFractionCheckBox.Text = "Bounce Fraction";
            this.BounceFractionCheckBox.UseVisualStyleBackColor = true;
            this.BounceFractionCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // CustomLightOptionsTextBox
            // 
            this.CustomLightOptionsTextBox.Location = new System.Drawing.Point(18, 218);
            this.CustomLightOptionsTextBox.Name = "CustomLightOptionsTextBox";
            this.CustomLightOptionsTextBox.Size = new System.Drawing.Size(276, 21);
            this.CustomLightOptionsTextBox.TabIndex = 6;
            this.CustomLightOptionsTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // TracesCheckBox
            // 
            this.TracesCheckBox.AutoSize = true;
            this.TracesCheckBox.Location = new System.Drawing.Point(117, 44);
            this.TracesCheckBox.Name = "TracesCheckBox";
            this.TracesCheckBox.Size = new System.Drawing.Size(63, 19);
            this.TracesCheckBox.TabIndex = 13;
            this.TracesCheckBox.Text = "Traces";
            this.TracesCheckBox.UseVisualStyleBackColor = true;
            this.TracesCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // JitterCheckBox
            // 
            this.JitterCheckBox.AutoSize = true;
            this.JitterCheckBox.Location = new System.Drawing.Point(117, 94);
            this.JitterCheckBox.Name = "JitterCheckBox";
            this.JitterCheckBox.Size = new System.Drawing.Size(52, 19);
            this.JitterCheckBox.TabIndex = 12;
            this.JitterCheckBox.Text = "Jitter";
            this.JitterCheckBox.UseVisualStyleBackColor = true;
            this.JitterCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // DumpOptionsCheckBox
            // 
            this.DumpOptionsCheckBox.AutoSize = true;
            this.DumpOptionsCheckBox.Location = new System.Drawing.Point(18, 169);
            this.DumpOptionsCheckBox.Name = "DumpOptionsCheckBox";
            this.DumpOptionsCheckBox.Size = new System.Drawing.Size(105, 19);
            this.DumpOptionsCheckBox.TabIndex = 11;
            this.DumpOptionsCheckBox.Text = "Dump Options";
            this.DumpOptionsCheckBox.UseVisualStyleBackColor = true;
            this.DumpOptionsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // NoModelShadowCheckBox
            // 
            this.NoModelShadowCheckBox.AutoSize = true;
            this.NoModelShadowCheckBox.Location = new System.Drawing.Point(18, 144);
            this.NoModelShadowCheckBox.Name = "NoModelShadowCheckBox";
            this.NoModelShadowCheckBox.Size = new System.Drawing.Size(128, 19);
            this.NoModelShadowCheckBox.TabIndex = 10;
            this.NoModelShadowCheckBox.Text = "No Model Shadow";
            this.NoModelShadowCheckBox.UseVisualStyleBackColor = true;
            this.NoModelShadowCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // ModelShadowCheckBox
            // 
            this.ModelShadowCheckBox.AutoSize = true;
            this.ModelShadowCheckBox.Location = new System.Drawing.Point(18, 119);
            this.ModelShadowCheckBox.Name = "ModelShadowCheckBox";
            this.ModelShadowCheckBox.Size = new System.Drawing.Size(109, 19);
            this.ModelShadowCheckBox.TabIndex = 9;
            this.ModelShadowCheckBox.Text = "Model Shadow";
            this.ModelShadowCheckBox.UseVisualStyleBackColor = true;
            this.ModelShadowCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // VerboseCheckBox
            // 
            this.VerboseCheckBox.AutoSize = true;
            this.VerboseCheckBox.Location = new System.Drawing.Point(18, 94);
            this.VerboseCheckBox.Name = "VerboseCheckBox";
            this.VerboseCheckBox.Size = new System.Drawing.Size(71, 19);
            this.VerboseCheckBox.TabIndex = 8;
            this.VerboseCheckBox.Text = "Verbose";
            this.VerboseCheckBox.UseVisualStyleBackColor = true;
            this.VerboseCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // ExtraCheckBox
            // 
            this.ExtraCheckBox.AutoSize = true;
            this.ExtraCheckBox.Location = new System.Drawing.Point(18, 69);
            this.ExtraCheckBox.Name = "ExtraCheckBox";
            this.ExtraCheckBox.Size = new System.Drawing.Size(54, 19);
            this.ExtraCheckBox.TabIndex = 7;
            this.ExtraCheckBox.Text = "Extra";
            this.ExtraCheckBox.UseVisualStyleBackColor = true;
            this.ExtraCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // FastCheckBox
            // 
            this.FastCheckBox.AutoSize = true;
            this.FastCheckBox.Checked = true;
            this.FastCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.FastCheckBox.Location = new System.Drawing.Point(18, 44);
            this.FastCheckBox.Name = "FastCheckBox";
            this.FastCheckBox.Size = new System.Drawing.Size(49, 19);
            this.FastCheckBox.TabIndex = 6;
            this.FastCheckBox.Text = "Fast";
            this.FastCheckBox.UseVisualStyleBackColor = true;
            this.FastCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // BSPOptionsGroupBox
            // 
            this.BSPOptionsGroupBox.Controls.Add(this.SampleScaleTextBox);
            this.BSPOptionsGroupBox.Controls.Add(this.BlockSizeTextBox);
            this.BSPOptionsGroupBox.Controls.Add(this.CustomCommandLineLabel);
            this.BSPOptionsGroupBox.Controls.Add(this.CustomCommandLineTextBox);
            this.BSPOptionsGroupBox.Controls.Add(this.DebugLightmapsCheckBox);
            this.BSPOptionsGroupBox.Controls.Add(this.SampleScaleCheckBox);
            this.BSPOptionsGroupBox.Controls.Add(this.BlockSizeCheckBox);
            this.BSPOptionsGroupBox.Controls.Add(this.OnlyEntsCheckBox);
            this.BSPOptionsGroupBox.ForeColor = System.Drawing.SystemColors.Window;
            this.BSPOptionsGroupBox.Location = new System.Drawing.Point(148, 20);
            this.BSPOptionsGroupBox.Name = "BSPOptionsGroupBox";
            this.BSPOptionsGroupBox.Size = new System.Drawing.Size(311, 259);
            this.BSPOptionsGroupBox.TabIndex = 3;
            this.BSPOptionsGroupBox.TabStop = false;
            this.BSPOptionsGroupBox.Text = "BSP Options";
            // 
            // SampleScaleTextBox
            // 
            this.SampleScaleTextBox.Location = new System.Drawing.Point(126, 94);
            this.SampleScaleTextBox.Name = "SampleScaleTextBox";
            this.SampleScaleTextBox.Size = new System.Drawing.Size(73, 21);
            this.SampleScaleTextBox.TabIndex = 17;
            this.SampleScaleTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // BlockSizeTextBox
            // 
            this.BlockSizeTextBox.Location = new System.Drawing.Point(126, 67);
            this.BlockSizeTextBox.Name = "BlockSizeTextBox";
            this.BlockSizeTextBox.Size = new System.Drawing.Size(73, 21);
            this.BlockSizeTextBox.TabIndex = 16;
            this.BlockSizeTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // CustomCommandLineLabel
            // 
            this.CustomCommandLineLabel.AutoSize = true;
            this.CustomCommandLineLabel.Location = new System.Drawing.Point(52, 160);
            this.CustomCommandLineLabel.Name = "CustomCommandLineLabel";
            this.CustomCommandLineLabel.Size = new System.Drawing.Size(206, 15);
            this.CustomCommandLineLabel.TabIndex = 5;
            this.CustomCommandLineLabel.Text = "Custom Command Line Arguements";
            // 
            // CustomCommandLineTextBox
            // 
            this.CustomCommandLineTextBox.Location = new System.Drawing.Point(17, 178);
            this.CustomCommandLineTextBox.Name = "CustomCommandLineTextBox";
            this.CustomCommandLineTextBox.Size = new System.Drawing.Size(276, 21);
            this.CustomCommandLineTextBox.TabIndex = 4;
            this.CustomCommandLineTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // DebugLightmapsCheckBox
            // 
            this.DebugLightmapsCheckBox.AutoSize = true;
            this.DebugLightmapsCheckBox.Location = new System.Drawing.Point(17, 119);
            this.DebugLightmapsCheckBox.Name = "DebugLightmapsCheckBox";
            this.DebugLightmapsCheckBox.Size = new System.Drawing.Size(124, 19);
            this.DebugLightmapsCheckBox.TabIndex = 3;
            this.DebugLightmapsCheckBox.Text = "Debug Lightmaps";
            this.DebugLightmapsCheckBox.UseVisualStyleBackColor = true;
            this.DebugLightmapsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // SampleScaleCheckBox
            // 
            this.SampleScaleCheckBox.AutoSize = true;
            this.SampleScaleCheckBox.Location = new System.Drawing.Point(17, 94);
            this.SampleScaleCheckBox.Name = "SampleScaleCheckBox";
            this.SampleScaleCheckBox.Size = new System.Drawing.Size(103, 19);
            this.SampleScaleCheckBox.TabIndex = 2;
            this.SampleScaleCheckBox.Text = "Sample Scale";
            this.SampleScaleCheckBox.UseVisualStyleBackColor = true;
            this.SampleScaleCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // BlockSizeCheckBox
            // 
            this.BlockSizeCheckBox.AutoSize = true;
            this.BlockSizeCheckBox.Location = new System.Drawing.Point(17, 69);
            this.BlockSizeCheckBox.Name = "BlockSizeCheckBox";
            this.BlockSizeCheckBox.Size = new System.Drawing.Size(83, 19);
            this.BlockSizeCheckBox.TabIndex = 1;
            this.BlockSizeCheckBox.Text = "Block Size";
            this.BlockSizeCheckBox.UseVisualStyleBackColor = true;
            this.BlockSizeCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // OnlyEntsCheckBox
            // 
            this.OnlyEntsCheckBox.AutoSize = true;
            this.OnlyEntsCheckBox.Location = new System.Drawing.Point(17, 44);
            this.OnlyEntsCheckBox.Name = "OnlyEntsCheckBox";
            this.OnlyEntsCheckBox.Size = new System.Drawing.Size(93, 19);
            this.OnlyEntsCheckBox.TabIndex = 0;
            this.OnlyEntsCheckBox.Text = "Only Entities";
            this.OnlyEntsCheckBox.UseVisualStyleBackColor = true;
            this.OnlyEntsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // CompilePathsCheckBox
            // 
            this.CompilePathsCheckBox.AutoSize = true;
            this.CompilePathsCheckBox.Location = new System.Drawing.Point(15, 77);
            this.CompilePathsCheckBox.Name = "CompilePathsCheckBox";
            this.CompilePathsCheckBox.Size = new System.Drawing.Size(106, 19);
            this.CompilePathsCheckBox.TabIndex = 2;
            this.CompilePathsCheckBox.Text = "Compile Paths";
            this.CompilePathsCheckBox.UseVisualStyleBackColor = true;
            this.CompilePathsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // CompileLightingCheckBox
            // 
            this.CompileLightingCheckBox.AutoSize = true;
            this.CompileLightingCheckBox.Checked = true;
            this.CompileLightingCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CompileLightingCheckBox.Location = new System.Drawing.Point(15, 52);
            this.CompileLightingCheckBox.Name = "CompileLightingCheckBox";
            this.CompileLightingCheckBox.Size = new System.Drawing.Size(119, 19);
            this.CompileLightingCheckBox.TabIndex = 1;
            this.CompileLightingCheckBox.Text = "Compile Lighting";
            this.CompileLightingCheckBox.UseVisualStyleBackColor = true;
            this.CompileLightingCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // CompileBSPCheckBox
            // 
            this.CompileBSPCheckBox.AutoSize = true;
            this.CompileBSPCheckBox.Checked = true;
            this.CompileBSPCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CompileBSPCheckBox.Location = new System.Drawing.Point(15, 27);
            this.CompileBSPCheckBox.Name = "CompileBSPCheckBox";
            this.CompileBSPCheckBox.Size = new System.Drawing.Size(99, 19);
            this.CompileBSPCheckBox.TabIndex = 0;
            this.CompileBSPCheckBox.Text = "Compile BSP";
            this.CompileBSPCheckBox.UseVisualStyleBackColor = true;
            this.CompileBSPCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Location = new System.Drawing.Point(1106, 250);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(146, 23);
            this.OptionsButton.TabIndex = 8;
            this.OptionsButton.Text = "Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // FormConsole
            // 
            this.FormConsole.Arguments = new string[0];
            this.FormConsole.AutoScrollToEndLine = true;
            this.FormConsole.BackColor = System.Drawing.Color.Black;
            this.FormConsole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FormConsole.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FormConsole.Font = new System.Drawing.Font("Consolas", 10F);
            this.FormConsole.ForeColor = System.Drawing.SystemColors.Window;
            this.FormConsole.HyperlinkColor = System.Drawing.Color.Empty;
            this.FormConsole.Location = new System.Drawing.Point(0, 0);
            this.FormConsole.MinimumSize = new System.Drawing.Size(470, 200);
            this.FormConsole.Name = "FormConsole";
            this.FormConsole.ReadOnly = true;
            this.FormConsole.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.FormConsole.SecureReadLine = true;
            this.FormConsole.Size = new System.Drawing.Size(934, 362);
            this.FormConsole.State = WindowsForm.Console.Enums.ConsoleState.Writing;
            this.FormConsole.TabIndex = 9;
            this.FormConsole.Text = "";
            this.FormConsole.Title = "";
            // 
            // RootPathButton
            // 
            this.RootPathButton.Location = new System.Drawing.Point(1106, 221);
            this.RootPathButton.Name = "RootPathButton";
            this.RootPathButton.Size = new System.Drawing.Size(146, 23);
            this.RootPathButton.TabIndex = 10;
            this.RootPathButton.Text = "Root Path";
            this.RootPathButton.UseVisualStyleBackColor = true;
            this.RootPathButton.Click += new System.EventHandler(this.RootPathButton_Click);
            // 
            // CompileBSPButton
            // 
            this.CompileBSPButton.BackColor = System.Drawing.Color.White;
            this.CompileBSPButton.FlatAppearance.BorderSize = 0;
            this.CompileBSPButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CompileBSPButton.Location = new System.Drawing.Point(12, 18);
            this.CompileBSPButton.Name = "CompileBSPButton";
            this.CompileBSPButton.Size = new System.Drawing.Size(300, 23);
            this.CompileBSPButton.TabIndex = 11;
            this.CompileBSPButton.Text = "Compile BSP";
            this.CompileBSPButton.UseVisualStyleBackColor = false;
            this.CompileBSPButton.Click += new System.EventHandler(this.CompileBSPButton_Click);
            // 
            // CompileReflectionsButton
            // 
            this.CompileReflectionsButton.BackColor = System.Drawing.Color.White;
            this.CompileReflectionsButton.FlatAppearance.BorderSize = 0;
            this.CompileReflectionsButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.CompileReflectionsButton.Location = new System.Drawing.Point(12, 47);
            this.CompileReflectionsButton.Name = "CompileReflectionsButton";
            this.CompileReflectionsButton.Size = new System.Drawing.Size(300, 23);
            this.CompileReflectionsButton.TabIndex = 12;
            this.CompileReflectionsButton.Text = "Compile Reflections";
            this.CompileReflectionsButton.UseVisualStyleBackColor = false;
            this.CompileReflectionsButton.Click += new System.EventHandler(this.CompileReflectionsButton_Click);
            // 
            // BuildFFButton
            // 
            this.BuildFFButton.BackColor = System.Drawing.Color.White;
            this.BuildFFButton.FlatAppearance.BorderSize = 0;
            this.BuildFFButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.BuildFFButton.Location = new System.Drawing.Point(12, 76);
            this.BuildFFButton.Name = "BuildFFButton";
            this.BuildFFButton.Size = new System.Drawing.Size(300, 23);
            this.BuildFFButton.TabIndex = 13;
            this.BuildFFButton.Text = "Build Fast File";
            this.BuildFFButton.UseVisualStyleBackColor = false;
            this.BuildFFButton.Click += new System.EventHandler(this.BuildFFButton_Click);
            // 
            // UpdateCSVButton
            // 
            this.UpdateCSVButton.BackColor = System.Drawing.Color.White;
            this.UpdateCSVButton.FlatAppearance.BorderSize = 0;
            this.UpdateCSVButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.UpdateCSVButton.Location = new System.Drawing.Point(12, 105);
            this.UpdateCSVButton.Name = "UpdateCSVButton";
            this.UpdateCSVButton.Size = new System.Drawing.Size(300, 23);
            this.UpdateCSVButton.TabIndex = 14;
            this.UpdateCSVButton.Text = "Update CSV";
            this.UpdateCSVButton.UseVisualStyleBackColor = false;
            // 
            // MapCustomCommandLineTextBox
            // 
            this.MapCustomCommandLineTextBox.Location = new System.Drawing.Point(12, 232);
            this.MapCustomCommandLineTextBox.Name = "MapCustomCommandLineTextBox";
            this.MapCustomCommandLineTextBox.Size = new System.Drawing.Size(300, 20);
            this.MapCustomCommandLineTextBox.TabIndex = 18;
            this.MapCustomCommandLineTextBox.TextChanged += new System.EventHandler(this.onChange);
            // 
            // CustomCommandLineCheckBox
            // 
            this.CustomCommandLineCheckBox.AutoSize = true;
            this.CustomCommandLineCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.CustomCommandLineCheckBox.Location = new System.Drawing.Point(12, 209);
            this.CustomCommandLineCheckBox.Name = "CustomCommandLineCheckBox";
            this.CustomCommandLineCheckBox.Size = new System.Drawing.Size(215, 17);
            this.CustomCommandLineCheckBox.TabIndex = 18;
            this.CustomCommandLineCheckBox.Text = "Use Custom Command Line Arguements";
            this.CustomCommandLineCheckBox.UseVisualStyleBackColor = true;
            this.CustomCommandLineCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // EnableDeveloperScriptCheckBox
            // 
            this.EnableDeveloperScriptCheckBox.AutoSize = true;
            this.EnableDeveloperScriptCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.EnableDeveloperScriptCheckBox.Location = new System.Drawing.Point(12, 186);
            this.EnableDeveloperScriptCheckBox.Name = "EnableDeveloperScriptCheckBox";
            this.EnableDeveloperScriptCheckBox.Size = new System.Drawing.Size(141, 17);
            this.EnableDeveloperScriptCheckBox.TabIndex = 19;
            this.EnableDeveloperScriptCheckBox.Text = "Enable Developer Script";
            this.EnableDeveloperScriptCheckBox.UseVisualStyleBackColor = true;
            this.EnableDeveloperScriptCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // EnableDeveloperCheckBox
            // 
            this.EnableDeveloperCheckBox.AutoSize = true;
            this.EnableDeveloperCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.EnableDeveloperCheckBox.Location = new System.Drawing.Point(12, 163);
            this.EnableDeveloperCheckBox.Name = "EnableDeveloperCheckBox";
            this.EnableDeveloperCheckBox.Size = new System.Drawing.Size(111, 17);
            this.EnableDeveloperCheckBox.TabIndex = 20;
            this.EnableDeveloperCheckBox.Text = "Enable Developer";
            this.EnableDeveloperCheckBox.UseVisualStyleBackColor = true;
            this.EnableDeveloperCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // EnableCheatsCheckBox
            // 
            this.EnableCheatsCheckBox.AutoSize = true;
            this.EnableCheatsCheckBox.ForeColor = System.Drawing.SystemColors.Window;
            this.EnableCheatsCheckBox.Location = new System.Drawing.Point(217, 163);
            this.EnableCheatsCheckBox.Name = "EnableCheatsCheckBox";
            this.EnableCheatsCheckBox.Size = new System.Drawing.Size(95, 17);
            this.EnableCheatsCheckBox.TabIndex = 21;
            this.EnableCheatsCheckBox.Text = "Enable Cheats";
            this.EnableCheatsCheckBox.UseVisualStyleBackColor = true;
            this.EnableCheatsCheckBox.CheckedChanged += new System.EventHandler(this.onChange);
            // 
            // RunSelectedMapButton
            // 
            this.RunSelectedMapButton.BackColor = System.Drawing.Color.White;
            this.RunSelectedMapButton.FlatAppearance.BorderSize = 0;
            this.RunSelectedMapButton.ForeColor = System.Drawing.SystemColors.WindowText;
            this.RunSelectedMapButton.Location = new System.Drawing.Point(12, 134);
            this.RunSelectedMapButton.Name = "RunSelectedMapButton";
            this.RunSelectedMapButton.Size = new System.Drawing.Size(300, 23);
            this.RunSelectedMapButton.TabIndex = 22;
            this.RunSelectedMapButton.Text = "Run Selected Map";
            this.RunSelectedMapButton.UseVisualStyleBackColor = false;
            this.RunSelectedMapButton.Click += new System.EventHandler(this.RunSelectedMapButton_Click);
            // 
            // ClearConsoleLinkLabel
            // 
            this.ClearConsoleLinkLabel.ActiveLinkColor = System.Drawing.Color.ForestGreen;
            this.ClearConsoleLinkLabel.AutoSize = true;
            this.ClearConsoleLinkLabel.BackColor = System.Drawing.Color.Black;
            this.ClearConsoleLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ClearConsoleLinkLabel.LinkColor = System.Drawing.SystemColors.Window;
            this.ClearConsoleLinkLabel.Location = new System.Drawing.Point(1168, 303);
            this.ClearConsoleLinkLabel.Name = "ClearConsoleLinkLabel";
            this.ClearConsoleLinkLabel.Size = new System.Drawing.Size(84, 15);
            this.ClearConsoleLinkLabel.TabIndex = 23;
            this.ClearConsoleLinkLabel.TabStop = true;
            this.ClearConsoleLinkLabel.Text = "Clear Console";
            this.ClearConsoleLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ClearConsoleLinkLabel_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.FormConsole);
            this.panel1.Location = new System.Drawing.Point(318, 303);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(934, 362);
            this.panel1.TabIndex = 24;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ClearConsoleLinkLabel);
            this.Controls.Add(this.RunSelectedMapButton);
            this.Controls.Add(this.EnableCheatsCheckBox);
            this.Controls.Add(this.EnableDeveloperCheckBox);
            this.Controls.Add(this.EnableDeveloperScriptCheckBox);
            this.Controls.Add(this.CustomCommandLineCheckBox);
            this.Controls.Add(this.MapCustomCommandLineTextBox);
            this.Controls.Add(this.UpdateCSVButton);
            this.Controls.Add(this.BuildFFButton);
            this.Controls.Add(this.CompileReflectionsButton);
            this.Controls.Add(this.CompileBSPButton);
            this.Controls.Add(this.RootPathButton);
            this.Controls.Add(this.OptionsButton);
            this.Controls.Add(this.CreditsLabel);
            this.Controls.Add(this.OpenFXButton);
            this.Controls.Add(this.OpenASMButton);
            this.Controls.Add(this.OpenRadiantButton);
            this.Controls.Add(this.CompileOptionsGroupBox);
            this.Controls.Add(this.RefreshMapsButton);
            this.Controls.Add(this.MapsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Main";
            this.Text = "Call of Duty 4 Compile Tools";
            this.CompileOptionsGroupBox.ResumeLayout(false);
            this.CompileOptionsGroupBox.PerformLayout();
            this.LightingOptionsGroupBox.ResumeLayout(false);
            this.LightingOptionsGroupBox.PerformLayout();
            this.BSPOptionsGroupBox.ResumeLayout(false);
            this.BSPOptionsGroupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RefreshMapsButton;
        private System.Windows.Forms.ListBox MapsListBox;
        private System.Windows.Forms.Button OpenRadiantButton;
        private System.Windows.Forms.Button OpenASMButton;
        private System.Windows.Forms.Button OpenFXButton;
        private System.Windows.Forms.LinkLabel CreditsLabel;
        private System.Windows.Forms.GroupBox CompileOptionsGroupBox;
        private System.Windows.Forms.GroupBox LightingOptionsGroupBox;
        private System.Windows.Forms.GroupBox BSPOptionsGroupBox;
        private System.Windows.Forms.CheckBox CompilePathsCheckBox;
        private System.Windows.Forms.CheckBox CompileLightingCheckBox;
        private System.Windows.Forms.CheckBox CompileBSPCheckBox;
        private System.Windows.Forms.CheckBox DebugLightmapsCheckBox;
        private System.Windows.Forms.CheckBox SampleScaleCheckBox;
        private System.Windows.Forms.CheckBox BlockSizeCheckBox;
        private System.Windows.Forms.CheckBox OnlyEntsCheckBox;
        private System.Windows.Forms.TextBox CustomCommandLineTextBox;
        private System.Windows.Forms.Label CustomCommandLineLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox BounceFractionCheckBox;
        private System.Windows.Forms.TextBox CustomLightOptionsTextBox;
        private System.Windows.Forms.CheckBox TracesCheckBox;
        private System.Windows.Forms.CheckBox JitterCheckBox;
        private System.Windows.Forms.CheckBox DumpOptionsCheckBox;
        private System.Windows.Forms.CheckBox NoModelShadowCheckBox;
        private System.Windows.Forms.CheckBox ModelShadowCheckBox;
        private System.Windows.Forms.CheckBox VerboseCheckBox;
        private System.Windows.Forms.CheckBox ExtraCheckBox;
        private System.Windows.Forms.CheckBox FastCheckBox;
        private System.Windows.Forms.TextBox JitterTextBox;
        private System.Windows.Forms.TextBox BounceFractionTextBox;
        private System.Windows.Forms.TextBox TracesTextBox;
        private System.Windows.Forms.TextBox SampleScaleTextBox;
        private System.Windows.Forms.TextBox BlockSizeTextBox;
        private System.Windows.Forms.Button OptionsButton;
        private WindowsForm.Console.FConsole FormConsole;
        private System.Windows.Forms.Button RootPathButton;
        private System.Windows.Forms.Button CompileBSPButton;
        private System.Windows.Forms.Button CompileReflectionsButton;
        private System.Windows.Forms.Button BuildFFButton;
        private System.Windows.Forms.Button UpdateCSVButton;
        private System.Windows.Forms.TextBox MapCustomCommandLineTextBox;
        private System.Windows.Forms.CheckBox CustomCommandLineCheckBox;
        private System.Windows.Forms.CheckBox EnableDeveloperScriptCheckBox;
        private System.Windows.Forms.CheckBox EnableDeveloperCheckBox;
        private System.Windows.Forms.CheckBox EnableCheatsCheckBox;
        private System.Windows.Forms.Button RunSelectedMapButton;
        private System.Windows.Forms.LinkLabel ClearConsoleLinkLabel;
        private System.Windows.Forms.Panel panel1;
    }
}

