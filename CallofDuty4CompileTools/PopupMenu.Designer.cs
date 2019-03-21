namespace CallofDuty4CompileTools
{
    partial class PopupMenu
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
            this.optionsPopupMenu1 = new CallofDuty4CompileTools.RootPathPopupMenu();
            this.SuspendLayout();
            // 
            // optionsPopupMenu1
            // 
            this.optionsPopupMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.optionsPopupMenu1.Location = new System.Drawing.Point(-5, -30);
            this.optionsPopupMenu1.Name = "optionsPopupMenu1";
            this.optionsPopupMenu1.Size = new System.Drawing.Size(401, 196);
            this.optionsPopupMenu1.TabIndex = 0;
            // 
            // PopupMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.ClientSize = new System.Drawing.Size(384, 161);
            this.Controls.Add(this.optionsPopupMenu1);
            this.Name = "PopupMenu";
            this.Text = "Popup Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private RootPathPopupMenu optionsPopupMenu1;
    }
}