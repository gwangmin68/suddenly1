﻿namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.Panel();
            this.b_search = new System.Windows.Forms.Button();
            this.b_list = new System.Windows.Forms.Button();
            this.b_cart = new System.Windows.Forms.Button();
            this.b_like = new System.Windows.Forms.Button();
            this.b_order = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
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
            this.panel3.Controls.Add(this.textBox1);
            this.panel3.Controls.Add(this.b_order);
            this.panel3.Controls.Add(this.b_like);
            this.panel3.Controls.Add(this.b_cart);
            this.panel3.Controls.Add(this.b_list);
            this.panel3.Controls.Add(this.b_search);
            this.panel3.Location = new System.Drawing.Point(0, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(936, 74);
            this.panel3.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.SystemColors.Desktop;
            this.Logo.Location = new System.Drawing.Point(46, 19);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(130, 118);
            this.Logo.TabIndex = 2;
            // 
            // b_search
            // 
            this.b_search.FlatAppearance.BorderSize = 0;
            this.b_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_search.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_search.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_search.Location = new System.Drawing.Point(322, 4);
            this.b_search.Name = "b_search";
            this.b_search.Size = new System.Drawing.Size(117, 68);
            this.b_search.TabIndex = 3;
            this.b_search.Text = "Search";
            this.b_search.UseVisualStyleBackColor = true;
            // 
            // b_list
            // 
            this.b_list.FlatAppearance.BorderSize = 0;
            this.b_list.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_list.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_list.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_list.Location = new System.Drawing.Point(445, 4);
            this.b_list.Name = "b_list";
            this.b_list.Size = new System.Drawing.Size(117, 68);
            this.b_list.TabIndex = 4;
            this.b_list.Text = "Rank";
            this.b_list.UseVisualStyleBackColor = true;
            // 
            // b_cart
            // 
            this.b_cart.FlatAppearance.BorderSize = 0;
            this.b_cart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_cart.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_cart.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_cart.Location = new System.Drawing.Point(568, 4);
            this.b_cart.Name = "b_cart";
            this.b_cart.Size = new System.Drawing.Size(117, 68);
            this.b_cart.TabIndex = 5;
            this.b_cart.Text = "Cart";
            this.b_cart.UseVisualStyleBackColor = true;
            // 
            // b_like
            // 
            this.b_like.FlatAppearance.BorderSize = 0;
            this.b_like.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_like.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_like.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_like.Location = new System.Drawing.Point(691, 4);
            this.b_like.Name = "b_like";
            this.b_like.Size = new System.Drawing.Size(117, 68);
            this.b_like.TabIndex = 6;
            this.b_like.Text = "Like";
            this.b_like.UseVisualStyleBackColor = true;
            // 
            // b_order
            // 
            this.b_order.FlatAppearance.BorderSize = 0;
            this.b_order.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_order.Font = new System.Drawing.Font("Bebas Neue", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_order.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.b_order.Location = new System.Drawing.Point(814, 4);
            this.b_order.Name = "b_order";
            this.b_order.Size = new System.Drawing.Size(117, 68);
            this.b_order.TabIndex = 7;
            this.b_order.Text = "Order";
            this.b_order.UseVisualStyleBackColor = true;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(919, 94);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 446);
            this.vScrollBar1.TabIndex = 3;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(339, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 540);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
        private System.Windows.Forms.Button b_search;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        public System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

