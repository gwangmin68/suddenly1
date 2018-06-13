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
            
            string sname = str;
            var client = new RestClient("http://192.168.1.76/NAVER");
            var request = new RestRequest(sname, Method.GET);

            IRestResponse<Snack> response = client.Execute<Snack>(request);
            if (response.IsSuccessful)
            {

                var data = response.Data;
                if(data.total == 0)
                {
                    MessageBox.Show("검색 결과가 없습니다.");
                 
                    return;
                }
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
                        }
                       
                    }
                    var imgrequest = WebRequest.Create(imagelink);
                    using (var imgresponse = imgrequest.GetResponse())
                    using (var stream = imgresponse.GetResponseStream())
                    {
                        pictureBox2.Image=(Image.FromStream(stream));

                        name.Text = title;
                        lowprice.Text = "" + i;
                        pictureBox2.MouseClick += new MouseEventHandler((object Handler, MouseEventArgs args) =>
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

           
        }
        public Form2(string search)
        {
            InitializeComponent();
            Search(search);

        }
        
        
        
        

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            Search(textBox1.Text);

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search(textBox1.Text);
            }
        }

        private void bOrder_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(@".\List.txt", true);
            sw.WriteLine($"<data>{name.Text}x1</data>");
            sw.Close();
            MessageBox.Show("성공적으로 등록되었습니다.");
            this.Close();
        }
    }
}
