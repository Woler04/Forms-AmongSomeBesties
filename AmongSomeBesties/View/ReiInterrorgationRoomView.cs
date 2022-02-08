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
    public partial class InterrorgationRoom4 : Form
    {
        public InterrorgationRoom4()
        {
            InitializeComponent();
        }

        private void InterrorgationRoom_Load(object sender, EventArgs e)
        {

            lbl_Dialog.Text = "Rei: I think the red Sussy Baka was near the refrigerators last night.";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            SuspectsView sus = new SuspectsView();
            sus.Show();
            this.Hide();
        }
    }
}
