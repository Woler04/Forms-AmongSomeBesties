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
    public partial class SuspectsView : Form
    {
        public SuspectsView()
        {
            InitializeComponent();
        }

        private void pic_red_Click(object sender, EventArgs e)
        {
            PictureBox send = (PictureBox)sender;
            InterrorgationRoom red = new InterrorgationRoom();
            red.Show();
            this.Hide();
        }

        private void pic_hua_Click(object sender, EventArgs e)
        {
            InterrorgationRoom2 hua = new InterrorgationRoom2();
            hua.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InterrorgationRoom3 joe = new InterrorgationRoom3();
            joe.Show();
            this.Hide();
        }

        private void pic_rei_Click(object sender, EventArgs e)
        {
            InterrorgationRoom4 rei = new InterrorgationRoom4();
            rei.Show();
            this.Hide();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            EntrySceneView entry = new EntrySceneView();
            entry.Show();
            this.Hide();
        }
    }
}
