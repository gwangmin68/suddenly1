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
                MessageBox.Show(line);
                line = line.Substring(6, line.Length - 13);
                listView1.Items.Add(line);
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

        private void button1_Click(object sender, EventArgs e)
        {

            List<ListViewItem> list = new List<ListViewItem>();
            foreach (ListViewItem items in listView1.CheckedItems)
            {
                list.Add(items);
            }
            foreach (ListViewItem i in list)
            {
                listView1.Items.Remove(i);

            }
            StreamWriter sw = new StreamWriter(@".\List.txt", false);
            foreach (ListViewItem item in listView1.Items)
            {
                sw.WriteLine($"<data>{item.Text}</data>");
            }
            sw.Close();

        }
    }
}
