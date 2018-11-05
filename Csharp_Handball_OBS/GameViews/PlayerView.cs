using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Csharp_Handball_OBS.GameViews
{
    public partial class PlayerView : UserControl
    {
        public PlayerView(string playerName)
        {
            InitializeComponent();
            label1.Text = playerName;
        }
    }
}
