namespace CallofDuty4CompileTools
{
    partial class RootPathPopupMenu
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.RootPathTextBox = new System.Windows.Forms.TextBox();
            this.RootPathLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RootPathTextBox
            // 
            this.RootPathTextBox.Location = new System.Drawing.Point(13, 111);
            this.RootPathTextBox.Name = "RootPathTextBox";
            this.RootPathTextBox.Size = new System.Drawing.Size(371, 20);
            this.RootPathTextBox.TabIndex = 0;
            // 
            // RootPathLabel
            // 
            this.RootPathLabel.AutoSize = true;
            this.RootPathLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.RootPathLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.RootPathLabel.Location = new System.Drawing.Point(10, 93);
            this.RootPathLabel.Name = "RootPathLabel";
            this.RootPathLabel.Size = new System.Drawing.Size(339, 15);
            this.RootPathLabel.TabIndex = 1;
            this.RootPathLabel.Text = "Please enter the Root Path for Call of Duty 4 Modern Warfare:";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(228, 162);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(75, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(309, 162);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OptionsPopupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.RootPathLabel);
            this.Controls.Add(this.RootPathTextBox);
            this.Name = "OptionsPopupMenu";
            this.Size = new System.Drawing.Size(400, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox RootPathTextBox;
        private System.Windows.Forms.Label RootPathLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button CancelButton;
    }
}
