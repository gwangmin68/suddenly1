using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form3 : Form
    {
        public int result = 0;
        public Form3(string []listView, decimal[] intarr)
        {
            InitializeComponent();
            foreach(string item in listView)
            {
                if (item != "")
                checkedListBox1.Items.Add(item.Clone());
                
            }
            for(int i = 0; i < 10; i++)
            {
                result += (int)intarr[i];
            }
            resultlabel.Text = "" + result + "원";
            

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
            foreach (string items in checkedListBox1.CheckedItems)
            {
                list.Add(items);
            }
            foreach(string i in list)
            {
                checkedListBox1.Items.Remove(i);
                
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamWriter sw = File.CreateText(@".\List.txt");
            foreach(var item in checkedListBox1.Items)
            {
                sw.WriteLine($"<data>{item}</data>");
            }
            sw.Close();
            
        }
    }
}
