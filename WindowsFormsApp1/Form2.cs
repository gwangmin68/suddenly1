using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if (listView1.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                string s = "";
                for (int x = 0; x <= listView1.CheckedItems.Count - 1; x++)
                {
                    s = s + "Checked Item " + (x + 1).ToString() + " = " + listView1.CheckedItems[x].ToString() + "\n";
                }
                MessageBox.Show(s);
            }
        }
    }
}
