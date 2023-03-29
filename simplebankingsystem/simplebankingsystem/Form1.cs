using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simplebankingsystem
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if(txt_username.Text=="Admin" & txt_password.Text=="admin")
            {
                Form2 f = new Form2();
                f.Show();
                
          
            }
        }
    }
}
