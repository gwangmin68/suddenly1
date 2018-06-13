using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Response;

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {

        public Form4()
        {
            InitializeComponent();
            string line;

            // Read the file and display it line by line.  
            System.IO.StreamReader file =
                new System.IO.StreamReader(@".\List.txt");
            while ((line = file.ReadLine()) != null)
            {
                line = line.Substring(6, line.Length - 13);
                checkedListBox1.Items.Add(line);
            }
            
            file.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            List<string> list = new List<string>();
            foreach (string items in checkedListBox1.CheckedItems)
            {
                list.Add(items);
            }
            foreach (string i in list)
            {
                checkedListBox1.Items.Remove(i);

            }
            StreamWriter sw = new StreamWriter(@".\List.txt", false);
            foreach (string item in checkedListBox1.Items)
            {
                sw.WriteLine($"<data>{item}</data>");
            }
            sw.Close();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_like_Click(object sender, EventArgs e)
        {
            MessageBox.Show("여러분 사랑해요!");
        }
    }
}
