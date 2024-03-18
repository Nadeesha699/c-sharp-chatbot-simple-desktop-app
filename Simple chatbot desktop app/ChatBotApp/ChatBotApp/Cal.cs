using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChatBotApp
{
    public partial class Cal : Form
    {
        public Cal()
        {
            InitializeComponent();
        }

        double tot;

        private void Cal_Load(object sender, EventArgs e)
        {
            btn_add.Visible = false;
            btn_div.Visible = false;
            btn_mul.Visible = false;
            btn_sub.Visible = false;
            lbl_tot.Visible = false;    
        }

        private void btn_expand_Click(object sender, EventArgs e)
        {
            btn_add.Visible = true;
            btn_div.Visible = true;
            btn_mul.Visible = true;
            btn_sub.Visible = true;
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            btn_expand.Visible = false;
            btn_div.Visible = false;
            btn_mul.Visible = false;
            btn_sub.Visible = false;
            if (txt_in1.Text.Length != 0 && txt_in2.Text.Length != 0)
            {
                tot = Convert.ToDouble(txt_in1.Text) + Convert.ToDouble(txt_in2.Text);
            }
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            btn_expand.Visible = true;
            btn_add.Visible = true;
            btn_div.Visible = true;
            btn_mul.Visible = true;
            btn_sub.Visible = true;
            txt_in1.Text = "";
            txt_in2.Text = "";
            lbl_tot.Visible = true;
            lbl_tot.Text = tot.ToString();
        }

        private void btn_sub_Click(object sender, EventArgs e)
        {
            btn_expand.Visible = false;
            btn_add.Visible = false;
            btn_div.Visible = false;
            btn_mul.Visible = false;
            if (txt_in1.Text.Length != 0 && txt_in2.Text.Length != 0)
            {
                tot = Convert.ToDouble(txt_in1.Text) - Convert.ToDouble(txt_in2.Text);
            }

        }

        private void btn_mul_Click(object sender, EventArgs e)
        {
            btn_expand.Visible = false;
            btn_add.Visible = false;
            btn_div.Visible = false;
            btn_sub.Visible = false;
            if (txt_in1.Text.Length != 0 && txt_in2.Text.Length != 0)
            {
                tot = Convert.ToDouble(txt_in1.Text) * Convert.ToDouble(txt_in2.Text);
            }

        }

        private void btn_div_Click(object sender, EventArgs e)
        {
            btn_expand.Visible = false;    
            btn_add.Visible = false;
            btn_mul.Visible = false;
            btn_sub.Visible = false;
            if (txt_in1.Text.Length != 0 && txt_in2.Text.Length != 0)
            {
                tot = Convert.ToDouble(txt_in1.Text) / Convert.ToDouble(txt_in2.Text);
            }

        }
    }
}
