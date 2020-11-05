using System;
using System.Windows.Forms;
using Microsoft.Win32;

namespace CallofDuty4CompileTools
{
    public partial class RootPathPopupMenu : UserControl
    {
        public RootPathPopupMenu()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string SubKey = RootPathTextBox.Text;
            string KeyName = @"HKEY_CURRENT_USER\Software\Call of Duty 4 Compile Tools";
            Registry.SetValue(KeyName, "RootPath", SubKey + @"\");
            PopupMenu.PopUp.Hide();
        }

        private void CancelButton_Click(object sender, EventArgs e) => PopupMenu.PopUp.Hide();
    }
}
