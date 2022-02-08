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
    public partial class EndView : Form
    {
        private string decision;
        public EndView(Button decision)
        {
            this.decision = decision.Name;
            InitializeComponent();
        }

        private void End_Load(object sender, EventArgs e)
        {
            
            switch (this.decision)
            {
                case "btn_Rei":
                    lbl_end.Text = "You blame Rei. She can't accept that you could think she would do such a think to you. And now she has depression.";
                    break;
                case "btn_Hua":
                    lbl_end.Text = "You blame Captain Hua. She did it, but she is the captain so now you are punished without dinner for a week.";
                    break;         
                case "btn_Red":    
                    lbl_end.Text = "You blame Red. He has an alibi, not telling you what tho";
                    break;         
                case "btn_Joe":    
                    lbl_end.Text = "You blam... (YOU DIED)";
                    break;       
                case "btn_end":    
                    lbl_end.Text = "You blame nobody... It was very rainy day without ice cream for you...";
                    break;
                default:
                    break;
            }
        }
    }
}
