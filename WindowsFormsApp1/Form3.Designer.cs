namespace WindowsFormsApp1
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Logo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_order = new System.Windows.Forms.Button();
            this.b_like = new System.Windows.Forms.Button();
            this.b_cart = new System.Windows.Forms.Button();
            this.b_list = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = System.Drawing.Color.RosyBrown;
            flowLayoutPanel1.Location = new System.Drawing.Point(752, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new System.Drawing.Size(84, 15);
            flowLayoutPanel1.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(70, 80);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.RosyBrown;
            this.Logo.Controls.Add(this.pictureBox1);
            this.Logo.Location = new System.Drawing.Point(62, 19);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 118);
            this.Logo.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.btn_search);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(flowLayoutPanel1);
            this.panel3.Controls.Add(this.b_order);
            this.panel3.Controls.Add(this.b_like);
            this.panel3.Controls.Add(this.b_cart);
            this.panel3.Controls.Add(this.b_list);
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 74);
            this.panel3.TabIndex = 5;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btn_search.FlatAppearance.BorderSize = 0;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Image = ((System.Drawing.Image)(resources.GetObject("btn_search.Image")));
            this.btn_search.Location = new System.Drawing.Point(516, 26);
            this.btn_search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(22, 20);
            this.btn_search.TabIndex = 9;
            this.btn_search.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(381, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 21);
            this.textBox1.TabIndex = 8;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // b_order
            // 
            this.b_order.FlatAppearance.BorderSize = 0;
            this.b_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_order.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_order.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_order.Image = ((System.Drawing.Image)(resources.GetObject("b_order.Image")));
            this.b_order.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_order.Location = new System.Drawing.Point(843, 3);
            this.b_order.Name = "b_order";
            this.b_order.Size = new System.Drawing.Size(85, 67);
            this.b_order.TabIndex = 7;
            this.b_order.Text = "Order";
            this.b_order.UseVisualStyleBackColor = true;
            // 
            // b_like
            // 
            this.b_like.FlatAppearance.BorderSize = 0;
            this.b_like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_like.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_like.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_like.Image = ((System.Drawing.Image)(resources.GetObject("b_like.Image")));
            this.b_like.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_like.Location = new System.Drawing.Point(752, 3);
            this.b_like.Name = "b_like";
            this.b_like.Size = new System.Drawing.Size(85, 67);
            this.b_like.TabIndex = 6;
            this.b_like.Text = "Like";
            this.b_like.UseVisualStyleBackColor = true;
            // 
            // b_cart
            // 
            this.b_cart.FlatAppearance.BorderSize = 0;
            this.b_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cart.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_cart.Image = ((System.Drawing.Image)(resources.GetObject("b_cart.Image")));
            this.b_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_cart.Location = new System.Drawing.Point(661, 3);
            this.b_cart.Name = "b_cart";
            this.b_cart.Size = new System.Drawing.Size(85, 67);
            this.b_cart.TabIndex = 5;
            this.b_cart.Text = " Cart";
            this.b_cart.UseVisualStyleBackColor = true;
            // 
            // b_list
            // 
            this.b_list.FlatAppearance.BorderSize = 0;
            this.b_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_list.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_list.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_list.Image = ((System.Drawing.Image)(resources.GetObject("b_list.Image")));
            this.b_list.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_list.Location = new System.Drawing.Point(570, 3);
            this.b_list.Name = "b_list";
            this.b_list.Size = new System.Drawing.Size(85, 67);
            this.b_list.TabIndex = 4;
            this.b_list.Text = "Rank";
            this.b_list.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.RosyBrown;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 21);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RosyBrown;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(915, 1);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 18);
            this.button1.TabIndex = 2;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 97);
            this.panel2.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RosyBrown;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(753, 489);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 31);
            this.button2.TabIndex = 9;
            this.button2.Text = "주문";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RosyBrown;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("나눔스퀘어OTF", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(753, 428);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 31);
            this.button3.TabIndex = 10;
            this.button3.Text = "삭제";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.checkedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.checkedListBox1.Font = new System.Drawing.Font("나눔스퀘어OTF", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(92, 208);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(613, 312);
            this.checkedListBox1.TabIndex = 11;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 589);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(936, 589);
            this.MinimumSize = new System.Drawing.Size(438, 435);
            this.Name = "Form3";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.Logo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button b_order;
        private System.Windows.Forms.Button b_like;
        private System.Windows.Forms.Button b_cart;
        private System.Windows.Forms.Button b_list;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}