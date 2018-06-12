namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            System.Windows.Forms.ListViewItem listViewItem12 = new System.Windows.Forms.ListViewItem("포카칩(오리지널)", 0);
            System.Windows.Forms.ListViewItem listViewItem13 = new System.Windows.Forms.ListViewItem("스윙칩", 1);
            System.Windows.Forms.ListViewItem listViewItem14 = new System.Windows.Forms.ListViewItem("포카칩(어니언맛)", 2);
            System.Windows.Forms.ListViewItem listViewItem15 = new System.Windows.Forms.ListViewItem("새우깡(오리지널)", 9);
            System.Windows.Forms.ListViewItem listViewItem16 = new System.Windows.Forms.ListViewItem("새우깡(매운맛)", 6);
            System.Windows.Forms.ListViewItem listViewItem17 = new System.Windows.Forms.ListViewItem("감자깡", 4);
            System.Windows.Forms.ListViewItem listViewItem18 = new System.Windows.Forms.ListViewItem("프링글스(오리지널)", 8);
            System.Windows.Forms.ListViewItem listViewItem19 = new System.Windows.Forms.ListViewItem("포스틱", 7);
            System.Windows.Forms.ListViewItem listViewItem20 = new System.Windows.Forms.ListViewItem("가나초콜릿", 3);
            System.Windows.Forms.ListViewItem listViewItem21 = new System.Windows.Forms.ListViewItem("밀키스", "밀키스.jpg");
            System.Windows.Forms.ListViewItem listViewItem22 = new System.Windows.Forms.ListViewItem("awawr", 10);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.b_order = new System.Windows.Forms.Button();
            this.b_like = new System.Windows.Forms.Button();
            this.b_cart = new System.Windows.Forms.Button();
            this.b_list = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(936, 21);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(0, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(931, 97);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.b_order);
            this.panel3.Controls.Add(this.b_like);
            this.panel3.Controls.Add(this.b_cart);
            this.panel3.Controls.Add(this.b_list);
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 74);
            this.panel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(370, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(127, 21);
            this.textBox1.TabIndex = 8;
            // 
            // b_order
            // 
            this.b_order.FlatAppearance.BorderSize = 0;
            this.b_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_order.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_order.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_order.Location = new System.Drawing.Point(838, 5);
            this.b_order.Name = "b_order";
            this.b_order.Size = new System.Drawing.Size(95, 67);
            this.b_order.TabIndex = 7;
            this.b_order.Text = "Order";
            this.b_order.UseVisualStyleBackColor = true;
            this.b_order.Click += new System.EventHandler(this.b_order_Click);
            // 
            // b_like
            // 
            this.b_like.FlatAppearance.BorderSize = 0;
            this.b_like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_like.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_like.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_like.Image = ((System.Drawing.Image)(resources.GetObject("b_like.Image")));
            this.b_like.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_like.Location = new System.Drawing.Point(737, 5);
            this.b_like.Name = "b_like";
            this.b_like.Size = new System.Drawing.Size(95, 67);
            this.b_like.TabIndex = 6;
            this.b_like.Text = "Like";
            this.b_like.UseVisualStyleBackColor = true;
            // 
            // b_cart
            // 
            this.b_cart.FlatAppearance.BorderSize = 0;
            this.b_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_cart.Image = ((System.Drawing.Image)(resources.GetObject("b_cart.Image")));
            this.b_cart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_cart.Location = new System.Drawing.Point(636, 5);
            this.b_cart.Name = "b_cart";
            this.b_cart.Size = new System.Drawing.Size(95, 67);
            this.b_cart.TabIndex = 5;
            this.b_cart.Text = "Cart";
            this.b_cart.UseVisualStyleBackColor = true;
            // 
            // b_list
            // 
            this.b_list.FlatAppearance.BorderSize = 0;
            this.b_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_list.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_list.Location = new System.Drawing.Point(535, 5);
            this.b_list.Name = "b_list";
            this.b_list.Size = new System.Drawing.Size(95, 67);
            this.b_list.TabIndex = 4;
            this.b_list.Text = "Rank";
            this.b_list.UseVisualStyleBackColor = true;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.Desktop;
            this.Logo.Location = new System.Drawing.Point(46, 19);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 74);
            this.Logo.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.CheckBoxes = true;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Hand;
            listViewItem12.StateImageIndex = 0;
            listViewItem13.StateImageIndex = 0;
            listViewItem14.StateImageIndex = 0;
            listViewItem15.StateImageIndex = 0;
            listViewItem16.StateImageIndex = 0;
            listViewItem17.StateImageIndex = 0;
            listViewItem18.StateImageIndex = 0;
            listViewItem19.StateImageIndex = 0;
            listViewItem20.StateImageIndex = 0;
            listViewItem21.StateImageIndex = 0;
            listViewItem22.StateImageIndex = 0;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem12,
            listViewItem13,
            listViewItem14,
            listViewItem15,
            listViewItem16,
            listViewItem17,
            listViewItem18,
            listViewItem19,
            listViewItem20,
            listViewItem21,
            listViewItem22});
            this.listView1.LargeImageList = this.imageList1;
            this.listView1.Location = new System.Drawing.Point(0, 94);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(936, 302);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "포카칩.jpg");
            this.imageList1.Images.SetKeyName(1, "스윙칩.jpg");
            this.imageList1.Images.SetKeyName(2, "포카칩1.jpg");
            this.imageList1.Images.SetKeyName(3, "가나초콜릿.jpg");
            this.imageList1.Images.SetKeyName(4, "감자깡.jpg");
            this.imageList1.Images.SetKeyName(5, "밀키스.jpg");
            this.imageList1.Images.SetKeyName(6, "새우깡1.jpg");
            this.imageList1.Images.SetKeyName(7, "포스틱.jpg");
            this.imageList1.Images.SetKeyName(8, "프링글스.jpg");
            this.imageList1.Images.SetKeyName(9, "새우깡.jpg");
            this.imageList1.Images.SetKeyName(10, "st1.png");
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(827, 407);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 18);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(501, 22);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(44, 40);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 435);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button b_order;
        private System.Windows.Forms.Button b_like;
        private System.Windows.Forms.Button b_cart;
        private System.Windows.Forms.Button b_list;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}