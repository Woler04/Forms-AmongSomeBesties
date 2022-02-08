using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongSomeBesties.View
{
    public partial class EntrySceneView : Form
    {
        static private bool hasD = false;
        public EntrySceneView()
        {
            InitializeComponent();
            if (!hasD)
            {
                btn_d.Enabled = false;
            }
            
        }

        private void btn_Option2_Click(object sender, EventArgs e)
        {
            hasD = true;
            SuspectsView sus = new SuspectsView();
            sus.Show();
            this.Hide();
        }

        private void btn_Decide(object sender, EventArgs e)
        {
            DecideScene decide = new DecideScene();
            decide.Show();
            this.Hide();
        }

        private void EntrySceneView_Load(object sender, EventArgs e)
        {

        }
    }
}
