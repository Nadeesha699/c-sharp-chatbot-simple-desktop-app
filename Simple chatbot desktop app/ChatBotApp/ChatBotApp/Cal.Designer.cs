namespace ChatBotApp
{
    partial class Cal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cal));
            this.btn_mul = new System.Windows.Forms.Button();
            this.btn_sub = new System.Windows.Forms.Button();
            this.btn_expand = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_div = new System.Windows.Forms.Button();
            this.btn_equal = new System.Windows.Forms.Button();
            this.txt_in1 = new System.Windows.Forms.TextBox();
            this.txt_in2 = new System.Windows.Forms.TextBox();
            this.lbl_tot = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_mul
            // 
            this.btn_mul.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btn_mul.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_mul.ForeColor = System.Drawing.Color.White;
            this.btn_mul.Location = new System.Drawing.Point(253, 175);
            this.btn_mul.Name = "btn_mul";
            this.btn_mul.Size = new System.Drawing.Size(48, 48);
            this.btn_mul.TabIndex = 0;
            this.btn_mul.Text = "*";
            this.btn_mul.UseVisualStyleBackColor = false;
            this.btn_mul.Click += new System.EventHandler(this.btn_mul_Click);
            // 
            // btn_sub
            // 
            this.btn_sub.BackColor = System.Drawing.Color.Teal;
            this.btn_sub.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_sub.ForeColor = System.Drawing.Color.White;
            this.btn_sub.Location = new System.Drawing.Point(183, 175);
            this.btn_sub.Name = "btn_sub";
            this.btn_sub.Size = new System.Drawing.Size(48, 48);
            this.btn_sub.TabIndex = 1;
            this.btn_sub.Text = "-";
            this.btn_sub.UseVisualStyleBackColor = false;
            this.btn_sub.Click += new System.EventHandler(this.btn_sub_Click);
            // 
            // btn_expand
            // 
            this.btn_expand.BackColor = System.Drawing.Color.Gray;
            this.btn_expand.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_expand.ForeColor = System.Drawing.Color.White;
            this.btn_expand.Location = new System.Drawing.Point(224, 233);
            this.btn_expand.Name = "btn_expand";
            this.btn_expand.Size = new System.Drawing.Size(37, 39);
            this.btn_expand.TabIndex = 2;
            this.btn_expand.Text = "^";
            this.btn_expand.UseVisualStyleBackColor = false;
            this.btn_expand.Click += new System.EventHandler(this.btn_expand_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Orange;
            this.btn_add.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.ForeColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(112, 175);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(48, 48);
            this.btn_add.TabIndex = 3;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_div
            // 
            this.btn_div.BackColor = System.Drawing.Color.Crimson;
            this.btn_div.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_div.ForeColor = System.Drawing.Color.White;
            this.btn_div.Location = new System.Drawing.Point(327, 175);
            this.btn_div.Name = "btn_div";
            this.btn_div.Size = new System.Drawing.Size(48, 48);
            this.btn_div.TabIndex = 4;
            this.btn_div.Text = "/";
            this.btn_div.UseVisualStyleBackColor = false;
            this.btn_div.Click += new System.EventHandler(this.btn_div_Click);
            // 
            // btn_equal
            // 
            this.btn_equal.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_equal.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_equal.ForeColor = System.Drawing.Color.White;
            this.btn_equal.Location = new System.Drawing.Point(195, 302);
            this.btn_equal.Name = "btn_equal";
            this.btn_equal.Size = new System.Drawing.Size(98, 40);
            this.btn_equal.TabIndex = 5;
            this.btn_equal.Text = "=";
            this.btn_equal.UseVisualStyleBackColor = false;
            this.btn_equal.Click += new System.EventHandler(this.btn_equal_Click);
            // 
            // txt_in1
            // 
            this.txt_in1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_in1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_in1.Location = new System.Drawing.Point(112, 104);
            this.txt_in1.Name = "txt_in1";
            this.txt_in1.Size = new System.Drawing.Size(111, 27);
            this.txt_in1.TabIndex = 6;
            // 
            // txt_in2
            // 
            this.txt_in2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_in2.Location = new System.Drawing.Point(253, 104);
            this.txt_in2.Name = "txt_in2";
            this.txt_in2.Size = new System.Drawing.Size(114, 27);
            this.txt_in2.TabIndex = 7;
            // 
            // lbl_tot
            // 
            this.lbl_tot.AutoSize = true;
            this.lbl_tot.BackColor = System.Drawing.Color.Transparent;
            this.lbl_tot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tot.Location = new System.Drawing.Point(205, 50);
            this.lbl_tot.Name = "lbl_tot";
            this.lbl_tot.Size = new System.Drawing.Size(70, 25);
            this.lbl_tot.TabIndex = 8;
            this.lbl_tot.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(-2, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 84);
            this.label1.TabIndex = 12;
            this.label1.Text = "BOT Me";
            // 
            // Cal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(481, 462);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_tot);
            this.Controls.Add(this.txt_in2);
            this.Controls.Add(this.txt_in1);
            this.Controls.Add(this.btn_equal);
            this.Controls.Add(this.btn_div);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.btn_expand);
            this.Controls.Add(this.btn_sub);
            this.Controls.Add(this.btn_mul);
            this.Name = "Cal";
            this.Text = "Cal";
            this.Load += new System.EventHandler(this.Cal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_mul;
        private System.Windows.Forms.Button btn_sub;
        private System.Windows.Forms.Button btn_expand;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_div;
        private System.Windows.Forms.Button btn_equal;
        private System.Windows.Forms.TextBox txt_in1;
        private System.Windows.Forms.TextBox txt_in2;
        private System.Windows.Forms.Label lbl_tot;
        private System.Windows.Forms.Label label1;
    }
}