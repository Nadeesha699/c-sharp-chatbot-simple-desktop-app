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
    public partial class BotMe : Form
    {
        int x = 0;
        public BotMe()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            bot_prg.Visible = true;
            while (x <= 100)
            {
                bot_prg.Value = x;
                System.Threading.Thread.Sleep(50); // Simulate work
                x++;
                if(x == 100)
                {
                    Home form2 = new Home();
                    form2.Show();
                    this.Hide();
                }
            }
               
              
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bot_prg.Visible = false;

        }
    }
}
