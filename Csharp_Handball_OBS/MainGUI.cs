using Csharp_Handball_OBS.GameViews;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Handball_OBS
{
    public partial class MainGUI : Form
    {
        public MainGUI()
        {
            InitializeComponent();
            this.Controls.Add(new GameView());
        }
    }
}
