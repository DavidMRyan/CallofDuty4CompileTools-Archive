using System.Windows.Forms;

namespace CallofDuty4CompileTools
{
    public partial class PopupMenu : Form
    {
        public static Form PopUp;

        public PopupMenu()
        {
            InitializeComponent();
            PopUp = this;
        }
    }
}
