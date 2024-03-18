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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            

            if (txt_b_text.Text.Length != 0)
            {
                lbl_bot.Visible = true;
                lbl_me.Visible = true;

                if (txt_b_text.Text.Equals("Hi") || txt_b_text.Text.Equals("Hello") || txt_b_text.Text.Equals("Bye") || txt_b_text.Text.Equals("hi") || txt_b_text.Text.Equals("hello") || txt_b_text.Text.Equals("bye"))
                {
                    lbl_bot.Text = txt_b_text.Text +" Nadeesha";
                    lbl_me.Text = txt_b_text.Text;
                    txt_b_text.Clear();
                }
                else if (txt_b_text.Text.Equals("exit")){
                    BotMe obj = new BotMe();
                    obj.Show();
                    this.Hide();
                }
                else if (txt_b_text.Text.Equals("cal"))
                {
                    Cal cal = new Cal();    
                    cal.Show(); 
                    this.Hide();
                }
                else
                {
                    lbl_bot.Text = "I don't know";
                    lbl_me.Text = txt_b_text.Text;
                    txt_b_text.Clear();
                }

            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            BotMe form1 = new BotMe();
            form1.Dispose();
            lbl_bot.Visible = false;
            lbl_me.Visible = false;
        }

    
    }
}
