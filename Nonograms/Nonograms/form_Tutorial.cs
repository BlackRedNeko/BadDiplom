using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nonograms
{
    public partial class form_Tutorial : Form
    {
        public form_Tutorial()
        {
            InitializeComponent();
        }

        bool bool_Back_To_Menu = true;

        private void label25_Click(object sender, EventArgs e)
        {
            bool_Back_To_Menu = false;
            form_Game fg = new form_Game();
            fg.lbl_Help.Text = "0";
            fg.Show();
            this.Close();
        }

        private void form_Tutorial_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (bool_Back_To_Menu == true)
            {
                form_Main_Menu fmm = new form_Main_Menu();
                fmm.Show();
            }
        }
    }
}
