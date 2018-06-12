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
        public void Search(string str)
        {
            StreamWriter sw = File.CreateText(@".\List.txt");
            string sname = str;
            var client = new RestClient("http://192.168.1.76/NAVER");
            var request = new RestRequest(sname, Method.GET);

            IRestResponse<Snack> response = client.Execute<Snack>(request);
            if (response.IsSuccessful)
            {

                var data = response.Data;
                int i = 9999999;
                string link = null;
                string imagelink = null, title=null;
                if (data != null)
                {
                    foreach (var item in data.items)
                    {
                        if (int.Parse(item.lprice) < i)
                        {
                            i = int.Parse(item.lprice);
                            link = item.link;
                            imagelink = item.image;
                            title = item.title;
                            sw.WriteLine("<item>" +
                                         $"<name>${item.title}</name>\n" +
                                         $"<link>${item.link}</link>\n" +
                                         $"<image>${item.image}</image>\n" +
                                         $"<price>${item.lprice}</price>\n" +
                                         "</item>\n");
                        }
                       
                    }
                    var imgrequest = WebRequest.Create(imagelink);
                    using (var imgresponse = imgrequest.GetResponse())
                    using (var stream = imgresponse.GetResponseStream())
                    {
                        imageList1.Images.Add(Image.FromStream(stream));
                        var item1 = new ListViewItem();
                        item1.ImageIndex = 0;
                       
                        item1.Text = title;
                        listView1.Items.Add(item1);
                        listView1.MouseClick += new MouseEventHandler((object Handler, MouseEventArgs args) =>
                        {

                            System.Diagnostics.Process.Start(link);
                        });
                    }
                }
            }
            else
            {
                MessageBox.Show(response.ErrorMessage);
            }

            sw.Close();
        }
        public Form2(string search)
        {
            InitializeComponent();
            Search(search);

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
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.CheckedItems)
            {
                listView1.Items.Remove(item); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
