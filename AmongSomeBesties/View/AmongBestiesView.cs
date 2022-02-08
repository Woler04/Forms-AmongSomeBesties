using AmongSomeBesties.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongSomeBesties
{
    public partial class AmongBesties : Form
    {
        public AmongBesties()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            EntrySceneView entryScene = new EntrySceneView();
            entryScene.Show();
            this.Hide();
        }
    }
}
