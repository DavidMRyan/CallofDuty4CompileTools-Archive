using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
