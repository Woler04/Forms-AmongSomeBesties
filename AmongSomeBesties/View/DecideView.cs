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
    public partial class DecideScene : Form
    {
        public DecideScene()
        {
            InitializeComponent();
        }

        private void btn_Option2_Click(object sender, EventArgs e)
        {
            SuspectsView sus = new SuspectsView();
            sus.Show();
            this.Hide();
        }

        private void DecideScene_Load(object sender, EventArgs e)
        {
            lbl_Dialog.Text = "Who do you think is the ice cream eater or this is going to be a COLD case";
        }

        private void btn_Rei_Click(object sender, EventArgs e)
        {
            EndView end = new EndView((Button)sender);
            end.Show();
            this.Hide();
        }
    }
}
