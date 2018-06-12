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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string s = "";
        private void button1_Click(object sender, System.Windows.Forms.ItemCheckEventArgs e)
        {
            if (listView1.CheckedItems.Count != 0)
            {
                // If so, loop through all checked items and print results.  
                
                for (int x = 0; x <= listView1.CheckedItems.Count - 1; x++)
                {
                    s = s + "Checked Item " + (x + 1).ToString() + " = " + listView1.CheckedItems[x].ToString() + "\n";
                }
                MessageBox.Show(s);
            }
        }

        private void b_order_Click(object sender, EventArgs e)
        {
            var client = new RestClient("http://35.198.244.96:80/NAVER");
            var request = new RestRequest("새우깡", Method.GET);

            IRestResponse<Snack> response = client.Execute<Snack>(request);
            var data = response.Data;
            int i = 9999999;
            string link = null;
            string imagelink = null;
            if (data != null)
            {
                foreach (var item in data.items)
                {
                    if (int.Parse(item.lprice) < i)
                    {
                        i = int.Parse(item.lprice);
                        link = item.link;
                        imagelink = item.image;
                    }

                    //    Debug.WriteLine(item.title);
                }
            }

            var imgReq = WebRequest.Create(imagelink);

            using (var imgResp = imgReq.GetResponse())
            using (var stream = imgResp.GetResponseStream())
            {
                imageList1.Images.Add(Image.FromStream(stream));
                var item = new ListViewItem();
                item.ImageIndex = imageList1.Images.Count - 1;
                item.Text = "dkdkd";
                listView1.Items.Add(item);
            }

            //MessageBox.Show(i.ToString());
           //MessageBox.Show(link);
        }
    }
}
