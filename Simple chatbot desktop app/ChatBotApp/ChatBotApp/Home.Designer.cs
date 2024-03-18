namespace ChatBotApp
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.txt_b_text = new System.Windows.Forms.TextBox();
            this.btn_send = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_bot = new System.Windows.Forms.Label();
            this.lbl_me = new System.Windows.Forms.Label();
            this.lbl_tut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_b_text
            // 
            this.txt_b_text.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_b_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_b_text.Location = new System.Drawing.Point(60, 113);
            this.txt_b_text.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_b_text.Multiline = true;
            this.txt_b_text.Name = "txt_b_text";
            this.txt_b_text.Size = new System.Drawing.Size(305, 29);
            this.txt_b_text.TabIndex = 0;
            this.txt_b_text.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // btn_send
            // 
            this.btn_send.AutoSize = true;
            this.btn_send.BackColor = System.Drawing.Color.Transparent;
            this.btn_send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_send.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_send.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_send.Location = new System.Drawing.Point(381, 113);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(28, 29);
            this.btn_send.TabIndex = 1;
            this.btn_send.Text = ">";
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label2.Location = new System.Drawing.Point(55, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "<";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(55, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = ">";
            // 
            // lbl_bot
            // 
            this.lbl_bot.AutoSize = true;
            this.lbl_bot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bot.ForeColor = System.Drawing.Color.DeepPink;
            this.lbl_bot.Location = new System.Drawing.Point(91, 32);
            this.lbl_bot.Name = "lbl_bot";
            this.lbl_bot.Size = new System.Drawing.Size(59, 20);
            this.lbl_bot.TabIndex = 4;
            this.lbl_bot.Text = "label4";
            // 
            // lbl_me
            // 
            this.lbl_me.AutoSize = true;
            this.lbl_me.BackColor = System.Drawing.Color.Transparent;
            this.lbl_me.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_me.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lbl_me.Location = new System.Drawing.Point(91, 73);
            this.lbl_me.Name = "lbl_me";
            this.lbl_me.Size = new System.Drawing.Size(59, 20);
            this.lbl_me.TabIndex = 5;
            this.lbl_me.Text = "label5";
            // 
            // lbl_tut
            // 
            this.lbl_tut.AutoSize = true;
            this.lbl_tut.BackColor = System.Drawing.Color.PapayaWhip;
            this.lbl_tut.Location = new System.Drawing.Point(632, 113);
            this.lbl_tut.Name = "lbl_tut";
            this.lbl_tut.Size = new System.Drawing.Size(160, 80);
            this.lbl_tut.TabIndex = 10;
            this.lbl_tut.Text = "             commands\r\n\r\nclose                        :-    exit\r\nshow calculator" +
    "       :-     cal\r\n\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(612, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 84);
            this.label1.TabIndex = 11;
            this.label1.Text = "BOT Me";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(860, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tut);
            this.Controls.Add(this.lbl_me);
            this.Controls.Add(this.lbl_bot);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.txt_b_text);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.ShowIcon = false;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_b_text;
        private System.Windows.Forms.Label btn_send;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_bot;
        private System.Windows.Forms.Label lbl_me;
        private System.Windows.Forms.Label lbl_tut;
        private System.Windows.Forms.Label label1;
    }
}