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
    public partial class GameView : UserControl
    {
        public GameView()
        {
            InitializeComponent();
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));
            playersHomeList.Controls.Add(new PlayerView("Bartel Boris"));
            playersHomeList.Controls.Add(new PlayerView("Joris Jemanson"));
            playersHomeList.Controls.Add(new PlayerView("Albertus Appenkos"));

            playersOutList.Controls.Add(new PlayerView("Simon Sedelaars"));
            playersOutList.Controls.Add(new PlayerView("Pieter Petelink"));
            playersOutList.Controls.Add(new PlayerView("Otto Overans"));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
