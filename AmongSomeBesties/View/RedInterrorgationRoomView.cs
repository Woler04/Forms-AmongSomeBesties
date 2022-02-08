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
    public partial class InterrorgationRoom : Form
    {
        public InterrorgationRoom()
        {
            InitializeComponent();
        }

        private void InterrorgationRoom_Load(object sender, EventArgs e)
        {

            lbl_Dialog.Text = "Sussy Baka: I- I- I am alergic to ice, cream and blood... \n(He is looking kinda sus)";
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            SuspectsView sus = new SuspectsView();
            sus.Show();
            this.Hide();
        }

        private void pic_red_Click(object sender, EventArgs e)
        {

        }
    }
}
