using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        String path = @".WindowsFormsApp1\Resources\List.txt";
        private void btn_submit_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count != 0)
            {
                StreamWriter sw = File.CreateText(path);
                
                for (int x = 0; x <= listView1.CheckedItems.Count - 1; x++)
                {
                    sw.WriteLine(listView1.CheckedItems.ToString());
                }
            }
        }

    
    }
}
