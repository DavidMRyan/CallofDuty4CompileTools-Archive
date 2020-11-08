using System.Windows.Forms;

namespace CallofDuty4CompileTools
{
    public partial class PopupMenu : Form
    {
        public static Form PopUp;

        // TODO: Hide the component rather than disposing on Closing
        public PopupMenu()
        {
            InitializeComponent();
            PopUp = this;
        }
    }
}
